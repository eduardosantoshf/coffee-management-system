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
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            SqlConnection cnn;
            cnn = getBDconnection();
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private SqlConnection getBDconnection()
        {
            return new SqlConnection("Data Source=DESKTOP-B6II5UN;Initial Catalog=ProjetoBD;Integrated Security=True");
            //return new SqlConnection("data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101N;initial catalog=p2g1;User id=p2g1;Password=Diogoedu232.");
        }

        private void CafeBar_Click(object sender, EventArgs e)
        {
            panelBar.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBar.SelectedItem.ToString().Equals("Geral")){
                comboBoxBarBebidas.Visible = false;
                labelBebidas.Visible = false;
                comboBoxBarGeral.Visible = true;
                labelBarGeral.Visible = true;
            }
            if (comboBoxBar.SelectedItem.ToString().Equals("Bebidas"))
            {
                comboBoxBarGeral.Visible = false;
                labelBarGeral.Visible = false;
                comboBoxBarBebidas.Visible = true;
                labelBebidas.Visible = true;
            }
        }

        private void CafePastelaria_Click(object sender, EventArgs e)
        {
            panelPastelaria.Visible = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPastelaria.SelectedItem.ToString().Equals("Geral"))
            {
                comboBoxPasteis.Visible = false;
                labelPastelariaPasteis.Visible = false;
                comboBoxPastelariaGeral.Visible = true;
                labelPastelariaGeral.Visible = true;
            }
            if (comboBoxPastelaria.SelectedItem.ToString().Equals("Pasteis"))
            {
                comboBoxPastelariaGeral.Visible = false;
                labelPastelariaGeral.Visible = false;
                comboBoxPasteis.Visible = true;
                labelPastelariaPasteis.Visible = true;
            }
        }

        private void CafeRestaurante_Click(object sender, EventArgs e)
        {
            panelRestaurante.Visible = true;
        }

        private void comboBoxRestaurante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRestaurante.SelectedItem.ToString().Equals("Geral"))
            {
                comboBoxAlmocos.Visible = false;
                labelRestauranteAlmocos.Visible = false;
                comboBoxRestauranteGeral.Visible = true;
                labelRestauranteGeral.Visible = true;
            }
            if (comboBoxRestaurante.SelectedItem.ToString().Equals("Almocos"))
            {
                comboBoxRestauranteGeral.Visible = false;
                labelRestauranteGeral.Visible = false;
                comboBoxAlmocos.Visible = true;
                labelRestauranteAlmocos.Visible = true;
            }
        }

        private void ButtonBarClose_Click(object sender, EventArgs e)
        {
            panelBar.Visible = false;
        }

        private void buttonRestauranteClose_Click(object sender, EventArgs e)
        {
            panelRestaurante.Visible = false;
        }

        private void buttonPastelariaClose_Click(object sender, EventArgs e)
        {
            panelPastelaria.Visible = false;
        }
    }
}
