namespace orgEventos1
{
    partial class frm_CadCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datPick_nascCli = new System.Windows.Forms.DateTimePicker();
            this.txt_emailCli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.msktx_telefoneCli = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.msktx_cpfCli = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nomeCli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.msktxt_cepCli = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_numLogradouro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_logradouro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_AddCli = new System.Windows.Forms.Button();
            this.btn_SairCadCli = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.datPick_nascCli);
            this.groupBox1.Controls.Add(this.txt_emailCli);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.msktx_telefoneCli);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.msktx_cpfCli);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_nomeCli);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1059, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data Nascimento:";
            // 
            // datPick_nascCli
            // 
            this.datPick_nascCli.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datPick_nascCli.Location = new System.Drawing.Point(754, 72);
            this.datPick_nascCli.MinDate = new System.DateTime(1909, 1, 1, 0, 0, 0, 0);
            this.datPick_nascCli.Name = "datPick_nascCli";
            this.datPick_nascCli.Size = new System.Drawing.Size(102, 22);
            this.datPick_nascCli.TabIndex = 8;
            // 
            // txt_emailCli
            // 
            this.txt_emailCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_emailCli.Location = new System.Drawing.Point(81, 72);
            this.txt_emailCli.Name = "txt_emailCli";
            this.txt_emailCli.Size = new System.Drawing.Size(519, 22);
            this.txt_emailCli.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "E-mail:";
            // 
            // msktx_telefoneCli
            // 
            this.msktx_telefoneCli.Location = new System.Drawing.Point(891, 35);
            this.msktx_telefoneCli.Mask = "(00) 00000-0000";
            this.msktx_telefoneCli.Name = "msktx_telefoneCli";
            this.msktx_telefoneCli.Size = new System.Drawing.Size(112, 22);
            this.msktx_telefoneCli.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(821, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone:";
            // 
            // msktx_cpfCli
            // 
            this.msktx_cpfCli.Location = new System.Drawing.Point(676, 35);
            this.msktx_cpfCli.Mask = "000,000,000-00";
            this.msktx_cpfCli.Name = "msktx_cpfCli";
            this.msktx_cpfCli.Size = new System.Drawing.Size(112, 22);
            this.msktx_cpfCli.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(634, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // txt_nomeCli
            // 
            this.txt_nomeCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nomeCli.Location = new System.Drawing.Point(81, 35);
            this.txt_nomeCli.Name = "txt_nomeCli";
            this.txt_nomeCli.Size = new System.Drawing.Size(519, 22);
            this.txt_nomeCli.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.msktxt_cepCli);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_complemento);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_numLogradouro);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_logradouro);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(42, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1059, 148);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // msktxt_cepCli
            // 
            this.msktxt_cepCli.Location = new System.Drawing.Point(477, 72);
            this.msktxt_cepCli.Mask = "00000-000";
            this.msktxt_cepCli.Name = "msktxt_cepCli";
            this.msktxt_cepCli.Size = new System.Drawing.Size(86, 22);
            this.msktxt_cepCli.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "CEP:";
            // 
            // txt_complemento
            // 
            this.txt_complemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_complemento.Location = new System.Drawing.Point(319, 72);
            this.txt_complemento.MaxLength = 20;
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(82, 22);
            this.txt_complemento.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Complemento:";
            // 
            // txt_numLogradouro
            // 
            this.txt_numLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_numLogradouro.Location = new System.Drawing.Point(114, 72);
            this.txt_numLogradouro.MaxLength = 6;
            this.txt_numLogradouro.Name = "txt_numLogradouro";
            this.txt_numLogradouro.Size = new System.Drawing.Size(70, 22);
            this.txt_numLogradouro.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Número:";
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_logradouro.Location = new System.Drawing.Point(114, 35);
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(492, 22);
            this.txt_logradouro.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Logradouro:";
            // 
            // btn_AddCli
            // 
            this.btn_AddCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCli.Location = new System.Drawing.Point(632, 539);
            this.btn_AddCli.Name = "btn_AddCli";
            this.btn_AddCli.Size = new System.Drawing.Size(158, 44);
            this.btn_AddCli.TabIndex = 3;
            this.btn_AddCli.Text = "Adicionar";
            this.btn_AddCli.UseVisualStyleBackColor = true;
            this.btn_AddCli.Click += new System.EventHandler(this.btn_AddCli_Click);
            // 
            // btn_SairCadCli
            // 
            this.btn_SairCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SairCadCli.Location = new System.Drawing.Point(372, 539);
            this.btn_SairCadCli.Name = "btn_SairCadCli";
            this.btn_SairCadCli.Size = new System.Drawing.Size(158, 44);
            this.btn_SairCadCli.TabIndex = 4;
            this.btn_SairCadCli.Text = "Voltar";
            this.btn_SairCadCli.UseVisualStyleBackColor = true;
            this.btn_SairCadCli.Click += new System.EventHandler(this.btn_SairCadCli_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(401, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // frm_CadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1167, 595);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_SairCadCli);
            this.Controls.Add(this.btn_AddCli);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_CadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro do Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nomeCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datPick_nascCli;
        private System.Windows.Forms.TextBox txt_emailCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msktx_telefoneCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msktx_cpfCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_numLogradouro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_logradouro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox msktxt_cepCli;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_AddCli;
        private System.Windows.Forms.Button btn_SairCadCli;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}