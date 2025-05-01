namespace orgEventos1
{
    partial class frm_ConsultaCliente
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
            this.dtg_BuscarCli = new System.Windows.Forms.DataGridView();
            this.btn_sairConsultaCliente = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_DelCli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BuscarCli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BuscarCli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BuscarCli)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_BuscarCli
            // 
            this.dtg_BuscarCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_BuscarCli.Location = new System.Drawing.Point(17, 118);
            this.dtg_BuscarCli.Name = "dtg_BuscarCli";
            this.dtg_BuscarCli.Size = new System.Drawing.Size(1138, 381);
            this.dtg_BuscarCli.TabIndex = 0;
            // 
            // btn_sairConsultaCliente
            // 
            this.btn_sairConsultaCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sairConsultaCliente.Location = new System.Drawing.Point(1023, 538);
            this.btn_sairConsultaCliente.Name = "btn_sairConsultaCliente";
            this.btn_sairConsultaCliente.Size = new System.Drawing.Size(132, 45);
            this.btn_sairConsultaCliente.TabIndex = 1;
            this.btn_sairConsultaCliente.Text = "Sair";
            this.btn_sairConsultaCliente.UseVisualStyleBackColor = true;
            this.btn_sairConsultaCliente.Click += new System.EventHandler(this.btn_sairConsultaCliente_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Location = new System.Drawing.Point(18, 505);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(116, 40);
            this.btn_Editar.TabIndex = 2;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.Location = new System.Drawing.Point(140, 505);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(116, 40);
            this.btn_adicionar.TabIndex = 3;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_DelCli
            // 
            this.btn_DelCli.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DelCli.Location = new System.Drawing.Point(262, 505);
            this.btn_DelCli.Name = "btn_DelCli";
            this.btn_DelCli.Size = new System.Drawing.Size(116, 40);
            this.btn_DelCli.TabIndex = 4;
            this.btn_DelCli.Text = "Excluir";
            this.btn_DelCli.UseVisualStyleBackColor = true;
            this.btn_DelCli.Click += new System.EventHandler(this.btn_DelCli_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Consultar Cliente";
            // 
            // txt_BuscarCli
            // 
            this.txt_BuscarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarCli.Location = new System.Drawing.Point(564, 86);
            this.txt_BuscarCli.Name = "txt_BuscarCli";
            this.txt_BuscarCli.Size = new System.Drawing.Size(466, 26);
            this.txt_BuscarCli.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pesquisar:";
            // 
            // btn_BuscarCli
            // 
            this.btn_BuscarCli.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarCli.Location = new System.Drawing.Point(1039, 86);
            this.btn_BuscarCli.Name = "btn_BuscarCli";
            this.btn_BuscarCli.Size = new System.Drawing.Size(96, 26);
            this.btn_BuscarCli.TabIndex = 8;
            this.btn_BuscarCli.Text = "Buscar";
            this.btn_BuscarCli.UseVisualStyleBackColor = true;
            this.btn_BuscarCli.Click += new System.EventHandler(this.btn_BuscarCli_Click);
            // 
            // frm_ConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 595);
            this.Controls.Add(this.btn_BuscarCli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_BuscarCli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DelCli);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_sairConsultaCliente);
            this.Controls.Add(this.dtg_BuscarCli);
            this.Name = "frm_ConsultaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BuscarCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_BuscarCli;
        private System.Windows.Forms.Button btn_sairConsultaCliente;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_DelCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BuscarCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BuscarCli;
    }
}