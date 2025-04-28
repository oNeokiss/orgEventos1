namespace orgEventos1
{
    partial class frm_CadTrabalhadores
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
            this.txtBox_PesquisarTrabalhador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_excluirTrabalhador = new System.Windows.Forms.Button();
            this.btn_adicionarTrabalhador = new System.Windows.Forms.Button();
            this.btn_EditarTrabalhador = new System.Windows.Forms.Button();
            this.btn_sairConsultarTrabalhador = new System.Windows.Forms.Button();
            this.dtgv_ConsultarTrabalhador = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ConsultarTrabalhador)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pesquisar:";
            // 
            // txtBox_PesquisarTrabalhador
            // 
            this.txtBox_PesquisarTrabalhador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_PesquisarTrabalhador.Location = new System.Drawing.Point(689, 81);
            this.txtBox_PesquisarTrabalhador.Name = "txtBox_PesquisarTrabalhador";
            this.txtBox_PesquisarTrabalhador.Size = new System.Drawing.Size(466, 26);
            this.txtBox_PesquisarTrabalhador.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Consultar Trabalhador";
            // 
            // btn_excluirTrabalhador
            // 
            this.btn_excluirTrabalhador.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluirTrabalhador.Location = new System.Drawing.Point(262, 500);
            this.btn_excluirTrabalhador.Name = "btn_excluirTrabalhador";
            this.btn_excluirTrabalhador.Size = new System.Drawing.Size(116, 40);
            this.btn_excluirTrabalhador.TabIndex = 12;
            this.btn_excluirTrabalhador.Text = "Excluir";
            this.btn_excluirTrabalhador.UseVisualStyleBackColor = true;
            // 
            // btn_adicionarTrabalhador
            // 
            this.btn_adicionarTrabalhador.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionarTrabalhador.Location = new System.Drawing.Point(140, 500);
            this.btn_adicionarTrabalhador.Name = "btn_adicionarTrabalhador";
            this.btn_adicionarTrabalhador.Size = new System.Drawing.Size(116, 40);
            this.btn_adicionarTrabalhador.TabIndex = 11;
            this.btn_adicionarTrabalhador.Text = "Adicionar";
            this.btn_adicionarTrabalhador.UseVisualStyleBackColor = true;
            // 
            // btn_EditarTrabalhador
            // 
            this.btn_EditarTrabalhador.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarTrabalhador.Location = new System.Drawing.Point(18, 500);
            this.btn_EditarTrabalhador.Name = "btn_EditarTrabalhador";
            this.btn_EditarTrabalhador.Size = new System.Drawing.Size(116, 40);
            this.btn_EditarTrabalhador.TabIndex = 10;
            this.btn_EditarTrabalhador.Text = "Editar";
            this.btn_EditarTrabalhador.UseVisualStyleBackColor = true;
            // 
            // btn_sairConsultarTrabalhador
            // 
            this.btn_sairConsultarTrabalhador.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sairConsultarTrabalhador.Location = new System.Drawing.Point(1023, 533);
            this.btn_sairConsultarTrabalhador.Name = "btn_sairConsultarTrabalhador";
            this.btn_sairConsultarTrabalhador.Size = new System.Drawing.Size(132, 45);
            this.btn_sairConsultarTrabalhador.TabIndex = 9;
            this.btn_sairConsultarTrabalhador.Text = "Sair";
            this.btn_sairConsultarTrabalhador.UseVisualStyleBackColor = true;
            this.btn_sairConsultarTrabalhador.Click += new System.EventHandler(this.btn_sairConsultarTrabalhador_Click);
            // 
            // dtgv_ConsultarTrabalhador
            // 
            this.dtgv_ConsultarTrabalhador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ConsultarTrabalhador.Location = new System.Drawing.Point(17, 113);
            this.dtgv_ConsultarTrabalhador.Name = "dtgv_ConsultarTrabalhador";
            this.dtgv_ConsultarTrabalhador.Size = new System.Drawing.Size(1138, 381);
            this.dtgv_ConsultarTrabalhador.TabIndex = 8;
            // 
            // frm_CadTrabalhadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 595);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_PesquisarTrabalhador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_excluirTrabalhador);
            this.Controls.Add(this.btn_adicionarTrabalhador);
            this.Controls.Add(this.btn_EditarTrabalhador);
            this.Controls.Add(this.btn_sairConsultarTrabalhador);
            this.Controls.Add(this.dtgv_ConsultarTrabalhador);
            this.Name = "frm_CadTrabalhadores";
            this.Text = "frm_CadTrabalhadores";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ConsultarTrabalhador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_PesquisarTrabalhador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_excluirTrabalhador;
        private System.Windows.Forms.Button btn_adicionarTrabalhador;
        private System.Windows.Forms.Button btn_EditarTrabalhador;
        private System.Windows.Forms.Button btn_sairConsultarTrabalhador;
        private System.Windows.Forms.DataGridView dtgv_ConsultarTrabalhador;
    }
}