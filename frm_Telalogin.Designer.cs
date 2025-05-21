namespace orgEventos1
{
    partial class frm_Telalogin
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
            this.btn_sairLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBox_MostrarSenha = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Senha = new System.Windows.Forms.TextBox();
            this.txtBox_NomeUsuario = new System.Windows.Forms.TextBox();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sairLogin
            // 
            this.btn_sairLogin.BackColor = System.Drawing.Color.White;
            this.btn_sairLogin.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sairLogin.Location = new System.Drawing.Point(265, 409);
            this.btn_sairLogin.Name = "btn_sairLogin";
            this.btn_sairLogin.Size = new System.Drawing.Size(91, 32);
            this.btn_sairLogin.TabIndex = 38;
            this.btn_sairLogin.Text = "Sair";
            this.btn_sairLogin.UseVisualStyleBackColor = false;
            this.btn_sairLogin.Click += new System.EventHandler(this.btn_sairLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.btn_Entrar);
            this.groupBox1.Controls.Add(this.cBox_MostrarSenha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBox_Senha);
            this.groupBox1.Controls.Add(this.txtBox_NomeUsuario);
            this.groupBox1.Location = new System.Drawing.Point(28, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 207);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // cBox_MostrarSenha
            // 
            this.cBox_MostrarSenha.AutoSize = true;
            this.cBox_MostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_MostrarSenha.Location = new System.Drawing.Point(19, 140);
            this.cBox_MostrarSenha.Name = "cBox_MostrarSenha";
            this.cBox_MostrarSenha.Size = new System.Drawing.Size(111, 20);
            this.cBox_MostrarSenha.TabIndex = 4;
            this.cBox_MostrarSenha.Text = "Mostrar senha";
            this.cBox_MostrarSenha.UseVisualStyleBackColor = true;
            this.cBox_MostrarSenha.CheckedChanged += new System.EventHandler(this.cBox_MostrarSenha_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome de Usuário:";
            // 
            // txtBox_Senha
            // 
            this.txtBox_Senha.Location = new System.Drawing.Point(17, 114);
            this.txtBox_Senha.Name = "txtBox_Senha";
            this.txtBox_Senha.PasswordChar = '*';
            this.txtBox_Senha.Size = new System.Drawing.Size(264, 20);
            this.txtBox_Senha.TabIndex = 1;
            // 
            // txtBox_NomeUsuario
            // 
            this.txtBox_NomeUsuario.Location = new System.Drawing.Point(17, 51);
            this.txtBox_NomeUsuario.Name = "txtBox_NomeUsuario";
            this.txtBox_NomeUsuario.Size = new System.Drawing.Size(264, 20);
            this.txtBox_NomeUsuario.TabIndex = 0;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Entrar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.Location = new System.Drawing.Point(228, 174);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(76, 27);
            this.btn_Entrar.TabIndex = 37;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // frm_Telalogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(371, 453);
            this.ControlBox = false;
            this.Controls.Add(this.btn_sairLogin);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Telalogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sairLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cBox_MostrarSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Senha;
        private System.Windows.Forms.TextBox txtBox_NomeUsuario;
        private System.Windows.Forms.Button btn_Entrar;
    }
}