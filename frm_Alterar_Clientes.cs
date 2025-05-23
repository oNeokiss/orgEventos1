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
    public partial class frm_Alterar_Clientes : Form
    {

        string _conexao = orgEventos1.Properties.Settings.Default.conexao;


        public frm_Alterar_Clientes(int codigo)
        {
            InitializeComponent();

            if (codigo > 0)
            {

                Cliente cliente = new Cliente();
                Cliente_DAO cliente_DAO = new Cliente_DAO(_conexao);

                cliente = cliente_DAO.ObtemCliente(codigo);


                if (cliente != null)
                {
                    MessageBox.Show("Cliente nao encontrado", "ATENCAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();

                }

                txt_nomeCliente.Text = cliente.nome;
                msktx_cpfCli.Text = cliente.cpf;
                msktx_telefoneCli.Text = cliente.telefone;
                txt_emailCliente.Text = cliente.email;
                datPick_nascCli.Text = cliente.nome;
                txt_logradouro.Text = cliente.logradouro;
                txt_numLogradouro.Text = cliente.numLogradouro;
                txt_complemento.Text = cliente.complemento;
                
            }
        }

        private void btn_SairCadCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddCli_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Cliente_DAO cliente_DAO = new Cliente_DAO(_conexao);

            if (string.IsNullOrWhiteSpace(txt_nomeCliente.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cliente.nome = txt_nomeCliente.Text;
                cliente.cpf = msktx_cpfCli.Text;
                cliente.telefone = msktx_telefoneCli.Text;
                cliente.email = txt_emailCliente.Text;
                cliente.logradouro = txt_logradouro.Text;
                cliente.dataNasc = datPick_nascCli.Value;
                cliente.numLogradouro = txt_numLogradouro.Text;
                cliente.complemento = txt_complemento.Text;

                cliente_DAO.IncluirCliente(cliente);

                MessageBox.Show("Cadastro com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();   


            }
        }
    }
    
}
