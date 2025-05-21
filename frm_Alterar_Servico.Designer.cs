namespace orgEventos1
{
    partial class frm_Alterar_Servico
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
            this.mktb_ValorServico = new System.Windows.Forms.MaskedTextBox();
            this.txt_TipoServico = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_IDServico = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mktb_ValorServico);
            this.groupBox1.Controls.Add(this.txt_TipoServico);
            this.groupBox1.Controls.Add(this.txt_descricao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(43, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1029, 242);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // mktb_ValorServico
            // 
            this.mktb_ValorServico.Location = new System.Drawing.Point(215, 59);
            this.mktb_ValorServico.Mask = "$";
            this.mktb_ValorServico.Name = "mktb_ValorServico";
            this.mktb_ValorServico.Size = new System.Drawing.Size(136, 20);
            this.mktb_ValorServico.TabIndex = 16;
            // 
            // txt_TipoServico
            // 
            this.txt_TipoServico.Location = new System.Drawing.Point(215, 197);
            this.txt_TipoServico.Name = "txt_TipoServico";
            this.txt_TipoServico.Size = new System.Drawing.Size(317, 20);
            this.txt_TipoServico.TabIndex = 15;
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(215, 124);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(779, 20);
            this.txt_descricao.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 41);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descrição :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 41);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 41);
            this.label2.TabIndex = 13;
            this.label2.Text = "Valor :";
            // 
            // lbl_IDServico
            // 
            this.lbl_IDServico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_IDServico.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDServico.Location = new System.Drawing.Point(1023, 32);
            this.lbl_IDServico.Name = "lbl_IDServico";
            this.lbl_IDServico.Size = new System.Drawing.Size(187, 35);
            this.lbl_IDServico.TabIndex = 16;
            this.lbl_IDServico.Text = "ID aqui";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(944, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 41);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID :";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(1023, 391);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(109, 43);
            this.btn_Cadastrar.TabIndex = 13;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(1158, 391);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(109, 43);
            this.btn_sair.TabIndex = 14;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "ALteração de serviço";
            // 
            // frm_Alterar_Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1311, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_IDServico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.label1);
            this.Name = "frm_Alterar_Servico";
            this.Text = "frm_Alterar_Servico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mktb_ValorServico;
        private System.Windows.Forms.TextBox txt_TipoServico;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_IDServico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label1;
    }
}