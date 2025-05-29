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
    public partial class frm_Alterar_Lugar : Form
    {

        string _conexao = orgEventos1.Properties.Settings.Default.conexao;


        public frm_Alterar_Lugar(int codigo)
        {
            InitializeComponent();


            if (codigo > 0)
            {

                Lugar lugar = new Lugar();
                Lugar_DAO lugar_DAO = new Lugar_DAO(_conexao);

                lugar = lugar_DAO.ObtemLugar(codigo);


                if (lugar == null)
                {
                    MessageBox.Show("Lugar nao encontrado", "ATENCAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();


                }


                lbl_cod.Text = lugar.id_lugar.ToString();
                txt_TipoLugar.Text = lugar.tipo;
                txt_NomeLugar.Text = lugar.nome;
                mskb_Cep_Lugar.Text = lugar.cep;
                mskb_capacidade.Text = lugar.capacidade;
                txt_Logradouro.Text = lugar.logradouro;
                txt_numLogradouro.Text = lugar.numLogradouro;
                msktb_precoLugar.Text = lugar.preco.ToString();

            }

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {

            Lugar lugar = new Lugar();
            Lugar_DAO lugar_DAO = new Lugar_DAO(_conexao);

            if (string.IsNullOrWhiteSpace(txt_NomeLugar.Text))
            {

                MessageBox.Show("Por favor, preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                try
                {

                    lugar.tipo = txt_TipoLugar.Text;
                    lugar.nome = txt_NomeLugar.Text;
                    lugar.cep = mskb_Cep_Lugar.Text;
                    lugar.capacidade = mskb_capacidade.Text;
                    lugar.logradouro = txt_Logradouro.Text;
                    lugar.numLogradouro = txt_numLogradouro.Text;
                    lugar.preco = decimal.Parse(msktb_precoLugar.Text);


                    int codigo = Convert.ToInt32(lbl_cod.Text);
                    lugar.id_lugar = codigo;

                    lugar_DAO.AlterarLugar(lugar);

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
