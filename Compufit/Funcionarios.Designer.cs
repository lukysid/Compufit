namespace Compufit
{
    partial class Funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.grbAcoes = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label60 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label59 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.label50 = new System.Windows.Forms.Label();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.txtDtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.dtgFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox19.SuspendLayout();
            this.grbAcoes.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.grbAcoes);
            this.groupBox19.Controls.Add(this.groupBox20);
            this.groupBox19.Controls.Add(this.groupBox21);
            this.groupBox19.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox19.Location = new System.Drawing.Point(16, 54);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(1022, 225);
            this.groupBox19.TabIndex = 1;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Ficha";
            // 
            // grbAcoes
            // 
            this.grbAcoes.Controls.Add(this.btnCancelar);
            this.grbAcoes.Controls.Add(this.btnSalvar);
            this.grbAcoes.Location = new System.Drawing.Point(912, 19);
            this.grbAcoes.Name = "grbAcoes";
            this.grbAcoes.Size = new System.Drawing.Size(101, 200);
            this.grbAcoes.TabIndex = 2;
            this.grbAcoes.TabStop = false;
            this.grbAcoes.Text = "Ações";
            this.grbAcoes.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(13, 113);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 65);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(13, 29);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 65);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.btnBuscar);
            this.groupBox20.Controls.Add(this.label60);
            this.groupBox20.Controls.Add(this.txtCidade);
            this.groupBox20.Controls.Add(this.cbxEstado);
            this.groupBox20.Controls.Add(this.label59);
            this.groupBox20.Controls.Add(this.txtNumero);
            this.groupBox20.Controls.Add(this.label48);
            this.groupBox20.Controls.Add(this.label49);
            this.groupBox20.Controls.Add(this.txtCep);
            this.groupBox20.Controls.Add(this.txtEndereço);
            this.groupBox20.Controls.Add(this.label47);
            this.groupBox20.Location = new System.Drawing.Point(6, 134);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(897, 85);
            this.groupBox20.TabIndex = 1;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Logadouro";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(117, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 23);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(675, 48);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(47, 16);
            this.label60.TabIndex = 19;
            this.label60.Text = "Estado:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(515, 46);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(137, 21);
            this.txtCidade.TabIndex = 22;
            // 
            // cbxEstado
            // 
            this.cbxEstado.Enabled = false;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbxEstado.Location = new System.Drawing.Point(728, 43);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(75, 24);
            this.cbxEstado.TabIndex = 18;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(457, 49);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(52, 16);
            this.label59.TabIndex = 21;
            this.label59.Text = "Cidade:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(390, 46);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(47, 21);
            this.txtNumero.TabIndex = 19;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(362, 49);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(22, 16);
            this.label48.TabIndex = 18;
            this.label48.Text = "Nº:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(6, 22);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(32, 16);
            this.label49.TabIndex = 20;
            this.label49.Text = "CEP:";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(44, 19);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.ReadOnly = true;
            this.txtCep.Size = new System.Drawing.Size(59, 21);
            this.txtCep.TabIndex = 18;
            // 
            // txtEndereço
            // 
            this.txtEndereço.Location = new System.Drawing.Point(74, 46);
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.ReadOnly = true;
            this.txtEndereço.Size = new System.Drawing.Size(275, 21);
            this.txtEndereço.TabIndex = 19;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 49);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(62, 16);
            this.label47.TabIndex = 18;
            this.label47.Text = "Endereço:";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.txtSenha);
            this.groupBox21.Controls.Add(this.lblSenha);
            this.groupBox21.Controls.Add(this.groupBox22);
            this.groupBox21.Controls.Add(this.label50);
            this.groupBox21.Controls.Add(this.cbxCargo);
            this.groupBox21.Controls.Add(this.txtMatricula);
            this.groupBox21.Controls.Add(this.label51);
            this.groupBox21.Controls.Add(this.label52);
            this.groupBox21.Controls.Add(this.txtCelular);
            this.groupBox21.Controls.Add(this.label53);
            this.groupBox21.Controls.Add(this.txtTelefone);
            this.groupBox21.Controls.Add(this.txtEmail);
            this.groupBox21.Controls.Add(this.label54);
            this.groupBox21.Controls.Add(this.label55);
            this.groupBox21.Controls.Add(this.txtDtNascimento);
            this.groupBox21.Controls.Add(this.label56);
            this.groupBox21.Controls.Add(this.txtCpf);
            this.groupBox21.Controls.Add(this.label57);
            this.groupBox21.Controls.Add(this.txtRg);
            this.groupBox21.Controls.Add(this.txtNome);
            this.groupBox21.Controls.Add(this.label58);
            this.groupBox21.Location = new System.Drawing.Point(6, 19);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(897, 109);
            this.groupBox21.TabIndex = 0;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Identificação";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(488, 15);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(141, 21);
            this.txtSenha.TabIndex = 19;
            this.txtSenha.Visible = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(420, 18);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(45, 16);
            this.lblSenha.TabIndex = 18;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.Visible = false;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.radioButton7);
            this.groupBox22.Controls.Add(this.radioButton8);
            this.groupBox22.Location = new System.Drawing.Point(657, 65);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(175, 37);
            this.groupBox22.TabIndex = 0;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Sexo";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(92, 15);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(72, 20);
            this.radioButton7.TabIndex = 19;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Feminino";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(6, 15);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(80, 20);
            this.radioButton8.TabIndex = 18;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Masculino";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(227, 20);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(44, 16);
            this.label50.TabIndex = 17;
            this.label50.Text = "Cargo:";
            // 
            // cbxCargo
            // 
            this.cbxCargo.Enabled = false;
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Items.AddRange(new object[] {
            "Administrador",
            "Atendente",
            "Personal",
            "Nutricionista",
            "Limpeza"});
            this.cbxCargo.Location = new System.Drawing.Point(277, 15);
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(121, 24);
            this.cbxCargo.TabIndex = 16;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(74, 18);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ReadOnly = true;
            this.txtMatricula.Size = new System.Drawing.Size(113, 21);
            this.txtMatricula.TabIndex = 15;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(6, 21);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(62, 16);
            this.label51.TabIndex = 14;
            this.label51.Text = "Matricula:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(510, 74);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(48, 16);
            this.label52.TabIndex = 13;
            this.label52.Text = "Celular:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(564, 71);
            this.txtCelular.Mask = "00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ReadOnly = true;
            this.txtCelular.Size = new System.Drawing.Size(87, 21);
            this.txtCelular.TabIndex = 12;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(369, 74);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(55, 16);
            this.label53.TabIndex = 11;
            this.label53.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(430, 72);
            this.txtTelefone.Mask = "0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(74, 21);
            this.txtTelefone.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(54, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(295, 21);
            this.txtEmail.TabIndex = 9;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(6, 74);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(38, 16);
            this.label54.TabIndex = 8;
            this.label54.Text = "Email:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(654, 47);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(123, 16);
            this.label55.TabIndex = 7;
            this.label55.Text = "Data de Nascimento:";
            // 
            // txtDtNascimento
            // 
            this.txtDtNascimento.Location = new System.Drawing.Point(783, 44);
            this.txtDtNascimento.Mask = "00-00-0000";
            this.txtDtNascimento.Name = "txtDtNascimento";
            this.txtDtNascimento.ReadOnly = true;
            this.txtDtNascimento.Size = new System.Drawing.Size(63, 21);
            this.txtDtNascimento.TabIndex = 6;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(509, 48);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(31, 16);
            this.label56.TabIndex = 5;
            this.label56.Text = "CPF:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(545, 44);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.ReadOnly = true;
            this.txtCpf.Size = new System.Drawing.Size(84, 21);
            this.txtCpf.TabIndex = 4;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(373, 47);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(27, 16);
            this.label57.TabIndex = 3;
            this.label57.Text = "RG:";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(405, 44);
            this.txtRg.Mask = "00.000.000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.ReadOnly = true;
            this.txtRg.Size = new System.Drawing.Size(77, 21);
            this.txtRg.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(54, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(295, 21);
            this.txtNome.TabIndex = 1;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(6, 47);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(42, 16);
            this.label58.TabIndex = 0;
            this.label58.Text = "Nome:";
            // 
            // dtgFuncionarios
            // 
            this.dtgFuncionarios.AllowUserToAddRows = false;
            this.dtgFuncionarios.AllowUserToDeleteRows = false;
            this.dtgFuncionarios.AllowUserToResizeColumns = false;
            this.dtgFuncionarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgFuncionarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFuncionarios.EnableHeadersVisualStyles = false;
            this.dtgFuncionarios.Location = new System.Drawing.Point(16, 286);
            this.dtgFuncionarios.Name = "dtgFuncionarios";
            this.dtgFuncionarios.ReadOnly = true;
            this.dtgFuncionarios.RowHeadersVisible = false;
            this.dtgFuncionarios.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgFuncionarios.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgFuncionarios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.dtgFuncionarios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgFuncionarios.RowTemplate.ReadOnly = true;
            this.dtgFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFuncionarios.Size = new System.Drawing.Size(1022, 292);
            this.dtgFuncionarios.TabIndex = 2;
            this.dtgFuncionarios.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFuncionarios_CellEnter);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(16, 13);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAdicionar.Size = new System.Drawing.Size(130, 35);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = " Incluir";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(163, 13);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAlterar.Size = new System.Drawing.Size(130, 35);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = " Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(309, 13);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnExcluir.Size = new System.Drawing.Size(130, 35);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = " Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 590);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dtgFuncionarios);
            this.Controls.Add(this.groupBox19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Funcionarios";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            this.groupBox19.ResumeLayout(false);
            this.grbAcoes.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtEndereço;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.MaskedTextBox txtDtNascimento;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.DataGridView dtgFuncionarios;
        private System.Windows.Forms.GroupBox grbAcoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
    }
}