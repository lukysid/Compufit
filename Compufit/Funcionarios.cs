using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Compufit
{
    public partial class Funcionarios : Form
    {
        private static readonly HttpClient client = new HttpClient();

        private Button botaoAtivo; 

        public Funcionarios()
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
            
            this.txtMatricula.Clear();
            this.txtNome.Clear();
            this.txtRg.Clear();
            this.txtCpf.Clear();
            this.txtDtNascimento.Clear();
            this.txtEmail.Clear();
            this.txtTelefone.Clear();
            this.txtCelular.Clear();
            this.txtCep.Clear();
            this.txtEndereço.Clear();
            this.txtNumero.Clear();
            this.txtCidade.Clear();
            this.txtSenha.Clear();

            
            this.cbxCargo.SelectedIndex = -1;
            this.cbxEstado.SelectedIndex = -1;
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
            cbxCargo.Enabled = true;
            txtEmail.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;

            txtCep.ReadOnly = false;
            txtEndereço.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtCidade.ReadOnly = false;
            cbxEstado.Enabled = true;

            lblSenha.Visible = true ;
            txtSenha.Visible = true ;
                       
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastroFuncionarios funcionario = new CadastroFuncionarios
            {
                Nome = txtNome.Text,
                RG = txtRg.Text,
                CPF = txtCpf.Text,
                DataNascimento = txtDtNascimento.Text,
                Cargo = cbxCargo.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Celular = txtCelular.Text,
                CEP = txtCep.Text,
                Endereco = txtEndereço.Text,
                Numero = txtNumero.Text,
                Cidade = txtCidade.Text,
                Estado = cbxEstado.Text,
                Senha = txtSenha.Text

               
            };

            if (!string.IsNullOrEmpty(txtMatricula.Text))
            {
                
                int matricula = int.Parse(txtMatricula.Text); 
                if (funcionario.Atualizar(matricula))
                {
                    MessageBox.Show("Funcionário atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar funcionário.");
                }
            }
            else
            {
                
                if (funcionario.Gravar())
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar funcionário.");
                }
            }

            Carregar();
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            try
            {
                Carregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Carregar()
        {
            try
            {
                
                BindingSource dados = new BindingSource();
                dados.DataSource = new CadastroFuncionarios().CarregarDados();
                dtgFuncionarios.DataSource = dados;
               

                grbAcoes.Visible = false;


                txtNome.ReadOnly = true;
                txtRg.ReadOnly = true;
                txtCpf.ReadOnly = true;
                txtDtNascimento.ReadOnly = true;
                cbxCargo.Enabled = false;
                txtEmail.ReadOnly = true;
                txtTelefone.ReadOnly = true;
                txtCelular.ReadOnly = true;

                txtCep.ReadOnly = true;
                txtEndereço.ReadOnly = true;
                txtNumero.ReadOnly = true;
                txtCidade.ReadOnly = true;
                cbxEstado.Enabled = false;
               

                lblSenha.Visible = false;
                txtSenha.Visible = false;

                dtgFuncionarios.Enabled = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AtivarBotao((Button)sender);
            Carregar();
        }

        private void dtgFuncionarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.txtMatricula.Text = this.dtgFuncionarios.CurrentRow.Cells["Matricula"].Value?.ToString();
            this.txtNome.Text = this.dtgFuncionarios.CurrentRow.Cells["Nome"].Value?.ToString();
            this.txtRg.Text = this.dtgFuncionarios.CurrentRow.Cells["RG"].Value?.ToString();
            this.txtCpf.Text = this.dtgFuncionarios.CurrentRow.Cells["CPF"].Value?.ToString();
            this.txtDtNascimento.Text = this.dtgFuncionarios.CurrentRow.Cells["DataNascimento"].Value?.ToString();
            this.cbxCargo.Text = this.dtgFuncionarios.CurrentRow.Cells["Cargo"].Value?.ToString();
            this.txtEmail.Text = this.dtgFuncionarios.CurrentRow.Cells["Email"].Value?.ToString();
            this.txtTelefone.Text = this.dtgFuncionarios.CurrentRow.Cells["Telefone"].Value?.ToString();
            this.txtCelular.Text = this.dtgFuncionarios.CurrentRow.Cells["Celular"].Value?.ToString();
            this.txtCep.Text = this.dtgFuncionarios.CurrentRow.Cells["CEP"].Value?.ToString();
            this.txtEndereço.Text = this.dtgFuncionarios.CurrentRow.Cells["Endereco"].Value?.ToString();
            this.txtNumero.Text = this.dtgFuncionarios.CurrentRow.Cells["Numero"].Value?.ToString();
            this.txtCidade.Text = this.dtgFuncionarios.CurrentRow.Cells["Cidade"].Value?.ToString();
            this.cbxEstado.Text = this.dtgFuncionarios.CurrentRow.Cells["Estado"].Value?.ToString();
            this.txtSenha.Text = this.dtgFuncionarios.CurrentRow.Cells["Senha"].Value?.ToString();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AtivarBotao((Button)sender);


            grbAcoes.Visible = true;


            txtNome.ReadOnly = false;
            txtRg.ReadOnly = false;
            txtCpf.ReadOnly = false;
            txtDtNascimento.ReadOnly = false;
            cbxCargo.Enabled = true;
            txtEmail.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;

            txtCep.ReadOnly = false;
            txtEndereço.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtCidade.ReadOnly = false;
            cbxEstado.Enabled = true;

            lblSenha.Visible = true;
            txtSenha.Visible = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            if (this.dtgFuncionarios.CurrentRow != null)
            {
                int matricula = Convert.ToInt32(this.dtgFuncionarios.CurrentRow.Cells["Matricula"].Value);

                var result = MessageBox.Show("Tem certeza que deseja excluir este funcionário?",
                                             "Excluir Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    
                    CadastroFuncionarios funcionario = new CadastroFuncionarios();
                    bool sucesso = funcionario.Deletar(matricula);

                    if (sucesso)
                    {
                        MessageBox.Show("Funcionário excluído com sucesso!");
                        Carregar();  
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir o funcionário.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para excluir.");
            }
        }
    }
}

