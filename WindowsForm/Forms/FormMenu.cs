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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin(this);
            formLogin.Show();

            // Esconde o Menu
            this.Hide();
        }

        private void btnAPI1_Click(object sender, EventArgs e)
        {
            FormAPI formAPI = new FormAPI(this);
            formAPI.Show();

            // Esconde o Menu
            this.Hide();
        }

        private void btnAPI2_Click(object sender, EventArgs e)
        {
            FormAPIObject formAPIObject = new FormAPIObject(this);
            formAPIObject.Show();

            // Esconde o Menu
            this.Hide();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            // Fecha o programa
            this.Close();
        }
    }
}
