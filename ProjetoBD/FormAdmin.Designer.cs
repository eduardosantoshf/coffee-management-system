namespace ProjetoBD
{
    partial class FormAdmin
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
            this.buttonEmp = new System.Windows.Forms.Button();
            this.buttonRemoveEmp = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonProd = new System.Windows.Forms.Button();
            this.panelAddEmp = new System.Windows.Forms.Panel();
            this.buttonOkEmp = new System.Windows.Forms.Button();
            this.buttonCancelEmp = new System.Windows.Forms.Button();
            this.buttonAddEmp2 = new System.Windows.Forms.Button();
            this.labelEmpIdade = new System.Windows.Forms.Label();
            this.textBoxNIFcafe = new System.Windows.Forms.TextBox();
            this.textBoxEmpIdade = new System.Windows.Forms.TextBox();
            this.labelCafeNIF = new System.Windows.Forms.Label();
            this.labelEmpInicContrato = new System.Windows.Forms.Label();
            this.labelEmpNome = new System.Windows.Forms.Label();
            this.textBoxEmpNome = new System.Windows.Forms.TextBox();
            this.dateTimePickerEmp = new System.Windows.Forms.DateTimePicker();
            this.labelEmpNIF = new System.Windows.Forms.Label();
            this.textBoxEmpNIF = new System.Windows.Forms.TextBox();
            this.listBoxEmpregados = new System.Windows.Forms.ListBox();
            this.panelProd = new System.Windows.Forms.Panel();
            this.buttonEditProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProdTipo = new System.Windows.Forms.ComboBox();
            this.buttonOkProd = new System.Windows.Forms.Button();
            this.buttonCancelProd = new System.Windows.Forms.Button();
            this.buttonAddProd = new System.Windows.Forms.Button();
            this.buttonRemoveProd = new System.Windows.Forms.Button();
            this.labelProdutoPreco = new System.Windows.Forms.Label();
            this.textBoxProdPreco = new System.Windows.Forms.TextBox();
            this.labelProdutoNome = new System.Windows.Forms.Label();
            this.textBoxProdNome = new System.Windows.Forms.TextBox();
            this.listBoxProds = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.buttonOkCliente = new System.Windows.Forms.Button();
            this.buttonCancelCliente = new System.Windows.Forms.Button();
            this.buttonAddCliente = new System.Windows.Forms.Button();
            this.buttonRemoveCliente = new System.Windows.Forms.Button();
            this.labelClienteNome = new System.Windows.Forms.Label();
            this.textBoxClienteNome = new System.Windows.Forms.TextBox();
            this.labelClienteNIF = new System.Windows.Forms.Label();
            this.textBoxClienteNIF = new System.Windows.Forms.TextBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.panelAddEmp.SuspendLayout();
            this.panelProd.SuspendLayout();
            this.panelClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEmp
            // 
            this.buttonEmp.Location = new System.Drawing.Point(136, 66);
            this.buttonEmp.Name = "buttonEmp";
            this.buttonEmp.Size = new System.Drawing.Size(198, 66);
            this.buttonEmp.TabIndex = 0;
            this.buttonEmp.Text = "Empregado";
            this.buttonEmp.UseVisualStyleBackColor = true;
            this.buttonEmp.Click += new System.EventHandler(this.buttonEmp_Click);
            // 
            // buttonRemoveEmp
            // 
            this.buttonRemoveEmp.Location = new System.Drawing.Point(267, 231);
            this.buttonRemoveEmp.Name = "buttonRemoveEmp";
            this.buttonRemoveEmp.Size = new System.Drawing.Size(142, 42);
            this.buttonRemoveEmp.TabIndex = 1;
            this.buttonRemoveEmp.Text = "Remove Empregado";
            this.buttonRemoveEmp.UseVisualStyleBackColor = true;
            this.buttonRemoveEmp.Visible = false;
            this.buttonRemoveEmp.Click += new System.EventHandler(this.buttonRemoveEmp_Click);
            // 
            // buttonCliente
            // 
            this.buttonCliente.Location = new System.Drawing.Point(564, 66);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(198, 66);
            this.buttonCliente.TabIndex = 2;
            this.buttonCliente.Text = "Cliente";
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // buttonProd
            // 
            this.buttonProd.Location = new System.Drawing.Point(995, 66);
            this.buttonProd.Name = "buttonProd";
            this.buttonProd.Size = new System.Drawing.Size(198, 66);
            this.buttonProd.TabIndex = 5;
            this.buttonProd.Text = "Produto";
            this.buttonProd.UseVisualStyleBackColor = true;
            this.buttonProd.Click += new System.EventHandler(this.buttonProd_Click);
            // 
            // panelAddEmp
            // 
            this.panelAddEmp.Controls.Add(this.buttonOkEmp);
            this.panelAddEmp.Controls.Add(this.buttonCancelEmp);
            this.panelAddEmp.Controls.Add(this.buttonAddEmp2);
            this.panelAddEmp.Controls.Add(this.labelEmpIdade);
            this.panelAddEmp.Controls.Add(this.textBoxNIFcafe);
            this.panelAddEmp.Controls.Add(this.buttonRemoveEmp);
            this.panelAddEmp.Controls.Add(this.textBoxEmpIdade);
            this.panelAddEmp.Controls.Add(this.labelCafeNIF);
            this.panelAddEmp.Controls.Add(this.labelEmpInicContrato);
            this.panelAddEmp.Controls.Add(this.labelEmpNome);
            this.panelAddEmp.Controls.Add(this.textBoxEmpNome);
            this.panelAddEmp.Controls.Add(this.dateTimePickerEmp);
            this.panelAddEmp.Controls.Add(this.labelEmpNIF);
            this.panelAddEmp.Controls.Add(this.textBoxEmpNIF);
            this.panelAddEmp.Controls.Add(this.listBoxEmpregados);
            this.panelAddEmp.Location = new System.Drawing.Point(45, 180);
            this.panelAddEmp.Name = "panelAddEmp";
            this.panelAddEmp.Size = new System.Drawing.Size(1255, 327);
            this.panelAddEmp.TabIndex = 7;
            this.panelAddEmp.Visible = false;
            // 
            // buttonOkEmp
            // 
            this.buttonOkEmp.Location = new System.Drawing.Point(90, 279);
            this.buttonOkEmp.Name = "buttonOkEmp";
            this.buttonOkEmp.Size = new System.Drawing.Size(142, 42);
            this.buttonOkEmp.TabIndex = 43;
            this.buttonOkEmp.Text = "OK";
            this.buttonOkEmp.UseVisualStyleBackColor = true;
            this.buttonOkEmp.Visible = false;
            this.buttonOkEmp.Click += new System.EventHandler(this.buttonOkEmp_Click);
            // 
            // buttonCancelEmp
            // 
            this.buttonCancelEmp.Location = new System.Drawing.Point(267, 279);
            this.buttonCancelEmp.Name = "buttonCancelEmp";
            this.buttonCancelEmp.Size = new System.Drawing.Size(142, 42);
            this.buttonCancelEmp.TabIndex = 42;
            this.buttonCancelEmp.Text = "Cancel";
            this.buttonCancelEmp.UseVisualStyleBackColor = true;
            this.buttonCancelEmp.Visible = false;
            this.buttonCancelEmp.Click += new System.EventHandler(this.buttonCancelEmp_Click);
            // 
            // buttonAddEmp2
            // 
            this.buttonAddEmp2.Location = new System.Drawing.Point(90, 231);
            this.buttonAddEmp2.Name = "buttonAddEmp2";
            this.buttonAddEmp2.Size = new System.Drawing.Size(142, 42);
            this.buttonAddEmp2.TabIndex = 41;
            this.buttonAddEmp2.Text = "Add Empregado";
            this.buttonAddEmp2.UseVisualStyleBackColor = true;
            this.buttonAddEmp2.Click += new System.EventHandler(this.buttonAddEmp2_Click);
            // 
            // labelEmpIdade
            // 
            this.labelEmpIdade.AutoSize = true;
            this.labelEmpIdade.Location = new System.Drawing.Point(193, 79);
            this.labelEmpIdade.Name = "labelEmpIdade";
            this.labelEmpIdade.Size = new System.Drawing.Size(120, 17);
            this.labelEmpIdade.TabIndex = 40;
            this.labelEmpIdade.Text = "Empregado Idade";
            // 
            // textBoxNIFcafe
            // 
            this.textBoxNIFcafe.Location = new System.Drawing.Point(196, 38);
            this.textBoxNIFcafe.Name = "textBoxNIFcafe";
            this.textBoxNIFcafe.Size = new System.Drawing.Size(163, 22);
            this.textBoxNIFcafe.TabIndex = 39;
            // 
            // textBoxEmpIdade
            // 
            this.textBoxEmpIdade.Location = new System.Drawing.Point(196, 101);
            this.textBoxEmpIdade.Name = "textBoxEmpIdade";
            this.textBoxEmpIdade.Size = new System.Drawing.Size(163, 22);
            this.textBoxEmpIdade.TabIndex = 38;
            // 
            // labelCafeNIF
            // 
            this.labelCafeNIF.AutoSize = true;
            this.labelCafeNIF.Location = new System.Drawing.Point(193, 18);
            this.labelCafeNIF.Name = "labelCafeNIF";
            this.labelCafeNIF.Size = new System.Drawing.Size(62, 17);
            this.labelCafeNIF.TabIndex = 37;
            this.labelCafeNIF.Text = "Cafe NIF";
            // 
            // labelEmpInicContrato
            // 
            this.labelEmpInicContrato.AutoSize = true;
            this.labelEmpInicContrato.Location = new System.Drawing.Point(392, 79);
            this.labelEmpInicContrato.Name = "labelEmpInicContrato";
            this.labelEmpInicContrato.Size = new System.Drawing.Size(172, 17);
            this.labelEmpInicContrato.TabIndex = 36;
            this.labelEmpInicContrato.Text = "Data de Inicio do Contrato";
            // 
            // labelEmpNome
            // 
            this.labelEmpNome.AutoSize = true;
            this.labelEmpNome.Location = new System.Drawing.Point(4, 81);
            this.labelEmpNome.Name = "labelEmpNome";
            this.labelEmpNome.Size = new System.Drawing.Size(122, 17);
            this.labelEmpNome.TabIndex = 35;
            this.labelEmpNome.Text = "Empregado Nome";
            // 
            // textBoxEmpNome
            // 
            this.textBoxEmpNome.Location = new System.Drawing.Point(7, 101);
            this.textBoxEmpNome.Name = "textBoxEmpNome";
            this.textBoxEmpNome.Size = new System.Drawing.Size(163, 22);
            this.textBoxEmpNome.TabIndex = 34;
            // 
            // dateTimePickerEmp
            // 
            this.dateTimePickerEmp.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerEmp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEmp.Location = new System.Drawing.Point(395, 99);
            this.dateTimePickerEmp.MaxDate = new System.DateTime(2999, 6, 8, 0, 0, 0, 0);
            this.dateTimePickerEmp.Name = "dateTimePickerEmp";
            this.dateTimePickerEmp.Size = new System.Drawing.Size(117, 22);
            this.dateTimePickerEmp.TabIndex = 33;
            this.dateTimePickerEmp.Value = new System.DateTime(2020, 6, 8, 0, 0, 0, 0);
            // 
            // labelEmpNIF
            // 
            this.labelEmpNIF.AutoSize = true;
            this.labelEmpNIF.Location = new System.Drawing.Point(4, 18);
            this.labelEmpNIF.Name = "labelEmpNIF";
            this.labelEmpNIF.Size = new System.Drawing.Size(106, 17);
            this.labelEmpNIF.TabIndex = 2;
            this.labelEmpNIF.Text = "Empregado NIF";
            // 
            // textBoxEmpNIF
            // 
            this.textBoxEmpNIF.Location = new System.Drawing.Point(7, 38);
            this.textBoxEmpNIF.Name = "textBoxEmpNIF";
            this.textBoxEmpNIF.Size = new System.Drawing.Size(163, 22);
            this.textBoxEmpNIF.TabIndex = 1;
            // 
            // listBoxEmpregados
            // 
            this.listBoxEmpregados.FormattingEnabled = true;
            this.listBoxEmpregados.ItemHeight = 16;
            this.listBoxEmpregados.Location = new System.Drawing.Point(832, 16);
            this.listBoxEmpregados.Name = "listBoxEmpregados";
            this.listBoxEmpregados.Size = new System.Drawing.Size(411, 292);
            this.listBoxEmpregados.TabIndex = 0;
            this.listBoxEmpregados.SelectedIndexChanged += new System.EventHandler(this.listBoxEmpregados_SelectedIndexChanged);
            // 
            // panelProd
            // 
            this.panelProd.Controls.Add(this.buttonEditProd);
            this.panelProd.Controls.Add(this.label1);
            this.panelProd.Controls.Add(this.comboBoxProdTipo);
            this.panelProd.Controls.Add(this.buttonOkProd);
            this.panelProd.Controls.Add(this.buttonCancelProd);
            this.panelProd.Controls.Add(this.buttonAddProd);
            this.panelProd.Controls.Add(this.buttonRemoveProd);
            this.panelProd.Controls.Add(this.labelProdutoPreco);
            this.panelProd.Controls.Add(this.textBoxProdPreco);
            this.panelProd.Controls.Add(this.labelProdutoNome);
            this.panelProd.Controls.Add(this.textBoxProdNome);
            this.panelProd.Controls.Add(this.listBoxProds);
            this.panelProd.Location = new System.Drawing.Point(45, 180);
            this.panelProd.Name = "panelProd";
            this.panelProd.Size = new System.Drawing.Size(1255, 327);
            this.panelProd.TabIndex = 44;
            this.panelProd.Visible = false;
            // 
            // buttonEditProd
            // 
            this.buttonEditProd.Location = new System.Drawing.Point(238, 231);
            this.buttonEditProd.Name = "buttonEditProd";
            this.buttonEditProd.Size = new System.Drawing.Size(142, 42);
            this.buttonEditProd.TabIndex = 46;
            this.buttonEditProd.Text = "Edit Produto";
            this.buttonEditProd.UseVisualStyleBackColor = true;
            this.buttonEditProd.Visible = false;
            this.buttonEditProd.Click += new System.EventHandler(this.buttonEditProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Produto Tipo";
            // 
            // comboBoxProdTipo
            // 
            this.comboBoxProdTipo.FormattingEnabled = true;
            this.comboBoxProdTipo.Items.AddRange(new object[] {
            "Bebidas",
            "Alcool",
            "Almocos",
            "Pasteis"});
            this.comboBoxProdTipo.Location = new System.Drawing.Point(196, 36);
            this.comboBoxProdTipo.Name = "comboBoxProdTipo";
            this.comboBoxProdTipo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProdTipo.TabIndex = 44;
            // 
            // buttonOkProd
            // 
            this.buttonOkProd.Location = new System.Drawing.Point(158, 279);
            this.buttonOkProd.Name = "buttonOkProd";
            this.buttonOkProd.Size = new System.Drawing.Size(142, 42);
            this.buttonOkProd.TabIndex = 43;
            this.buttonOkProd.Text = "OK";
            this.buttonOkProd.UseVisualStyleBackColor = true;
            this.buttonOkProd.Visible = false;
            this.buttonOkProd.Click += new System.EventHandler(this.buttonOkProd_Click);
            // 
            // buttonCancelProd
            // 
            this.buttonCancelProd.Location = new System.Drawing.Point(327, 279);
            this.buttonCancelProd.Name = "buttonCancelProd";
            this.buttonCancelProd.Size = new System.Drawing.Size(142, 42);
            this.buttonCancelProd.TabIndex = 42;
            this.buttonCancelProd.Text = "Cancel";
            this.buttonCancelProd.UseVisualStyleBackColor = true;
            this.buttonCancelProd.Visible = false;
            this.buttonCancelProd.Click += new System.EventHandler(this.buttonCancelProd_Click);
            // 
            // buttonAddProd
            // 
            this.buttonAddProd.Location = new System.Drawing.Point(90, 231);
            this.buttonAddProd.Name = "buttonAddProd";
            this.buttonAddProd.Size = new System.Drawing.Size(142, 42);
            this.buttonAddProd.TabIndex = 41;
            this.buttonAddProd.Text = "Add Produto";
            this.buttonAddProd.UseVisualStyleBackColor = true;
            this.buttonAddProd.Click += new System.EventHandler(this.buttonAddProd_Click);
            // 
            // buttonRemoveProd
            // 
            this.buttonRemoveProd.Location = new System.Drawing.Point(386, 231);
            this.buttonRemoveProd.Name = "buttonRemoveProd";
            this.buttonRemoveProd.Size = new System.Drawing.Size(142, 42);
            this.buttonRemoveProd.TabIndex = 1;
            this.buttonRemoveProd.Text = "Remove Produto";
            this.buttonRemoveProd.UseVisualStyleBackColor = true;
            this.buttonRemoveProd.Visible = false;
            this.buttonRemoveProd.Click += new System.EventHandler(this.buttonRemoveProd_Click);
            // 
            // labelProdutoPreco
            // 
            this.labelProdutoPreco.AutoSize = true;
            this.labelProdutoPreco.Location = new System.Drawing.Point(4, 81);
            this.labelProdutoPreco.Name = "labelProdutoPreco";
            this.labelProdutoPreco.Size = new System.Drawing.Size(99, 17);
            this.labelProdutoPreco.TabIndex = 35;
            this.labelProdutoPreco.Text = "Produto Preco";
            // 
            // textBoxProdPreco
            // 
            this.textBoxProdPreco.Location = new System.Drawing.Point(7, 101);
            this.textBoxProdPreco.Name = "textBoxProdPreco";
            this.textBoxProdPreco.Size = new System.Drawing.Size(163, 22);
            this.textBoxProdPreco.TabIndex = 34;
            // 
            // labelProdutoNome
            // 
            this.labelProdutoNome.AutoSize = true;
            this.labelProdutoNome.Location = new System.Drawing.Point(4, 18);
            this.labelProdutoNome.Name = "labelProdutoNome";
            this.labelProdutoNome.Size = new System.Drawing.Size(99, 17);
            this.labelProdutoNome.TabIndex = 2;
            this.labelProdutoNome.Text = "Produto Nome";
            // 
            // textBoxProdNome
            // 
            this.textBoxProdNome.Location = new System.Drawing.Point(7, 38);
            this.textBoxProdNome.Name = "textBoxProdNome";
            this.textBoxProdNome.Size = new System.Drawing.Size(163, 22);
            this.textBoxProdNome.TabIndex = 1;
            // 
            // listBoxProds
            // 
            this.listBoxProds.FormattingEnabled = true;
            this.listBoxProds.ItemHeight = 16;
            this.listBoxProds.Location = new System.Drawing.Point(832, 16);
            this.listBoxProds.Name = "listBoxProds";
            this.listBoxProds.Size = new System.Drawing.Size(411, 292);
            this.listBoxProds.TabIndex = 0;
            this.listBoxProds.SelectedIndexChanged += new System.EventHandler(this.listBoxProds_SelectedIndexChanged);
            // 
            // panelClientes
            // 
            this.panelClientes.Controls.Add(this.buttonOkCliente);
            this.panelClientes.Controls.Add(this.buttonCancelCliente);
            this.panelClientes.Controls.Add(this.buttonAddCliente);
            this.panelClientes.Controls.Add(this.buttonRemoveCliente);
            this.panelClientes.Controls.Add(this.labelClienteNome);
            this.panelClientes.Controls.Add(this.textBoxClienteNome);
            this.panelClientes.Controls.Add(this.labelClienteNIF);
            this.panelClientes.Controls.Add(this.textBoxClienteNIF);
            this.panelClientes.Controls.Add(this.listBoxClientes);
            this.panelClientes.Location = new System.Drawing.Point(45, 180);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(1255, 327);
            this.panelClientes.TabIndex = 44;
            this.panelClientes.Visible = false;
            // 
            // buttonOkCliente
            // 
            this.buttonOkCliente.Location = new System.Drawing.Point(90, 279);
            this.buttonOkCliente.Name = "buttonOkCliente";
            this.buttonOkCliente.Size = new System.Drawing.Size(142, 42);
            this.buttonOkCliente.TabIndex = 43;
            this.buttonOkCliente.Text = "OK";
            this.buttonOkCliente.UseVisualStyleBackColor = true;
            this.buttonOkCliente.Visible = false;
            this.buttonOkCliente.Click += new System.EventHandler(this.buttonOkCliente_Click);
            // 
            // buttonCancelCliente
            // 
            this.buttonCancelCliente.Location = new System.Drawing.Point(267, 279);
            this.buttonCancelCliente.Name = "buttonCancelCliente";
            this.buttonCancelCliente.Size = new System.Drawing.Size(142, 42);
            this.buttonCancelCliente.TabIndex = 42;
            this.buttonCancelCliente.Text = "Cancel";
            this.buttonCancelCliente.UseVisualStyleBackColor = true;
            this.buttonCancelCliente.Visible = false;
            this.buttonCancelCliente.Click += new System.EventHandler(this.buttonCancelCliente_Click);
            // 
            // buttonAddCliente
            // 
            this.buttonAddCliente.Location = new System.Drawing.Point(90, 231);
            this.buttonAddCliente.Name = "buttonAddCliente";
            this.buttonAddCliente.Size = new System.Drawing.Size(142, 42);
            this.buttonAddCliente.TabIndex = 41;
            this.buttonAddCliente.Text = "Add Cliente";
            this.buttonAddCliente.UseVisualStyleBackColor = true;
            this.buttonAddCliente.Click += new System.EventHandler(this.buttonAddCliente_Click);
            // 
            // buttonRemoveCliente
            // 
            this.buttonRemoveCliente.Location = new System.Drawing.Point(267, 231);
            this.buttonRemoveCliente.Name = "buttonRemoveCliente";
            this.buttonRemoveCliente.Size = new System.Drawing.Size(142, 42);
            this.buttonRemoveCliente.TabIndex = 1;
            this.buttonRemoveCliente.Text = "Remove Cliente";
            this.buttonRemoveCliente.UseVisualStyleBackColor = true;
            this.buttonRemoveCliente.Visible = false;
            this.buttonRemoveCliente.Click += new System.EventHandler(this.buttonRemoveCliente_Click);
            // 
            // labelClienteNome
            // 
            this.labelClienteNome.AutoSize = true;
            this.labelClienteNome.Location = new System.Drawing.Point(4, 81);
            this.labelClienteNome.Name = "labelClienteNome";
            this.labelClienteNome.Size = new System.Drawing.Size(92, 17);
            this.labelClienteNome.TabIndex = 35;
            this.labelClienteNome.Text = "Cliente Nome";
            // 
            // textBoxClienteNome
            // 
            this.textBoxClienteNome.Location = new System.Drawing.Point(7, 101);
            this.textBoxClienteNome.Name = "textBoxClienteNome";
            this.textBoxClienteNome.Size = new System.Drawing.Size(163, 22);
            this.textBoxClienteNome.TabIndex = 34;
            // 
            // labelClienteNIF
            // 
            this.labelClienteNIF.AutoSize = true;
            this.labelClienteNIF.Location = new System.Drawing.Point(4, 18);
            this.labelClienteNIF.Name = "labelClienteNIF";
            this.labelClienteNIF.Size = new System.Drawing.Size(76, 17);
            this.labelClienteNIF.TabIndex = 2;
            this.labelClienteNIF.Text = "Cliente NIF";
            // 
            // textBoxClienteNIF
            // 
            this.textBoxClienteNIF.Location = new System.Drawing.Point(7, 38);
            this.textBoxClienteNIF.Name = "textBoxClienteNIF";
            this.textBoxClienteNIF.Size = new System.Drawing.Size(163, 22);
            this.textBoxClienteNIF.TabIndex = 1;
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 16;
            this.listBoxClientes.Location = new System.Drawing.Point(832, 16);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(411, 292);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 813);
            this.Controls.Add(this.buttonProd);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.buttonEmp);
            this.Controls.Add(this.panelProd);
            this.Controls.Add(this.panelClientes);
            this.Controls.Add(this.panelAddEmp);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.panelAddEmp.ResumeLayout(false);
            this.panelAddEmp.PerformLayout();
            this.panelProd.ResumeLayout(false);
            this.panelProd.PerformLayout();
            this.panelClientes.ResumeLayout(false);
            this.panelClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEmp;
        private System.Windows.Forms.Button buttonRemoveEmp;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonProd;
        private System.Windows.Forms.Panel panelAddEmp;
        private System.Windows.Forms.ListBox listBoxEmpregados;
        private System.Windows.Forms.Label labelEmpNIF;
        private System.Windows.Forms.TextBox textBoxEmpNIF;
        private System.Windows.Forms.Label labelEmpIdade;
        private System.Windows.Forms.TextBox textBoxNIFcafe;
        private System.Windows.Forms.TextBox textBoxEmpIdade;
        private System.Windows.Forms.Label labelCafeNIF;
        private System.Windows.Forms.Label labelEmpInicContrato;
        private System.Windows.Forms.Label labelEmpNome;
        private System.Windows.Forms.TextBox textBoxEmpNome;
        private System.Windows.Forms.DateTimePicker dateTimePickerEmp;
        private System.Windows.Forms.Button buttonOkEmp;
        private System.Windows.Forms.Button buttonCancelEmp;
        private System.Windows.Forms.Button buttonAddEmp2;
        private System.Windows.Forms.Panel panelProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProdTipo;
        private System.Windows.Forms.Button buttonOkProd;
        private System.Windows.Forms.Button buttonCancelProd;
        private System.Windows.Forms.Button buttonAddProd;
        private System.Windows.Forms.Button buttonRemoveProd;
        private System.Windows.Forms.Label labelProdutoPreco;
        private System.Windows.Forms.TextBox textBoxProdPreco;
        private System.Windows.Forms.Label labelProdutoNome;
        private System.Windows.Forms.TextBox textBoxProdNome;
        private System.Windows.Forms.ListBox listBoxProds;
        private System.Windows.Forms.Button buttonEditProd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.Button buttonOkCliente;
        private System.Windows.Forms.Button buttonCancelCliente;
        private System.Windows.Forms.Button buttonAddCliente;
        private System.Windows.Forms.Button buttonRemoveCliente;
        private System.Windows.Forms.Label labelClienteNome;
        private System.Windows.Forms.TextBox textBoxClienteNome;
        private System.Windows.Forms.Label labelClienteNIF;
        private System.Windows.Forms.TextBox textBoxClienteNIF;
        private System.Windows.Forms.ListBox listBoxClientes;
    }
}