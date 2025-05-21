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
    public partial class frm_CadEvento : Form
    {
        string _conexao = orgEventos1.Properties.Settings.Default.conexao;


        public frm_CadEvento()
        {
            InitializeComponent();
            ListarCliente();             // Lista os médicos cadastrados ao abrir
            configurarDataGridCli();       // Configura visualmente o DataGridView
        }

        private void configurarDataGridCli()
        {
            dtg_EventoCli.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold); // Define a fonte das células
            dtg_EventoCli.RowHeadersWidth = 25; // Largura do cabeçalho das linhas
            dtg_EventoCli.ReadOnly = true; // Impede edição direta na grade

            dtg_EventoCli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configuração de cada coluna do DataGrid
            // Para cada coluna: define autoajuste, alinhamento, padding e cabeçalho
            dtg_EventoCli.Columns["id_cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtg_EventoCli.Columns["id_cliente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoCli.Columns["id_cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoCli.Columns["id_cliente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_EventoCli.Columns["id_cliente"].HeaderText = "codigo";

            //dtgv_ConsultarCliente.Columns["nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_EventoCli.Columns["nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoCli.Columns["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoCli.Columns["nome"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_EventoCli.Columns["nome"].HeaderText = "Nome";


            //dtgv_ConsultarCliente.Columns["cpf"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_EventoCli.Columns["cpf"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoCli.Columns["cpf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoCli.Columns["cpf"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_EventoCli.Columns["cpf"].HeaderText = "CPF";

            //dtgv_ConsultarCliente.Columns["telefone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_EventoCli.Columns["telefone"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoCli.Columns["telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoCli.Columns["telefone"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_EventoCli.Columns["telefone"].HeaderText = "Telefone";

            //dtgv_ConsultarCliente.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_EventoCli.Columns["email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoCli.Columns["email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoCli.Columns["email"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_EventoCli.Columns["email"].HeaderText = "E-Mail";

            //dtgv_ConsultarCliente.Columns["dataNasc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_EventoCli.Columns["dataNasc"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoCli.Columns["dataNasc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoCli.Columns["dataNasc"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_EventoCli.Columns["dataNasc"].HeaderText = "Data Nascimento";

            //dtgv_ConsultarCliente.Columns["logradouro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_EventoCli.Columns["logradouro"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoCli.Columns["logradouro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoCli.Columns["logradouro"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_EventoCli.Columns["logradouro"].HeaderText = "Logradouro";

            //dtgv_ConsultarCliente.Columns["numLogradouro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_EventoCli.Columns["numLogradouro"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoCli.Columns["numLogradouro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoCli.Columns["numLogradouro"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_EventoCli.Columns["numLogradouro"].HeaderText = "Número";

            //dtgv_ConsultarCliente.Columns["complemento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_EventoCli.Columns["complemento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoCli.Columns["complemento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoCli.Columns["complemento"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_EventoCli.Columns["complemento"].HeaderText = "Complemento";


        }

        private void ListarCliente()
        {
            Cliente_DAO cliente_DAO = new Cliente_DAO(_conexao); // Cria objeto de acesso a dados
            string busca = txt_BuscarCli.Text.ToString(); // Pega o texto digitado
            DataSet dsCliente = new DataSet(); // Cria dataset para receber os dados
            dsCliente = cliente_DAO.BuscarCliente(busca); // Chama método de busca no DAO

            dtg_EventoCli.DataSource = dsCliente; // Define fonte de dados
            dtg_EventoCli.DataMember = "Cliente"; // Define a tabela a ser usada no DataSet



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

        

        private void btn_EditarCli_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddCli_Click(object sender, EventArgs e)
        {
            frm_CadCliente frmcadcliente = new frm_CadCliente();
            frmcadcliente.ShowDialog();
        }
    }
}
