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
    public partial class frm_ConsultaTrabalhadores : Form
    {
        string _conexao = orgEventos1.Properties.Settings.Default.conexao;

        public frm_ConsultaTrabalhadores()
        {
            InitializeComponent();
            ListarTrabalhador();
        }

        private void btn_sairConsultarTrabalhador_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_adicionarTrabalhador_Click(object sender, EventArgs e)
        {
            frm_CadTrabalhador frm_cadtrabalhador = new frm_CadTrabalhador();
            frm_cadtrabalhador.ShowDialog();
        }


        private void ListarTrabalhador()
        {
            Trabalhador_DAO trabalhador_DAO = new Trabalhador_DAO(_conexao); // Cria objeto de acesso a dados
            string busca = txtBox_PesquisarTrabalhador.Text.ToString(); // Pega o texto digitado
            DataSet dsTrabalhador = new DataSet(); // Cria dataset para receber os dados
            dsTrabalhador = trabalhador_DAO.BuscarTrabalhador(busca); // Chama método de busca no DAO

            dtgv_ConsultarTrabalhador.DataSource = dsTrabalhador; // Define fonte de dados
            dtgv_ConsultarTrabalhador.DataMember = "Trabalhador"; // Define a tabela a ser usada no DataSet



        }


        private void btn_excluirTrabalhador_Click(object sender, EventArgs e)
        {
            if (dtgv_ConsultarTrabalhador.SelectedRows.Count > 0)
            {
                // Pega o código do médico da linha selecionada
                int codigo = Convert.ToInt32(dtgv_ConsultarTrabalhador.CurrentRow.Cells[0].Value);

                // Exibe um MessageBox de confirmação
                var resultado = MessageBox.Show(
                    "Deseja excluir esse registro?",
                    "Pergunta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                // Se o usuário confirmar a exclusão
                if (resultado == DialogResult.Yes)
                {
                    // Cria o DAO e exclui o médico
                    Trabalhador_DAO trabalhador_dao = new Trabalhador_DAO(_conexao);
                    trabalhador_dao.ExcluirTrabalhador(codigo);

                    // Atualiza a lista após exclusão
                    ListarTrabalhador();
                }
                else
                {
                    // Caso não tenha selecionado nada ou cancele, exibe aviso
                    MessageBox.Show(
                        "Selecione um registro para exclusão!",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_EditarTrabalhador_Click(object sender, EventArgs e)
        {

            if (dtgv_ConsultarTrabalhador.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dtgv_ConsultarTrabalhador.SelectedRows.Count > 0);

                frm_Alterar_Trabalhadores frm_Alterar_Trabalhadores = new frm_Alterar_Trabalhadores(codigo);
                frm_Alterar_Trabalhadores.ShowDialog();

                ListarTrabalhador();

            }

            else
            {
                MessageBox.Show("Selecione um registro para alteração!",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            }


        }

        private void btn_pesquisarTrabalhador_Click(object sender, EventArgs e)
        {
            if (txtBox_PesquisarTrabalhador.Text == "")
            {
                MessageBox.Show("Informe um conteúdo!"); // Alerta se não foi digitado nada
                txtBox_PesquisarTrabalhador.Focus(); // Coloca o cursor no campo de texto
                ListarTrabalhador(); // Lista todos os serviços (sem filtro)
                return;
            }

            ListarTrabalhador(); // Realiza a busca filtrada
        }
    }
}
