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
            // =============================
            // CARREGAMENTO INICIAL DE DADOS
            // =============================

            ListarCliente(); // Chama a função que busca e exibe a lista de clientes no DataGridView correspondente
            ListarLugar();   // Chama a função que busca e exibe a lista de lugares
            ListarServico(); // Chama a função que busca e exibe a lista de serviços

            // =============================
            // CONFIGURAÇÃO VISUAL DOS DATAGRIDS
            // =============================

            configurarDataGridCli();   // Aplica estilos visuais e cabeçalhos ao DataGrid de clientes
            configurarDataGridLugar(); // Aplica formatação ao DataGrid de lugares

            // =============================
            // CONFIGURAÇÃO ESPECÍFICA PARA SERVIÇOS
            // =============================

            CarregarServicos();         // Carrega os serviços disponíveis e adiciona a coluna de checkbox para seleção
            configurarDataGridServico(); // Ajusta visualmente o DataGridView de serviços (largura, fonte, wrap de texto etc.)

            // =============================
            // EVENTOS DO DATAGRID DE SERVIÇOS
            // =============================

            // Adiciona um manipulador de evento para quando o valor de uma célula é alterado (usado para atualizar o total)
            dtg_EventoServico.CellValueChanged += dgv_Servicos_CellValueChanged;

            // Adiciona manipulador para quando uma célula muda de estado de "sujo" para "limpo"
            // Isso permite capturar alterações de checkbox imediatamente
            dtg_EventoServico.CurrentCellDirtyStateChanged += dgv_Servicos_CurrentCellDirtyStateChanged;

            // Adiciona manipulador para evento disparado após o término do binding dos dados
            // Serve para aplicar ajustes finais ao layout ou conteúdo
            dtg_EventoServico.DataBindingComplete += dtg_EventoServico_DataBindingComplete;

            dtp_HoraInicio.Format = DateTimePickerFormat.Time;
            dtp_HoraInicio.ShowUpDown = true;

            dtp_HoraFim.Format = DateTimePickerFormat.Time;
            dtp_HoraFim.ShowUpDown = true;

            dtp_Data.Format = DateTimePickerFormat.Custom;
            dtp_Data.CustomFormat = "dd/MM/yyyy";

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


        private void configurarDataGridServico()
        {
            dtg_EventoServico.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dtg_EventoServico.RowHeadersWidth = 25;
            dtg_EventoServico.RowTemplate.Height = 50;

            // id_servico
            dtg_EventoServico.Columns["id_servico"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtg_EventoServico.Columns["id_servico"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoServico.Columns["id_servico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoServico.Columns["id_servico"].HeaderText = "Código";
            dtg_EventoServico.Columns["id_servico"].ReadOnly = true;

            // tipo
            dtg_EventoServico.Columns["tipo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_EventoServico.Columns["tipo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoServico.Columns["tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoServico.Columns["tipo"].HeaderText = "Nome";
            dtg_EventoServico.Columns["tipo"].ReadOnly = true;

            // descricao
            dtg_EventoServico.Columns["descricao"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dtg_EventoServico.Columns["descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg_EventoServico.Columns["descricao"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoServico.Columns["descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dtg_EventoServico.Columns["descricao"].HeaderText = "Descrição";
            dtg_EventoServico.Columns["descricao"].ReadOnly = true;

            // preco
            dtg_EventoServico.Columns["preco"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_EventoServico.Columns["preco"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoServico.Columns["preco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_EventoServico.Columns["preco"].HeaderText = "Preço";
            dtg_EventoServico.Columns["preco"].ReadOnly = true;

            // Adiciona quebra de linha nos textos longos de descrição
            foreach (DataGridViewRow row in dtg_EventoServico.Rows)
            {
                if (row.Cells["descricao"].Value != null)
                    row.Cells["descricao"].Value = row.Cells["descricao"].Value.ToString() + "\n";
            }

            // Faz com que a altura das linhas se ajuste automaticamente ao conteúdo
            dtg_EventoServico.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }









        // =============================
        // BLOCO: LISTAGEM DE DADOS
        // =============================

        // Lista os clientes com base no texto de busca
        private void ListarCliente()
        {
            Cliente_DAO cliente_DAO = new Cliente_DAO(_conexao); // Cria uma instância do DAO passando a string de conexão
            string busca = txt_BuscarCli.Text.ToString(); // Obtém o texto digitado na caixa de busca
            DataSet dsCliente = new DataSet(); // Cria um DataSet para armazenar os dados retornados
            dsCliente = cliente_DAO.BuscarCliente(busca); // Executa a busca no banco de dados através do DAO

            dtg_EventoCli.DataSource = dsCliente; // Atribui os dados ao DataGridView
            dtg_EventoCli.DataMember = "Cliente"; // Define qual tabela do DataSet será usada (caso haja mais de uma)
        }

        // Lista os lugares com base no texto de busca
        private void ListarLugar()
        {
            Lugar_DAO lugar_DAO = new Lugar_DAO(_conexao); // Instancia o DAO responsável por lugares
            string busca = txt_BuscarLugar.Text.ToString(); // Pega o conteúdo digitado na caixa de texto
            DataSet dsLugar = new DataSet(); // Cria um DataSet para armazenar os resultados da busca
            dsLugar = lugar_DAO.BuscarLugar(busca); // Executa a busca no banco de dados

            dtg_EventoLugar.DataSource = dsLugar; // Define o DataSource do DataGridView com os dados retornados
            dtg_EventoLugar.DataMember = "Lugar"; // Define o nome da tabela usada dentro do DataSet
        }

        // Lista os serviços com base no texto de busca
        private void ListarServico()
        {
            Servico_DAO servico_DAO = new Servico_DAO(_conexao); // Instancia o DAO para serviços
            string busca = txt_BuscarServico.Text.ToString(); // Obtém o texto da caixa de busca
            DataSet dsServico = new DataSet(); // Cria um DataSet que receberá os dados
            dsServico = servico_DAO.BuscarServico(busca); // Executa a busca

            dtg_EventoServico.DataSource = dsServico; // Define os dados retornados como fonte para o DataGridView
            dtg_EventoServico.DataMember = "Servico"; // Especifica qual tabela do DataSet deve ser usada
        }

        // =============================
        // BOTÕES (EVENTOS)
        // =============================

        // Evento do botão "Editar Cliente" - ainda não implementado
        private void btn_EditarCli_Click(object sender, EventArgs e)
        {
            // Código de edição do cliente será adicionado aqui futuramente
        }

        // Evento do botão "Adicionar Cliente"
        private void btn_AddCli_Click(object sender, EventArgs e)
        {
            // Cria e exibe o formulário de cadastro de cliente
            frm_CadCliente frmcadcliente = new frm_CadCliente();
            frmcadcliente.ShowDialog(); // Abre o formulário como uma janela modal (bloqueia a janela principal)
        }

        // Evento do botão "Buscar Cliente"
        private void btn_BuscarCli_Click_1(object sender, EventArgs e)
        {
            // Verifica se o campo de busca está vazio
            if (txt_BuscarCli.Text == "")
            {
                MessageBox.Show("Informe um conteúdo!"); // Mostra alerta ao usuário
                txt_BuscarCli.Focus(); // Retorna o foco ao campo de busca
                ListarCliente(); // Executa a listagem geral de clientes
                return;
            }

            ListarCliente(); // Se tiver texto, executa busca com filtro
        }

        // Evento do botão "Buscar Lugar"
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

        // Evento do botão "Buscar Serviço"
        private void btn_BuscarServico_Click(object sender, EventArgs e)
        {
            if (txt_BuscarServico.Text == "")
            {
                MessageBox.Show("Informe um conteúdo!"); // Alerta se não foi digitado nada
                txt_BuscarServico.Focus(); // Coloca o cursor no campo de texto
                ListarServico(); // Lista todos os serviços (sem filtro)
                return;
            }

            ListarServico(); // Realiza a busca filtrada
        }





        // =============================
        // BLOQUE: SERVIÇOS
        // =============================

        // Método para carregar a lista de serviços e adicionar uma coluna de seleção
        //private void CarregarServicos()
        //{
        //    Servico servico = new Servico(); // Cria uma instância da classe de modelo 'Servico'
        //    Servico_DAO servico_DAO = new Servico_DAO(_conexao); // Instancia o DAO com a conexão atual

        //    var listaServicos = servico_DAO.ListarServicos(); // Chama o método que retorna a lista de serviços
        //    dtg_EventoServico.DataSource = null;  // Limpa a fonte de dados atual (evita bugs ao recarregar)
        //    dtg_EventoServico.DataSource = listaServicos; // Atribui a nova lista ao DataGridView

        //    // Adiciona uma coluna de checkbox chamada "Selecionado" se ela ainda não existir
        //    if (!dtg_EventoServico.Columns.Contains("Selecionado"))
        //    {
        //        DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn(); // Cria a coluna checkbox
        //        chk.HeaderText = "Selecionar"; // Define o título da coluna
        //        chk.Name = "Selecionado"; // Define o nome interno da coluna
        //        dtg_EventoServico.Columns.Add(chk); // Adiciona a coluna ao DataGridView
        //    }

        //    // Hacer todo el grid readonly excepto la columna de checkbox

        //    dtg_EventoServico.Columns["Selecionado"].ReadOnly = false;

        //    dtg_EventoServico.ReadOnly = true;
        //}

        private void CarregarServicos()
        {
            // Crea objeto de serviço e DAO para acesso ao banco
            Servico servico = new Servico();
            Servico_DAO servico_DAO = new Servico_DAO(_conexao);

            // Obtém a lista de serviços do banco de dados
            var listaServicos = servico_DAO.ListarServicos();

            // Limpa a fonte de dados anterior e define a nova
            dtg_EventoServico.DataSource = null;
            dtg_EventoServico.DataSource = listaServicos;

            // Adiciona coluna de CheckBox se ainda não existir
            if (!dtg_EventoServico.Columns.Contains("Selecionado"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "Selecionar";
                chk.Name = "Selecionado";
                dtg_EventoServico.Columns.Add(chk);
            }


            dtg_EventoServico.Columns["Selecionado"].ReadOnly = false;
            //// Define o DataGridView como somente leitura
            //dtg_EventoServico.ReadOnly = true;

            //// Permite edição apenas na coluna de CheckBox
            //if (dtg_EventoServico.Columns.Contains("Selecionado"))
            //{
            //    dtg_EventoServico.Columns["Selecionado"].ReadOnly = false;
            //}
        }




        // Evento disparado quando o valor de uma célula é alterado
        private void dgv_Servicos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula alterada é da coluna "Selecionado"
            if (e.ColumnIndex == dtg_EventoServico.Columns["Selecionado"].Index)
            {
                CalcularTotalServicos(); // Recalcula o total de serviços selecionados
            }
        }

        // Evento disparado quando a célula atual muda de estado "sujo" (modificada)
        private void dgv_Servicos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // Se a célula atual foi modificada
            if (dtg_EventoServico.IsCurrentCellDirty)
            {
                dtg_EventoServico.CommitEdit(DataGridViewDataErrorContexts.Commit); // Confirma a edição para disparar eventos corretamente
            }
        }

        // Método que calcula o valor total dos serviços marcados no checkbox
        private void CalcularTotalServicos()
        {
            decimal total = 0; // Variável para armazenar o total

            // Itera por cada linha do DataGridView
            foreach (DataGridViewRow row in dtg_EventoServico.Rows)
            {
                // Verifica se a célula "Selecionado" está marcada (true)
                bool selecionado = Convert.ToBoolean(row.Cells["Selecionado"].Value ?? false);
                decimal preco = 0;

                // Tenta obter e converter o valor do preço da célula
                if (row.Cells["preco"].Value != null && decimal.TryParse(row.Cells["preco"].Value.ToString(), out preco))
                {
                    // Se selecionado, adiciona o preço ao total
                    if (selecionado)
                        total += preco;
                }
            }

            // Exibe o total formatado como moeda brasileira no rótulo
            lbl_TotalServicos.Text = total.ToString("C", new CultureInfo("pt-BR"));
        }

        // Evento disparado quando o binding de dados termina (usado para ajustes visuais)
        private void dtg_EventoServico_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Ajusta a altura das linhas automaticamente com base no conteúdo
            dtg_EventoServico.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Força quebra de linha na coluna "descricao", caso não tenha
            foreach (DataGridViewRow row in dtg_EventoServico.Rows)
            {
                if (row.Cells["descricao"].Value != null)
                {
                    string texto = row.Cells["descricao"].Value.ToString();
                    if (!texto.EndsWith("\n"))
                        row.Cells["descricao"].Value = texto + "\n"; // Adiciona quebra de linha
                }
            }
        }

        private void btn_EditarCli_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_SalvarEvent_Click(object sender, EventArgs e)
        {
            if (dtg_EventoCli.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente!");
                return;
            }
            int idCliente = Convert.ToInt32(dtg_EventoCli.CurrentRow.Cells["id_cliente"].Value);

            // Verifica se há uma linha selecionada no DataGridView de lugar
            if (dtg_EventoLugar.CurrentRow == null)
            {
                MessageBox.Show("Selecione um lugar!");
                return;
            }
            int idLugar = Convert.ToInt32(dtg_EventoLugar.CurrentRow.Cells["id_lugar"].Value);

            Evento evento = new Evento
            {
                id_cliente = idCliente,  // pegar do DataGridView
                id_lugar = idLugar,
                data_evento = dtp_Data.Value.Date,
                hora_inicio = dtp_HoraInicio.Value.TimeOfDay,
                hora_fim = dtp_HoraFim.Value.TimeOfDay
            };

            Evento_DAO eventoDAO = new Evento_DAO(_conexao);
            int idEventoGerado = eventoDAO.InserirEvento(evento);

            List<ServicoDoEvento> listaServicos = new List<ServicoDoEvento>();

            foreach (DataGridViewRow row in dtg_EventoServico.Rows)
            {
                bool selecionado = Convert.ToBoolean(row.Cells["Selecionado"].Value ?? false);
                if (selecionado)
                {
                    int idServico = Convert.ToInt32(row.Cells["id_servico"].Value);
                    listaServicos.Add(new ServicoDoEvento
                    {
                        fk_evento_id_evento = idEventoGerado,
                        fk_servico_id_servico = idServico
                    });
                }
            }

            eventoDAO.InserirServicosDoEvento(listaServicos, idEventoGerado);

            MessageBox.Show("Evento salvo com sucesso!");
        }
    }
}
