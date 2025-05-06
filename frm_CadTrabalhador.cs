using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using orgEventos1_DATA;

namespace orgEventos1
{
    public partial class frm_CadTrabalhador : Form
    {

        string _conexao = orgEventos1.Properties.Settings.Default.conexao;

        public frm_CadTrabalhador()
        {
            InitializeComponent();
        }

        private void btn_SairCadTrab_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddTrab_Click(object sender, EventArgs e)
        {
            Trabalhador trabalhador = new Trabalhador();
            //Trabalhador_DAO trabalhador_DAO = new Trabalhador_DAO(_conexao);

            
        }

    }
    
}
