namespace GeradorSenhaBase64
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.btnGerarSenha = new System.Windows.Forms.Button();
            this.btnBuscarPlanilha = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnDiretorio = new System.Windows.Forms.Button();
            this.txbDiretorio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.dgvUsuarioSenha = new System.Windows.Forms.DataGridView();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpaGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(90, 33);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(258, 22);
            this.txbUsuario.TabIndex = 2;
            // 
            // btnGerarSenha
            // 
            this.btnGerarSenha.Location = new System.Drawing.Point(305, 172);
            this.btnGerarSenha.Name = "btnGerarSenha";
            this.btnGerarSenha.Size = new System.Drawing.Size(113, 45);
            this.btnGerarSenha.TabIndex = 4;
            this.btnGerarSenha.Text = "Gerar Senha";
            this.btnGerarSenha.UseVisualStyleBackColor = true;
            this.btnGerarSenha.Click += new System.EventHandler(this.btnGerarSenha_Click);
            // 
            // btnBuscarPlanilha
            // 
            this.btnBuscarPlanilha.Location = new System.Drawing.Point(365, 34);
            this.btnBuscarPlanilha.Name = "btnBuscarPlanilha";
            this.btnBuscarPlanilha.Size = new System.Drawing.Size(31, 23);
            this.btnBuscarPlanilha.TabIndex = 5;
            this.btnBuscarPlanilha.Text = "...";
            this.btnBuscarPlanilha.UseVisualStyleBackColor = true;
            this.btnBuscarPlanilha.Click += new System.EventHandler(this.btnBuscarPlanilha_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnDiretorio
            // 
            this.btnDiretorio.Location = new System.Drawing.Point(365, 80);
            this.btnDiretorio.Name = "btnDiretorio";
            this.btnDiretorio.Size = new System.Drawing.Size(31, 23);
            this.btnDiretorio.TabIndex = 8;
            this.btnDiretorio.Text = "...";
            this.btnDiretorio.UseVisualStyleBackColor = true;
            this.btnDiretorio.Click += new System.EventHandler(this.btnDiretorio_Click);
            // 
            // txbDiretorio
            // 
            this.txbDiretorio.Location = new System.Drawing.Point(90, 79);
            this.txbDiretorio.Name = "txbDiretorio";
            this.txbDiretorio.Size = new System.Drawing.Size(258, 22);
            this.txbDiretorio.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Diretório:";
            // 
            // dgvUsuarioSenha
            // 
            this.dgvUsuarioSenha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioSenha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario,
            this.senha});
            this.dgvUsuarioSenha.Location = new System.Drawing.Point(12, 133);
            this.dgvUsuarioSenha.Name = "dgvUsuarioSenha";
            this.dgvUsuarioSenha.RowTemplate.Height = 24;
            this.dgvUsuarioSenha.Size = new System.Drawing.Size(283, 305);
            this.dgvUsuarioSenha.TabIndex = 0;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            // 
            // senha
            // 
            this.senha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            this.senha.Width = 78;
            // 
            // btnLimpaGrid
            // 
            this.btnLimpaGrid.Location = new System.Drawing.Point(305, 264);
            this.btnLimpaGrid.Name = "btnLimpaGrid";
            this.btnLimpaGrid.Size = new System.Drawing.Size(113, 45);
            this.btnLimpaGrid.TabIndex = 9;
            this.btnLimpaGrid.Text = "Limpar Grid";
            this.btnLimpaGrid.UseVisualStyleBackColor = true;
            this.btnLimpaGrid.Click += new System.EventHandler(this.btnLimpaGrid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.btnLimpaGrid);
            this.Controls.Add(this.dgvUsuarioSenha);
            this.Controls.Add(this.btnDiretorio);
            this.Controls.Add(this.txbDiretorio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarPlanilha);
            this.Controls.Add(this.btnGerarSenha);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Senhas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Button btnGerarSenha;
        private System.Windows.Forms.Button btnBuscarPlanilha;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnDiretorio;
        private System.Windows.Forms.TextBox txbDiretorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.DataGridView dgvUsuarioSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.Button btnLimpaGrid;
    }
}

