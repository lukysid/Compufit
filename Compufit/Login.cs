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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pictureBox2;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtFuncionario.Text == "Funcionário")
            {
                txtFuncionario.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtFuncionario.Text == "")
            {
                txtFuncionario.Text = "Funcionário";
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.PasswordChar = '*';
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.PasswordChar = '\0';
                txtSenha.Text = "Senha";
                
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            string nome = txtFuncionario.Text;
            string senha = txtSenha.Text;

            
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha ambos os campos de nome e senha.");
                return;
            }

            
            CadastroFuncionarios funcionario = new CadastroFuncionarios();
            bool autenticado = funcionario.Autenticar(nome, senha);

            if (autenticado)
            {
                
                Menu menu = new Menu(nome);
                menu.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Nome ou senha inválidos. Tente novamente.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
