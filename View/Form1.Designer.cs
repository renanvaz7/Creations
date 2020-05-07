namespace Creations
{
    partial class btn_TelaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_TelaInicial_User = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblTituloTelaLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_TelaInicial_Minimizar = new System.Windows.Forms.PictureBox();
            this.btn_TelaInicial_Sair = new System.Windows.Forms.PictureBox();
            this.btn_TelaInicial_Entrar = new System.Windows.Forms.Button();
            this.txt_TelaInicial_Senha = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TelaInicial_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TelaInicial_Sair)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TelaInicial_User
            // 
            this.txt_TelaInicial_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TelaInicial_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.txt_TelaInicial_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TelaInicial_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TelaInicial_User.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_TelaInicial_User.Location = new System.Drawing.Point(393, 181);
            this.txt_TelaInicial_User.Name = "txt_TelaInicial_User";
            this.txt_TelaInicial_User.Size = new System.Drawing.Size(559, 24);
            this.txt_TelaInicial_User.TabIndex = 3;
            this.txt_TelaInicial_User.Text = "Usuário";
            this.txt_TelaInicial_User.Enter += new System.EventHandler(this.txt_TelaInicial_User_Enter);
            this.txt_TelaInicial_User.Leave += new System.EventHandler(this.txt_TelaInicial_User_Leave);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.linkLabel1.DisabledLinkColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(389, 270);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(127, 20);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Esqueci a senha";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.PaleTurquoise;
            // 
            // lblTituloTelaLogin
            // 
            this.lblTituloTelaLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituloTelaLogin.AutoSize = true;
            this.lblTituloTelaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblTituloTelaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTelaLogin.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTituloTelaLogin.Location = new System.Drawing.Point(493, 32);
            this.lblTituloTelaLogin.Name = "lblTituloTelaLogin";
            this.lblTituloTelaLogin.Size = new System.Drawing.Size(396, 42);
            this.lblTituloTelaLogin.TabIndex = 10;
            this.lblTituloTelaLogin.Text = "NOME DA ACADEMIA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 531);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox1.Image = global::Creations.Properties.Resources._1200px_Google__G__Logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(34, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(393, 207);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(559, 2);
            this.textBox1.TabIndex = 13;
            // 
            // btn_TelaInicial_Minimizar
            // 
            this.btn_TelaInicial_Minimizar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_TelaInicial_Minimizar.Image = global::Creations.Properties.Resources.minus;
            this.btn_TelaInicial_Minimizar.Location = new System.Drawing.Point(1006, 0);
            this.btn_TelaInicial_Minimizar.Name = "btn_TelaInicial_Minimizar";
            this.btn_TelaInicial_Minimizar.Size = new System.Drawing.Size(20, 20);
            this.btn_TelaInicial_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_TelaInicial_Minimizar.TabIndex = 16;
            this.btn_TelaInicial_Minimizar.TabStop = false;
            this.btn_TelaInicial_Minimizar.Click += new System.EventHandler(this.btn_TelaInicial_Minimizar_Click);
            // 
            // btn_TelaInicial_Sair
            // 
            this.btn_TelaInicial_Sair.BackColor = System.Drawing.SystemColors.Control;
            this.btn_TelaInicial_Sair.Image = global::Creations.Properties.Resources.cancel;
            this.btn_TelaInicial_Sair.Location = new System.Drawing.Point(1032, 0);
            this.btn_TelaInicial_Sair.Name = "btn_TelaInicial_Sair";
            this.btn_TelaInicial_Sair.Size = new System.Drawing.Size(20, 20);
            this.btn_TelaInicial_Sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_TelaInicial_Sair.TabIndex = 15;
            this.btn_TelaInicial_Sair.TabStop = false;
            this.btn_TelaInicial_Sair.Click += new System.EventHandler(this.btn_TelaInicial_Sair_Click);
            // 
            // btn_TelaInicial_Entrar
            // 
            this.btn_TelaInicial_Entrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_TelaInicial_Entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btn_TelaInicial_Entrar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_TelaInicial_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TelaInicial_Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TelaInicial_Entrar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_TelaInicial_Entrar.Location = new System.Drawing.Point(393, 328);
            this.btn_TelaInicial_Entrar.Name = "btn_TelaInicial_Entrar";
            this.btn_TelaInicial_Entrar.Size = new System.Drawing.Size(559, 57);
            this.btn_TelaInicial_Entrar.TabIndex = 4;
            this.btn_TelaInicial_Entrar.Text = "Entrar";
            this.btn_TelaInicial_Entrar.UseVisualStyleBackColor = false;
            // 
            // txt_TelaInicial_Senha
            // 
            this.txt_TelaInicial_Senha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TelaInicial_Senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.txt_TelaInicial_Senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TelaInicial_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TelaInicial_Senha.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_TelaInicial_Senha.Location = new System.Drawing.Point(393, 234);
            this.txt_TelaInicial_Senha.Name = "txt_TelaInicial_Senha";
            this.txt_TelaInicial_Senha.Size = new System.Drawing.Size(559, 24);
            this.txt_TelaInicial_Senha.TabIndex = 17;
            this.txt_TelaInicial_Senha.Text = "Senha";
            this.txt_TelaInicial_Senha.Enter += new System.EventHandler(this.txt_TelaInicial_Senha_Enter);
            this.txt_TelaInicial_Senha.Leave += new System.EventHandler(this.txt_TelaInicial_Senha_Leave);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(393, 260);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(559, 2);
            this.textBox3.TabIndex = 18;
            // 
            // btn_TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1053, 531);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txt_TelaInicial_Senha);
            this.Controls.Add(this.btn_TelaInicial_Minimizar);
            this.Controls.Add(this.btn_TelaInicial_Sair);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_TelaInicial_Entrar);
            this.Controls.Add(this.lblTituloTelaLogin);
            this.Controls.Add(this.txt_TelaInicial_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "btn_TelaLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial ";
            this.Enter += new System.EventHandler(this.txt_TelaInicial_Senha_Enter);
            this.Leave += new System.EventHandler(this.txt_TelaInicial_Senha_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_TelaLogin_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TelaInicial_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TelaInicial_Sair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TelaInicial_User;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblTituloTelaLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox btn_TelaInicial_Sair;
        private System.Windows.Forms.PictureBox btn_TelaInicial_Minimizar;
        private System.Windows.Forms.Button btn_TelaInicial_Entrar;
        private System.Windows.Forms.TextBox txt_TelaInicial_Senha;
        private System.Windows.Forms.TextBox textBox3;
    }
}

