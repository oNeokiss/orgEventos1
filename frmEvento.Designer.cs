namespace orgEventos1
{
    partial class frmEvento
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
            this.txt_TipoEvento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msktb_ValorEvento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Lotacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_Inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fim = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_DATA = new System.Windows.Forms.DateTimePicker();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Evento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_TipoEvento
            // 
            this.txt_TipoEvento.Location = new System.Drawing.Point(326, 129);
            this.txt_TipoEvento.Name = "txt_TipoEvento";
            this.txt_TipoEvento.Size = new System.Drawing.Size(278, 20);
            this.txt_TipoEvento.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor :";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // msktb_ValorEvento
            // 
            this.msktb_ValorEvento.Location = new System.Drawing.Point(326, 193);
            this.msktb_ValorEvento.Mask = "$";
            this.msktb_ValorEvento.Name = "msktb_ValorEvento";
            this.msktb_ValorEvento.Size = new System.Drawing.Size(158, 20);
            this.msktb_ValorEvento.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lotação :";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Lotacao
            // 
            this.txt_Lotacao.Location = new System.Drawing.Point(326, 259);
            this.txt_Lotacao.Name = "txt_Lotacao";
            this.txt_Lotacao.Size = new System.Drawing.Size(123, 20);
            this.txt_Lotacao.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "Início :";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 41);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fim :";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtp_Inicio
            // 
            this.dtp_Inicio.Location = new System.Drawing.Point(326, 320);
            this.dtp_Inicio.Name = "dtp_Inicio";
            this.dtp_Inicio.Size = new System.Drawing.Size(238, 20);
            this.dtp_Inicio.TabIndex = 7;
            // 
            // dtp_Fim
            // 
            this.dtp_Fim.Location = new System.Drawing.Point(326, 370);
            this.dtp_Fim.Name = "dtp_Fim";
            this.dtp_Fim.Size = new System.Drawing.Size(216, 20);
            this.dtp_Fim.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(206, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 41);
            this.label7.TabIndex = 4;
            this.label7.Text = "Data :";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtp_DATA
            // 
            this.dtp_DATA.Location = new System.Drawing.Point(326, 428);
            this.dtp_DATA.Name = "dtp_DATA";
            this.dtp_DATA.Size = new System.Drawing.Size(216, 20);
            this.dtp_DATA.TabIndex = 7;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(643, 549);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(115, 47);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(522, 549);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(115, 47);
            this.btn_Cadastrar.TabIndex = 8;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // frmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 608);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.dtp_DATA);
            this.Controls.Add(this.dtp_Fim);
            this.Controls.Add(this.dtp_Inicio);
            this.Controls.Add(this.msktb_ValorEvento);
            this.Controls.Add(this.txt_Lotacao);
            this.Controls.Add(this.txt_TipoEvento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEvento";
            this.Text = "frmEvento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TipoEvento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msktb_ValorEvento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Lotacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_Inicio;
        private System.Windows.Forms.DateTimePicker dtp_Fim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_DATA;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Cadastrar;
    }
}