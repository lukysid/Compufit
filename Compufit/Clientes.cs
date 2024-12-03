using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Compufit
{
    public partial class Clientes : Form
    {
        private static readonly HttpClient client = new HttpClient();

        private Button botaoAtivo; 

        public Clientes()
        {
            InitializeComponent();
        }

        private void AtivarBotao(Button botao)
        {
            if (botaoAtivo != null)
            {
                botaoAtivo.BackColor = Color.DarkOrange; 
                botaoAtivo.FlatAppearance.BorderSize = 1;
            }

            botao.BackColor = Color.DarkOrange;            
            botao.FlatAppearance.BorderSize = 2;
            botao.FlatAppearance.BorderColor = Color.Black;

            botaoAtivo = botao;
        }

        private void Limpar()
        {
            txtMatricula.Clear();
            txtNome.Clear();
            txtRg.Clear();
            txtCpf.Clear();
            txtDtNascimento.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtCep.Clear();
            txtEndereço.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            cbxEstado.SelectedIndex = -1;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string cep = txtCep.Text;

            if (string.IsNullOrEmpty(cep))
            {
                MessageBox.Show("Por favor, insira um CEP válido!");
                return;
            }

            string url = $"https://viacep.com.br/ws/{cep}/json/";

            try
            {
                var response = await client.GetStringAsync(url);
                var endereco = JObject.Parse(response);

                if (endereco["erro"] != null && (bool)endereco["erro"] == true)
                {
                    MessageBox.Show("CEP não encontrado.");
                    return;
                }

                txtEndereço.Text = endereco["logradouro"]?.ToString() ?? "Não informado";
                txtCidade.Text = endereco["localidade"]?.ToString() ?? "Não informado";
                cbxEstado.Text = endereco["uf"]?.ToString() ?? "Não informado";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar o CEP: {ex.Message}");
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AtivarBotao((Button)sender);
            Limpar();
            grbAcoes.Visible = true;

            txtNome.ReadOnly = false;
            txtRg.ReadOnly = false;
            txtCpf.ReadOnly = false;
            txtDtNascimento.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;
            txtCep.ReadOnly = false;
            txtEndereço.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtCidade.ReadOnly = false;
            cbxEstado.Enabled = true;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastroClientes cliente = new CadastroClientes
            {
                Nome = txtNome.Text,
                RG = txtRg.Text,
                CPF = txtCpf.Text,
                DataNascimento = txtDtNascimento.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Celular = txtCelular.Text,
                CEP = txtCep.Text,
                Endereco = txtEndereço.Text,
                Numero = txtNumero.Text,
                Cidade = txtCidade.Text,
                Estado = cbxEstado.Text
            };

            if (!string.IsNullOrEmpty(txtMatricula.Text))
            {
                int matricula = int.Parse(txtMatricula.Text);
                if (cliente.Atualizar(matricula))
                {
                    MessageBox.Show("Cliente atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar cliente2.");
                }
            }
            else
            {
                if (cliente.Gravar())
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar cliente3.");
                }
            }

            Carregar();
        }
        


        private void Carregar()
        {
            try
            {
                BindingSource dados = new BindingSource
                {
                    DataSource = new CadastroClientes().CarregarDados()
                };
                dtgClientes.DataSource = dados;

                grbAcoes.Visible = false;

                txtNome.ReadOnly = true;
                txtRg.ReadOnly = true;
                txtCpf.ReadOnly = true;
                txtDtNascimento.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtTelefone.ReadOnly = true;
                txtCelular.ReadOnly = true;
                txtCep.ReadOnly = true;
                txtEndereço.ReadOnly = true;
                txtNumero.ReadOnly = true;
                txtCidade.ReadOnly = true;
                cbxEstado.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Carregar();
        }

        private void dtgClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMatricula.Text = dtgClientes.CurrentRow.Cells["Matricula"].Value?.ToString();
            txtNome.Text = dtgClientes.CurrentRow.Cells["Nome"].Value?.ToString();
            txtRg.Text = dtgClientes.CurrentRow.Cells["RG"].Value?.ToString();
            txtCpf.Text = dtgClientes.CurrentRow.Cells["CPF"].Value?.ToString();
            txtDtNascimento.Text = dtgClientes.CurrentRow.Cells["DataNascimento"].Value?.ToString();
            txtEmail.Text = dtgClientes.CurrentRow.Cells["Email"].Value?.ToString();
            txtTelefone.Text = dtgClientes.CurrentRow.Cells["Telefone"].Value?.ToString();
            txtCelular.Text = dtgClientes.CurrentRow.Cells["Celular"].Value?.ToString();
            txtCep.Text = dtgClientes.CurrentRow.Cells["CEP"].Value?.ToString();
            txtEndereço.Text = dtgClientes.CurrentRow.Cells["Endereco"].Value?.ToString();
            txtNumero.Text = dtgClientes.CurrentRow.Cells["Numero"].Value?.ToString();
            txtCidade.Text = dtgClientes.CurrentRow.Cells["Cidade"].Value?.ToString();
            cbxEstado.Text = dtgClientes.CurrentRow.Cells["Estado"].Value?.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AtivarBotao((Button)sender);
            grbAcoes.Visible = true;

            txtNome.ReadOnly = false;
            txtRg.ReadOnly = false;
            txtCpf.ReadOnly = false;
            txtDtNascimento.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;
            txtCep.ReadOnly = false;
            txtEndereço.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtCidade.ReadOnly = false;
            cbxEstado.Enabled = true;
        }       

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dtgClientes.CurrentRow != null)
            {
                int matricula = Convert.ToInt32(dtgClientes.CurrentRow.Cells["Matricula"].Value);

                var result = MessageBox.Show("Tem certeza que deseja excluir este cliente?",
                                             "Excluir Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    CadastroClientes cliente = new CadastroClientes();
                    bool sucesso = cliente.Deletar(matricula);

                    if (sucesso)
                    {
                        MessageBox.Show("Cliente excluído com sucesso!");
                        Carregar();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir o cliente.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para excluir.");
            }
        }

        private void Clientes_Load_1(object sender, EventArgs e)
        {
            Carregar();
        }
    }
}
