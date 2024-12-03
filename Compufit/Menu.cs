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
    public partial class Menu : Form
    {
        private string nomeUsuario;
        public Menu(string nome)
        {
            InitializeComponent();
            nomeUsuario = nome;
        }

        private Button botaoAtivo; 


        private void btmSide_Click(object sender, EventArgs e)
        {
            if(MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AtivarBotao(Button botao)
        {
            
            if (botaoAtivo != null)
            {
                botaoAtivo.BackColor = Color.DarkOrange; 
                botaoAtivo.ForeColor = Color.White; 
                botaoAtivo.FlatAppearance.BorderSize = 0; 
            }

            
            botao.BackColor = Color.Black; 
            botao.ForeColor = Color.White; 
            botao.FlatAppearance.BorderSize = 0; 

            
            botaoAtivo = botao;
        }


        private void AbrirFormularioNoPainel(Form formulario)
        {
            
            pnlConteudo.Controls.Clear();

            
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            
            pnlConteudo.Controls.Add(formulario);
            pnlConteudo.Tag = formulario;
            formulario.Show();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            AtivarBotao((Button)sender);

            
            Funcionarios formFuncionarios = new Funcionarios();

            
            AbrirFormularioNoPainel(formFuncionarios);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AtivarBotao((Button)sender);

            
            Clientes formClientes = new Clientes();

            
            AbrirFormularioNoPainel(formClientes);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            AtivarBotao((Button)sender);

            
            RegistroAcesso formAcesso = new RegistroAcesso();

            
            AbrirFormularioNoPainel(formAcesso);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AtivarBotao((Button)sender);

            
            Inicio formInicio = new Inicio();

            
            AbrirFormularioNoPainel(formInicio);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblNome.Text = "Bem-vindo, " + nomeUsuario;
        }
    }
}
