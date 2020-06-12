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
            //return new SqlConnection("Data Source=DESKTOP-B6II5UN;Initial Catalog=ProjetoBD;Integrated Security=True");
            //return new SqlConnection("Data Source=DESKTOP-AUG6BMB\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            return new SqlConnection("Data Source = tcp:mednat.ieeta.pt\\SQLSERVER, 8101; Initial Catalog = p2g1; Persist Security Info = True; User ID = p2g1; Password = Diogoedu232.");
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
            //used to add a new empregado to the database
            if (!verifyBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("insertEmpregado", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@NIF", SqlDbType.Int).Value = E.NIF;
            cmd.Parameters.Add("@NIF_cafe", SqlDbType.Int).Value = E.NIF_cafe;
            cmd.Parameters.Add("@idade", SqlDbType.Int).Value = E.idade;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = E.nome;
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
            //used to remove a empregado from the database
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
                throw new Exception("Failed to update empregado in database. \n ERROR MESSAGE: \n" + ex.Message);
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
                listBoxProds.Items.Clear();

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
            comboBoxProdTipo.SelectedItem = comboBoxProdTipo.Items[prod.tipo-1]; //tipo de produto(bebidas-1,alcool-2,almocos-3,pasteis-4)
            //used to show the information of the Produto in the corresponding boxes
        }
        private bool SaveProduto(object sender, EventArgs e) 
        {
            Produto P = new Produto();
            if (adding)
            {
                try
                {
                    P.nome = textBoxProdNome.Text;
                    P.preco = float.Parse(textBoxProdPreco.Text);
                    P.tipo = int.Parse(comboBoxProdTipo.SelectedIndex.ToString())+1; //tipo de produto(bebidas-1,alcool-2,almocos-3,pasteis-4)
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }

                SubmitProduto(P);
                listBoxProds.Items.Add(P);
                adding = false;
            }
            else if (removing)
            {
                try
                {
                    P = (Produto)listBoxProds.Items[currentProd];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                RemoveProduto(P);
                listBoxProds.Items.Remove(P);
                removing = false;
            }
            else {
                //edit produto
                try
                {
                    P = (Produto)listBoxProds.Items[currentProd];
                    P.preco = float.Parse(textBoxProdPreco.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                EditProduto(P);
                loadProdutos(sender,e);
            }
            return true;
        }
        private void SubmitProduto(Produto P)
        {
            //used to add a new produto to the database
            if (!verifyBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("addProduto", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@nomeP", SqlDbType.VarChar).Value = P.nome;
            cmd.Parameters.Add("@precoP", SqlDbType.Float).Value = P.preco;
            cmd.Parameters.Add("@tipoP", SqlDbType.Int).Value = P.tipo;        

            try
            {
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("getLastProdutoID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@lastID", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                
                cmd.ExecuteNonQuery();
                P.ID = (int)cmd.Parameters["@lastID"].Value;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update produto in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        private void RemoveProduto(Produto P)
        {
            //used to remove a produto from the database
            if (!verifyBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("removeProduto", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@pID", SqlDbType.Int).Value = P.ID;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update produto in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        private void EditProduto(Produto P)
        {
            //used to edit a produto in the database
            if (!verifyBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("editProduto", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ID_P", SqlDbType.Int).Value = P.ID;
            cmd.Parameters.Add("@precoP", SqlDbType.Float).Value = P.preco;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update produto in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
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

        //functions Clientes
        private void loadClientes(object sender, EventArgs e)
        {   //loads all Clientes from the DB
            if (!verifyBDConnection())
                return;


            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Cafes.Cliente", cn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                listBoxClientes.Items.Clear();

                while (reader.Read())
                {
                    Cliente C = new Cliente();
                    C.NIF = int.Parse(reader["NIF"].ToString());
                    C.nome = reader["nome"].ToString();
                    listBoxClientes.Items.Add(C);
                }
            }

            cn.Close();
            currentCliente = 0;
        }
        public void ShowCliente()
        {   //shows information of Cliente
            if (listBoxClientes.Items.Count == 0 | currentCliente < 0)
                return;
            Cliente client = new Cliente();
            client = (Cliente)listBoxClientes.Items[currentCliente];

            textBoxClienteNIF.Text = client.NIF.ToString();
            textBoxClienteNome.Text = client.nome;
            //used to show the information of the Cliente in the corresponding boxes
        }
        private bool SaveCliente()
        {
            Cliente C = new Cliente();
            if (adding)
            {
                try
                {
                    C.NIF = int.Parse(textBoxClienteNIF.Text);
                    C.nome = textBoxClienteNome.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }

                SubmitCliente(C);
                listBoxClientes.Items.Add(C);
                adding = false;
            }
            if (removing)
            {
                try
                {
                    C = (Cliente)listBoxClientes.Items[currentCliente];
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                RemoveCliente(C);
                listBoxClientes.Items.Remove(C);
                removing = false;
            }
            return true;
        }
        private void SubmitCliente(Cliente C)
        {
            //used to add a new empregado to the database
            if (!verifyBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("insertCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@NIF", SqlDbType.Int).Value = C.NIF;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = C.nome;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update cliente in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        private void RemoveCliente(Cliente C)
        {
            //used to remove a Cliente from the database
            if (!verifyBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("removeCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ClienteNIF", SqlDbType.Int).Value = C.NIF;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update cliente in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex >= 0)
            {
                currentCliente = listBoxClientes.SelectedIndex;
                ShowCliente();
                LockControlsCliente();
                ShowButtonsChosenIdxCliente();
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

        //hide/show Produtos
        public void LockControlsProd()
        {
            textBoxProdNome.ReadOnly = true;
            textBoxProdPreco.ReadOnly = true;
            comboBoxProdTipo.Enabled = false;
        }
        public void UnlockControlsProd()
        {
            textBoxProdNome.ReadOnly = false;
            textBoxProdPreco.ReadOnly = false;
            comboBoxProdTipo.Enabled = true;
        }
        public void ShowButtonsChosenIdxProd()
        {
            buttonRemoveProd.Visible = true;
            buttonAddProd.Visible = false;
            buttonEditProd.Visible = true;
            buttonCancelProd.Visible = true;
            buttonOkProd.Visible = false;
        }
        public void ShowButtonsProd()
        {
            buttonRemoveProd.Visible = false;
            buttonAddProd.Visible = true;
            buttonEditProd.Visible = false;
            buttonOkProd.Visible = false;
            buttonCancelProd.Visible = false;
        }
        public void HideButtonsProd()
        {
            buttonRemoveProd.Visible = false;
            buttonAddProd.Visible = false;
            buttonEditProd.Visible = false;
            buttonOkProd.Visible = true;
            buttonCancelProd.Visible = true;
        }
        public void ClearFieldsProd()
        {
            textBoxProdNome.Text = "";
            textBoxProdPreco.Text = "";
        }

        //hide/show Clientes
        public void LockControlsCliente()
        {
            textBoxClienteNome.ReadOnly = true;
            textBoxClienteNIF.ReadOnly = true;
        }
        public void UnlockControlsCliente()
        {
            textBoxClienteNome.ReadOnly = false;
            textBoxClienteNIF.ReadOnly = false;
        }
        public void ShowButtonsChosenIdxCliente()
        {
            buttonRemoveCliente.Visible = true;
            buttonAddCliente.Visible = false;
            buttonCancelCliente.Visible = true;
            buttonOkCliente.Visible = false;
        }
        public void ShowButtonsCliente()
        {
            buttonRemoveCliente.Visible = false;
            buttonAddCliente.Visible = true;
            buttonOkCliente.Visible = false;
            buttonCancelCliente.Visible = false;
        }
        public void HideButtonsCliente()
        {
            buttonRemoveCliente.Visible = false;
            buttonAddCliente.Visible = false;
            buttonOkCliente.Visible = true;
            buttonCancelCliente.Visible = true;
        }
        public void ClearFieldsCliente()
        {
            textBoxClienteNome.Text = "";
            textBoxClienteNIF.Text = "";
        }
        //buttons
        //buttons Empregados
        private void buttonEmp_Click(object sender, EventArgs e)
        {
            panelAddEmp.Visible = true;
            panelProd.Visible = false;
            panelClientes.Visible = false;
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
            panelClientes.Visible = false;
            loadProdutos(sender,e);
        }
        private void buttonCancelProd_Click(object sender, EventArgs e)
        {
            listBoxProds.Enabled = true;
            ClearFieldsProd();
            ShowButtonsProd();
            UnlockControlsProd();
        }
        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            adding = true;
            HideButtonsProd();
            listBoxProds.Enabled = false;
        }
        private void buttonRemoveProd_Click(object sender, EventArgs e)
        {
            removing = true;
            HideButtonsProd();
            listBoxProds.Enabled = false;
        }
        private void buttonEditProd_Click(object sender, EventArgs e)
        {
            adding = false;
            removing = false;
            HideButtonsProd();
            textBoxProdPreco.ReadOnly = false;
            listBoxProds.Enabled = false;
        }
        private void buttonOkProd_Click(object sender, EventArgs e)
        {
            try
            {
                SaveProduto(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listBoxProds.Enabled = true;
            ClearFieldsProd();
            ShowButtonsProd();
            UnlockControlsProd();
        }

        //buttons Clientes
        private void buttonCliente_Click(object sender, EventArgs e)
        {
            panelClientes.Visible = true;
            panelAddEmp.Visible = false;
            panelProd.Visible = false;
            loadClientes(sender, e);
        }
        private void buttonCancelCliente_Click(object sender, EventArgs e)
        {
            listBoxClientes.Enabled = true;
            ClearFieldsCliente();
            ShowButtonsCliente();
            UnlockControlsCliente();
        }
        private void buttonAddCliente_Click(object sender, EventArgs e)
        {
            adding = true;
            HideButtonsCliente();
            listBoxClientes.Enabled = false;
        }
        private void buttonRemoveCliente_Click(object sender, EventArgs e)
        {
            removing = true;
            HideButtonsCliente();
            listBoxClientes.Enabled = false;
        }
        private void buttonOkCliente_Click(object sender, EventArgs e)
        {
            try
            {
                SaveCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listBoxClientes.Enabled = true;
            ClearFieldsCliente();
            ShowButtonsCliente();
            UnlockControlsCliente();
        }
        //form changes
        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Show();
        }
    }
}
