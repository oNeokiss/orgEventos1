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
    public partial class frm_ConsultarServicos : Form
    {
        string _conexao = orgEventos1.Properties.Settings.Default.conexao;

        public frm_ConsultarServicos()
        {
            InitializeComponent();
            ListarServico();
        }

        

        private void btn_AddServico_Click(object sender, EventArgs e)
        {
            frmServico frmservico = new frmServico();
            frmservico.ShowDialog();
        }


        private void ListarServico()
        {
            Servico_DAO servico_DAO = new Servico_DAO(_conexao); // Instancia o DAO para serviços
            string busca = txt_BuscarServico.Text.ToString(); // Obtém o texto da caixa de busca
            DataSet dsServico = new DataSet(); // Cria um DataSet que receberá os dados
            dsServico = servico_DAO.BuscarServico(busca); // Executa a busca

            dtgv_ConsultarServico.DataSource = dsServico; // Define os dados retornados como fonte para o DataGridView
            dtgv_ConsultarServico.DataMember = "Servico"; // Especifica qual tabela do DataSet deve ser usada
        }


        private void btn_EditarServico_Click(object sender, EventArgs e)
        {
            if (dtgv_ConsultarServico.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dtgv_ConsultarServico.CurrentRow.Cells[0].Value);

                frm_Alterar_Servico frm_alterar_servico = new frm_Alterar_Servico(codigo);
                frm_alterar_servico.ShowDialog();

                ListarServico();

            }

            else
            {
                MessageBox.Show("Selecione um registro para alteração!",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void btn_DelServico_Click(object sender, EventArgs e)
        {
            if (dtgv_ConsultarServico.SelectedRows.Count > 0)
            {
                // Pega o código do médico da linha selecionada
                int codigo = Convert.ToInt32(dtgv_ConsultarServico.CurrentRow.Cells[0].Value);

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
                    Servico_DAO servico_dao = new Servico_DAO(_conexao);
                    servico_dao.ExcluirServico(codigo);

                    // Atualiza a lista após exclusão
                    ListarServico();
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

        private void btn_sairConsultaServico_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_BuscarServico_Click(object sender, EventArgs e)
        {

        }
    }
}
