namespace orgEventos1
{
    partial class frm_ConsultaLugares
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
            this.btn_BuscarLugar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_PesquisarLugares = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DelLugar = new System.Windows.Forms.Button();
            this.btn_AddLugar = new System.Windows.Forms.Button();
            this.btn_EditarLugar = new System.Windows.Forms.Button();
            this.btn_sairConsultaLugar = new System.Windows.Forms.Button();
            this.dtgv_ConsultarLugar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ConsultarLugar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BuscarLugar
            // 
            this.btn_BuscarLugar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarLugar.Location = new System.Drawing.Point(1053, 81);
            this.btn_BuscarLugar.Name = "btn_BuscarLugar";
            this.btn_BuscarLugar.Size = new System.Drawing.Size(103, 31);
            this.btn_BuscarLugar.TabIndex = 17;
            this.btn_BuscarLugar.Text = "Pesquisar";
            this.btn_BuscarLugar.UseVisualStyleBackColor = true;
            this.btn_BuscarLugar.Click += new System.EventHandler(this.btn_BuscarLugar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Pesquisar:";
            // 
            // txtBox_PesquisarLugares
            // 
            this.txtBox_PesquisarLugares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_PesquisarLugares.Location = new System.Drawing.Point(679, 85);
            this.txtBox_PesquisarLugares.Name = "txtBox_PesquisarLugares";
            this.txtBox_PesquisarLugares.Size = new System.Drawing.Size(368, 26);
            this.txtBox_PesquisarLugares.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 42);
            this.label1.TabIndex = 14;
            this.label1.Text = "Consultar Lugares";
            // 
            // btn_DelLugar
            // 
            this.btn_DelLugar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DelLugar.Location = new System.Drawing.Point(262, 504);
            this.btn_DelLugar.Name = "btn_DelLugar";
            this.btn_DelLugar.Size = new System.Drawing.Size(116, 40);
            this.btn_DelLugar.TabIndex = 13;
            this.btn_DelLugar.Text = "Excluir";
            this.btn_DelLugar.UseVisualStyleBackColor = true;
            // 
            // btn_AddLugar
            // 
            this.btn_AddLugar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddLugar.Location = new System.Drawing.Point(140, 504);
            this.btn_AddLugar.Name = "btn_AddLugar";
            this.btn_AddLugar.Size = new System.Drawing.Size(116, 40);
            this.btn_AddLugar.TabIndex = 12;
            this.btn_AddLugar.Text = "Adicionar";
            this.btn_AddLugar.UseVisualStyleBackColor = true;
            this.btn_AddLugar.Click += new System.EventHandler(this.btn_AddLugar_Click);
            // 
            // btn_EditarLugar
            // 
            this.btn_EditarLugar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarLugar.Location = new System.Drawing.Point(18, 504);
            this.btn_EditarLugar.Name = "btn_EditarLugar";
            this.btn_EditarLugar.Size = new System.Drawing.Size(116, 40);
            this.btn_EditarLugar.TabIndex = 11;
            this.btn_EditarLugar.Text = "Editar";
            this.btn_EditarLugar.UseVisualStyleBackColor = true;
            // 
            // btn_sairConsultaLugar
            // 
            this.btn_sairConsultaLugar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sairConsultaLugar.Location = new System.Drawing.Point(1023, 537);
            this.btn_sairConsultaLugar.Name = "btn_sairConsultaLugar";
            this.btn_sairConsultaLugar.Size = new System.Drawing.Size(132, 45);
            this.btn_sairConsultaLugar.TabIndex = 10;
            this.btn_sairConsultaLugar.Text = "Sair";
            this.btn_sairConsultaLugar.UseVisualStyleBackColor = true;
            // 
            // dtgv_ConsultarLugar
            // 
            this.dtgv_ConsultarLugar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ConsultarLugar.Location = new System.Drawing.Point(17, 117);
            this.dtgv_ConsultarLugar.Name = "dtgv_ConsultarLugar";
            this.dtgv_ConsultarLugar.Size = new System.Drawing.Size(1138, 381);
            this.dtgv_ConsultarLugar.TabIndex = 9;
            // 
            // frm_ConsultaLugares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 595);
            this.Controls.Add(this.btn_BuscarLugar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_PesquisarLugares);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DelLugar);
            this.Controls.Add(this.btn_AddLugar);
            this.Controls.Add(this.btn_EditarLugar);
            this.Controls.Add(this.btn_sairConsultaLugar);
            this.Controls.Add(this.dtgv_ConsultarLugar);
            this.Name = "frm_ConsultaLugares";
            this.Text = "frm_ConsultaLugares";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ConsultarLugar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscarLugar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_PesquisarLugares;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DelLugar;
        private System.Windows.Forms.Button btn_AddLugar;
        private System.Windows.Forms.Button btn_EditarLugar;
        private System.Windows.Forms.Button btn_sairConsultaLugar;
        private System.Windows.Forms.DataGridView dtgv_ConsultarLugar;
    }
}