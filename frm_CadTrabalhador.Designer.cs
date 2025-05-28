namespace orgEventos1
{
    partial class frm_CadTrabalhador
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBox_emailTrab = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.msktx_telefoneTrab = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.msktx_cpfTrab = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_nomeTrab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SairCadTrab = new System.Windows.Forms.Button();
            this.btn_AddTrab = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBox_emailTrab);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.msktx_telefoneTrab);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.msktx_cpfTrab);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbox_nomeTrab);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1059, 148);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // txtBox_emailTrab
            // 
            this.txtBox_emailTrab.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtBox_emailTrab.Location = new System.Drawing.Point(81, 72);
            this.txtBox_emailTrab.Name = "txtBox_emailTrab";
            this.txtBox_emailTrab.Size = new System.Drawing.Size(519, 22);
            this.txtBox_emailTrab.TabIndex = 7;
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
            // msktx_telefoneTrab
            // 
            this.msktx_telefoneTrab.Location = new System.Drawing.Point(696, 72);
            this.msktx_telefoneTrab.Mask = "(00) 00000-0000";
            this.msktx_telefoneTrab.Name = "msktx_telefoneTrab";
            this.msktx_telefoneTrab.Size = new System.Drawing.Size(109, 22);
            this.msktx_telefoneTrab.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone:";
            // 
            // msktx_cpfTrab
            // 
            this.msktx_cpfTrab.Location = new System.Drawing.Point(693, 35);
            this.msktx_cpfTrab.Mask = "000,000,000-00";
            this.msktx_cpfTrab.Name = "msktx_cpfTrab";
            this.msktx_cpfTrab.Size = new System.Drawing.Size(112, 22);
            this.msktx_cpfTrab.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // txtbox_nomeTrab
            // 
            this.txtbox_nomeTrab.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbox_nomeTrab.Location = new System.Drawing.Point(81, 35);
            this.txtbox_nomeTrab.Name = "txtbox_nomeTrab";
            this.txtbox_nomeTrab.Size = new System.Drawing.Size(519, 22);
            this.txtbox_nomeTrab.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastro de Trabalhadores";
            // 
            // btn_SairCadTrab
            // 
            this.btn_SairCadTrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SairCadTrab.Location = new System.Drawing.Point(358, 311);
            this.btn_SairCadTrab.Name = "btn_SairCadTrab";
            this.btn_SairCadTrab.Size = new System.Drawing.Size(158, 44);
            this.btn_SairCadTrab.TabIndex = 6;
            this.btn_SairCadTrab.Text = "Voltar";
            this.btn_SairCadTrab.UseVisualStyleBackColor = true;
            this.btn_SairCadTrab.Click += new System.EventHandler(this.btn_SairCadTrab_Click);
            // 
            // btn_AddTrab
            // 
            this.btn_AddTrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddTrab.Location = new System.Drawing.Point(618, 311);
            this.btn_AddTrab.Name = "btn_AddTrab";
            this.btn_AddTrab.Size = new System.Drawing.Size(158, 44);
            this.btn_AddTrab.TabIndex = 5;
            this.btn_AddTrab.Text = "Adicionar";
            this.btn_AddTrab.UseVisualStyleBackColor = true;
            this.btn_AddTrab.Click += new System.EventHandler(this.btn_AddTrab_Click);
            // 
            // frm_CadTrabalhador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1167, 367);
            this.Controls.Add(this.btn_SairCadTrab);
            this.Controls.Add(this.btn_AddTrab);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_CadTrabalhador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_CadTrabalhador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBox_emailTrab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msktx_telefoneTrab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msktx_cpfTrab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_nomeTrab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SairCadTrab;
        private System.Windows.Forms.Button btn_AddTrab;
    }
}