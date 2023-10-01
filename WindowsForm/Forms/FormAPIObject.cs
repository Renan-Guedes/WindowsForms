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
        public FormAPIObject()
        {
            InitializeComponent();
        }

        string strUrl = "https://jsonplaceholder.typicode.com/todos/";

        private async void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaUsers consultaUsers = new ConsultaUsers();
                var resultadoConsulta = await consultaUsers.RealizaConsulta(this.strUrl);

                listBox.Items.Clear();

                foreach (var user in resultadoConsulta)
                {
                    listBox.Items.Add($"{user.Id} - {user.Title}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo deu errado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
