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

            // Configuração de cada coluna do DataGrid
            // Para cada coluna: define autoajuste, alinhamento, padding e cabeçalho
            dtgv_ConsultarCliente.Columns["id_cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgv_ConsultarCliente.Columns["id_cliente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["id_cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ConsultarCliente.Columns["id_cliente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgv_ConsultarCliente.Columns["id_cliente"].HeaderText = "codigo";

            //dtg_BuscarPac.Columns["nomePac"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_BuscarPac.Columns["nomePac"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["nomePac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["nomePac"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            //dtg_BuscarPac.Columns["nomePac"].HeaderText = "Nome";

            //dtg_BuscarPac.Columns["cpfPac"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_BuscarPac.Columns["cpfPac"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["cpfPac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["cpfPac"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            //dtg_BuscarPac.Columns["cpfPac"].HeaderText = "CPF";

            //dtg_BuscarPac.Columns["nascPac"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_BuscarPac.Columns["nascPac"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["nascPac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["nascPac"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            //dtg_BuscarPac.Columns["nascPac"].HeaderText = "Data Nascimento";

            //dtg_BuscarPac.Columns["celPac"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_BuscarPac.Columns["celPac"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["celPac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["celPac"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            //dtg_BuscarPac.Columns["celPac"].HeaderText = "Telefone";

            //dtg_BuscarPac.Columns["emailPac"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_BuscarPac.Columns["emailPac"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["emailPac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["emailPac"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            //dtg_BuscarPac.Columns["emailPac"].HeaderText = "e-mail";

            //dtg_BuscarPac.Columns["estCivilPac"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_BuscarPac.Columns["estCivilPac"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["estCivilPac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["estCivilPac"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            //dtg_BuscarPac.Columns["estCivilPac"].HeaderText = "Estado Civil";

            //dtg_BuscarPac.Columns["tipSangPac"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_BuscarPac.Columns["tipSangPac"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["tipSangPac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["tipSangPac"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            //dtg_BuscarPac.Columns["tipSangPac"].HeaderText = "Tipo Sanguineo";

            //dtg_BuscarPac.Columns["rhPac"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_BuscarPac.Columns["rhPac"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["rhPac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["rhPac"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            //dtg_BuscarPac.Columns["rhPac"].HeaderText = "RH";

            //dtg_BuscarPac.Columns["cepPac"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_BuscarPac.Columns["cepPac"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["cepPac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["cepPac"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            //dtg_BuscarPac.Columns["cepPac"].HeaderText = "CEP";

            //dtg_BuscarPac.Columns["logradouroPac"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_BuscarPac.Columns["logradouroPac"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["logradouroPac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["logradouroPac"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            //dtg_BuscarPac.Columns["logradouroPac"].HeaderText = "Logradouro";

            //dtg_BuscarPac.Columns["numLogradouroPac"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_BuscarPac.Columns["numLogradouroPac"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["numLogradouroPac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["numLogradouroPac"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            //dtg_BuscarPac.Columns["numLogradouroPac"].HeaderText = "Número";

            //dtg_BuscarPac.Columns["bairroPac"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_BuscarPac.Columns["bairroPac"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["bairroPac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["bairroPac"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            //dtg_BuscarPac.Columns["bairroPac"].HeaderText = "Bairro";

            //dtg_BuscarPac.Columns["ufPac"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_BuscarPac.Columns["ufPac"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["ufPac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["ufPac"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            //dtg_BuscarPac.Columns["ufPac"].HeaderText = "UF";

            //dtg_BuscarPac.Columns["complementoPac"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_BuscarPac.Columns["complementoPac"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["complementoPac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["complementoPac"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            //dtg_BuscarPac.Columns["complementoPac"].HeaderText = "Complemento";

            //dtg_BuscarPac.Columns["cidadePac"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_BuscarPac.Columns["cidadePac"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["cidadePac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["cidadePac"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            //dtg_BuscarPac.Columns["cidadePac"].HeaderText = "Cidade";

            //dtg_BuscarPac.Columns["nomeAcomp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_BuscarPac.Columns["nomeAcomp"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["nomeAcomp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["nomeAcomp"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            //dtg_BuscarPac.Columns["nomeAcomp"].HeaderText = "Acompanhante";

            //dtg_BuscarPac.Columns["celAcomp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_BuscarPac.Columns["celAcomp"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["celAcomp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtg_BuscarPac.Columns["celAcomp"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            //dtg_BuscarPac.Columns["celAcomp"].HeaderText = "Telefone Acomphante";


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

        
    }
}
