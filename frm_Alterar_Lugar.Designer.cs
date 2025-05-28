namespace orgEventos1
{
    partial class frm_Alterar_Lugar
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
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskb_Cep_Lugar = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_numLogradouro = new System.Windows.Forms.TextBox();
            this.txt_Logradouro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msktb_precoLugar = new System.Windows.Forms.GroupBox();
            this.mskb_capacidade = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TipoLugar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NomeLugar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.msktb_precoLugar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.Location = new System.Drawing.Point(1028, 476);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(101, 48);
            this.btn_Cadastrar.TabIndex = 8;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(1028, 531);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(101, 48);
            this.btn_sair.TabIndex = 9;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskb_Cep_Lugar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_numLogradouro);
            this.groupBox2.Controls.Add(this.txt_Logradouro);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(35, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(973, 171);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // mskb_Cep_Lugar
            // 
            this.mskb_Cep_Lugar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskb_Cep_Lugar.Location = new System.Drawing.Point(184, 87);
            this.mskb_Cep_Lugar.Mask = "00000-000";
            this.mskb_Cep_Lugar.Name = "mskb_Cep_Lugar";
            this.mskb_Cep_Lugar.Size = new System.Drawing.Size(89, 29);
            this.mskb_Cep_Lugar.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(124, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 33);
            this.label7.TabIndex = 4;
            this.label7.Text = "N° :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "CEP :";
            // 
            // txt_numLogradouro
            // 
            this.txt_numLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numLogradouro.Location = new System.Drawing.Point(184, 132);
            this.txt_numLogradouro.Name = "txt_numLogradouro";
            this.txt_numLogradouro.Size = new System.Drawing.Size(104, 26);
            this.txt_numLogradouro.TabIndex = 7;
            // 
            // txt_Logradouro
            // 
            this.txt_Logradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Logradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Logradouro.Location = new System.Drawing.Point(184, 43);
            this.txt_Logradouro.Name = "txt_Logradouro";
            this.txt_Logradouro.Size = new System.Drawing.Size(377, 26);
            this.txt_Logradouro.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "Logradouro :";
            // 
            // msktb_precoLugar
            // 
            this.msktb_precoLugar.Controls.Add(this.mskb_capacidade);
            this.msktb_precoLugar.Controls.Add(this.label10);
            this.msktb_precoLugar.Controls.Add(this.txt_preco);
            this.msktb_precoLugar.Controls.Add(this.label8);
            this.msktb_precoLugar.Controls.Add(this.txt_TipoLugar);
            this.msktb_precoLugar.Controls.Add(this.label4);
            this.msktb_precoLugar.Controls.Add(this.label5);
            this.msktb_precoLugar.Controls.Add(this.txt_NomeLugar);
            this.msktb_precoLugar.Controls.Add(this.label2);
            this.msktb_precoLugar.Controls.Add(this.label1);
            this.msktb_precoLugar.Location = new System.Drawing.Point(35, 114);
            this.msktb_precoLugar.Name = "msktb_precoLugar";
            this.msktb_precoLugar.Size = new System.Drawing.Size(973, 215);
            this.msktb_precoLugar.TabIndex = 11;
            this.msktb_precoLugar.TabStop = false;
            this.msktb_precoLugar.Text = "Dados";
            // 
            // mskb_capacidade
            // 
            this.mskb_capacidade.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskb_capacidade.Location = new System.Drawing.Point(712, 36);
            this.mskb_capacidade.Mask = "999";
            this.mskb_capacidade.Name = "mskb_capacidade";
            this.mskb_capacidade.Size = new System.Drawing.Size(46, 29);
            this.mskb_capacidade.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(115, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 33);
            this.label10.TabIndex = 15;
            this.label10.Text = "R$";
            // 
            // txt_preco
            // 
            this.txt_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_preco.Location = new System.Drawing.Point(170, 158);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(118, 31);
            this.txt_preco.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 33);
            this.label8.TabIndex = 5;
            this.label8.Text = "Valor :";
            // 
            // txt_TipoLugar
            // 
            this.txt_TipoLugar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_TipoLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TipoLugar.Location = new System.Drawing.Point(128, 97);
            this.txt_TipoLugar.Name = "txt_TipoLugar";
            this.txt_TipoLugar.Size = new System.Drawing.Size(363, 26);
            this.txt_TipoLugar.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Capacidade :";
            // 
            // txt_NomeLugar
            // 
            this.txt_NomeLugar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NomeLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeLugar.Location = new System.Drawing.Point(121, 45);
            this.txt_NomeLugar.Name = "txt_NomeLugar";
            this.txt_NomeLugar.Size = new System.Drawing.Size(363, 26);
            this.txt_NomeLugar.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, -49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 75);
            this.label1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(393, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 39);
            this.label9.TabIndex = 10;
            this.label9.Text = "Alterar Lugar";
            // 
            // frm_Alterar_Lugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1167, 595);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.msktb_precoLugar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.btn_sair);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frm_Alterar_Lugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Alterar_Lugar";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.msktb_precoLugar.ResumeLayout(false);
            this.msktb_precoLugar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskb_Cep_Lugar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_numLogradouro;
        private System.Windows.Forms.TextBox txt_Logradouro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox msktb_precoLugar;
        private System.Windows.Forms.MaskedTextBox mskb_capacidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TipoLugar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NomeLugar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
    }
}