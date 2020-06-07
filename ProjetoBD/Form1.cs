using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//HAVE ACCESS TO SQL DB
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace ProjetoBD
{
    public partial class Form1 : Form
    {
        private SqlConnection cn;
        private int currentRecibo;
        private bool adding;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            
            cn = getBDConnection(); //gets the connection to the DB
            loadRecibos(sender, e); //loads all Recibos from DB and opens the connection
        }

        private SqlConnection getBDConnection()
        {
            return new SqlConnection("Data Source=DESKTOP-B6II5UN;Initial Catalog=ProjetoBD;Integrated Security=True");
            //return new SqlConnection("data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101N;initial catalog=p2g1;User id=p2g1;Password=Diogoedu232.");
        }
        private bool verifyBDConnection()
        {   //used to connect to the DB
            if (cn == null)
                cn = getBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        private void loadRecibos(object sender, EventArgs e)
        {   //loads all Recibos from the DB
            if (!verifyBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM Cafes.Recibo", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBoxRecibos.Items.Clear();

            while (reader.Read())
            {
                Recibo R = new Recibo();
                R.reciboID = int.Parse(reader["reciboID"].ToString());
                R.ClienteNIF = reader["ClienteNIF"].ToString();
                R.EmpNIF = reader["EmpNIF"].ToString();
                R.data_recibo = reader["data_recibo"].ToString();
                R.valor = reader["valor"].ToString();
                listBoxRecibos.Items.Add(R);
            }
            cn.Close();

            currentRecibo = 0;
            ShowRecibo();
        }
        public void ShowRecibo()
        {   //shows information of Recibo
            if (listBoxRecibos.Items.Count == 0 | currentRecibo < 0)
                return;
            Recibo recibo = new Recibo();
            recibo = (Recibo)listBoxRecibos.Items[currentRecibo];
            
            /*txtID.Text = contact.CustomerID;
            txtCompany.Text = contact.CompanyName;
            txtContact.Text = contact.ContactName;
            txtAddress1.Text = contact.Address1;
            txtCity.Text = contact.City;
            txtState.Text = contact.State;
            txtZIP.Text = contact.ZIP;
            txtCountry.Text = contact.Country;
            txtTel.Text = contact.tel;
            txtFax.Text = contact.FAX;*/       //used to show the information of the Recibo in the corresponding boxes
        }
        private void SubmitRecibo(Recibo R)
        {
            //CRIAR UMA PROCEDURES PARA ADICIONAR NOVOS RECIBOS (ONDE O reciboID É +1 QUE O ANTERIOR)
            if (!verifyBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT Cafes.Recibo (reciboID, ClienteNIF, EmpNIF, data_recibo, valor, " + "VALUES (@reciboID, @ClienteNIF, @EmpNIF, @data_recibo, @valor";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@reciboID", R.reciboID);
            cmd.Parameters.AddWithValue("@ClienteNIF", R.ClienteNIF);
            cmd.Parameters.AddWithValue("@EmpNIF", R.EmpNIF);
            cmd.Parameters.AddWithValue("@data_recibo", R.data_recibo);
            cmd.Connection = cn;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update recibo in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        private void UpdateRecibo(Recibo R)
        {
            int rows = 0;

            if (!verifyBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE Cafes.Recibo " + "SET reciboID = @reciboID, " + "    ClienteNIF = @ClienteNIF, " + "    EmpNIF = @EmpNIF, " +
                "    data_recibo = @data_recibo, " + "    valor=@valor, ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@reciboID", R.reciboID);
            cmd.Parameters.AddWithValue("@ClienteNIF", R.ClienteNIF);
            cmd.Parameters.AddWithValue("@EmpNIF", R.EmpNIF);
            cmd.Parameters.AddWithValue("@data_recibo", R.data_recibo);
            cmd.Connection = cn;

            try
            {
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update recibos in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                if (rows == 1)
                    MessageBox.Show("Update OK");
                else
                    MessageBox.Show("Update NOT OK");

                cn.Close();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            adding = true;
            //ClearFields();
            HideButtons();
            listBoxRecibos.Enabled = false;
        }

        private void HideButtons() {
            //UnlockControls(); //used to change the values of selected Recibo
            buttonAdd.Visible = false;
            buttonRemove.Visible = false;
            //buttonEdit.Visible = false;
            buttonOK.Visible = true;
            buttonCancel.Visible = true;
        }
        public void ShowButtons()
        {
            //LockControls();
            buttonAdd.Visible = true;
            buttonRemove.Visible = true;
            //buttonEdit.Visible = true;
            buttonOK.Visible = false;
            buttonCancel.Visible = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                SaveRecibo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listBoxRecibos.Enabled = true;
            //int idx = listBoxRecibos.FindString(txtID.Text);
            //listBoxRecibos.SelectedIndex = idx;
            ShowButtons();
        }

        private bool SaveRecibo()
        {
            Recibo R = new Recibo();
            try
            {
                //R.reciboID = txtID.Text;
                R.ClienteNIF = textBoxClienteNIF.Text;
                R.EmpNIF = textBoxEmpNIF.Text;
                //R.data_recibo = monthCalendarRecibo.DateSelected;
                R.valor = textBoxValor.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            if (adding)
            {
                SubmitRecibo(R);
                listBoxRecibos.Items.Add(R);
            }
            else
            {
                UpdateRecibo(R);
                listBoxRecibos.Items[currentRecibo] = R;
            }
            return true;
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            //vai ser usado para adicionar a comida/bebida ao valor total e ao recibo
        }

        private void listBoxRecibos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRecibos.SelectedIndex > 0)
            {
                currentRecibo = listBoxRecibos.SelectedIndex;
                ShowRecibo();
            }
        }


        //
        //COMBO BOXES   
        //
        private void BackToStart()
        {
            //changes all visibilities to false
            comboBoxPastelaria.Visible = false;
            labelTodos.Visible = false;
            comboBoxBar.Visible = false;
            comboBoxRestaurante.Visible = false;
            comboBoxBebidas.Visible = false;
            labelBebidas.Visible = false;
            comboBoxGeral.Visible = false;
            labelGeral.Visible = false;
            comboBoxPasteis.Visible = false;
            labelPastelariaPasteis.Visible = false;
            comboBoxAlmocos.Visible = false;
            labelAlmocos.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPastelaria.SelectedItem.ToString().Equals("Geral"))
            {
                comboBoxPasteis.Visible = false;
                labelPastelariaPasteis.Visible = false;
                comboBoxGeral.Visible = true;
                labelGeral.Visible = true;
            }
            if (comboBoxPastelaria.SelectedItem.ToString().Equals("Pasteis"))
            {
                comboBoxGeral.Visible = false;
                labelGeral.Visible = false;
                comboBoxPasteis.Visible = true;
                labelPastelariaPasteis.Visible = true;
            }
        }

        private void comboBoxCafes_SelectedIndexChanged(object sender, EventArgs e)
        {
            BackToStart();
            if (comboBoxCafes.SelectedItem.ToString().Equals("Cafe Pastelaria"))
            {
                comboBoxPastelaria.Visible = true;
                labelTodos.Visible = true;
                comboBoxBar.Visible = false;
                comboBoxRestaurante.Visible = false;
            }
            if (comboBoxCafes.SelectedItem.ToString().Equals("Cafe Restaurante"))
            {
                comboBoxPastelaria.Visible = false;
                labelTodos.Visible = true;
                comboBoxBar.Visible = false;
                comboBoxRestaurante.Visible = true;
            }
            if (comboBoxCafes.SelectedItem.ToString().Equals("Cafe Bar"))
            {
                comboBoxPastelaria.Visible = false;
                labelTodos.Visible = true;
                comboBoxBar.Visible = true;
                comboBoxRestaurante.Visible = false;
            }
        }

        private void comboBoxBar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBar.SelectedItem.ToString().Equals("Geral"))
            {
                comboBoxBebidas.Visible = false;
                labelBebidas.Visible = false;
                comboBoxGeral.Visible = true;
                labelGeral.Visible = true;
            }
            if (comboBoxBar.SelectedItem.ToString().Equals("Bebidas"))
            {
                comboBoxBebidas.Visible = true;
                labelBebidas.Visible = true;
                comboBoxGeral.Visible = false;
                labelGeral.Visible = false;
            }
        }

        private void comboBoxRestaurante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRestaurante.SelectedItem.ToString().Equals("Geral"))
            {
                comboBoxAlmocos.Visible = false;
                labelAlmocos.Visible = false;
                comboBoxGeral.Visible = true;
                labelGeral.Visible = true;
            }
            if (comboBoxRestaurante.SelectedItem.ToString().Equals("Almocos"))
            {
                comboBoxAlmocos.Visible = true;
                labelAlmocos.Visible = true;
                comboBoxGeral.Visible = false;
                labelGeral.Visible = false;
            }
        }
    }

}
