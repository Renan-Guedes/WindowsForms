using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.DAL;
using WindowsForm.Models;
using static System.Net.WebRequestMethods;

namespace WindowsForm.Forms
{
    public partial class FormAPI : Form
    {
        public FormAPI()
        {
            InitializeComponent();
        }

        string strURL = "https://economia.awesomeapi.com.br/last/USD-BRL";

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            ConsultaDolar consultaDolar = new ConsultaDolar();
            var resultadoConsulta = consultaDolar.RealizaConsulta(this.strURL);

            lblCompra.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", resultadoConsulta.Data.Compra);
            lblVenda.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", resultadoConsulta.Data.Venda);
            lblVariacao.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", resultadoConsulta.Data.PctVariacao);
        }
    }
}
