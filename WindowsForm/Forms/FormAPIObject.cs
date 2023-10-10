using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.DAL;

namespace WindowsForm.Forms
{
    public partial class FormAPIObject : Form
    {
        private FormMenu formMenu;

        public FormAPIObject(FormMenu formMenu)
        {
            InitializeComponent();

            this.formMenu = formMenu;
        }

        string strURL = "https://jsonplaceholder.typicode.com/todos/";

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaUsers consultaUsers = new ConsultaUsers();
                var resultadoConsulta = await consultaUsers.RealizaConsulta(this.strURL);

                listBox1.Items.Clear();

                foreach (var user in resultadoConsulta)
                {
                    listBox1.Items.Add($"{user.Id} - {user.Title}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo deu errado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            // Exibe o formulário principal (FormMenu)
            formMenu.Show();

            // Fecha o Formulário atual
            this.Close();
        }
    }
}
