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
    public partial class frmCad_Usuarios : Form
    {

        string _conexao = orgEventos1.Properties.Settings.Default.conexao;

        public frmCad_Usuarios()
        {
            InitializeComponent();
        }





        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();

            Usuarios_DAO usuarios_dao = new Usuarios_DAO(_conexao);

            if (string.IsNullOrEmpty(txtBox_NomeUsuario.Text))
            {
                MessageBox.Show("Preencha todos os campos necessarios por favor", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                try
                {

                    usuarios.NomeUsuario = txtBox_NomeUsuario.Text;
                    usuarios.Senha = txtBox_Senha.Text;


                    usuarios_dao.IncluirUsuarios(usuarios);

                    MessageBox.Show("Cadastro com Sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtBox_NomeUsuario.Text = string.Empty;
                    txtBox_Senha.Text = string.Empty;

                    txtBox_NomeUsuario.Focus();


                }

                catch (Exception erro)
                {
                    // Mostra uma mensagem de erro caso algo dê errado durante o processo
                    MessageBox.Show("Ocorreu um erro" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
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
    }
}
