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
    public partial class frm_ConsultaLugares : Form
    {
        string _conexao = orgEventos1.Properties.Settings.Default.conexao;


        public frm_ConsultaLugares()
        {
            InitializeComponent();
            ListarLugar();
        }


        private void ListarLugar()
        {
            Lugar_DAO lugar_DAO = new Lugar_DAO(_conexao); // Instancia o DAO responsável por lugares
            string busca = txt_BuscarLugar.Text.ToString(); // Pega o conteúdo digitado na caixa de texto
            DataSet dsLugar = new DataSet(); // Cria um DataSet para armazenar os resultados da busca
            dsLugar = lugar_DAO.BuscarLugar(busca); // Executa a busca no banco de dados

            dtgv_ConsultarLugar.DataSource = dsLugar; // Define o DataSource do DataGridView com os dados retornados
            dtgv_ConsultarLugar.DataMember = "Lugar"; // Define o nome da tabela usada dentro do DataSet
        }



        private void btn_AddLugar_Click(object sender, EventArgs e)
        {
            frm_CadLugar frm_cadlugar = new frm_CadLugar();
            frm_cadlugar.ShowDialog();
        }

        private void btn_BuscarLugar_Click(object sender, EventArgs e)
        {
            if (txt_BuscarLugar.Text == "")
            {
                MessageBox.Show("Informe um conteúdo!"); // Alerta se o campo está vazio
                txt_BuscarLugar.Focus(); // Foca no campo de texto
                ListarLugar(); // Executa a listagem completa
                return;
            }

            ListarLugar(); // Executa a busca com base no texto
        }

        private void btn_EditarLugar_Click(object sender, EventArgs e)
        {

        }

        private void btn_DelLugar_Click(object sender, EventArgs e)
        {
            if (dtgv_ConsultarLugar.SelectedRows.Count > 0)
            {
                // Pega o código do médico da linha selecionada
                int codigo = Convert.ToInt32(dtgv_ConsultarLugar.CurrentRow.Cells[0].Value);

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
                    Lugar_DAO lugar_dao = new Lugar_DAO(_conexao);
                    lugar_dao.ExcluirLugar(codigo);

                    // Atualiza a lista após exclusão
                    ListarLugar();
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

        private void btn_sairConsultaLugar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
