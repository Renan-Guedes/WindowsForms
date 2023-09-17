using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Informa ao usuário qual o Login e a Senha antes de iniciar o formulário
            MessageBox.Show("Login: admin\nSenha: 123", "Informações sobre o Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se o login está correto
                if (txtUsuario.Text.Equals("admin") && txtSenha.Text.Equals("123"))
                {
                    MessageBox.Show("Você conseguiu passar :D", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Verifica se não algum campo não foi preenchido
                else if (txtUsuario.Text.Equals("") || txtSenha.Text.Equals(""))
                {
                    MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSenha.Text = "";
                }
                // Informa ao usuário caso os campos não estejam corretos
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos", "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Text = "";
                    txtSenha.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            // Troca a cor do campo quando Usuário está clicado
            txtUsuario.BackColor = Color.LightYellow;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            // Troca a cor do campo quando Usuário deixa de ser clicado
            txtUsuario.BackColor = Color.White;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            // Troca a cor do campo quando Senha está clicado
            txtSenha.BackColor = Color.LightYellow;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            // Troca a cor do campo quando Senha deixa de ser clicado
            txtSenha.BackColor = Color.White;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            // Limita o que é escrito no campo Usuário para apenas letras e números 
            if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 08)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras ou números", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
            }
        }
    }
}
