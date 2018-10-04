using GeradorSenhaBase64.Regra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorSenhaBase64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RGerarSenha rGerarSenha = new RGerarSenha();

        private void btnGerarSenha_Click(object sender, EventArgs e)
        {
            int i = dgvUsuarioSenha.RowCount;
            if ( (txbUsuario.Text != "" && txbDiretorio.Text != "") 
                || (dgvUsuarioSenha.RowCount > 1))
            {
                if (txbUsuario.Text != "" && txbDiretorio.Text != "")
                {
                    string pathPlanilhaUsuario = txbUsuario.Text;
                    string pathNovaPlanilha = txbDiretorio.Text;

                    rGerarSenha.gerarSenha(pathPlanilhaUsuario, pathNovaPlanilha);

                    MessageBox.Show("Senhas criadas com sucesso.", "Info");
                }
                else if (dgvUsuarioSenha.RowCount > 1)
                {
                    foreach(DataGridViewRow dr in dgvUsuarioSenha.Rows)
                    {
                        if(dr.Cells[0].Value != null)
                        {
                            string usuLogin = dr.Cells[0].Value.ToString();
                            string usuSenha = rGerarSenha.criarSenha(usuLogin);
                            dr.Cells[1].Value = usuSenha;
                        }
                    }
                    MessageBox.Show("Senhas criadas com sucesso.", "Info");
                }                

            }
            else if (txbUsuario.Text == "" && txbDiretorio.Text == "")
            {
                MessageBox.Show("É necessário preencher os campos.", "Atenção");
            }
            else if(txbUsuario.Text == null)
            {
                MessageBox.Show("É necessário informar a planilha que será lida", "Atenção");
            }
            else
            {
                MessageBox.Show("É necessário informar o diretório que deseja salvar a planilha", "Atenção");
            }
        }

        private void btnBuscarPlanilha_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Excel Worksheets|*.xlsx";
            openFileDialog.FileName = "";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string local = openFileDialog.FileName;
                txbUsuario.Text = local;
            }
        }

        private void btnDiretorio_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txbDiretorio.Text = folderBrowserDialog.SelectedPath.ToString();
            }
        }

        private void btnLimpaGrid_Click(object sender, EventArgs e)
        {
            dgvUsuarioSenha.Rows.Clear();
        }
    }
}
