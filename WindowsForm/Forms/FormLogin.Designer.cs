namespace WindowsForm.Forms
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            checkBoxMostrar = new CheckBox();
            btnLogin = new Button();
            btnApagar = new Button();
            label4 = new Label();
            txtSenha = new TextBox();
            label3 = new Label();
            lblCriarConta = new Label();
            txtUsuario = new TextBox();
            lblVoltar = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(89, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 38);
            label1.TabIndex = 0;
            label1.Text = "Tela de Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(52, 80);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 1;
            label2.Text = "Usuário";
            // 
            // checkBoxMostrar
            // 
            checkBoxMostrar.AutoSize = true;
            checkBoxMostrar.Location = new Point(163, 235);
            checkBoxMostrar.Name = "checkBoxMostrar";
            checkBoxMostrar.Size = new Size(138, 24);
            checkBoxMostrar.TabIndex = 3;
            checkBoxMostrar.Text = "Mostrar a Senha";
            checkBoxMostrar.UseVisualStyleBackColor = true;
            checkBoxMostrar.CheckedChanged += checkBoxMostrar_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.HotTrack;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(62, 290);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(239, 41);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.White;
            btnApagar.Cursor = Cursors.Hand;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnApagar.ForeColor = SystemColors.HotTrack;
            btnApagar.Location = new Point(63, 347);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(238, 41);
            btnApagar.TabIndex = 5;
            btnApagar.Text = "Apagar todos os campos";
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(89, 425);
            label4.Name = "label4";
            label4.Size = new Size(188, 25);
            label4.TabIndex = 12;
            label4.Text = "Não tem uma conta?";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.ControlLight;
            txtSenha.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(62, 194);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(239, 35);
            txtSenha.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(52, 166);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 13;
            label3.Text = "Senha";
            // 
            // lblCriarConta
            // 
            lblCriarConta.AutoSize = true;
            lblCriarConta.Cursor = Cursors.Hand;
            lblCriarConta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblCriarConta.ForeColor = SystemColors.HotTrack;
            lblCriarConta.Location = new Point(110, 459);
            lblCriarConta.Name = "lblCriarConta";
            lblCriarConta.Size = new Size(138, 23);
            lblCriarConta.TabIndex = 6;
            lblCriarConta.Text = "Criar uma conta";
            lblCriarConta.Click += lblCriarConta_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.ControlLight;
            txtUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(62, 108);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(239, 35);
            txtUsuario.TabIndex = 1;
            // 
            // lblVoltar
            // 
            lblVoltar.AutoSize = true;
            lblVoltar.Cursor = Cursors.Hand;
            lblVoltar.ForeColor = SystemColors.ControlDarkDark;
            lblVoltar.Location = new Point(12, 498);
            lblVoltar.Name = "lblVoltar";
            lblVoltar.Size = new Size(48, 20);
            lblVoltar.TabIndex = 17;
            lblVoltar.Text = "Voltar";
            lblVoltar.Click += lblVoltar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(367, 527);
            ControlBox = false;
            Controls.Add(lblVoltar);
            Controls.Add(txtUsuario);
            Controls.Add(lblCriarConta);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btnApagar);
            Controls.Add(btnLogin);
            Controls.Add(checkBoxMostrar);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox checkBoxMostrar;
        private Button btnLogin;
        private Button btnApagar;
        private Label label4;
        private TextBox txtSenha;
        private Label label3;
        private Label lblCriarConta;
        private TextBox txtUsuario;
        private Label lblVoltar;
    }
}