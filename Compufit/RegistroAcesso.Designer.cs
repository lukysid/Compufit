namespace Compufit
{
    partial class RegistroAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroAcesso));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.txtDtUltimaVisita = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalVisitas = new System.Windows.Forms.TextBox();
            this.txtVisitasPorSemana = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
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
            this.dtgRegistroAcesso = new System.Windows.Forms.DataGridView();
            this.groupBox19.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroAcesso)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.groupBox20);
            this.groupBox19.Controls.Add(this.groupBox21);
            this.groupBox19.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox19.Location = new System.Drawing.Point(16, 12);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(1022, 268);
            this.groupBox19.TabIndex = 7;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Ficha";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.txtDtUltimaVisita);
            this.groupBox20.Controls.Add(this.label6);
            this.groupBox20.Controls.Add(this.txtTotalVisitas);
            this.groupBox20.Controls.Add(this.txtVisitasPorSemana);
            this.groupBox20.Controls.Add(this.label5);
            this.groupBox20.Controls.Add(this.label4);
            this.groupBox20.Controls.Add(this.label3);
            this.groupBox20.Controls.Add(this.label2);
            this.groupBox20.Controls.Add(this.txtDtCadastro);
            this.groupBox20.Controls.Add(this.label1);
            this.groupBox20.Location = new System.Drawing.Point(6, 134);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(1010, 128);
            this.groupBox20.TabIndex = 1;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Histórico";
            this.groupBox20.Enter += new System.EventHandler(this.groupBox20_Enter);
            // 
            // txtDtUltimaVisita
            // 
            this.txtDtUltimaVisita.Location = new System.Drawing.Point(120, 54);
            this.txtDtUltimaVisita.Mask = "00-00-0000";
            this.txtDtUltimaVisita.Name = "txtDtUltimaVisita";
            this.txtDtUltimaVisita.ReadOnly = true;
            this.txtDtUltimaVisita.Size = new System.Drawing.Size(63, 21);
            this.txtDtUltimaVisita.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Ultima Visita:";
            // 
            // txtTotalVisitas
            // 
            this.txtTotalVisitas.Location = new System.Drawing.Point(296, 81);
            this.txtTotalVisitas.Name = "txtTotalVisitas";
            this.txtTotalVisitas.ReadOnly = true;
            this.txtTotalVisitas.Size = new System.Drawing.Size(67, 21);
            this.txtTotalVisitas.TabIndex = 30;
            // 
            // txtVisitasPorSemana
            // 
            this.txtVisitasPorSemana.Location = new System.Drawing.Point(120, 83);
            this.txtVisitasPorSemana.Name = "txtVisitasPorSemana";
            this.txtVisitasPorSemana.ReadOnly = true;
            this.txtVisitasPorSemana.Size = new System.Drawing.Size(63, 21);
            this.txtVisitasPorSemana.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Total de Visitas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Visitas na Semana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(744, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "GOLD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tipo de Plano:";
            // 
            // txtDtCadastro
            // 
            this.txtDtCadastro.Location = new System.Drawing.Point(120, 27);
            this.txtDtCadastro.Mask = "00-00-0000";
            this.txtDtCadastro.Name = "txtDtCadastro";
            this.txtDtCadastro.ReadOnly = true;
            this.txtDtCadastro.Size = new System.Drawing.Size(63, 21);
            this.txtDtCadastro.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Data de Cadastro:";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.btnBuscar);
            this.groupBox21.Controls.Add(this.groupBox22);
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
            this.groupBox21.Size = new System.Drawing.Size(1010, 109);
            this.groupBox21.TabIndex = 0;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Identificação";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(193, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(42, 25);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.radioButton7);
            this.groupBox22.Controls.Add(this.radioButton8);
            this.groupBox22.Location = new System.Drawing.Point(783, 66);
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
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(74, 18);
            this.txtMatricula.Name = "txtMatricula";
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
            this.label52.Location = new System.Drawing.Point(562, 74);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(48, 16);
            this.label52.TabIndex = 13;
            this.label52.Text = "Celular:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(615, 71);
            this.txtCelular.Mask = "(00) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ReadOnly = true;
            this.txtCelular.Size = new System.Drawing.Size(87, 21);
            this.txtCelular.TabIndex = 12;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(386, 74);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(55, 16);
            this.label53.TabIndex = 11;
            this.label53.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(447, 72);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(88, 21);
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
            this.label54.Location = new System.Drawing.Point(9, 74);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(38, 16);
            this.label54.TabIndex = 8;
            this.label54.Text = "Email:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(776, 47);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(123, 16);
            this.label55.TabIndex = 7;
            this.label55.Text = "Data de Nascimento:";
            // 
            // txtDtNascimento
            // 
            this.txtDtNascimento.Location = new System.Drawing.Point(905, 44);
            this.txtDtNascimento.Mask = "00-00-0000";
            this.txtDtNascimento.Name = "txtDtNascimento";
            this.txtDtNascimento.ReadOnly = true;
            this.txtDtNascimento.Size = new System.Drawing.Size(63, 21);
            this.txtDtNascimento.TabIndex = 6;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(579, 48);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(31, 16);
            this.label56.TabIndex = 5;
            this.label56.Text = "CPF:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(615, 44);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.ReadOnly = true;
            this.txtCpf.Size = new System.Drawing.Size(87, 21);
            this.txtCpf.TabIndex = 4;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(414, 47);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(27, 16);
            this.label57.TabIndex = 3;
            this.label57.Text = "RG:";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(447, 45);
            this.txtRg.Mask = "00.000.000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.ReadOnly = true;
            this.txtRg.Size = new System.Drawing.Size(88, 21);
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
            // dtgRegistroAcesso
            // 
            this.dtgRegistroAcesso.AllowUserToAddRows = false;
            this.dtgRegistroAcesso.AllowUserToDeleteRows = false;
            this.dtgRegistroAcesso.AllowUserToResizeColumns = false;
            this.dtgRegistroAcesso.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgRegistroAcesso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgRegistroAcesso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRegistroAcesso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgRegistroAcesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRegistroAcesso.EnableHeadersVisualStyles = false;
            this.dtgRegistroAcesso.Location = new System.Drawing.Point(16, 286);
            this.dtgRegistroAcesso.Name = "dtgRegistroAcesso";
            this.dtgRegistroAcesso.ReadOnly = true;
            this.dtgRegistroAcesso.RowHeadersVisible = false;
            this.dtgRegistroAcesso.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgRegistroAcesso.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgRegistroAcesso.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.dtgRegistroAcesso.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgRegistroAcesso.RowTemplate.ReadOnly = true;
            this.dtgRegistroAcesso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRegistroAcesso.Size = new System.Drawing.Size(1022, 292);
            this.dtgRegistroAcesso.TabIndex = 8;
            // 
            // RegistroAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 590);
            this.Controls.Add(this.dtgRegistroAcesso);
            this.Controls.Add(this.groupBox19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroAcesso";
            this.Text = "RegistroAcesso";
            this.groupBox19.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroAcesso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDtCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalVisitas;
        private System.Windows.Forms.TextBox txtVisitasPorSemana;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtDtUltimaVisita;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgRegistroAcesso;
    }
}