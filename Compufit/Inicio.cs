using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compufit
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtMatriculaEntrada.Text))
            {
                MessageBox.Show("Por favor, insira uma matrícula.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMatriculaEntrada.Text, out int matricula))
            {
                MessageBox.Show("A matrícula deve ser um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            var registroAcesso = new CadastroRegistroAcesso
            {
                Matricula = matricula,
                Tipo = "Entrada",
                DataHora = DateTime.Now
            };

            
            bool sucesso = registroAcesso.Gravar();
            if (sucesso)
            {
                MessageBox.Show("Movimentação inserida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao inserir movimentação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {

            
            if (string.IsNullOrWhiteSpace(txtMatriculaSaida.Text))
            {
                MessageBox.Show("Por favor, insira uma matrícula.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMatriculaSaida.Text, out int matricula))
            {
                MessageBox.Show("A matrícula deve ser um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            var registroAcesso = new CadastroRegistroAcesso
            {
                Matricula = matricula,
                Tipo = "Saida",
                DataHora = DateTime.Now
            };

            
            bool sucesso = registroAcesso.Gravar();
            if (sucesso)
            {
                MessageBox.Show("Movimentação inserida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao inserir movimentação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
