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
    public partial class frm_ConsultarServicos : Form
    {
        public frm_ConsultarServicos()
        {
            InitializeComponent();
        }

        private void btn_AddServico_Click(object sender, EventArgs e)
        {
            frmEvento frmevento = new frmEvento();
            frmevento.ShowDialog();
        }

        private void btn_DelServico_Click(object sender, EventArgs e)
        {

        }
    }
}
