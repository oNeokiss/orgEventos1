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
            Trabalhador_DAO trabalhador_DAO = new Trabalhador_DAO(_conexao);

            if (string.IsNullOrWhiteSpace(txtbox_nomeTrab.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                trabalhador.Nome = txtbox_nomeTrab.Text;
                trabalhador.Cpf = msktx_cpfTrab.Text;
                trabalhador.Telefone = msktx_telefoneTrab.Text;
                trabalhador.Email = txtBox_emailTrab.Text;
                

                

                MessageBox.Show("Cadastro com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtbox_nomeTrab.Text = string.Empty;
                msktx_cpfTrab.Text = string.Empty;
                msktx_telefoneTrab.Text = string.Empty;
                txtBox_emailTrab.Text = string.Empty;
                


            }


        }

    }
    
}
