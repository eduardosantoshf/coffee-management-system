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

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(!verifyBDConnection())
                    return;
                SqlCommand commandSelect = new SqlCommand("select * from Cafes.Admin where username='"+textBoxUsername.Text+"' and password='"+textBoxPassword.Text+"' ;",cn);

                SqlDataReader reader;
                reader = commandSelect.ExecuteReader();
                int count = 0;
                while (reader.Read()) { count += 1;}
                if (count == 1) { MessageBox.Show("Username and password is correct!"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
