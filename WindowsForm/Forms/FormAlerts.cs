namespace WindowsForm
{
    public partial class FormAlerts : Form
    {
        public FormAlerts()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Mensagem Simples para o Usuário.");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Conteúdo da mensagem", "Título da Mensagem");
        }

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

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Gostou do resumo?", "Título da Mensagem",
                                                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ouviu o som do sistema?", "Título da Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}