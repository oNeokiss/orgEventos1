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
            this.Horario = new System.Windows.Forms.TabControl();
            this.tab_Cliente = new System.Windows.Forms.TabPage();
            this.btn_BuscarCli = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BuscarCli = new System.Windows.Forms.TextBox();
            this.btn_AddCli = new System.Windows.Forms.Button();
            this.btn_EditarCli = new System.Windows.Forms.Button();
            this.dtg_EventoCli = new System.Windows.Forms.DataGridView();
            this.tab_Serviço = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_BuscarServico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TotalServicos = new System.Windows.Forms.Label();
            this.txt_BuscarServico = new System.Windows.Forms.TextBox();
            this.dtg_EventoServico = new System.Windows.Forms.DataGridView();
            this.tab_Lugar = new System.Windows.Forms.TabPage();
            this.btn_BuscarLugar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_BuscarLugar = new System.Windows.Forms.TextBox();
            this.dtg_EventoLugar = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_SalvarEvent = new System.Windows.Forms.Button();
            this.dtp_HoraInicio = new System.Windows.Forms.DateTimePicker();
            this.tab_Horario = new System.Windows.Forms.TabPage();
            this.dtp_HoraFim = new System.Windows.Forms.DateTimePicker();
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Horario.SuspendLayout();
            this.tab_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EventoCli)).BeginInit();
            this.tab_Serviço.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EventoServico)).BeginInit();
            this.tab_Lugar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EventoLugar)).BeginInit();
            this.tab_Horario.SuspendLayout();
            this.SuspendLayout();
            // 
            // Horario
            // 
            this.Horario.Controls.Add(this.tab_Cliente);
            this.Horario.Controls.Add(this.tab_Serviço);
            this.Horario.Controls.Add(this.tab_Lugar);
            this.Horario.Controls.Add(this.tab_Horario);
            this.Horario.Location = new System.Drawing.Point(57, 55);
            this.Horario.Name = "Horario";
            this.Horario.SelectedIndex = 0;
            this.Horario.Size = new System.Drawing.Size(1043, 472);
            this.Horario.TabIndex = 0;
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
            this.btn_BuscarCli.Click += new System.EventHandler(this.btn_BuscarCli_Click_1);
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
            this.btn_EditarCli.Click += new System.EventHandler(this.btn_EditarCli_Click_1);
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
            this.tab_Serviço.Controls.Add(this.label4);
            this.tab_Serviço.Controls.Add(this.btn_BuscarServico);
            this.tab_Serviço.Controls.Add(this.label1);
            this.tab_Serviço.Controls.Add(this.lbl_TotalServicos);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(664, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 33);
            this.label4.TabIndex = 23;
            this.label4.Text = "Valor:";
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
            this.btn_BuscarServico.Click += new System.EventHandler(this.btn_BuscarServico_Click);
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
            // lbl_TotalServicos
            // 
            this.lbl_TotalServicos.AutoSize = true;
            this.lbl_TotalServicos.Font = new System.Drawing.Font("Arial", 21.75F);
            this.lbl_TotalServicos.Location = new System.Drawing.Point(759, 401);
            this.lbl_TotalServicos.Name = "lbl_TotalServicos";
            this.lbl_TotalServicos.Size = new System.Drawing.Size(71, 33);
            this.lbl_TotalServicos.TabIndex = 1;
            this.lbl_TotalServicos.Text = "0,00";
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
            this.btn_BuscarLugar.Click += new System.EventHandler(this.btn_BuscarLugar_Click);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(569, 554);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 33);
            this.label10.TabIndex = 18;
            this.label10.Text = "R$";
            // 
            // txt_preco
            // 
            this.txt_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_preco.Location = new System.Drawing.Point(624, 556);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(118, 31);
            this.txt_preco.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(471, 554);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 33);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total:";
            // 
            // btn_SalvarEvent
            // 
            this.btn_SalvarEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarEvent.Location = new System.Drawing.Point(868, 550);
            this.btn_SalvarEvent.Name = "btn_SalvarEvent";
            this.btn_SalvarEvent.Size = new System.Drawing.Size(163, 46);
            this.btn_SalvarEvent.TabIndex = 19;
            this.btn_SalvarEvent.Text = "Cadastrar";
            this.btn_SalvarEvent.UseVisualStyleBackColor = true;
            this.btn_SalvarEvent.Click += new System.EventHandler(this.btn_SalvarEvent_Click);
            // 
            // dtp_HoraInicio
            // 
            this.dtp_HoraInicio.Location = new System.Drawing.Point(136, 300);
            this.dtp_HoraInicio.Name = "dtp_HoraInicio";
            this.dtp_HoraInicio.Size = new System.Drawing.Size(200, 20);
            this.dtp_HoraInicio.TabIndex = 20;
            // 
            // tab_Horario
            // 
            this.tab_Horario.Controls.Add(this.label7);
            this.tab_Horario.Controls.Add(this.label6);
            this.tab_Horario.Controls.Add(this.label5);
            this.tab_Horario.Controls.Add(this.dtp_Data);
            this.tab_Horario.Controls.Add(this.dtp_HoraFim);
            this.tab_Horario.Controls.Add(this.dtp_HoraInicio);
            this.tab_Horario.Location = new System.Drawing.Point(4, 22);
            this.tab_Horario.Name = "tab_Horario";
            this.tab_Horario.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Horario.Size = new System.Drawing.Size(1035, 446);
            this.tab_Horario.TabIndex = 3;
            this.tab_Horario.Text = "Horario";
            this.tab_Horario.UseVisualStyleBackColor = true;
            // 
            // dtp_HoraFim
            // 
            this.dtp_HoraFim.Location = new System.Drawing.Point(502, 300);
            this.dtp_HoraFim.Name = "dtp_HoraFim";
            this.dtp_HoraFim.Size = new System.Drawing.Size(200, 20);
            this.dtp_HoraFim.TabIndex = 21;
            // 
            // dtp_Data
            // 
            this.dtp_Data.Location = new System.Drawing.Point(136, 92);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(200, 20);
            this.dtp_Data.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 33);
            this.label5.TabIndex = 24;
            this.label5.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 33);
            this.label6.TabIndex = 25;
            this.label6.Text = "Começo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(496, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 33);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fim:";
            // 
            // frm_CadEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 644);
            this.Controls.Add(this.btn_SalvarEvent);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Horario);
            this.Name = "frm_CadEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Evento";
            this.Horario.ResumeLayout(false);
            this.tab_Cliente.ResumeLayout(false);
            this.tab_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EventoCli)).EndInit();
            this.tab_Serviço.ResumeLayout(false);
            this.tab_Serviço.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EventoServico)).EndInit();
            this.tab_Lugar.ResumeLayout(false);
            this.tab_Lugar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EventoLugar)).EndInit();
            this.tab_Horario.ResumeLayout(false);
            this.tab_Horario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Horario;
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
        private System.Windows.Forms.Label lbl_TotalServicos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_SalvarEvent;
        private System.Windows.Forms.TabPage tab_Horario;
        private System.Windows.Forms.DateTimePicker dtp_HoraInicio;
        private System.Windows.Forms.DateTimePicker dtp_Data;
        private System.Windows.Forms.DateTimePicker dtp_HoraFim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}