namespace orgEventos1
{
    partial class frmCad_Usuarios
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
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.cBox_MostrarSenha = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Senha = new System.Windows.Forms.TextBox();
            this.txtBox_NomeUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sairLogin
            // 
            this.btn_sairLogin.BackColor = System.Drawing.Color.White;
            this.btn_sairLogin.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sairLogin.Location = new System.Drawing.Point(268, 409);
            this.btn_sairLogin.Name = "btn_sairLogin";
            this.btn_sairLogin.Size = new System.Drawing.Size(91, 32);
            this.btn_sairLogin.TabIndex = 40;
            this.btn_sairLogin.Text = "Sair";
            this.btn_sairLogin.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.btn_Cadastrar);
            this.groupBox1.Controls.Add(this.cBox_MostrarSenha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBox_Senha);
            this.groupBox1.Controls.Add(this.txtBox_NomeUsuario);
            this.groupBox1.Location = new System.Drawing.Point(27, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 207);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.Location = new System.Drawing.Point(228, 174);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(76, 27);
            this.btn_Cadastrar.TabIndex = 37;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
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
            this.cBox_MostrarSenha.CheckedChanged += new System.EventHandler(this.cBox_MostrarSenha_CheckedChanged);
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
            this.txtBox_NomeUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBox_NomeUsuario.Location = new System.Drawing.Point(17, 51);
            this.txtBox_NomeUsuario.Name = "txtBox_NomeUsuario";
            this.txtBox_NomeUsuario.Size = new System.Drawing.Size(264, 20);
            this.txtBox_NomeUsuario.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(121, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 33);
            this.label3.TabIndex = 41;
            this.label3.Text = "Cadastro";
            // 
            // frmCad_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(371, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_sairLogin);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCad_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCad_Usuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sairLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.CheckBox cBox_MostrarSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Senha;
        private System.Windows.Forms.TextBox txtBox_NomeUsuario;
        private System.Windows.Forms.Label label3;
    }
}