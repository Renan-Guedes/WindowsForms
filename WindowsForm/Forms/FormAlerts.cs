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
            MessageBox.Show("Mensagem Simples para o Usuário.");
        }

        // Alerta Simples com Título
        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Conteúdo da mensagem", "Título da Mensagem");
        }

        // Alerta com Sim ou Não
        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Vamos estudar C#?", "Título da Mensagem", MessageBoxButtons.YesNo);

            if (retorno == DialogResult.Yes)
            {
                MessageBox.Show("Clicou em Sim");
            }
            else if (retorno == DialogResult.No)
            {
                MessageBox.Show("Clicou em Não");
            }
        }

        // Alerta com Sim, Não e Cancelar
        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Gostou do resumo?", "Título da Mensagem",
                                                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        // Alerta Crítico / Sonoro
        private void button5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ouviu o som do sistema?", "Título da Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        // Botão para Retornar ao Formulário de Menu
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Exibe o formulário principal (FormMenu)
            formMenu.Show();

            // Fecha o FormAlerts
            this.Close();
        }
    }
}