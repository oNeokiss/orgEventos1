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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Cliente = new System.Windows.Forms.TabPage();
            this.btn_BuscarCli = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BuscarCli = new System.Windows.Forms.TextBox();
            this.btn_AddCli = new System.Windows.Forms.Button();
            this.btn_EditarCli = new System.Windows.Forms.Button();
            this.dtg_EventoCli = new System.Windows.Forms.DataGridView();
            this.tab_Serviço = new System.Windows.Forms.TabPage();
            this.btn_BuscarServico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BuscarServico = new System.Windows.Forms.TextBox();
            this.dtg_EventoServico = new System.Windows.Forms.DataGridView();
            this.tab_Lugar = new System.Windows.Forms.TabPage();
            this.btn_BuscarLugar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_BuscarLugar = new System.Windows.Forms.TextBox();
            this.dtg_EventoLugar = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tab_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EventoCli)).BeginInit();
            this.tab_Serviço.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EventoServico)).BeginInit();
            this.tab_Lugar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EventoLugar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Cliente);
            this.tabControl1.Controls.Add(this.tab_Serviço);
            this.tabControl1.Controls.Add(this.tab_Lugar);
            this.tabControl1.Location = new System.Drawing.Point(57, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1043, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_Cliente
            // 
            this.tab_Cliente.Controls.Add(this.btn_BuscarCli);
            this.tab_Cliente.Controls.Add(this.label2);
            this.tab_Cliente.Controls.Add(this.txt_BuscarCli);
            this.tab_Cliente.Controls.Add(this.btn_AddCli);
            this.tab_Cliente.Controls.Add(this.btn_EditarCli);
            this.tab_Cliente.Controls.Add(this.dtg_EventoCli);
            this.tab_Cliente.Location = new System.Drawing.Point(4, 22);
            this.tab_Cliente.Name = "tab_Cliente";
            this.tab_Cliente.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Cliente.Size = new System.Drawing.Size(1035, 446);
            this.tab_Cliente.TabIndex = 0;
            this.tab_Cliente.Text = "Cliente";
            this.tab_Cliente.UseVisualStyleBackColor = true;
            // 
            // btn_BuscarCli
            // 
            this.btn_BuscarCli.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarCli.Location = new System.Drawing.Point(891, 12);
            this.btn_BuscarCli.Name = "btn_BuscarCli";
            this.btn_BuscarCli.Size = new System.Drawing.Size(103, 31);
            this.btn_BuscarCli.TabIndex = 22;
            this.btn_BuscarCli.Text = "Pesquisar";
            this.btn_BuscarCli.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Selecione o cliente";
            // 
            // txt_BuscarCli
            // 
            this.txt_BuscarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarCli.Location = new System.Drawing.Point(591, 16);
            this.txt_BuscarCli.Name = "txt_BuscarCli";
            this.txt_BuscarCli.Size = new System.Drawing.Size(294, 26);
            this.txt_BuscarCli.TabIndex = 20;
            // 
            // btn_AddCli
            // 
            this.btn_AddCli.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCli.Location = new System.Drawing.Point(562, 395);
            this.btn_AddCli.Name = "btn_AddCli";
            this.btn_AddCli.Size = new System.Drawing.Size(116, 40);
            this.btn_AddCli.TabIndex = 19;
            this.btn_AddCli.Text = "Adicionar";
            this.btn_AddCli.UseVisualStyleBackColor = true;
            this.btn_AddCli.Click += new System.EventHandler(this.btn_AddCli_Click);
            // 
            // btn_EditarCli
            // 
            this.btn_EditarCli.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarCli.Location = new System.Drawing.Point(332, 395);
            this.btn_EditarCli.Name = "btn_EditarCli";
            this.btn_EditarCli.Size = new System.Drawing.Size(116, 40);
            this.btn_EditarCli.TabIndex = 18;
            this.btn_EditarCli.Text = "Editar";
            this.btn_EditarCli.UseVisualStyleBackColor = true;
            // 
            // dtg_EventoCli
            // 
            this.dtg_EventoCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_EventoCli.Location = new System.Drawing.Point(38, 48);
            this.dtg_EventoCli.Name = "dtg_EventoCli";
            this.dtg_EventoCli.Size = new System.Drawing.Size(959, 341);
            this.dtg_EventoCli.TabIndex = 17;
            // 
            // tab_Serviço
            // 
            this.tab_Serviço.Controls.Add(this.btn_BuscarServico);
            this.tab_Serviço.Controls.Add(this.label1);
            this.tab_Serviço.Controls.Add(this.txt_BuscarServico);
            this.tab_Serviço.Controls.Add(this.dtg_EventoServico);
            this.tab_Serviço.Location = new System.Drawing.Point(4, 22);
            this.tab_Serviço.Name = "tab_Serviço";
            this.tab_Serviço.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Serviço.Size = new System.Drawing.Size(1035, 446);
            this.tab_Serviço.TabIndex = 2;
            this.tab_Serviço.Text = "Serviço";
            this.tab_Serviço.UseVisualStyleBackColor = true;
            // 
            // btn_BuscarServico
            // 
            this.btn_BuscarServico.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarServico.Location = new System.Drawing.Point(891, 12);
            this.btn_BuscarServico.Name = "btn_BuscarServico";
            this.btn_BuscarServico.Size = new System.Drawing.Size(103, 31);
            this.btn_BuscarServico.TabIndex = 22;
            this.btn_BuscarServico.Text = "Pesquisar";
            this.btn_BuscarServico.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Selecione o serviço";
            // 
            // txt_BuscarServico
            // 
            this.txt_BuscarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarServico.Location = new System.Drawing.Point(591, 16);
            this.txt_BuscarServico.Name = "txt_BuscarServico";
            this.txt_BuscarServico.Size = new System.Drawing.Size(294, 26);
            this.txt_BuscarServico.TabIndex = 20;
            // 
            // dtg_EventoServico
            // 
            this.dtg_EventoServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_EventoServico.Location = new System.Drawing.Point(38, 48);
            this.dtg_EventoServico.Name = "dtg_EventoServico";
            this.dtg_EventoServico.Size = new System.Drawing.Size(959, 341);
            this.dtg_EventoServico.TabIndex = 17;
            // 
            // tab_Lugar
            // 
            this.tab_Lugar.Controls.Add(this.btn_BuscarLugar);
            this.tab_Lugar.Controls.Add(this.label3);
            this.tab_Lugar.Controls.Add(this.txt_BuscarLugar);
            this.tab_Lugar.Controls.Add(this.dtg_EventoLugar);
            this.tab_Lugar.Location = new System.Drawing.Point(4, 22);
            this.tab_Lugar.Name = "tab_Lugar";
            this.tab_Lugar.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Lugar.Size = new System.Drawing.Size(1035, 446);
            this.tab_Lugar.TabIndex = 1;
            this.tab_Lugar.Text = "Lugar";
            this.tab_Lugar.UseVisualStyleBackColor = true;
            // 
            // btn_BuscarLugar
            // 
            this.btn_BuscarLugar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarLugar.Location = new System.Drawing.Point(891, 12);
            this.btn_BuscarLugar.Name = "btn_BuscarLugar";
            this.btn_BuscarLugar.Size = new System.Drawing.Size(103, 31);
            this.btn_BuscarLugar.TabIndex = 22;
            this.btn_BuscarLugar.Text = "Pesquisar";
            this.btn_BuscarLugar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Selecione o lugar";
            // 
            // txt_BuscarLugar
            // 
            this.txt_BuscarLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarLugar.Location = new System.Drawing.Point(591, 16);
            this.txt_BuscarLugar.Name = "txt_BuscarLugar";
            this.txt_BuscarLugar.Size = new System.Drawing.Size(294, 26);
            this.txt_BuscarLugar.TabIndex = 20;
            // 
            // dtg_EventoLugar
            // 
            this.dtg_EventoLugar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_EventoLugar.Location = new System.Drawing.Point(38, 48);
            this.dtg_EventoLugar.Name = "dtg_EventoLugar";
            this.dtg_EventoLugar.Size = new System.Drawing.Size(959, 341);
            this.dtg_EventoLugar.TabIndex = 17;
            // 
            // frm_CadEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 644);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_CadEvento";
            this.Text = "frm_CadEvento";
            this.tabControl1.ResumeLayout(false);
            this.tab_Cliente.ResumeLayout(false);
            this.tab_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EventoCli)).EndInit();
            this.tab_Serviço.ResumeLayout(false);
            this.tab_Serviço.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EventoServico)).EndInit();
            this.tab_Lugar.ResumeLayout(false);
            this.tab_Lugar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EventoLugar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Cliente;
        private System.Windows.Forms.TabPage tab_Lugar;
        private System.Windows.Forms.TabPage tab_Serviço;
        private System.Windows.Forms.Button btn_BuscarServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BuscarServico;
        private System.Windows.Forms.DataGridView dtg_EventoServico;
        private System.Windows.Forms.Button btn_BuscarLugar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_BuscarLugar;
        private System.Windows.Forms.DataGridView dtg_EventoLugar;
        private System.Windows.Forms.Button btn_BuscarCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_BuscarCli;
        private System.Windows.Forms.Button btn_AddCli;
        private System.Windows.Forms.Button btn_EditarCli;
        private System.Windows.Forms.DataGridView dtg_EventoCli;
    }
}