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
    public partial class frm_Alterar_Servico : Form
    {
        string _conexao = orgEventos1.Properties.Settings.Default.conexao;

        public frm_Alterar_Servico(int codigo)
        {
            InitializeComponent();

            if (codigo > 0)
            {

                Servico servico = new Servico();
                Servico_DAO servico_DAO = new Servico_DAO(_conexao);

                servico = servico_DAO.ObtemServico(codigo);

                if (servico == null)
                {
                    MessageBox.Show("Cliente nao encontrado", "ATENCAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();

                }

                lbl_IDServico.Text = servico.id_servico.ToString();
                mktb_ValorServico.Text = servico.preco.ToString();
                txt_descricao.Text = servico.descricao;
                txt_TipoServico.Text = servico.tipo;


            }


        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {

            Servico servico = new Servico();
            Servico_DAO servico_DAO = new Servico_DAO(_conexao);


            if (string.IsNullOrWhiteSpace(txt_TipoServico.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
            else
            {

                try
                {

                    servico.preco = decimal.Parse(mktb_ValorServico.Text);
                    servico.descricao = txt_descricao.Text;
                    servico.tipo = txt_TipoServico.Text;

                    int codigo = Convert.ToInt32(lbl_IDServico.Text);
                    servico.id_servico = codigo;


                    servico_DAO.AlterarServico(servico);



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
