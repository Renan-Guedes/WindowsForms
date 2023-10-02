namespace WindowsForm.Forms
{
    partial class FormCadastro
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
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            label3 = new Label();
            btnApagar = new Button();
            btnCadastrar = new Button();
            checkBoxMostrar = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            txtConfirme = new TextBox();
            label4 = new Label();
            lblRetornar = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.ControlLight;
            txtUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(59, 100);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(239, 35);
            txtUsuario.TabIndex = 27;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.ControlLight;
            txtSenha.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(59, 182);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(239, 35);
            txtSenha.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(49, 154);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 24;
            label3.Text = "Senha";
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.White;
            btnApagar.Cursor = Cursors.Hand;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnApagar.ForeColor = SystemColors.HotTrack;
            btnApagar.Location = new Point(59, 420);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(238, 41);
            btnApagar.TabIndex = 22;
            btnApagar.Text = "Apagar todos os campos";
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.HotTrack;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.ForeColor = SystemColors.ControlLightLight;
            btnCadastrar.Location = new Point(58, 363);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(239, 41);
            btnCadastrar.TabIndex = 21;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // checkBoxMostrar
            // 
            checkBoxMostrar.AutoSize = true;
            checkBoxMostrar.Location = new Point(160, 310);
            checkBoxMostrar.Name = "checkBoxMostrar";
            checkBoxMostrar.Size = new Size(138, 24);
            checkBoxMostrar.TabIndex = 20;
            checkBoxMostrar.Text = "Mostrar a Senha";
            checkBoxMostrar.UseVisualStyleBackColor = true;
            checkBoxMostrar.CheckedChanged += checkBoxMostrar_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(49, 72);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 19;
            label2.Text = "Usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(66, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 38);
            label1.TabIndex = 18;
            label1.Text = "Tela de Cadastro";
            // 
            // txtConfirme
            // 
            txtConfirme.BackColor = SystemColors.ControlLight;
            txtConfirme.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirme.Location = new Point(59, 269);
            txtConfirme.Multiline = true;
            txtConfirme.Name = "txtConfirme";
            txtConfirme.PasswordChar = '*';
            txtConfirme.Size = new Size(239, 35);
            txtConfirme.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(49, 241);
            label4.Name = "label4";
            label4.Size = new Size(196, 25);
            label4.TabIndex = 29;
            label4.Text = "Confirme a sua Senha";
            // 
            // lblRetornar
            // 
            lblRetornar.AutoSize = true;
            lblRetornar.Cursor = Cursors.Hand;
            lblRetornar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRetornar.ForeColor = SystemColors.HotTrack;
            lblRetornar.Location = new Point(76, 485);
            lblRetornar.Name = "lblRetornar";
            lblRetornar.Size = new Size(212, 20);
            lblRetornar.TabIndex = 31;
            lblRetornar.Text = "Retornar para a tela de Login";
            lblRetornar.Click += lblRetornar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 527);
            ControlBox = false;
            Controls.Add(lblRetornar);
            Controls.Add(txtConfirme);
            Controls.Add(label4);
            Controls.Add(txtUsuario);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(btnApagar);
            Controls.Add(btnCadastrar);
            Controls.Add(checkBoxMostrar);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label3;
        private Button btnApagar;
        private Button btnCadastrar;
        private CheckBox checkBoxMostrar;
        private Label label2;
        private Label label1;
        private TextBox txtConfirme;
        private Label label4;
        private Label lblRetornar;
    }
}