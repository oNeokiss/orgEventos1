using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;


using orgEventos1_DATA;

namespace orgEventos1
{
    public partial class frm_CadCliente : Form
    {
        string _conexao = orgEventos1.Properties.Settings.Default.conexao;



        public frm_CadCliente()
        {
            InitializeComponent();
        }

        private void btn_SairCadCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddCli_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Cliente_DAO cliente_DAO = new Cliente_DAO(_conexao);

            if (string.IsNullOrWhiteSpace(txt_nomeCli.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cliente.nome = txt_nomeCli.Text;
                cliente.cpf = msktx_cpfCli.Text;
                cliente.telefone = msktx_telefoneCli.Text;
                cliente.email = txt_emailCli.Text;
                cliente.logradouro = txt_logradouro.Text;
                cliente.dataNasc = datPick_nascCli.Value;
                cliente.numLogradouro = txt_numLogradouro.Text;
                cliente.complemento = txt_complemento.Text;

                //cliente_DAO.IncluirCliente(cliente);

                MessageBox.Show("Cadastro com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_nomeCli.Text = string.Empty;
                msktx_cpfCli.Text = string.Empty;
                msktx_telefoneCli.Text = string.Empty;
                txt_emailCli.Text = string.Empty;
                txt_logradouro.Text = string.Empty;
                txt_numLogradouro.Text = string.Empty;
                txt_complemento.Text = string.Empty;


            }
        }
    }
}
