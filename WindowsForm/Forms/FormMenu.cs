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

        private void MenuAlertas_Click(object sender, EventArgs e)
        {
            FormAlerts formAlerts = new FormAlerts();
            formAlerts.ShowDialog();
        }

        private void MenuLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consumoDeAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAPI formAPI = new FormAPI();
            formAPI.ShowDialog();
        }
    }
}
