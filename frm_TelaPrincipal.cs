﻿using System;
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

        private void clToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadCliente frm_CadCliente = new frm_CadCliente();
            frm_CadCliente.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lugaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadLugar frm_CadLugar = new frm_CadLugar();
            frm_CadLugar.ShowDialog();
        }


        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ConsultaCliente frm_consultacliente = new frm_ConsultaCliente();
            frm_consultacliente.ShowDialog();
        }

        private void trabalhadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ConsultaTrabalhadores frm_cadtrabalhadores = new frm_ConsultaTrabalhadores();
            frm_cadtrabalhadores.ShowDialog();
        }

       

        private void trabalhadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadTrabalhador frm_cadtrabalhador = new frm_CadTrabalhador();
            frm_cadtrabalhador.ShowDialog();
        }        

        private void lugaresToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frm_ConsultaLugares frm_consultalugares = new frm_ConsultaLugares();
            frm_consultalugares.ShowDialog();
        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagamentos frmpagamentos = new frmPagamentos();
            frmpagamentos.ShowDialog();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadEvento frm_cadevento = new frm_CadEvento();
            frm_cadevento.ShowDialog();
        }

        private void servicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmServico frmservico = new frmServico();
            frmservico.ShowDialog();
        }

        private void servicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ConsultarServicos frm_consultarservicos = new frm_ConsultarServicos();
            frm_consultarservicos.ShowDialog();
        }

        private void eventosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ConsultarEventos frm_consultareventos = new frm_ConsultarEventos();
            frm_consultareventos.ShowDialog();
        }
    }
}
