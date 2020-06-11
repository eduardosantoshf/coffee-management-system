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
    public partial class Form2 : Form
    {
        private SqlConnection cn;
        private Form1 f1;

        public Form2(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }

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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            /* cmd = new SqlCommand("getLastReciboID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@lastID", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                R.reciboID = (int)cmd.Parameters["@lastID"].Value;
                */
            int correctLogin=0;
            try
            {
                if (!verifyBDConnection())
                    return;

                SqlCommand cmd = new SqlCommand("verifyLogin", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                cmd.Parameters.AddWithValue("@pass", textBoxPassword.Text);
                cmd.Parameters.Add("@flag", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
               
                cmd.ExecuteNonQuery();
                correctLogin = (int)cmd.Parameters["@flag"].Value;

                if (correctLogin == 1) {
                    new FormAdmin(f1).Show();
                    this.Close();
                    f1.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Login");
                    textBoxPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
