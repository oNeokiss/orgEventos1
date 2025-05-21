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
            ListarCliente();             // Lista os médicos cadastrados ao abrir
            configurarDataGrid();       // Configura visualmente o DataGridView
        }

        
        private void configurarDataGrid()
        {
            dtgv_ConsultarCliente.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold); // Define a fonte das células
            dtgv_ConsultarCliente.RowHeadersWidth = 25; // Largura do cabeçalho das linhas
            dtgv_ConsultarCliente.ReadOnly = true; // Impede edição direta na grade

            dtgv_ConsultarCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configuração de cada coluna do DataGrid
            // Para cada coluna: define autoajuste, alinhamento, padding e cabeçalho
            dtgv_ConsultarCliente.Columns["id_cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgv_ConsultarCliente.Columns["id_cliente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["id_cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["id_cliente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgv_ConsultarCliente.Columns["id_cliente"].HeaderText = "codigo";

            //dtgv_ConsultarCliente.Columns["nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_ConsultarCliente.Columns["nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["nome"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgv_ConsultarCliente.Columns["nome"].HeaderText = "Nome";


            //dtgv_ConsultarCliente.Columns["cpf"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_ConsultarCliente.Columns["cpf"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["cpf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["cpf"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgv_ConsultarCliente.Columns["cpf"].HeaderText = "CPF";

            //dtgv_ConsultarCliente.Columns["telefone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_ConsultarCliente.Columns["telefone"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["telefone"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgv_ConsultarCliente.Columns["telefone"].HeaderText = "Telefone";

            //dtgv_ConsultarCliente.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_ConsultarCliente.Columns["email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["email"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgv_ConsultarCliente.Columns["email"].HeaderText = "E-Mail";

            //dtgv_ConsultarCliente.Columns["dataNasc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_ConsultarCliente.Columns["dataNasc"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["dataNasc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["dataNasc"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgv_ConsultarCliente.Columns["dataNasc"].HeaderText = "Data Nascimento";

            //dtgv_ConsultarCliente.Columns["logradouro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_ConsultarCliente.Columns["logradouro"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["logradouro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["logradouro"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgv_ConsultarCliente.Columns["logradouro"].HeaderText = "Logradouro";

            //dtgv_ConsultarCliente.Columns["numLogradouro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_ConsultarCliente.Columns["numLogradouro"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["numLogradouro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["numLogradouro"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgv_ConsultarCliente.Columns["numLogradouro"].HeaderText = "Número";

            //dtgv_ConsultarCliente.Columns["complemento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_ConsultarCliente.Columns["complemento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["complemento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["complemento"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgv_ConsultarCliente.Columns["complemento"].HeaderText = "Complemento";           


        }



        private void ListarCliente()
        {
            Cliente_DAO cliente_DAO = new Cliente_DAO(_conexao); // Cria objeto de acesso a dados
            string busca = txtBox_PesquisarCliente.Text.ToString(); // Pega o texto digitado
            DataSet dsCliente = new DataSet(); // Cria dataset para receber os dados
            dsCliente = cliente_DAO.BuscarCliente(busca); // Chama método de busca no DAO

            dtgv_ConsultarCliente.DataSource = dsCliente; // Define fonte de dados
            dtgv_ConsultarCliente.DataMember = "Cliente"; // Define a tabela a ser usada no DataSet



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

        private void btn_pesqusiarCliente_Click(object sender, EventArgs e)
        {
            if (txtBox_PesquisarCliente.Text == "")
            {
                // Exibe mensagem de alerta
                MessageBox.Show("Informe um conteúdo!");
                txtBox_PesquisarCliente.Focus(); // Foca no campo de texto
                ListarCliente();
                return;
            }

            ListarCliente(); // Executa a busca

        }

        

        

        private void btn_Editar_Click(object sender, EventArgs e)
        {

        }
    }
}
