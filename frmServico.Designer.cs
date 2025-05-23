namespace orgEventos1
{
    partial class frmServico
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
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.lbl_IDServico = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tipoServ = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de serviço";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(1190, 395);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(109, 43);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(1055, 395);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(109, 43);
            this.btn_Cadastrar.TabIndex = 7;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // lbl_IDServico
            // 
            this.lbl_IDServico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_IDServico.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDServico.Location = new System.Drawing.Point(1055, 36);
            this.lbl_IDServico.Name = "lbl_IDServico";
            this.lbl_IDServico.Size = new System.Drawing.Size(187, 35);
            this.lbl_IDServico.TabIndex = 9;
            this.lbl_IDServico.Text = "ID aqui";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(976, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 41);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tipoServ);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_preco);
            this.groupBox1.Controls.Add(this.txt_descricao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(75, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1122, 274);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_descricao.Location = new System.Drawing.Point(545, 78);
            this.txt_descricao.MaxLength = 500;
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(544, 190);
            this.txt_descricao.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(539, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descrição :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Valor :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(117, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 33);
            this.label10.TabIndex = 17;
            this.label10.Text = "R$";
            // 
            // txt_preco
            // 
            this.txt_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_preco.Location = new System.Drawing.Point(175, 179);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(118, 31);
            this.txt_preco.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(33, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 33);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tipo :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(532, -71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 75);
            this.label8.TabIndex = 18;
            // 
            // txt_tipoServ
            // 
            this.txt_tipoServ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_tipoServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txt_tipoServ.Location = new System.Drawing.Point(121, 74);
            this.txt_tipoServ.Name = "txt_tipoServ";
            this.txt_tipoServ.Size = new System.Drawing.Size(363, 31);
            this.txt_tipoServ.TabIndex = 23;
            // 
            // frmServico
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
            this.Name = "frmServico";
            this.Text = "frmServico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Label lbl_IDServico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tipoServ;
    }
}