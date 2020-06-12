namespace ProjetoBD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClienteNIF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPastelariaPasteis = new System.Windows.Forms.Label();
            this.comboBoxPasteis = new System.Windows.Forms.ComboBox();
            this.labelTodos = new System.Windows.Forms.Label();
            this.comboBoxPastelaria = new System.Windows.Forms.ComboBox();
            this.labelBebidasGeral = new System.Windows.Forms.Label();
            this.comboBoxBebidasGeral = new System.Windows.Forms.ComboBox();
            this.listBoxRecibos = new System.Windows.Forms.ListBox();
            this.comboBoxAlmocos = new System.Windows.Forms.ComboBox();
            this.comboBoxAlcool = new System.Windows.Forms.ComboBox();
            this.comboBoxCafes = new System.Windows.Forms.ComboBox();
            this.labelCafe = new System.Windows.Forms.Label();
            this.labelAlmocos = new System.Windows.Forms.Label();
            this.labelAlcool = new System.Windows.Forms.Label();
            this.comboBoxBar = new System.Windows.Forms.ComboBox();
            this.comboBoxRestaurante = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.buttonAddFood = new System.Windows.Forms.Button();
            this.textBoxEmpNIF = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.buttonDisplayClientes = new System.Windows.Forms.Button();
            this.buttonDisplayEmp = new System.Windows.Forms.Button();
            this.dataGridViewEmps = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxProdutosRecibo = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmps)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRemove
            // 
            this.buttonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemove.Location = new System.Drawing.Point(357, 597);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(182, 51);
            this.buttonRemove.TabIndex = 12;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Visible = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(152, 597);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(182, 51);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cliente(NIF)";
            // 
            // textBoxClienteNIF
            // 
            this.textBoxClienteNIF.Location = new System.Drawing.Point(333, 292);
            this.textBoxClienteNIF.Name = "textBoxClienteNIF";
            this.textBoxClienteNIF.Size = new System.Drawing.Size(184, 22);
            this.textBoxClienteNIF.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Empregado(NIF)";
            // 
            // labelPastelariaPasteis
            // 
            this.labelPastelariaPasteis.AutoSize = true;
            this.labelPastelariaPasteis.Location = new System.Drawing.Point(330, 196);
            this.labelPastelariaPasteis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPastelariaPasteis.Name = "labelPastelariaPasteis";
            this.labelPastelariaPasteis.Size = new System.Drawing.Size(54, 17);
            this.labelPastelariaPasteis.TabIndex = 5;
            this.labelPastelariaPasteis.Text = "Pasteis";
            this.labelPastelariaPasteis.Visible = false;
            // 
            // comboBoxPasteis
            // 
            this.comboBoxPasteis.FormattingEnabled = true;
            this.comboBoxPasteis.Location = new System.Drawing.Point(332, 217);
            this.comboBoxPasteis.Name = "comboBoxPasteis";
            this.comboBoxPasteis.Size = new System.Drawing.Size(243, 24);
            this.comboBoxPasteis.TabIndex = 4;
            this.comboBoxPasteis.Visible = false;
            this.comboBoxPasteis.SelectedIndexChanged += new System.EventHandler(this.comboBoxPasteis_SelectedIndexChanged);
            // 
            // labelTodos
            // 
            this.labelTodos.AutoSize = true;
            this.labelTodos.Location = new System.Drawing.Point(104, 195);
            this.labelTodos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTodos.Name = "labelTodos";
            this.labelTodos.Size = new System.Drawing.Size(109, 17);
            this.labelTodos.TabIndex = 3;
            this.labelTodos.Text = "Tipo de produto";
            this.labelTodos.Visible = false;
            // 
            // comboBoxPastelaria
            // 
            this.comboBoxPastelaria.FormattingEnabled = true;
            this.comboBoxPastelaria.Items.AddRange(new object[] {
            "Bebidas Geral",
            "Pasteis"});
            this.comboBoxPastelaria.Location = new System.Drawing.Point(105, 216);
            this.comboBoxPastelaria.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPastelaria.Name = "comboBoxPastelaria";
            this.comboBoxPastelaria.Size = new System.Drawing.Size(182, 24);
            this.comboBoxPastelaria.TabIndex = 2;
            this.comboBoxPastelaria.Visible = false;
            this.comboBoxPastelaria.SelectedIndexChanged += new System.EventHandler(this.comboBoxPastelaria_SelectedIndexChanged);
            // 
            // labelBebidasGeral
            // 
            this.labelBebidasGeral.AutoSize = true;
            this.labelBebidasGeral.Location = new System.Drawing.Point(330, 196);
            this.labelBebidasGeral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBebidasGeral.Name = "labelBebidasGeral";
            this.labelBebidasGeral.Size = new System.Drawing.Size(59, 17);
            this.labelBebidasGeral.TabIndex = 1;
            this.labelBebidasGeral.Text = "Bebidas";
            this.labelBebidasGeral.Visible = false;
            // 
            // comboBoxBebidasGeral
            // 
            this.comboBoxBebidasGeral.FormattingEnabled = true;
            this.comboBoxBebidasGeral.Location = new System.Drawing.Point(332, 217);
            this.comboBoxBebidasGeral.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBebidasGeral.Name = "comboBoxBebidasGeral";
            this.comboBoxBebidasGeral.Size = new System.Drawing.Size(243, 24);
            this.comboBoxBebidasGeral.TabIndex = 0;
            this.comboBoxBebidasGeral.Visible = false;
            this.comboBoxBebidasGeral.SelectedIndexChanged += new System.EventHandler(this.comboBoxBebidasGeral_SelectedIndexChanged);
            // 
            // listBoxRecibos
            // 
            this.listBoxRecibos.FormattingEnabled = true;
            this.listBoxRecibos.ItemHeight = 16;
            this.listBoxRecibos.Location = new System.Drawing.Point(1044, 38);
            this.listBoxRecibos.Name = "listBoxRecibos";
            this.listBoxRecibos.Size = new System.Drawing.Size(282, 276);
            this.listBoxRecibos.TabIndex = 15;
            this.listBoxRecibos.SelectedIndexChanged += new System.EventHandler(this.listBoxRecibos_SelectedIndexChanged);
            // 
            // comboBoxAlmocos
            // 
            this.comboBoxAlmocos.FormattingEnabled = true;
            this.comboBoxAlmocos.Location = new System.Drawing.Point(332, 217);
            this.comboBoxAlmocos.Name = "comboBoxAlmocos";
            this.comboBoxAlmocos.Size = new System.Drawing.Size(243, 24);
            this.comboBoxAlmocos.TabIndex = 17;
            this.comboBoxAlmocos.Visible = false;
            this.comboBoxAlmocos.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlmocos_SelectedIndexChanged);
            // 
            // comboBoxAlcool
            // 
            this.comboBoxAlcool.FormattingEnabled = true;
            this.comboBoxAlcool.Location = new System.Drawing.Point(332, 217);
            this.comboBoxAlcool.Name = "comboBoxAlcool";
            this.comboBoxAlcool.Size = new System.Drawing.Size(243, 24);
            this.comboBoxAlcool.TabIndex = 18;
            this.comboBoxAlcool.Visible = false;
            this.comboBoxAlcool.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlcool_SelectedIndexChanged);
            // 
            // comboBoxCafes
            // 
            this.comboBoxCafes.FormattingEnabled = true;
            this.comboBoxCafes.Items.AddRange(new object[] {
            "Cafe Pastelaria",
            "Cafe Restaurante",
            "Cafe Bar"});
            this.comboBoxCafes.Location = new System.Drawing.Point(107, 150);
            this.comboBoxCafes.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCafes.Name = "comboBoxCafes";
            this.comboBoxCafes.Size = new System.Drawing.Size(182, 24);
            this.comboBoxCafes.TabIndex = 19;
            this.comboBoxCafes.SelectedIndexChanged += new System.EventHandler(this.comboBoxCafes_SelectedIndexChanged);
            // 
            // labelCafe
            // 
            this.labelCafe.AutoSize = true;
            this.labelCafe.Location = new System.Drawing.Point(104, 129);
            this.labelCafe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCafe.Name = "labelCafe";
            this.labelCafe.Size = new System.Drawing.Size(89, 17);
            this.labelCafe.TabIndex = 20;
            this.labelCafe.Text = "Tipo de Cafe";
            // 
            // labelAlmocos
            // 
            this.labelAlmocos.AutoSize = true;
            this.labelAlmocos.Location = new System.Drawing.Point(330, 195);
            this.labelAlmocos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlmocos.Name = "labelAlmocos";
            this.labelAlmocos.Size = new System.Drawing.Size(61, 17);
            this.labelAlmocos.TabIndex = 21;
            this.labelAlmocos.Text = "Almocos";
            this.labelAlmocos.Visible = false;
            // 
            // labelAlcool
            // 
            this.labelAlcool.AutoSize = true;
            this.labelAlcool.Location = new System.Drawing.Point(330, 196);
            this.labelAlcool.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlcool.Name = "labelAlcool";
            this.labelAlcool.Size = new System.Drawing.Size(46, 17);
            this.labelAlcool.TabIndex = 22;
            this.labelAlcool.Text = "Alcool";
            this.labelAlcool.Visible = false;
            // 
            // comboBoxBar
            // 
            this.comboBoxBar.FormattingEnabled = true;
            this.comboBoxBar.Items.AddRange(new object[] {
            "Bebidas Geral",
            "Bebidas"});
            this.comboBoxBar.Location = new System.Drawing.Point(105, 216);
            this.comboBoxBar.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBar.Name = "comboBoxBar";
            this.comboBoxBar.Size = new System.Drawing.Size(182, 24);
            this.comboBoxBar.TabIndex = 23;
            this.comboBoxBar.Visible = false;
            this.comboBoxBar.SelectedIndexChanged += new System.EventHandler(this.comboBoxBar_SelectedIndexChanged);
            // 
            // comboBoxRestaurante
            // 
            this.comboBoxRestaurante.FormattingEnabled = true;
            this.comboBoxRestaurante.Items.AddRange(new object[] {
            "Bebidas Geral",
            "Almocos"});
            this.comboBoxRestaurante.Location = new System.Drawing.Point(105, 216);
            this.comboBoxRestaurante.Name = "comboBoxRestaurante";
            this.comboBoxRestaurante.Size = new System.Drawing.Size(182, 24);
            this.comboBoxRestaurante.TabIndex = 24;
            this.comboBoxRestaurante.Visible = false;
            this.comboBoxRestaurante.SelectedIndexChanged += new System.EventHandler(this.comboBoxRestaurante_SelectedIndexChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOK.Location = new System.Drawing.Point(152, 654);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(182, 51);
            this.buttonOK.TabIndex = 25;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Visible = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Location = new System.Drawing.Point(357, 654);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(182, 51);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(192, 390);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.ReadOnly = true;
            this.textBoxValor.Size = new System.Drawing.Size(184, 22);
            this.textBoxValor.TabIndex = 27;
            this.textBoxValor.Text = "0,00";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(104, 393);
            this.labelValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(81, 17);
            this.labelValor.TabIndex = 28;
            this.labelValor.Text = "Valor Total:";
            // 
            // buttonAddFood
            // 
            this.buttonAddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddFood.Location = new System.Drawing.Point(582, 215);
            this.buttonAddFood.Name = "buttonAddFood";
            this.buttonAddFood.Size = new System.Drawing.Size(61, 25);
            this.buttonAddFood.TabIndex = 30;
            this.buttonAddFood.Text = "Add";
            this.buttonAddFood.UseVisualStyleBackColor = true;
            this.buttonAddFood.Visible = false;
            this.buttonAddFood.Click += new System.EventHandler(this.buttonAddFood_Click);
            // 
            // textBoxEmpNIF
            // 
            this.textBoxEmpNIF.Location = new System.Drawing.Point(105, 292);
            this.textBoxEmpNIF.Name = "textBoxEmpNIF";
            this.textBoxEmpNIF.Size = new System.Drawing.Size(184, 22);
            this.textBoxEmpNIF.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(400, 388);
            this.dateTimePicker1.MaxDate = new System.DateTime(2999, 6, 8, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 22);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.Value = new System.DateTime(2020, 6, 8, 0, 0, 0, 0);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(830, 320);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.RowTemplate.Height = 24;
            this.dataGridViewClientes.Size = new System.Drawing.Size(496, 215);
            this.dataGridViewClientes.TabIndex = 33;
            // 
            // buttonDisplayClientes
            // 
            this.buttonDisplayClientes.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDisplayClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDisplayClientes.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonDisplayClientes.Location = new System.Drawing.Point(709, 490);
            this.buttonDisplayClientes.Name = "buttonDisplayClientes";
            this.buttonDisplayClientes.Size = new System.Drawing.Size(115, 45);
            this.buttonDisplayClientes.TabIndex = 34;
            this.buttonDisplayClientes.Text = "Display Clients";
            this.buttonDisplayClientes.UseVisualStyleBackColor = false;
            this.buttonDisplayClientes.Click += new System.EventHandler(this.buttonDisplayClientes_Click);
            // 
            // buttonDisplayEmp
            // 
            this.buttonDisplayEmp.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDisplayEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDisplayEmp.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonDisplayEmp.Location = new System.Drawing.Point(709, 711);
            this.buttonDisplayEmp.Name = "buttonDisplayEmp";
            this.buttonDisplayEmp.Size = new System.Drawing.Size(115, 45);
            this.buttonDisplayEmp.TabIndex = 36;
            this.buttonDisplayEmp.Text = "Display Empregados";
            this.buttonDisplayEmp.UseVisualStyleBackColor = false;
            this.buttonDisplayEmp.Click += new System.EventHandler(this.buttonDisplayEmp_Click);
            // 
            // dataGridViewEmps
            // 
            this.dataGridViewEmps.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewEmps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmps.Location = new System.Drawing.Point(830, 541);
            this.dataGridViewEmps.Name = "dataGridViewEmps";
            this.dataGridViewEmps.RowHeadersWidth = 51;
            this.dataGridViewEmps.RowTemplate.Height = 24;
            this.dataGridViewEmps.Size = new System.Drawing.Size(496, 215);
            this.dataGridViewEmps.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 33);
            this.button1.TabIndex = 37;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxProdutosRecibo
            // 
            this.listBoxProdutosRecibo.FormattingEnabled = true;
            this.listBoxProdutosRecibo.ItemHeight = 16;
            this.listBoxProdutosRecibo.Location = new System.Drawing.Point(709, 38);
            this.listBoxProdutosRecibo.Name = "listBoxProdutosRecibo";
            this.listBoxProdutosRecibo.Size = new System.Drawing.Size(329, 276);
            this.listBoxProdutosRecibo.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1342, 813);
            this.Controls.Add(this.labelAlmocos);
            this.Controls.Add(this.listBoxProdutosRecibo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDisplayEmp);
            this.Controls.Add(this.dataGridViewEmps);
            this.Controls.Add(this.buttonDisplayClientes);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxEmpNIF);
            this.Controls.Add(this.buttonAddFood);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxRestaurante);
            this.Controls.Add(this.comboBoxBar);
            this.Controls.Add(this.labelAlcool);
            this.Controls.Add(this.labelCafe);
            this.Controls.Add(this.comboBoxCafes);
            this.Controls.Add(this.comboBoxAlcool);
            this.Controls.Add(this.comboBoxAlmocos);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listBoxRecibos);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPastelaria);
            this.Controls.Add(this.textBoxClienteNIF);
            this.Controls.Add(this.labelTodos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPasteis);
            this.Controls.Add(this.comboBoxBebidasGeral);
            this.Controls.Add(this.labelPastelariaPasteis);
            this.Controls.Add(this.labelBebidasGeral);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClienteNIF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPastelariaPasteis;
        private System.Windows.Forms.ComboBox comboBoxPasteis;
        private System.Windows.Forms.Label labelTodos;
        private System.Windows.Forms.ComboBox comboBoxPastelaria;
        private System.Windows.Forms.Label labelBebidasGeral;
        private System.Windows.Forms.ComboBox comboBoxBebidasGeral;
        private System.Windows.Forms.ListBox listBoxRecibos;
        private System.Windows.Forms.ComboBox comboBoxAlmocos;
        private System.Windows.Forms.ComboBox comboBoxAlcool;
        private System.Windows.Forms.ComboBox comboBoxCafes;
        private System.Windows.Forms.Label labelCafe;
        private System.Windows.Forms.Label labelAlmocos;
        private System.Windows.Forms.Label labelAlcool;
        private System.Windows.Forms.ComboBox comboBoxBar;
        private System.Windows.Forms.ComboBox comboBoxRestaurante;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Button buttonAddFood;
        private System.Windows.Forms.TextBox textBoxEmpNIF;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Button buttonDisplayClientes;
        private System.Windows.Forms.Button buttonDisplayEmp;
        private System.Windows.Forms.DataGridView dataGridViewEmps;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxProdutosRecibo;
    }
}

