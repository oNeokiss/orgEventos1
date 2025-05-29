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


                if (cliente == null)
                {
                    MessageBox.Show("Cliente nao encontrado", "ATENCAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();

                }
                label1.Text = cliente.id_cliente.ToString();
                txt_nomeCliente.Text = cliente.nome;
                msktx_cpfCli.Text = cliente.cpf;
                msktx_telefoneCli.Text = cliente.telefone;
                txt_emailCliente.Text = cliente.email;
                datPick_nascCli.Value = cliente.dataNasc;
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

                try
                {

                    cliente.nome = txt_nomeCliente.Text;
                    cliente.cpf = msktx_cpfCli.Text;
                    cliente.telefone = msktx_telefoneCli.Text;
                    cliente.email = txt_emailCliente.Text;
                    cliente.logradouro = txt_logradouro.Text;
                    cliente.dataNasc = datPick_nascCli.Value;
                    cliente.numLogradouro = txt_numLogradouro.Text;
                    cliente.complemento = txt_complemento.Text;

                    int codigo = Convert.ToInt32(label1.Text);
                    cliente.id_cliente = codigo;

                    cliente_DAO.AlterarCliente(cliente);

                    MessageBox.Show("Alterado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception erro)
                {
                    // Mostra mensagem de erro se algo der errado
                    MessageBox.Show("Ocorreu um erro" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
    
}
