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

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            frm_CadLugar frm_CadLugar = new frm_CadLugar();
            frm_CadLugar.ShowDialog();
        }
    }
}
