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
    public partial class frm_ConsultaLugares : Form
    {
        public frm_ConsultaLugares()
        {
            InitializeComponent();
        }

        private void btn_AddLugar_Click(object sender, EventArgs e)
        {
            frm_CadLugar frm_cadlugar = new frm_CadLugar();
            frm_cadlugar.ShowDialog();
        }

        private void btn_BuscarLugar_Click(object sender, EventArgs e)
        {

        }
    }
}
