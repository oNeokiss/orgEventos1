namespace orgEventos1
{
    partial class frm_CadEvento
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
            this.btn_SairCadEvent = new System.Windows.Forms.Button();
            this.btn_AddEvent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mskb_ValorLugar = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_SairCadEvent
            // 
            this.btn_SairCadEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SairCadEvent.Location = new System.Drawing.Point(384, 540);
            this.btn_SairCadEvent.Name = "btn_SairCadEvent";
            this.btn_SairCadEvent.Size = new System.Drawing.Size(158, 44);
            this.btn_SairCadEvent.TabIndex = 9;
            this.btn_SairCadEvent.Text = "Voltar";
            this.btn_SairCadEvent.UseVisualStyleBackColor = true;
            this.btn_SairCadEvent.Click += new System.EventHandler(this.btn_SairCadEvent_Click);
            // 
            // btn_AddEvent
            // 
            this.btn_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddEvent.Location = new System.Drawing.Point(644, 540);
            this.btn_AddEvent.Name = "btn_AddEvent";
            this.btn_AddEvent.Size = new System.Drawing.Size(158, 44);
            this.btn_AddEvent.TabIndex = 8;
            this.btn_AddEvent.Text = "Adicionar";
            this.btn_AddEvent.UseVisualStyleBackColor = true;
            this.btn_AddEvent.Click += new System.EventHandler(this.btn_AddEvent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadastro do Evento";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aniversário",
            "Chá de Bebê",
            "Casamento",
            "Palestras",
            "Conferência"});
            this.comboBox1.Location = new System.Drawing.Point(136, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(82, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(82, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lotação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(808, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Preço";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.textBox2.Location = new System.Drawing.Point(173, 168);
            this.textBox2.MaxLength = 5;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 29);
            this.textBox2.TabIndex = 23;
            // 
            // mskb_ValorLugar
            // 
            this.mskb_ValorLugar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskb_ValorLugar.Location = new System.Drawing.Point(874, 240);
            this.mskb_ValorLugar.Mask = "$0000.00";
            this.mskb_ValorLugar.Name = "mskb_ValorLugar";
            this.mskb_ValorLugar.Size = new System.Drawing.Size(123, 29);
            this.mskb_ValorLugar.TabIndex = 24;
            // 
            // frm_CadEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 595);
            this.Controls.Add(this.mskb_ValorLugar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_SairCadEvent);
            this.Controls.Add(this.btn_AddEvent);
            this.Controls.Add(this.label1);
            this.Name = "frm_CadEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro do Evento";
            this.Load += new System.EventHandler(this.frm_CadEvento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SairCadEvent;
        private System.Windows.Forms.Button btn_AddEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox mskb_ValorLugar;
    }
}