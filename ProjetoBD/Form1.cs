using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
