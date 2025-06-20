﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using orgEventos1_DATA;

namespace orgEventos1
{   

    public partial class frm_ConsultarEventos : Form
    {
        string _conexao = orgEventos1.Properties.Settings.Default.conexao;

        public frm_ConsultarEventos()
        {
            InitializeComponent();
            ListarEvento();
           
        }

        private void ListarEvento()
        {
            Evento_DAO eventoDAO = new Evento_DAO(_conexao);
            var listaEventos = eventoDAO.ListarEventosDetalhados();

            dtgv_ConsultarEvento.DataSource = listaEventos; // asigna la lista

            // Cambia los headers según los nombres de propiedades
            dtgv_ConsultarEvento.Columns["nomeCliente"].HeaderText = "Cliente";
            dtgv_ConsultarEvento.Columns["nomeLugar"].HeaderText = "Lugar";
            dtgv_ConsultarEvento.Columns["DataEvento"].HeaderText = "Data";
            dtgv_ConsultarEvento.Columns["HoraInicio"].HeaderText = "Início";
            dtgv_ConsultarEvento.Columns["HoraFim"].HeaderText = "Fim";

            // Opcional: formatear columnas fecha y hora
            dtgv_ConsultarEvento.Columns["DataEvento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgv_ConsultarEvento.Columns["HoraInicio"].DefaultCellStyle.Format = @"hh\:mm";
            dtgv_ConsultarEvento.Columns["HoraFim"].DefaultCellStyle.Format = @"hh\:mm";
        }

        //private void CarregarEventos()
        //{
        //    Evento_DAO eventoDAO = new Evento_DAO(_conexao);
        //    var listaEventos = eventoDAO.ListarEventosDetalhados();

        //    dtgv_ConsultarEvento.DataSource = listaEventos; // asigna la lista

        //    // Cambia los headers según los nombres de propiedades
        //    dtgv_ConsultarEvento.Columns["nomeCliente"].HeaderText = "Cliente";
        //    dtgv_ConsultarEvento.Columns["nomeLugar"].HeaderText = "Lugar";
        //    dtgv_ConsultarEvento.Columns["DataEvento"].HeaderText = "Data";
        //    dtgv_ConsultarEvento.Columns["HoraInicio"].HeaderText = "Início";
        //    dtgv_ConsultarEvento.Columns["HoraFim"].HeaderText = "Fim";

        //    // Opcional: formatear columnas fecha y hora
        //    dtgv_ConsultarEvento.Columns["DataEvento"].DefaultCellStyle.Format = "dd/MM/yyyy";
        //    dtgv_ConsultarEvento.Columns["HoraInicio"].DefaultCellStyle.Format = @"hh\:mm";
        //    dtgv_ConsultarEvento.Columns["HoraFim"].DefaultCellStyle.Format = @"hh\:mm";
        //}




        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            frm_CadEvento frmcadevento = new frm_CadEvento();
            frmcadevento.ShowDialog();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dtgv_ConsultarEvento.SelectedRows.Count > 0)
            {
                // Pega o código do médico da linha selecionada
                int codigo = Convert.ToInt32(dtgv_ConsultarEvento.CurrentRow.Cells[0].Value);

                // Exibe um MessageBox de confirmação
                var resultado = MessageBox.Show(
                    "Deseja excluir esse registro?",
                    "Pergunta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                // Se o usuário confirmar a exclusão
                if (resultado == DialogResult.Yes)
                {
                    // Cria o DAO e exclui o médico
                    Evento_DAO evento_dao = new Evento_DAO(_conexao);
                    evento_dao.ExcluirEvento(codigo);

                    // Atualiza a lista após exclusão
                    ListarEvento();
                }
                else
                {
                    // Caso não tenha selecionado nada ou cancele, exibe aviso
                    MessageBox.Show(
                        "Selecione um registro para exclusão!",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_pesqusiarCliente_Click(object sender, EventArgs e)
        {
            if (txt_BuscarEvento.Text == "")
            {
                MessageBox.Show("Informe um conteúdo!"); // Alerta se não foi digitado nada
                txt_BuscarEvento.Focus(); // Coloca o cursor no campo de texto
                ListarEvento(); // Lista todos os serviços (sem filtro)
                return;
            }

            ListarEvento(); // Realiza a busca filtrada
        }

        private void btn_sairConsultaCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
