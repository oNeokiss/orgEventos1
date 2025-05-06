namespace orgEventos1
{
    partial class frmPagamentos
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ValorPagamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_DataPagamento = new System.Windows.Forms.DateTimePicker();
            this.btn_EfetuarPagamento = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_IDPagamento = new System.Windows.Forms.Label();
            this.ckb_DataPagamento = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor :";
            // 
            // lbl_ValorPagamento
            // 
            this.lbl_ValorPagamento.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorPagamento.Location = new System.Drawing.Point(192, 183);
            this.lbl_ValorPagamento.Name = "lbl_ValorPagamento";
            this.lbl_ValorPagamento.Size = new System.Drawing.Size(187, 35);
            this.lbl_ValorPagamento.TabIndex = 2;
            this.lbl_ValorPagamento.Text = "Valor aqui";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data :";
            // 
            // dtp_DataPagamento
            // 
            this.dtp_DataPagamento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DataPagamento.Location = new System.Drawing.Point(183, 264);
            this.dtp_DataPagamento.Name = "dtp_DataPagamento";
            this.dtp_DataPagamento.Size = new System.Drawing.Size(217, 20);
            this.dtp_DataPagamento.TabIndex = 4;
            // 
            // btn_EfetuarPagamento
            // 
            this.btn_EfetuarPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EfetuarPagamento.Location = new System.Drawing.Point(564, 421);
            this.btn_EfetuarPagamento.Name = "btn_EfetuarPagamento";
            this.btn_EfetuarPagamento.Size = new System.Drawing.Size(212, 47);
            this.btn_EfetuarPagamento.TabIndex = 5;
            this.btn_EfetuarPagamento.Text = "Efetuar Pagamento";
            this.btn_EfetuarPagamento.UseVisualStyleBackColor = true;
            this.btn_EfetuarPagamento.Visible = false;
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(840, 421);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(93, 47);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(667, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 41);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID :";
            // 
            // lbl_IDPagamento
            // 
            this.lbl_IDPagamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_IDPagamento.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDPagamento.Location = new System.Drawing.Point(746, 38);
            this.lbl_IDPagamento.Name = "lbl_IDPagamento";
            this.lbl_IDPagamento.Size = new System.Drawing.Size(187, 35);
            this.lbl_IDPagamento.TabIndex = 2;
            this.lbl_IDPagamento.Text = "ID aqui";
            // 
            // ckb_DataPagamento
            // 
            this.ckb_DataPagamento.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_DataPagamento.Location = new System.Drawing.Point(70, 360);
            this.ckb_DataPagamento.Name = "ckb_DataPagamento";
            this.ckb_DataPagamento.Size = new System.Drawing.Size(210, 49);
            this.ckb_DataPagamento.TabIndex = 7;
            this.ckb_DataPagamento.Text = "Estou de acordo ";
            this.ckb_DataPagamento.UseVisualStyleBackColor = true;
            this.ckb_DataPagamento.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 490);
            this.Controls.Add(this.ckb_DataPagamento);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_EfetuarPagamento);
            this.Controls.Add(this.dtp_DataPagamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_IDPagamento);
            this.Controls.Add(this.lbl_ValorPagamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "frmPagamentos";
            this.Text = "frmPagamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ValorPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_DataPagamento;
        private System.Windows.Forms.Button btn_EfetuarPagamento;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_IDPagamento;
        private System.Windows.Forms.CheckBox ckb_DataPagamento;
    }
}