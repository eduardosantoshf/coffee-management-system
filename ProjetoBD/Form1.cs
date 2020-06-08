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
            //return new SqlConnection("Data Source=DESKTOP-AUG6BMB\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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


            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Cafes.Recibo", cn)){;
                SqlDataReader reader = cmd.ExecuteReader();
                listBoxRecibos.Items.Clear();
                
                while (reader.Read())
                {
                    Recibo R = new Recibo();
                    R.ClienteNIF = int.Parse(reader["ClienteNIF"].ToString());
                    R.EmpNIF = int.Parse(reader["EmpNIF"].ToString());
                    R.data_recibo = DateTime.Parse(reader["data_recibo"].ToString());
                    R.valor = float.Parse(reader["valor"].ToString());
                    listBoxRecibos.Items.Add(R);
                }
            }
            cn.Close();
            currentRecibo = 0;
        }
        public void ShowRecibo()
        {   //shows information of Recibo
            if (listBoxRecibos.Items.Count == 0 | currentRecibo < 0)
                return;
            Recibo recibo = new Recibo();
            recibo = (Recibo)listBoxRecibos.Items[currentRecibo];

            textBoxClienteNIF.Text = recibo.ClienteNIF.ToString();
            textBoxEmpNIF.Text = recibo.EmpNIF.ToString();
            textBoxValor.Text = recibo.valor.ToString();
            dateTimePicker1.Value = recibo.data_recibo;
            //used to show the information of the Recibo in the corresponding boxes
        }
        private void SubmitRecibo(Recibo R)
        {
            //used to add a new recibo to the database
            if (!verifyBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("insertRecibo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@valor", SqlDbType.Float).Value = R.valor;
            cmd.Parameters.Add("@ClienteNIF", SqlDbType.Int).Value = R.ClienteNIF;
            cmd.Parameters.Add("@EmpNIF", SqlDbType.Int).Value = R.EmpNIF;
            cmd.Parameters.Add("@data_recibo", SqlDbType.Date).Value = R.data_recibo;

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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            adding = true;
            HideButtons();
            listBoxRecibos.Enabled = false;
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
            ClearFields();
            ShowButtons();
            UnlockControls();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            listBoxRecibos.Enabled = true;
            ClearFields();
            ShowButtons();
            UnlockControls();
        }

        private bool SaveRecibo()
        {
            Recibo R = new Recibo();
            try
            {
                R.ClienteNIF = int.Parse(textBoxClienteNIF.Text);
                R.EmpNIF = int.Parse(textBoxEmpNIF.Text);
                R.data_recibo = dateTimePicker1.Value.Date;
                R.valor = float.Parse(textBoxValor.Text);
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
            return true;
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            //vai ser usado para adicionar a comida/bebida ao valor total e ao recibo
            
        }

        private void listBoxRecibos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRecibos.SelectedIndex >= 0)
            {
                currentRecibo = listBoxRecibos.SelectedIndex;
                ShowRecibo();
                LockControls();
                ShowButtonsChosenIdx();
            }
        }

        public void ClearFields()
        {
            textBoxClienteNIF.Text = "";
            textBoxEmpNIF.Text = "";
            textBoxValor.Text = "";
        }
        public void LockControls()
        {
            textBoxClienteNIF.ReadOnly = true;
            textBoxEmpNIF.ReadOnly = true;
            textBoxValor.ReadOnly = true;
        }
        public void UnlockControls()
        {
            textBoxClienteNIF.ReadOnly = false;
            textBoxEmpNIF.ReadOnly = false;
            textBoxValor.ReadOnly = false;
        }
        public void ShowButtons() 
        {
            buttonAdd.Visible = true;
            buttonRemove.Visible = false;
            buttonOK.Visible = false;
            buttonCancel.Visible = false;
        }
        public void ShowButtonsChosenIdx() 
        {
            buttonRemove.Visible = true;
            buttonAdd.Visible = false;
            buttonCancel.Visible = true;
            buttonOK.Visible = false;
        }
        public void HideButtons()
        {
            buttonRemove.Visible = false;
            buttonAdd.Visible = false;
            buttonOK.Visible = true;
            buttonCancel.Visible = true;
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

        private void comboBoxBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //working tests

        private void buttonDisplayClientes_Click(object sender, EventArgs e)
        {
            //execute procedure (readonly no edits)
            if (!verifyBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("getClientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridViewClientes.DataSource = dt;
            dataGridViewClientes.ReadOnly = true; //readOnly so no edits occur
        }

        private void buttonDisplayEmp_Click(object sender, EventArgs e)
        {
            //execute procedure (readonly no edits)
            if (!verifyBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("getEmps", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridViewEmps.DataSource = dt;
            dataGridViewEmps.ReadOnly = true; //readOnly so no edits occur
        }
    }

}
