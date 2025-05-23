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
    public partial class frmServico: Form
    {
        string _conexao = orgEventos1.Properties.Settings.Default.conexao;

        public frmServico()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();
            Servico_DAO servico_DAO = new Servico_DAO(_conexao);

            if (string.IsNullOrWhiteSpace(txt_tipoServ.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                servico.tipo = txt_tipoServ.Text;
                
                servico.descricao = txt_descricao.Text.Trim();
               
                //lugar.preco = msktb_precoLugar.Text;

                string inputPreco = txt_preco.Text;
                decimal preco;

                // Cambia CultureInfo según el formato que uses (coma o punto)
                if (decimal.TryParse(inputPreco, NumberStyles.Number, new CultureInfo("pt-BR"), out preco))
                {
                    servico.preco = preco;

                    // ✅ Si todo fue bien, continuar con el guardado
                    // Aquí podrías guardar en la base de datos, mostrar mensaje, etc.

                    servico_DAO.InserirServico(servico);

                    MessageBox.Show("Servico guardado correctamente.");


                    txt_tipoServ.Text = string.Empty;
                    txt_descricao.Text = string.Empty;
                    txt_preco.Text = string.Empty;



                    txt_tipoServ.Focus();
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
