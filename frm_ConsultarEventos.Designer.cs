namespace orgEventos1
{
    partial class frm_ConsultarEventos
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
            this.btn_pesqusiarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_PesquisarEvento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_sairConsultaCliente = new System.Windows.Forms.Button();
            this.dtgv_ConsultarEvento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ConsultarEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pesqusiarCliente
            // 
            this.btn_pesqusiarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesqusiarCliente.Location = new System.Drawing.Point(1053, 68);
            this.btn_pesqusiarCliente.Name = "btn_pesqusiarCliente";
            this.btn_pesqusiarCliente.Size = new System.Drawing.Size(103, 31);
            this.btn_pesqusiarCliente.TabIndex = 17;
            this.btn_pesqusiarCliente.Text = "Pesquisar";
            this.btn_pesqusiarCliente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Pesquisar:";
            // 
            // txtBox_PesquisarEvento
            // 
            this.txtBox_PesquisarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_PesquisarEvento.Location = new System.Drawing.Point(679, 72);
            this.txtBox_PesquisarEvento.Name = "txtBox_PesquisarEvento";
            this.txtBox_PesquisarEvento.Size = new System.Drawing.Size(368, 26);
            this.txtBox_PesquisarEvento.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 42);
            this.label1.TabIndex = 14;
            this.label1.Text = "Consultar Evento";
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Location = new System.Drawing.Point(262, 491);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(116, 40);
            this.btn_excluir.TabIndex = 13;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.Location = new System.Drawing.Point(140, 491);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(116, 40);
            this.btn_adicionar.TabIndex = 12;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Location = new System.Drawing.Point(18, 491);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(116, 40);
            this.btn_Editar.TabIndex = 11;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_sairConsultaCliente
            // 
            this.btn_sairConsultaCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sairConsultaCliente.Location = new System.Drawing.Point(1023, 524);
            this.btn_sairConsultaCliente.Name = "btn_sairConsultaCliente";
            this.btn_sairConsultaCliente.Size = new System.Drawing.Size(132, 45);
            this.btn_sairConsultaCliente.TabIndex = 10;
            this.btn_sairConsultaCliente.Text = "Sair";
            this.btn_sairConsultaCliente.UseVisualStyleBackColor = true;
            // 
            // dtgv_ConsultarEvento
            // 
            this.dtgv_ConsultarEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ConsultarEvento.Location = new System.Drawing.Point(17, 104);
            this.dtgv_ConsultarEvento.Name = "dtgv_ConsultarEvento";
            this.dtgv_ConsultarEvento.Size = new System.Drawing.Size(1138, 381);
            this.dtgv_ConsultarEvento.TabIndex = 9;
            // 
            // frm_Consultar_Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1167, 595);
            this.Controls.Add(this.btn_pesqusiarCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_PesquisarEvento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_sairConsultaCliente);
            this.Controls.Add(this.dtgv_ConsultarEvento);
            this.Name = "frm_Consultar_Eventos";
            this.Text = "frm_Consultar_Eventos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ConsultarEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pesqusiarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_PesquisarEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_sairConsultaCliente;
        private System.Windows.Forms.DataGridView dtgv_ConsultarEvento;
    }
}