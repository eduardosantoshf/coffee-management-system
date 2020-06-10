using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBD
{
    public partial class FormAdmin : Form
    {
        private Form1 f1;
        private SqlConnection cn;
        private int currentEmp;     //to track current Empregado
        private int currentCliente; //to track current Client
        private int currentProd;    //to track current Produto
        private int prodTipo;       //para saber o tipo de produto(bebidas-1,alcool-2,almocos-3,pasteis-4)
        private bool adding;
        private bool removing;

        public FormAdmin(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
            cn = getBDConnection();
        }
        //connection to database
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

        //Functions
        //Functions Empregados
        private void loadEmpregados(object sender, EventArgs e)
        {   //loads all Empregados from the DB
            if (!verifyBDConnection())
                return;


            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Cafes.Empregado", cn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                listBoxEmpregados.Items.Clear();

                while (reader.Read())
                {
                    Empregado E = new Empregado();
                    E.NIF = int.Parse(reader["NIF"].ToString());
                    E.NIF_cafe = int.Parse(reader["NIF_cafe"].ToString());
                    E.idade = int.Parse(reader["idade"].ToString());
                    E.nome = reader["nome"].ToString();
                    E.dataInicContrato = DateTime.Parse(reader["data_inic_contrato"].ToString());
                    listBoxEmpregados.Items.Add(E);
                }
            }

                cn.Close();
            currentEmp = 0;
        }
        private void SubmitEmpregado(Empregado E)
        {
            //used to add a new recibo to the database
            if (!verifyBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("insertEmpregado", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@EmpNIF", SqlDbType.Int).Value = E.NIF;
            cmd.Parameters.Add("@NIFcafe", SqlDbType.Int).Value = E.NIF_cafe;
            cmd.Parameters.Add("@idade", SqlDbType.Int).Value = E.idade;
            cmd.Parameters.Add("@idade", SqlDbType.VarChar).Value = E.nome;
            cmd.Parameters.Add("@data_inic_contrato", SqlDbType.Date).Value = E.dataInicContrato;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update empregado in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        private void RemoveEmpregado(Empregado E)
        {
            //used to add a new recibo to the database
            if (!verifyBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("removeEmpregado", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@EmpNIF", SqlDbType.Int).Value = E.NIF;

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
        private bool SaveEmpregado()
        {
            Empregado E = new Empregado();
            if (adding)
            {
                try
                {
                    E.NIF = int.Parse(textBoxEmpNIF.Text);
                    E.NIF_cafe = int.Parse(textBoxNIFcafe.Text);
                    E.dataInicContrato = dateTimePickerEmp.Value.Date;
                    E.idade = int.Parse(textBoxEmpIdade.Text);
                    E.nome = textBoxEmpNome.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }

                SubmitEmpregado(E);
                listBoxEmpregados.Items.Add(E);
                adding = false;
            }
            if (removing)
            {
                try
                {
                    E = (Empregado)listBoxEmpregados.Items[currentEmp];  
                }
                catch (Exception e) 
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                RemoveEmpregado(E);
                listBoxEmpregados.Items.Remove(E);
                removing = false;
            }
            return true;
        }
        public void ShowEmpregado()
        {   //shows information of Empregado
            if (listBoxEmpregados.Items.Count == 0 | currentEmp < 0)
                return;
            Empregado emp = new Empregado();
            emp = (Empregado)listBoxEmpregados.Items[currentEmp];

            textBoxEmpNIF.Text = emp.NIF.ToString();
            textBoxNIFcafe.Text = emp.NIF_cafe.ToString();
            textBoxEmpNome.Text = emp.nome.ToString();
            textBoxEmpIdade.Text = emp.idade.ToString();
            dateTimePickerEmp.Value = emp.dataInicContrato;
            //used to show the information of the Empregado in the corresponding boxes
        }

        private void listBoxEmpregados_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (listBoxEmpregados.SelectedIndex >= 0)
                {
                    currentEmp= listBoxEmpregados.SelectedIndex;
                    ShowEmpregado();
                    LockControlsEmp();
                    ShowButtonsChosenIdxEmp();
                }
        }

        //functions Produtos
        private void loadProdutos(object sender, EventArgs e)
        {   //loads all Empregados from the DB
            if (!verifyBDConnection())
                return;


            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Cafes.Produto", cn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                listBoxEmpregados.Items.Clear();

                while (reader.Read())
                {
                    Produto P = new Produto();
                    P.ID = int.Parse(reader["ID_P"].ToString());
                    P.preco = float.Parse(reader["precoP"].ToString());
                    P.tipo = int.Parse(reader["tipoP"].ToString());
                    P.nome = reader["nomeP"].ToString();
                    listBoxProds.Items.Add(P);
                }
            }

            cn.Close();
            currentProd = 0;
        }
        public void ShowProdutos()
        {   //shows information of Empregado
            if (listBoxProds.Items.Count == 0 | currentProd < 0)
                return;
            Produto prod = new Produto();
            prod = (Produto)listBoxProds.Items[currentProd];

            textBoxProdNome.Text = prod.nome;
            textBoxProdPreco.Text = prod.preco.ToString();
            comboBoxProdTipo.SelectedItem = comboBoxProdTipo.Items[(int)prodTipo];
            //used to show the information of the Produto in the corresponding boxes
        }

        private void listBoxProds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProds.SelectedIndex >= 0)
            {
                currentProd = listBoxProds.SelectedIndex;
                ShowProdutos();
                LockControlsProd();
                ShowButtonsChosenIdxProd();
            }
        }

        //hide/show 
        //hide/show Empregados
        public void LockControlsEmp()
        {
            textBoxEmpNIF.ReadOnly = true;
            textBoxNIFcafe.ReadOnly = true;
            textBoxEmpNome.ReadOnly = true;
            textBoxEmpIdade.ReadOnly = true;
            dateTimePickerEmp.Enabled = false;
        }
        public void UnlockControlsEmp()
        {
            textBoxEmpNIF.ReadOnly = false;
            textBoxNIFcafe.ReadOnly = false;
            textBoxEmpNome.ReadOnly = false;
            textBoxEmpIdade.ReadOnly = false;
            dateTimePickerEmp.Enabled = true;
        }
        public void ShowButtonsChosenIdxEmp()
        {
            buttonRemoveEmp.Visible = true;
            buttonAddEmp2.Visible = false;
            buttonCancelEmp.Visible = true;
            buttonOkEmp.Visible = false;
        }
        public void ShowButtonsEmp()
        {
            buttonAddEmp2.Visible = true;
            buttonRemoveEmp.Visible = false;
            buttonOkEmp.Visible = false;
            buttonCancelEmp.Visible = false;
        }
        public void HideButtonsEmp()
        {
            buttonRemoveEmp.Visible = false;
            buttonAddEmp2.Visible = false;
            buttonOkEmp.Visible = true;
            buttonCancelEmp.Visible = true;
        }
        public void ClearFieldsEmp()
        {
            textBoxEmpNIF.Text = "";
            textBoxNIFcafe.Text = "";
            textBoxEmpNome.Text = "";
            textBoxEmpIdade.Text = "";
        }
        //hide/show empregados
        public void LockControlsProd()
        {
            textBoxProdNome.ReadOnly = true;
            textBoxProdPreco.ReadOnly = true;
            comboBoxProdTipo.Enabled = false;
        }
        public void ShowButtonsChosenIdxProd()
        {
            buttonRemoveProd.Visible = true;
            buttonAddProd.Visible = false;
            buttonEditProd.Visible = true;
            buttonCancelProd.Visible = true;
            buttonOkProd.Visible = false;
        }

        //buttons
        //buttons Empregados
        private void buttonEmp_Click(object sender, EventArgs e)
        {
            panelAddEmp.Visible = true;
            panelProd.Visible = false;
            loadEmpregados(sender, e);
        }
        private void buttonCancelEmp_Click(object sender, EventArgs e)
        {
            listBoxEmpregados.Enabled = true;
            ClearFieldsEmp();
            ShowButtonsEmp();
            UnlockControlsEmp();
        }
        private void buttonAddEmp2_Click(object sender, EventArgs e)
        {
            adding = true;
            HideButtonsEmp();
            listBoxEmpregados.Enabled = false;
        }
        private void buttonRemoveEmp_Click(object sender, EventArgs e)
        {
            removing = true;
            HideButtonsEmp();
            listBoxEmpregados.Enabled = false;
        }
        private void buttonOkEmp_Click(object sender, EventArgs e)
        {
            try
            {
                SaveEmpregado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listBoxEmpregados.Enabled = true;
            ClearFieldsEmp();
            ShowButtonsEmp();
            UnlockControlsEmp();
        }

        //buttons Produtos
        private void buttonProd_Click(object sender, EventArgs e)
        {
            panelProd.Visible = true;
            panelAddEmp.Visible = false;
            loadProdutos(sender,e);
        }

        private void comboBoxProdTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxProdTipo.SelectedIndex.ToString())
            {
                case "Bebidas": prodTipo = 1; break;
                case "Alcool": prodTipo = 2; break;
                case "Almocos": prodTipo = 3; break;
                case "Pasteis": prodTipo = 4; break;
                default: break;
            }
        }

        //form changes
        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Show();
        }
    }
}
