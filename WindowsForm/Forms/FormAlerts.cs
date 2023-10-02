using WindowsForm.Forms;

namespace WindowsForm
{
    public partial class FormAlerts : Form
    {
        private FormMenu formMenu;
        
        public FormAlerts(FormMenu formMenu)
        {
            InitializeComponent();

            this.formMenu = formMenu;
        }

        // Alerta Simples
        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Mensagem Simples para o Usu�rio.");
        }

        // Alerta Simples com T�tulo
        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Conte�do da mensagem", "T�tulo da Mensagem");
        }

        // Alerta com Sim ou N�o
        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Vamos estudar C#?", "T�tulo da Mensagem", MessageBoxButtons.YesNo);

            if (retorno == DialogResult.Yes)
            {
                MessageBox.Show("Clicou em Sim");
            }
            else if (retorno == DialogResult.No)
            {
                MessageBox.Show("Clicou em N�o");
            }
        }

        // Alerta com Sim, N�o e Cancelar
        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Gostou do resumo?", "T�tulo da Mensagem",
                                                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        // Alerta Cr�tico / Sonoro
        private void button5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ouviu o som do sistema?", "T�tulo da Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        // Bot�o para Retornar ao Formul�rio de Menu
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Exibe o formul�rio principal (FormMenu)
            formMenu.Show();

            // Fecha o FormAlerts
            this.Close();
        }
    }
}