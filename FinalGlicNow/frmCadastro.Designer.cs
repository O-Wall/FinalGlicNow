﻿namespace FinalGlicNow
{
    partial class FrmCadastro
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.picEstado = new System.Windows.Forms.PictureBox();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.picCelular = new System.Windows.Forms.PictureBox();
            this.picCidade = new System.Windows.Forms.PictureBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.picBairro = new System.Windows.Forms.PictureBox();
            this.picComplemento = new System.Windows.Forms.PictureBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.picCep = new System.Windows.Forms.PictureBox();
            this.picEndereco = new System.Windows.Forms.PictureBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.cboTipoDiabete = new System.Windows.Forms.ComboBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.picEmail = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.picCpf = new System.Windows.Forms.PictureBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.picConfSenha = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.picSenha = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.picEditar = new System.Windows.Forms.PictureBox();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBairro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComplemento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEndereco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.lblCadastro);
            this.panel2.Controls.Add(this.picClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 36);
            this.panel2.TabIndex = 18;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Location = new System.Drawing.Point(26, 16);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(49, 13);
            this.lblCadastro.TabIndex = 26;
            this.lblCadastro.Text = "Cadastro";
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Location = new System.Drawing.Point(588, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 24);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picClose.TabIndex = 42;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Pré-diabetes.",
            "Diabetes tipo 1",
            "Diabetes tipo 2",
            "Diabetes Gestacional",
            ""});
            this.cboEstado.Location = new System.Drawing.Point(119, 465);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(138, 21);
            this.cboEstado.TabIndex = 14;
            this.cboEstado.Text = "Estado";
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // picEstado
            // 
            this.picEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEstado.Location = new System.Drawing.Point(293, 462);
            this.picEstado.Name = "picEstado";
            this.picEstado.Size = new System.Drawing.Size(24, 24);
            this.picEstado.TabIndex = 106;
            this.picEstado.TabStop = false;
            // 
            // cboCidade
            // 
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Items.AddRange(new object[] {
            "Pré-diabetes.",
            "Diabetes tipo 1",
            "Diabetes tipo 2",
            "Diabetes Gestacional",
            ""});
            this.cboCidade.Location = new System.Drawing.Point(323, 466);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(228, 21);
            this.cboCidade.TabIndex = 15;
            this.cboCidade.Text = "Cidade";
            this.cboCidade.SelectedIndexChanged += new System.EventHandler(this.cboCidade_SelectedIndexChanged);
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.SystemColors.Window;
            this.txtCelular.ForeColor = System.Drawing.Color.Black;
            this.txtCelular.Location = new System.Drawing.Point(345, 295);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(206, 20);
            this.txtCelular.TabIndex = 9;
            this.txtCelular.Text = "Celular";
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // picCelular
            // 
            this.picCelular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCelular.Location = new System.Drawing.Point(315, 291);
            this.picCelular.Name = "picCelular";
            this.picCelular.Size = new System.Drawing.Size(24, 24);
            this.picCelular.TabIndex = 103;
            this.picCelular.TabStop = false;
            // 
            // picCidade
            // 
            this.picCidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCidade.Location = new System.Drawing.Point(89, 462);
            this.picCidade.Name = "picCidade";
            this.picCidade.Size = new System.Drawing.Size(24, 24);
            this.picCidade.TabIndex = 102;
            this.picCidade.TabStop = false;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.Window;
            this.txtBairro.ForeColor = System.Drawing.Color.Black;
            this.txtBairro.Location = new System.Drawing.Point(119, 428);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(228, 20);
            this.txtBairro.TabIndex = 12;
            this.txtBairro.Text = "Bairro";
            // 
            // picBairro
            // 
            this.picBairro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBairro.Location = new System.Drawing.Point(89, 424);
            this.picBairro.Name = "picBairro";
            this.picBairro.Size = new System.Drawing.Size(24, 24);
            this.picBairro.TabIndex = 100;
            this.picBairro.TabStop = false;
            // 
            // picComplemento
            // 
            this.picComplemento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picComplemento.Location = new System.Drawing.Point(89, 389);
            this.picComplemento.Name = "picComplemento";
            this.picComplemento.Size = new System.Drawing.Size(24, 24);
            this.picComplemento.TabIndex = 99;
            this.picComplemento.TabStop = false;
            // 
            // txtComplemento
            // 
            this.txtComplemento.BackColor = System.Drawing.SystemColors.Window;
            this.txtComplemento.ForeColor = System.Drawing.Color.Black;
            this.txtComplemento.Location = new System.Drawing.Point(119, 390);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(432, 20);
            this.txtComplemento.TabIndex = 11;
            this.txtComplemento.Text = "Complemento";
            // 
            // txtCEP
            // 
            this.txtCEP.BackColor = System.Drawing.SystemColors.Window;
            this.txtCEP.ForeColor = System.Drawing.Color.Black;
            this.txtCEP.Location = new System.Drawing.Point(394, 428);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(157, 20);
            this.txtCEP.TabIndex = 13;
            this.txtCEP.Text = "CEP";
            this.txtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCEP_KeyPress);
            // 
            // picCep
            // 
            this.picCep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCep.Location = new System.Drawing.Point(364, 424);
            this.picCep.Name = "picCep";
            this.picCep.Size = new System.Drawing.Size(24, 24);
            this.picCep.TabIndex = 96;
            this.picCep.TabStop = false;
            // 
            // picEndereco
            // 
            this.picEndereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEndereco.Location = new System.Drawing.Point(89, 353);
            this.picEndereco.Name = "picEndereco";
            this.picEndereco.Size = new System.Drawing.Size(24, 24);
            this.picEndereco.TabIndex = 95;
            this.picEndereco.TabStop = false;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndereco.ForeColor = System.Drawing.Color.Black;
            this.txtEndereco.Location = new System.Drawing.Point(119, 354);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(432, 20);
            this.txtEndereco.TabIndex = 10;
            this.txtEndereco.Text = "Endereço";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(320, 527);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(113, 36);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "&Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(439, 527);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 36);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Prefiro não informar"});
            this.cboGenero.Location = new System.Drawing.Point(89, 294);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(200, 21);
            this.cboGenero.TabIndex = 8;
            this.cboGenero.Text = "Gênero";
            this.cboGenero.SelectedIndexChanged += new System.EventHandler(this.cboGenero_SelectedIndexChanged);
            // 
            // cboTipoDiabete
            // 
            this.cboTipoDiabete.FormattingEnabled = true;
            this.cboTipoDiabete.Items.AddRange(new object[] {
            "Pré-diabetes.",
            "Diabetes tipo 1",
            "Diabetes tipo 2",
            "Diabetes Gestacional",
            ""});
            this.cboTipoDiabete.Location = new System.Drawing.Point(295, 252);
            this.cboTipoDiabete.Name = "cboTipoDiabete";
            this.cboTipoDiabete.Size = new System.Drawing.Size(256, 21);
            this.cboTipoDiabete.TabIndex = 7;
            this.cboTipoDiabete.Text = "Tipo de Diabete";
            this.cboTipoDiabete.SelectedIndexChanged += new System.EventHandler(this.cboTipoDiabete_SelectedIndexChanged);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(89, 253);
            this.dtpDataNascimento.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(200, 20);
            this.dtpDataNascimento.TabIndex = 6;
            this.dtpDataNascimento.UseWaitCursor = true;
            this.dtpDataNascimento.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // picEmail
            // 
            this.picEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEmail.Location = new System.Drawing.Point(89, 215);
            this.picEmail.Name = "picEmail";
            this.picEmail.Size = new System.Drawing.Size(24, 24);
            this.picEmail.TabIndex = 88;
            this.picEmail.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(119, 219);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(432, 20);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "E-mail";
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.SystemColors.Window;
            this.txtCPF.ForeColor = System.Drawing.Color.Black;
            this.txtCPF.Location = new System.Drawing.Point(353, 182);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(198, 20);
            this.txtCPF.TabIndex = 4;
            this.txtCPF.Text = "CPF";
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            // 
            // picCpf
            // 
            this.picCpf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCpf.Location = new System.Drawing.Point(323, 178);
            this.picCpf.Name = "picCpf";
            this.picCpf.Size = new System.Drawing.Size(24, 24);
            this.picCpf.TabIndex = 85;
            this.picCpf.TabStop = false;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.Window;
            this.txtLogin.ForeColor = System.Drawing.Color.Black;
            this.txtLogin.Location = new System.Drawing.Point(119, 182);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(180, 20);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.Text = "Login";
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfSenha.ForeColor = System.Drawing.Color.Black;
            this.txtConfSenha.Location = new System.Drawing.Point(353, 148);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(198, 20);
            this.txtConfSenha.TabIndex = 2;
            this.txtConfSenha.Text = "Confirmar senha";
            this.txtConfSenha.Enter += new System.EventHandler(this.txtConfSenha_Enter);
            // 
            // picConfSenha
            // 
            this.picConfSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picConfSenha.Location = new System.Drawing.Point(323, 143);
            this.picConfSenha.Name = "picConfSenha";
            this.picConfSenha.Size = new System.Drawing.Size(24, 24);
            this.picConfSenha.TabIndex = 82;
            this.picConfSenha.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(119, 147);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(180, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(165, 100);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(386, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome Completo";
            // 
            // picSenha
            // 
            this.picSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSenha.Location = new System.Drawing.Point(89, 143);
            this.picSenha.Name = "picSenha";
            this.picSenha.Size = new System.Drawing.Size(24, 24);
            this.picSenha.TabIndex = 79;
            this.picSenha.TabStop = false;
            // 
            // picLogin
            // 
            this.picLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogin.Location = new System.Drawing.Point(89, 178);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(24, 24);
            this.picLogin.TabIndex = 78;
            this.picLogin.TabStop = false;
            // 
            // picEditar
            // 
            this.picEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEditar.Location = new System.Drawing.Point(129, 100);
            this.picEditar.Name = "picEditar";
            this.picEditar.Size = new System.Drawing.Size(24, 24);
            this.picEditar.TabIndex = 77;
            this.picEditar.TabStop = false;
            // 
            // picProfile
            // 
            this.picProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picProfile.Location = new System.Drawing.Point(89, 60);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(64, 64);
            this.picProfile.TabIndex = 76;
            this.picProfile.TabStop = false;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.picEstado);
            this.Controls.Add(this.cboCidade);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.picCelular);
            this.Controls.Add(this.picCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.picBairro);
            this.Controls.Add(this.picComplemento);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.picCep);
            this.Controls.Add(this.picEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.cboTipoDiabete);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.picEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.picCpf);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtConfSenha);
            this.Controls.Add(this.picConfSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.picSenha);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.picEditar);
            this.Controls.Add(this.picProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastro";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBairro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComplemento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEndereco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.PictureBox picEstado;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.PictureBox picCelular;
        private System.Windows.Forms.PictureBox picCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.PictureBox picBairro;
        private System.Windows.Forms.PictureBox picComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.PictureBox picCep;
        private System.Windows.Forms.PictureBox picEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.ComboBox cboTipoDiabete;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.PictureBox picEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.PictureBox picCpf;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.PictureBox picConfSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox picSenha;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.PictureBox picEditar;
        private System.Windows.Forms.PictureBox picProfile;
    }
}