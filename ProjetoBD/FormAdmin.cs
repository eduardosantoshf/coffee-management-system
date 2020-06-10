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
    public partial class FormAdmin : Form
    {
        private Form1 f1;

        public FormAdmin(Form1 f1)
        {
            InitializeComponent();
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Show();
        }
    }
}
