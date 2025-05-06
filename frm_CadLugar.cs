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
    public partial class frm_CadLugar : Form
    {
        string _conexao = orgEventos1.Properties.Settings.Default.conexao;

        public frm_CadLugar()
        {
            InitializeComponent();
        }

        private void frm_CadLugar_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Lugar lugar = new Lugar();

        }
    }
}
