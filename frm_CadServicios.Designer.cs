namespace orgEventos1
{
    partial class frm_CadServicios
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SairCadEvent = new System.Windows.Forms.Button();
            this.btn_AddEvent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mskb_ValorLugar = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(619, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tipo";
            // 
            // btn_SairCadEvent
            // 
            this.btn_SairCadEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SairCadEvent.Location = new System.Drawing.Point(386, 539);
            this.btn_SairCadEvent.Name = "btn_SairCadEvent";
            this.btn_SairCadEvent.Size = new System.Drawing.Size(158, 44);
            this.btn_SairCadEvent.TabIndex = 16;
            this.btn_SairCadEvent.Text = "Voltar";
            this.btn_SairCadEvent.UseVisualStyleBackColor = true;
            // 
            // btn_AddEvent
            // 
            this.btn_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddEvent.Location = new System.Drawing.Point(646, 539);
            this.btn_AddEvent.Name = "btn_AddEvent";
            this.btn_AddEvent.Size = new System.Drawing.Size(158, 44);
            this.btn_AddEvent.TabIndex = 15;
            this.btn_AddEvent.Text = "Adicionar";
            this.btn_AddEvent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cadastro de serviços";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(459, 280);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 134);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.textBox2.Location = new System.Drawing.Point(151, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 29);
            this.textBox2.TabIndex = 22;
            // 
            // mskb_ValorLugar
            // 
            this.mskb_ValorLugar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskb_ValorLugar.Location = new System.Drawing.Point(675, 148);
            this.mskb_ValorLugar.Mask = "$0000.00";
            this.mskb_ValorLugar.Name = "mskb_ValorLugar";
            this.mskb_ValorLugar.Size = new System.Drawing.Size(123, 29);
            this.mskb_ValorLugar.TabIndex = 23;
            // 
            // frm_CadServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 595);
            this.Controls.Add(this.mskb_ValorLugar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_SairCadEvent);
            this.Controls.Add(this.btn_AddEvent);
            this.Controls.Add(this.label1);
            this.Name = "frm_CadServicios";
            this.Text = "frm_CadServicios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SairCadEvent;
        private System.Windows.Forms.Button btn_AddEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox mskb_ValorLugar;
    }
}