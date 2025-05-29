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
    public partial class frm_Alterar_Trabalhadores : Form
    {
        string _conexao = orgEventos1.Properties.Settings.Default.conexao;

        public frm_Alterar_Trabalhadores(int codigo)
        {
            InitializeComponent();

            if (codigo > 0)
            {

                Trabalhador trabalhador = new Trabalhador();
                Trabalhador_DAO trabalhador_DAO = new Trabalhador_DAO(_conexao);

                trabalhador = trabalhador_DAO.ObtemTrabalhador(codigo);


                if (trabalhador == null)
                {
                    MessageBox.Show("Trabalhador nao encontrado", "ATENCAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();

                }

                lbl_cod.Text = trabalhador.id_trabalhador.ToString();
                txtbox_nomeTrab.Text = trabalhador.nome;
                msktx_cpfTrab.Text = trabalhador.cpf;
                txtBox_emailTrab.Text = trabalhador.email;
                msktx_telefoneTrab.Text = trabalhador.telefone;
    
            }
        }

        private void btn_SairCadTrab_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddTrab_Click(object sender, EventArgs e)
        {

            Trabalhador trabalhador = new Trabalhador();
            Trabalhador_DAO trabalhador_dao = new Trabalhador_DAO(_conexao);

            if (string.IsNullOrWhiteSpace(txtbox_nomeTrab.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                try
                {

                    trabalhador.nome = txtbox_nomeTrab.Text;
                    trabalhador.cpf = msktx_cpfTrab.Text;
                    trabalhador.email = txtBox_emailTrab.Text;
                    trabalhador.telefone = msktx_telefoneTrab.Text;

                    int codigo = Convert.ToInt32(lbl_cod.Text);
                    trabalhador.id_trabalhador = codigo;

                    trabalhador_dao.AlterarTrabalhador(trabalhador);


                    MessageBox.Show("Alterado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                }
                catch (Exception erro)
                {
                    // Mostra mensagem de erro se algo der errado
                    MessageBox.Show("Ocorreu um erro" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
