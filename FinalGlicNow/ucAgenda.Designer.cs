namespace FinalGlicNow
{
    partial class ucAgenda
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtPesquisaTitulo = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.grdAgenda = new System.Windows.Forms.DataGridView();
            this.dtpDataAgenda = new System.Windows.Forms.DateTimePicker();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.picCalendario = new System.Windows.Forms.PictureBox();
            this.picMedico = new System.Windows.Forms.PictureBox();
            this.lblRegistrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCalendario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(87, 414);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 41);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar Observação";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(578, 414);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(107, 41);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtPesquisaTitulo
            // 
            this.txtPesquisaTitulo.BackColor = System.Drawing.Color.White;
            this.txtPesquisaTitulo.Location = new System.Drawing.Point(87, 29);
            this.txtPesquisaTitulo.Name = "txtPesquisaTitulo";
            this.txtPesquisaTitulo.Size = new System.Drawing.Size(598, 20);
            this.txtPesquisaTitulo.TabIndex = 0;
            this.txtPesquisaTitulo.Text = "Título";
            this.txtPesquisaTitulo.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.Color.White;
            this.txtObservacao.Location = new System.Drawing.Point(87, 317);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(598, 86);
            this.txtObservacao.TabIndex = 5;
            this.txtObservacao.Text = "Observações";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(87, 261);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(598, 20);
            this.txtTitulo.TabIndex = 2;
            this.txtTitulo.Text = "Título";
            // 
            // txtMedico
            // 
            this.txtMedico.BackColor = System.Drawing.Color.White;
            this.txtMedico.Location = new System.Drawing.Point(389, 291);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(296, 20);
            this.txtMedico.TabIndex = 4;
            this.txtMedico.Text = "Nome do Medico";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(117, 291);
            this.dtpData.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 3;
            this.dtpData.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // grdAgenda
            // 
            this.grdAgenda.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grdAgenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAgenda.Location = new System.Drawing.Point(87, 81);
            this.grdAgenda.Name = "grdAgenda";
            this.grdAgenda.Size = new System.Drawing.Size(598, 144);
            this.grdAgenda.TabIndex = 114;
            this.grdAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAgenda_CellClick);
            // 
            // dtpDataAgenda
            // 
            this.dtpDataAgenda.Location = new System.Drawing.Point(87, 55);
            this.dtpDataAgenda.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpDataAgenda.Name = "dtpDataAgenda";
            this.dtpDataAgenda.Size = new System.Drawing.Size(198, 20);
            this.dtpDataAgenda.TabIndex = 1;
            this.dtpDataAgenda.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpDataAgenda.ValueChanged += new System.EventHandler(this.dtpDataAgenda_ValueChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(84, 13);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(74, 13);
            this.lblPesquisar.TabIndex = 124;
            this.lblPesquisar.Text = "Pesquisar por:";
            // 
            // picCalendario
            // 
            this.picCalendario.Location = new System.Drawing.Point(87, 287);
            this.picCalendario.Name = "picCalendario";
            this.picCalendario.Size = new System.Drawing.Size(24, 24);
            this.picCalendario.TabIndex = 125;
            this.picCalendario.TabStop = false;
            // 
            // picMedico
            // 
            this.picMedico.Location = new System.Drawing.Point(359, 287);
            this.picMedico.Name = "picMedico";
            this.picMedico.Size = new System.Drawing.Size(24, 24);
            this.picMedico.TabIndex = 126;
            this.picMedico.TabStop = false;
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.AutoSize = true;
            this.lblRegistrar.Location = new System.Drawing.Point(84, 243);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(88, 13);
            this.lblRegistrar.TabIndex = 127;
            this.lblRegistrar.Text = "Registrar Tarefas";
            // 
            // ucAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(96)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.lblRegistrar);
            this.Controls.Add(this.picMedico);
            this.Controls.Add(this.picCalendario);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.dtpDataAgenda);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtPesquisaTitulo);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.grdAgenda);
            this.Name = "ucAgenda";
            this.Size = new System.Drawing.Size(763, 479);
            this.Load += new System.EventHandler(this.ucAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCalendario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtPesquisaTitulo;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridView grdAgenda;
        private System.Windows.Forms.DateTimePicker dtpDataAgenda;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.PictureBox picCalendario;
        private System.Windows.Forms.PictureBox picMedico;
        private System.Windows.Forms.Label lblRegistrar;
    }
}
