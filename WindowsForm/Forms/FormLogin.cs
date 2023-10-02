using MySql.Data.MySqlClient;
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
        private FormMenu formMenu;

        public FormLogin(FormMenu formMenu)
        {
            InitializeComponent();

            this.formMenu = formMenu;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Confere se todos os campos foram preenchidos
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var strConexao = "server=localhost;uid=root;database=meubd";

                    var conexao = new MySqlConnection(strConexao);
                    conexao.Open();

                    var comando = new MySqlCommand($"SELECT * FROM cadastro WHERE cadastro.login = '{txtUsuario.Text}' AND cadastro.senha = '{txtSenha.Text}'", conexao);
                    var reader = comando.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        MessageBox.Show("Login e Senha Corretos!", "Você conseguiu!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsuario.Text = "";
                        txtSenha.Text = "";
                        txtUsuario.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Email e/ou senha informados são inválidos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsuario.Text = "";
                        txtSenha.Text = "";
                        txtUsuario.Focus();
                    }

                    conexao.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtUsuario.Focus();
        }

        private void lblCriarConta_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro(this);
            formCadastro.Show();

            this.Hide();
        }

        private void lblVoltar_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            this.Close();
        }

        private void checkBoxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrar.Checked)
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }
    }
}
