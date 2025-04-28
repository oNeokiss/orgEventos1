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
    public partial class frm_CadTrabalhadores : Form
    {
        public frm_CadTrabalhadores()
        {
            InitializeComponent();
        }

        private void btn_sairConsultarTrabalhador_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
