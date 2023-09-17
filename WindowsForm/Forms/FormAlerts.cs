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
            MessageBox.Show("Mensagem Simples para o Usu�rio.");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Conte�do da mensagem", "T�tulo da Mensagem");
        }

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

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Gostou do resumo?", "T�tulo da Mensagem",
                                                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ouviu o som do sistema?", "T�tulo da Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}