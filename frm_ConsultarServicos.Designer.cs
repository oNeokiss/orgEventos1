namespace orgEventos1
{
    partial class frm_ConsultarServicos
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
            this.btn_DelServico = new System.Windows.Forms.Button();
            this.btn_AddServico = new System.Windows.Forms.Button();
            this.btn_EditarServico = new System.Windows.Forms.Button();
            this.btn_sairConsultaServico = new System.Windows.Forms.Button();
            this.dtgv_ConsultarCliente = new System.Windows.Forms.DataGridView();
            this.btn_BuscarServico = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_PesquisarLugar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ConsultarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Consultar Serviços";
            // 
            // btn_DelServico
            // 
            this.btn_DelServico.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DelServico.Location = new System.Drawing.Point(263, 491);
            this.btn_DelServico.Name = "btn_DelServico";
            this.btn_DelServico.Size = new System.Drawing.Size(116, 40);
            this.btn_DelServico.TabIndex = 12;
            this.btn_DelServico.Text = "Excluir";
            this.btn_DelServico.UseVisualStyleBackColor = true;
            // 
            // btn_AddServico
            // 
            this.btn_AddServico.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddServico.Location = new System.Drawing.Point(141, 491);
            this.btn_AddServico.Name = "btn_AddServico";
            this.btn_AddServico.Size = new System.Drawing.Size(116, 40);
            this.btn_AddServico.TabIndex = 11;
            this.btn_AddServico.Text = "Adicionar";
            this.btn_AddServico.UseVisualStyleBackColor = true;
            this.btn_AddServico.Click += new System.EventHandler(this.btn_AddServico_Click);
            // 
            // btn_EditarServico
            // 
            this.btn_EditarServico.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarServico.Location = new System.Drawing.Point(19, 491);
            this.btn_EditarServico.Name = "btn_EditarServico";
            this.btn_EditarServico.Size = new System.Drawing.Size(116, 40);
            this.btn_EditarServico.TabIndex = 10;
            this.btn_EditarServico.Text = "Editar";
            this.btn_EditarServico.UseVisualStyleBackColor = true;
            // 
            // btn_sairConsultaServico
            // 
            this.btn_sairConsultaServico.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sairConsultaServico.Location = new System.Drawing.Point(1024, 524);
            this.btn_sairConsultaServico.Name = "btn_sairConsultaServico";
            this.btn_sairConsultaServico.Size = new System.Drawing.Size(132, 45);
            this.btn_sairConsultaServico.TabIndex = 9;
            this.btn_sairConsultaServico.Text = "Sair";
            this.btn_sairConsultaServico.UseVisualStyleBackColor = true;
            // 
            // dtgv_ConsultarCliente
            // 
            this.dtgv_ConsultarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ConsultarCliente.Location = new System.Drawing.Point(18, 104);
            this.dtgv_ConsultarCliente.Name = "dtgv_ConsultarCliente";
            this.dtgv_ConsultarCliente.Size = new System.Drawing.Size(1138, 381);
            this.dtgv_ConsultarCliente.TabIndex = 8;
            // 
            // btn_BuscarServico
            // 
            this.btn_BuscarServico.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarServico.Location = new System.Drawing.Point(1054, 68);
            this.btn_BuscarServico.Name = "btn_BuscarServico";
            this.btn_BuscarServico.Size = new System.Drawing.Size(103, 31);
            this.btn_BuscarServico.TabIndex = 20;
            this.btn_BuscarServico.Text = "Pesquisar";
            this.btn_BuscarServico.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pesquisar:";
            // 
            // txtBox_PesquisarLugar
            // 
            this.txtBox_PesquisarLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_PesquisarLugar.Location = new System.Drawing.Point(680, 72);
            this.txtBox_PesquisarLugar.Name = "txtBox_PesquisarLugar";
            this.txtBox_PesquisarLugar.Size = new System.Drawing.Size(368, 26);
            this.txtBox_PesquisarLugar.TabIndex = 18;
            // 
            // frm_ConsultarServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 595);
            this.Controls.Add(this.btn_BuscarServico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_PesquisarLugar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DelServico);
            this.Controls.Add(this.btn_AddServico);
            this.Controls.Add(this.btn_EditarServico);
            this.Controls.Add(this.btn_sairConsultaServico);
            this.Controls.Add(this.dtgv_ConsultarCliente);
            this.Name = "frm_ConsultarServicos";
            this.Text = "frm_ConsultarLugares";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ConsultarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DelServico;
        private System.Windows.Forms.Button btn_AddServico;
        private System.Windows.Forms.Button btn_EditarServico;
        private System.Windows.Forms.Button btn_sairConsultaServico;
        private System.Windows.Forms.DataGridView dtgv_ConsultarCliente;
        private System.Windows.Forms.Button btn_BuscarServico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_PesquisarLugar;
    }
}