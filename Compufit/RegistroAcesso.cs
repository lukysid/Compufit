using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Compufit
{
    public partial class RegistroAcesso : Form
    {
        public RegistroAcesso()
        {
            InitializeComponent();
        }

        private void groupBox20_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Por favor, insira o ID (Matrícula) do cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!int.TryParse(txtMatricula.Text, out int matricula))
            {
                MessageBox.Show("A matrícula deve ser um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                
                CadastroClientes cadastroClientes = new CadastroClientes();
                CadastroClientes cliente = cadastroClientes.PesquisarPorId(matricula);

                if (cliente != null)
                {
                    
                    txtNome.Text = cliente.Nome;
                    txtRg.Text = cliente.RG;
                    txtCpf.Text = cliente.CPF;
                    txtDtNascimento.Text = cliente.DataNascimento;
                    txtEmail.Text = cliente.Email;
                    txtTelefone.Text = cliente.Telefone;
                    txtCelular.Text = cliente.Celular;
                }
                else
                {
                    
                    MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                
                CadastroRegistroAcesso cadastroRegistroAcesso = new CadastroRegistroAcesso();
                DataTable dadosMovimentacoes = cadastroRegistroAcesso.PesquisarPorMatricula(matricula);

                
                if (dadosMovimentacoes.Rows.Count > 0)
                {
                    
                    dtgRegistroAcesso.DataSource = dadosMovimentacoes;  // dgvMovimentacoes é o nome do seu DataGridView

                    
                    DateTime primeiraData = Convert.ToDateTime(dadosMovimentacoes.Rows[0]["DataHora"]);
                    txtDtCadastro.Text = primeiraData.ToString("dd/MM/yyyy HH:mm:ss");

                    
                    DateTime ultimaData = Convert.ToDateTime(dadosMovimentacoes.Rows[dadosMovimentacoes.Rows.Count - 1]["DataHora"]);
                    txtDtUltimaVisita.Text = ultimaData.ToString("dd/MM/yyyy HH:mm:ss");

                    
                    int totalRegistros = dadosMovimentacoes.Rows.Count;
                    double totalDivididoPor2 = (double)totalRegistros / 2;
                    int resultadoArredondado = (int)Math.Ceiling(totalDivididoPor2); 
                    txtTotalVisitas.Text = resultadoArredondado.ToString(); 

                   
                    double totalVisitasPorSemana = dadosMovimentacoes.AsEnumerable()
                        .GroupBy(row => GetStartOfWeek(Convert.ToDateTime(row["DataHora"])))  
                        .Sum(group => group.Count() / 2.0);  

                    
                    int visitasPorSemanaArredondado = (int)Math.Ceiling(totalVisitasPorSemana);  

                   
                    txtVisitasPorSemana.Text = visitasPorSemanaArredondado.ToString(); 

                }
                else
                {
                   
                    MessageBox.Show("Não foram encontradas movimentações para esta matrícula.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDtCadastro.Clear();
                    txtDtUltimaVisita.Clear();
                    txtTotalVisitas.Clear();
                    txtVisitasPorSemana.Clear();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Erro ao buscar informações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private DateTime GetStartOfWeek(DateTime date)
        {
            var diff = date.DayOfWeek - DayOfWeek.Monday;
            if (diff < 0) diff += 7;
            return date.AddDays(-diff).Date;  
        }
    }
}
