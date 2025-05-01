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
    public partial class frm_ConsultaCliente : Form
    {
        string _conexao = orgEventos1.Properties.Settings.Default.conexao;

        public frm_ConsultaCliente()
        {
            InitializeComponent();
            ListarCliente();      // Carrega a lista de pacientes ao abrir o formulário
            configuraDataGrid();   // Configura o estilo e layout do DataGrid
        }        


        private void configuraDataGrid()
        {
            // Define a fonte padrão das células
            dtg_BuscarCli.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            // Define a largura do cabeçalho das linhas
            dtg_BuscarCli.RowHeadersWidth = 25;

            // Faz as colunas ocuparem o espaço automaticamente
            dtg_BuscarCli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Torna o DataGrid apenas leitura
            dtg_BuscarCli.ReadOnly = true;


            dtg_BuscarCli.Columns["id_cliente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_BuscarCli.Columns["id_cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_BuscarCli.Columns["id_cliente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_BuscarCli.Columns["id_cliente"].HeaderText = "codigo";

            // Coluna nome
            dtg_BuscarCli.Columns["nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_BuscarCli.Columns["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_BuscarCli.Columns["nome"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_BuscarCli.Columns["nome"].HeaderText = "Nome";

            // Coluna CPF
            dtg_BuscarCli.Columns["cpf"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_BuscarCli.Columns["cpf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_BuscarCli.Columns["cpf"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_BuscarCli.Columns["cpf"].HeaderText = "CPF";

            // Coluna telefone
            dtg_BuscarCli.Columns["telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_BuscarCli.Columns["telefone"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_BuscarCli.Columns["telefone"].HeaderText = "Telefone";

            // Coluna e-mail
            dtg_BuscarCli.Columns["email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_BuscarCli.Columns["email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_BuscarCli.Columns["email"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_BuscarCli.Columns["email"].HeaderText = "e-mail";            

            // Coluna Data de Nascimento
            dtg_BuscarCli.Columns["dataNasc"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_BuscarCli.Columns["dataNasc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_BuscarCli.Columns["dataNasc"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_BuscarCli.Columns["dataNasc"].HeaderText = "Data Nascimento";

            dtg_BuscarCli.Columns["logradouro"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_BuscarCli.Columns["logradouro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_BuscarCli.Columns["logradouro"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_BuscarCli.Columns["logradouro"].HeaderText = "Logradouro";

            // Coluna especialização
            dtg_BuscarCli.Columns["numLogradouro"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_BuscarCli.Columns["numLogradouro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_BuscarCli.Columns["numLogradouro"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_BuscarCli.Columns["numLogradouro"].HeaderText = "Número";

            // Coluna Data de Nascimento
            dtg_BuscarCli.Columns["complemento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_BuscarCli.Columns["complemento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_BuscarCli.Columns["complemento"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_BuscarCli.Columns["complemento"].HeaderText = "Complemento";


        }


        private void btn_sairConsultaCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            frm_CadCliente frmCadCliente = new frm_CadCliente();
            frmCadCliente.ShowDialog();
        }

        private void btn_BuscarCli_Click(object sender, EventArgs e)
        {
            if (txt_BuscarCli.Text == "")
            {
                // Exibe mensagem de alerta
                MessageBox.Show("Informe um conteúdo!");
                txt_BuscarCli.Focus(); // Foca no campo de texto
                ListarCliente();
                return;
            }

            ListarCliente(); // Executa a busca
        }

        private void ListarCliente()
        {
            // Cria uma instância do DAO com a string de conexão
            Cliente_DAO cliente_dao = new Cliente_DAO(_conexao);

            // Obtém o texto digitado para pesquisa
            string busca = txt_BuscarCli.Text.ToString();

            // Cria e preenche o DataSet com os dados retornados da busca
            DataSet dsCliente = new DataSet();
            dsCliente = cliente_dao.BuscarCliente(busca);

            // Define a fonte de dados do DataGrid
            dtg_BuscarCli.DataSource = dsCliente;
            dtg_BuscarCli.DataMember = "Cliente";
        }

        private void btn_DelCli_Click(object sender, EventArgs e)
        {

        }
    }
}
