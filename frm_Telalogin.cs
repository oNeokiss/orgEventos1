using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using orgEventos1_DATA;

namespace orgEventos1
{
    public partial class frm_Telalogin : Form
    {
        Thread fechar;

        string _conexao = orgEventos1.Properties.Settings.Default.conexao;

        public frm_Telalogin()
        {
            InitializeComponent();
        }

        private void btn_sairLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            string nome = txtBox_NomeUsuario.Text;
            string senha = txtBox_Senha.Text;

            if (txtBox_NomeUsuario.Text == "" || txtBox_Senha.Text == "")
            {
                MessageBox.Show("Preencha os campos!"); // Exibe alerta
                txtBox_NomeUsuario.Focus(); // Retorna o foco à caixa de texto
                return; // Encerra o método
            }



            EntrarUsuarios();

        }

        private void EntrarUsuarios()
        {
            Usuarios_DAO usuarios_dao = new Usuarios_DAO(_conexao);

            string nome = txtBox_NomeUsuario.Text.ToString(); // Obtém o texto digitado na caixa de busca
            string senha = txtBox_Senha.Text.ToString();

            DataSet dsUsuarios = new DataSet(); // Cria um DataSet para armazenar os dados retornados
            dsUsuarios = usuarios_dao.LoginUsuario(nome, senha); // 


            if (dsUsuarios.Tables[0].Rows.Count > 0)
            {
                // frmTelaInicial frmTelaInical = new frmTelaInicial();
                //  frmTelaInical.ShowDialog();
                this.Close();
                fechar = new Thread(TelaInicial);
                fechar.SetApartmentState(ApartmentState.STA);
                fechar.Start();

            }

            else
            {
                MessageBox.Show("Nome de Usuário ou/e senha incorretos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TelaInicial(Object obj)
        {
            Application.Run(new frm_TelaPrincipal());
        }

        private void cBox_MostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_MostrarSenha.Checked)
            {
                txtBox_Senha.PasswordChar = '\0'; // Mostrar senha
            }
            else
            {
                txtBox_Senha.PasswordChar = '*'; // Ocultar senha
            }
        }

        private void cBox_MostrarSenha_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cBox_MostrarSenha.Checked)
            {
                txtBox_Senha.PasswordChar = '\0'; // Mostrar senha
            }
            else
            {
                txtBox_Senha.PasswordChar = '*'; // Ocultar senha
            }
        }
    }
    
}
