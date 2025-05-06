using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orgEventos1
{
    public partial class frm_TelaPrincipal : Form
    {
        public frm_TelaPrincipal()
        {
            InitializeComponent();
        }

        private void clToolStripMenuItem_Click(object sender, EventArgs e) //Cad Cliente
        {
            frm_CadCliente frm_cadcliente = new frm_CadCliente();
            frm_cadcliente.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) //Sair
        {
            this.Close();
        }

        private void lugaresToolStripMenuItem_Click(object sender, EventArgs e) //Cad Lugar
        {
            frm_CadLugar frm_CadLugar = new frm_CadLugar();
            frm_CadLugar.ShowDialog();
        }


        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)  //Consultar Cliente
        {
            frm_ConsultaCliente frm_consultacliente = new frm_ConsultaCliente();
            frm_consultacliente.ShowDialog();
        }

        private void trabalhadoresToolStripMenuItem1_Click(object sender, EventArgs e) //Consultar Trabalhadores
        {
            frm_ConsultaTrabalhadores frm_consultatrabalhadores = new frm_ConsultaTrabalhadores();
            frm_consultatrabalhadores.ShowDialog();
        }

        private void frm_TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void trabalhadoresToolStripMenuItem_Click(object sender, EventArgs e) //Cad trabalhadores
        {
            frm_CadTrabalhador frm_cadtrabalhador = new frm_CadTrabalhador();
            frm_cadtrabalhador.ShowDialog();
        }

        private void lugaresToolStripMenuItem1_Click(object sender, EventArgs e) //
        {
            
        }
    }
}
