using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
            ListarEConfigurar();   
        }


        private void ListarEConfigurar()
        {
            ListarCliente();             // Lista os médicos cadastrados ao abrir
            ListarLugar();
            ListarServico();

            configurarDataGridCli(); // Configura visualmente o DataGridView
            configurarDataGridLugar();






            //servico
            CarregarServicos();


            dtg_EventoServico.CellValueChanged += dgv_Servicos_CellValueChanged;
            dtg_EventoServico.CurrentCellDirtyStateChanged += dgv_Servicos_CurrentCellDirtyStateChanged;
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

        private void configurarDataGridLugar()
        {
            dtg_EventoLugar.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold); // Define a fonte das células
            dtg_EventoLugar.RowHeadersWidth = 25; // Largura do cabeçalho das linhas
            dtg_EventoLugar.ReadOnly = true; // Impede edição direta na grade

           // dtg_EventoLugar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configuração de cada coluna do DataGrid
            // Para cada coluna: define autoajuste, alinhamento, padding e cabeçalho
            dtg_EventoLugar.Columns["id_lugar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtg_EventoLugar.Columns["id_lugar"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoLugar.Columns["id_lugar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoLugar.Columns["id_lugar"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_EventoLugar.Columns["id_lugar"].HeaderText = "codigo";

            dtg_EventoLugar.Columns["nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_EventoLugar.Columns["nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoLugar.Columns["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoLugar.Columns["nome"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_EventoLugar.Columns["nome"].HeaderText = "Nome";


            dtg_EventoLugar.Columns["tipo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_EventoLugar.Columns["tipo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoLugar.Columns["tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoLugar.Columns["tipo"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_EventoLugar.Columns["tipo"].HeaderText = "Tipo";

            dtg_EventoLugar.Columns["cep"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_EventoLugar.Columns["cep"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoLugar.Columns["cep"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoLugar.Columns["cep"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_EventoLugar.Columns["cep"].HeaderText = "CEP";

            dtg_EventoLugar.Columns["capacidade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_EventoLugar.Columns["capacidade"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoLugar.Columns["capacidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoLugar.Columns["capacidade"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_EventoLugar.Columns["capacidade"].HeaderText = "Capacidade";


            dtg_EventoLugar.Columns["logradouro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_EventoLugar.Columns["logradouro"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoLugar.Columns["logradouro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoLugar.Columns["logradouro"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_EventoLugar.Columns["logradouro"].HeaderText = "Logradouro";

            dtg_EventoLugar.Columns["nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_EventoLugar.Columns["numLogradouro"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoLugar.Columns["numLogradouro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoLugar.Columns["numLogradouro"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_EventoLugar.Columns["numLogradouro"].HeaderText = "Número";

            dtg_EventoLugar.Columns["preco"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_EventoLugar.Columns["preco"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoLugar.Columns["preco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoLugar.Columns["preco"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtg_EventoLugar.Columns["preco"].HeaderText = "Preço";


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


        private void ListarLugar()
        {
            Lugar_DAO lugar_DAO = new Lugar_DAO(_conexao); // Cria objeto de acesso a dados
            string busca = txt_BuscarLugar.Text.ToString(); // Pega o texto digitado
            DataSet dsLugar = new DataSet(); // Cria dataset para receber os dados
            dsLugar = lugar_DAO.BuscarLugar(busca); // Chama método de busca no DAO

            dtg_EventoLugar.DataSource = dsLugar; // Define fonte de dados
            dtg_EventoLugar.DataMember = "Lugar"; // Define a tabela a ser usada no DataSet



        }

        private void ListarServico()
        {
           Servico_DAO servico_DAO = new Servico_DAO(_conexao); // Cria objeto de acesso a dados
            string busca = txt_BuscarServico.Text.ToString(); // Pega o texto digitado
            DataSet dsServico = new DataSet(); // Cria dataset para receber os dados
            dsServico = servico_DAO.BuscarServico(busca); // Chama método de busca no DAO

            dtg_EventoServico.DataSource = dsServico; // Define fonte de dados
            dtg_EventoServico.DataMember = "Servico"; // Define a tabela a ser usada no DataSet



        }






        private void btn_EditarCli_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddCli_Click(object sender, EventArgs e)
        {
            frm_CadCliente frmcadcliente = new frm_CadCliente();
            frmcadcliente.ShowDialog();
        }

        

        private void btn_BuscarCli_Click_1(object sender, EventArgs e)
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

        private void btn_BuscarLugar_Click(object sender, EventArgs e)
        {
            if (txt_BuscarLugar.Text == "")
            {
                // Exibe mensagem de alerta
                MessageBox.Show("Informe um conteúdo!");
                txt_BuscarLugar.Focus(); // Foca no campo de texto
                ListarLugar();
                return;
            }

            ListarLugar(); // Executa a busca
        }

        private void btn_BuscarServico_Click(object sender, EventArgs e)
        {
            if (txt_BuscarServico.Text == "")
            {
                // Exibe mensagem de alerta
                MessageBox.Show("Informe um conteúdo!");
                txt_BuscarServico.Focus(); // Foca no campo de texto
                ListarServico();
                return;
            }

            ListarServico(); // Executa a busca
        }




        //Servico

        private void CarregarServicos()
        {
            Servico servico = new Servico();
            Servico_DAO servico_DAO = new Servico_DAO(_conexao);

            

            var listaServicos = servico_DAO.ListarServicos();
            dtg_EventoServico.DataSource = null;  // Limpia el dataSource anterior
            dtg_EventoServico.DataSource = listaServicos;

            // Agregar la columna de CheckBox al final
            if (!dtg_EventoServico.Columns.Contains("Selecionado"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "Selecionar";
                chk.Name = "Selecionado";
                dtg_EventoServico.Columns.Add(chk);
            }

            
             // ocultar id si no lo necesitás
        }

        private void dgv_Servicos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtg_EventoServico.Columns["Selecionado"].Index)
            {
                CalcularTotalServicos();
            }
        }

        private void dgv_Servicos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dtg_EventoServico.IsCurrentCellDirty)
            {
                dtg_EventoServico.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void CalcularTotalServicos()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dtg_EventoServico.Rows)
            {
                bool selecionado = Convert.ToBoolean(row.Cells["Selecionado"].Value ?? false);
                decimal preco = 0;

                if (row.Cells["preco"].Value != null && decimal.TryParse(row.Cells["preco"].Value.ToString(), out preco))
                {
                    if (selecionado)
                        total += preco;
                }
            }

            lbl_TotalServicos.Text = total.ToString("C", new CultureInfo("pt-BR"));
        }

    }
}
