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
    public partial class FormCadastro : Form
    {
        private FormLogin formLogin;

        public FormCadastro(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            // Confere se todos os campos foram preenchidos
            if (txtUsuario.Text == "" || txtSenha.Text == "" || txtConfirme.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Confere se os campos "senha" e "confirme a senha" estão iguais
            else if (txtSenha.Text == txtConfirme.Text)
            {
                try
                {
                    var strConexao = "server=localhost;uid=root;database=meubd";
                    var conexao = new MySqlConnection(strConexao);

                    //Abre a conexão com o Banco de Dados
                    conexao.Open();

                    var comando = new MySqlCommand($"INSERT INTO cadastro (login, senha) VALUE (('{txtUsuario.Text}'), ('{txtSenha.Text}'))", conexao);
                    var reader = comando.ExecuteReader();

                    //Fecha a conexão com o Banco de Dados
                    reader.Close();

                    MessageBox.Show("Registro realizado com sucesso!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                    txtConfirme.Text = "";
                    txtUsuario.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (txtUsuario.Text != txtConfirme.Text)
            {
                MessageBox.Show("A senha e a confirmação precisam ser iguais", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtConfirme.Text = "";
            txtUsuario.Focus();
        }

        private void lblRetornar_Click(object sender, EventArgs e)
        {
            formLogin.Show();
            this.Close();
        }

        private void checkBoxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrar.Checked)
            {
                txtSenha.PasswordChar = '\0';
                txtConfirme.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
                txtConfirme.PasswordChar = '*';
            }
        }
    }
}
