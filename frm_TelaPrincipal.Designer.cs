namespace orgEventos1
{
    partial class frm_TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TelaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabalhadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lugaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabalhadoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lugaresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1440, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clToolStripMenuItem,
            this.trabalhadoresToolStripMenuItem,
            this.lugaresToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.cadastrosToolStripMenuItem.Text = "Cadastrar";
            // 
            // clToolStripMenuItem
            // 
            this.clToolStripMenuItem.Name = "clToolStripMenuItem";
            this.clToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.clToolStripMenuItem.Text = "Clientes";
            this.clToolStripMenuItem.Click += new System.EventHandler(this.clToolStripMenuItem_Click);
            // 
            // trabalhadoresToolStripMenuItem
            // 
            this.trabalhadoresToolStripMenuItem.Name = "trabalhadoresToolStripMenuItem";
            this.trabalhadoresToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.trabalhadoresToolStripMenuItem.Text = "Trabalhadores";
            // 
            // lugaresToolStripMenuItem
            // 
            this.lugaresToolStripMenuItem.Name = "lugaresToolStripMenuItem";
            this.lugaresToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.lugaresToolStripMenuItem.Text = "Lugares";
            this.lugaresToolStripMenuItem.Click += new System.EventHandler(this.lugaresToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.trabalhadoresToolStripMenuItem1,
            this.lugaresToolStripMenuItem1});
            this.consultaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.consultaToolStripMenuItem.Text = "Consultar";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.clientesToolStripMenuItem.Text = "Cliente";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // trabalhadoresToolStripMenuItem1
            // 
            this.trabalhadoresToolStripMenuItem1.Name = "trabalhadoresToolStripMenuItem1";
            this.trabalhadoresToolStripMenuItem1.Size = new System.Drawing.Size(203, 30);
            this.trabalhadoresToolStripMenuItem1.Text = "Trabalhadores";
            this.trabalhadoresToolStripMenuItem1.Click += new System.EventHandler(this.trabalhadoresToolStripMenuItem1_Click);
            // 
            // lugaresToolStripMenuItem1
            // 
            this.lugaresToolStripMenuItem1.Name = "lugaresToolStripMenuItem1";
            this.lugaresToolStripMenuItem1.Size = new System.Drawing.Size(203, 30);
            this.lugaresToolStripMenuItem1.Text = "Lugares";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frm_TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::orgEventos1.Properties.Resources.EventCad__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1440, 828);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_TelaPrincipal";
            this.Text = "EventCad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lugaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lugaresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trabalhadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabalhadoresToolStripMenuItem1;
    }
}

