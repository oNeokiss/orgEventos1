using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using orgEventos1_DATA;

namespace orgEventos1
{
    public partial class frm_CadLugar : Form
    {
        string _conexao = orgEventos1.Properties.Settings.Default.conexao;

        public frm_CadLugar()
        {
            InitializeComponent();
        }





        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {





        }



        private void btn_CadastrarLugar_Click(object sender, EventArgs e)
        {
            Lugar lugar = new Lugar();
            Lugar_DAO lugar_DAO = new Lugar_DAO(_conexao);

            if (string.IsNullOrWhiteSpace(txt_NomeLugar.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lugar.nome = txt_NomeLugar.Text;
                lugar.tipo = txt_TipoLugar.Text;
                lugar.cep = mskb_Cep_Lugar.Text;
                lugar.capacidade = mskb_capacidade.Text.Replace("_", "").Trim();
                lugar.logradouro = txt_Logradouro.Text;
                lugar.numLogradouro = txt_numLogradouro.Text;
                //lugar.preco = msktb_precoLugar.Text;

                string inputPreco = txt_preco.Text;
                decimal preco;

                // Cambia CultureInfo según el formato que uses (coma o punto)
                if (decimal.TryParse(inputPreco, NumberStyles.Number, new CultureInfo("pt-BR"), out preco))
                {
                    lugar.preco = preco;

                    // ✅ Si todo fue bien, continuar con el guardado
                    // Aquí podrías guardar en la base de datos, mostrar mensaje, etc.

                    lugar_DAO.IncluirLugar(lugar);

                    MessageBox.Show("Lugar guardado correctamente.");


                    txt_NomeLugar.Text = string.Empty;
                    txt_TipoLugar.Text = string.Empty;
                    mskb_Cep_Lugar.Text = string.Empty;
                    mskb_capacidade.Text = string.Empty;
                    txt_Logradouro.Text = string.Empty;
                    txt_numLogradouro.Text = string.Empty;

                    txt_preco.Text = string.Empty;

                    txt_NomeLugar.Focus();
                }
                else
                {
                    // ❌ Mostrar error si el precio es inválido
                    MessageBox.Show("Por favor, ingresa un valor válido para el precio (ej: 123.45).");

                    return; // No seguir guardando si el precio no es válido
                }



               
            }
        }
    }
}
