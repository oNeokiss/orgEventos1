namespace orgEventos1
{
    partial class frm_CadLugar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NomeLugar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskb_Cep_Lugar = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TipoLugar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Capacidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_LogradouroLugar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_NumeroLugar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskb_ValorLugar = new System.Windows.Forms.MaskedTextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(932, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Estabelecimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome :";
            // 
            // txt_NomeLugar
            // 
            this.txt_NomeLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeLugar.Location = new System.Drawing.Point(341, 344);
            this.txt_NomeLugar.Name = "txt_NomeLugar";
            this.txt_NomeLugar.Size = new System.Drawing.Size(363, 26);
            this.txt_NomeLugar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "CEP :";
            // 
            // mskb_Cep_Lugar
            // 
            this.mskb_Cep_Lugar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskb_Cep_Lugar.Location = new System.Drawing.Point(341, 401);
            this.mskb_Cep_Lugar.Mask = "99999-999";
            this.mskb_Cep_Lugar.Name = "mskb_Cep_Lugar";
            this.mskb_Cep_Lugar.Size = new System.Drawing.Size(89, 29);
            this.mskb_Cep_Lugar.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipo :";
            // 
            // txt_TipoLugar
            // 
            this.txt_TipoLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TipoLugar.Location = new System.Drawing.Point(340, 451);
            this.txt_TipoLugar.Name = "txt_TipoLugar";
            this.txt_TipoLugar.Size = new System.Drawing.Size(363, 26);
            this.txt_TipoLugar.TabIndex = 2;
            this.txt_TipoLugar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(733, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "Capacidade :";
            // 
            // txt_Capacidade
            // 
            this.txt_Capacidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Capacidade.Location = new System.Drawing.Point(918, 344);
            this.txt_Capacidade.Name = "txt_Capacidade";
            this.txt_Capacidade.Size = new System.Drawing.Size(251, 26);
            this.txt_Capacidade.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(740, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 33);
            this.label6.TabIndex = 1;
            this.label6.Text = "Logradouro :";
            // 
            // txt_LogradouroLugar
            // 
            this.txt_LogradouroLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LogradouroLugar.Location = new System.Drawing.Point(918, 404);
            this.txt_LogradouroLugar.Name = "txt_LogradouroLugar";
            this.txt_LogradouroLugar.Size = new System.Drawing.Size(377, 26);
            this.txt_LogradouroLugar.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(848, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 33);
            this.label7.TabIndex = 1;
            this.label7.Text = "N° :";
            // 
            // txt_NumeroLugar
            // 
            this.txt_NumeroLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumeroLugar.Location = new System.Drawing.Point(918, 452);
            this.txt_NumeroLugar.Name = "txt_NumeroLugar";
            this.txt_NumeroLugar.Size = new System.Drawing.Size(92, 26);
            this.txt_NumeroLugar.TabIndex = 2;
            this.txt_NumeroLugar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(237, 503);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 33);
            this.label8.TabIndex = 1;
            this.label8.Text = "Valor :";
            // 
            // mskb_ValorLugar
            // 
            this.mskb_ValorLugar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskb_ValorLugar.Location = new System.Drawing.Point(341, 508);
            this.mskb_ValorLugar.Mask = "$0000.00";
            this.mskb_ValorLugar.Name = "mskb_ValorLugar";
            this.mskb_ValorLugar.Size = new System.Drawing.Size(123, 29);
            this.mskb_ValorLugar.TabIndex = 3;
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(1327, 768);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(101, 48);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.Location = new System.Drawing.Point(1194, 768);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(101, 48);
            this.btn_Cadastrar.TabIndex = 4;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // frm_CadLugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 828);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.mskb_ValorLugar);
            this.Controls.Add(this.mskb_Cep_Lugar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NumeroLugar);
            this.Controls.Add(this.txt_TipoLugar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_LogradouroLugar);
            this.Controls.Add(this.txt_Capacidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_NomeLugar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_CadLugar";
            this.Text = "frm_CadLugar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_CadLugar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NomeLugar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskb_Cep_Lugar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TipoLugar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Capacidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_LogradouroLugar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_NumeroLugar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskb_ValorLugar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_Cadastrar;
    }
}