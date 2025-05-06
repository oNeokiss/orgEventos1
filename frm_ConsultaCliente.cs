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
    public partial class frm_ConsultaCliente : Form
    {
        string _conexao = orgEventos1.Properties.Settings.Default.conexao;

        public frm_ConsultaCliente()
        {
            InitializeComponent();
            ListarCliente();             // Lista os médicos cadastrados ao abrir
            configurarDataGrid();       // Configura visualmente o DataGridView
        }

        
        private void configurarDataGrid()
        {



        }



        private void ListarCliente()
        {




        }





        private void btn_sairConsultaCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            frm_CadCliente frmCadCliente = new frm_CadCliente();
            frmCadCliente.ShowDialog();
        }

        
    }
}
