namespace WindowsForm.Forms
{
    partial class FormMenu
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
            menuStrip1 = new MenuStrip();
            MenuAlertas = new ToolStripMenuItem();
            MenuLogin = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonFace;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuAlertas, MenuLogin, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(461, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuAlertas
            // 
            MenuAlertas.Name = "MenuAlertas";
            MenuAlertas.Size = new Size(121, 24);
            MenuAlertas.Text = "Tela de Alertas";
            MenuAlertas.Click += MenuAlertas_Click;
            // 
            // MenuLogin
            // 
            MenuLogin.Name = "MenuLogin";
            MenuLogin.Size = new Size(112, 24);
            MenuLogin.Text = "Tela de Login";
            MenuLogin.Click += MenuLogin_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(48, 24);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 76);
            label1.Name = "label1";
            label1.Size = new Size(390, 20);
            label1.TabIndex = 1;
            label1.Text = "Olá! Bem vindo (a) ao meu resumo sobre Windows Forms";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(219, 143);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 2;
            label2.Text = ":D";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 215);
            label3.Name = "label3";
            label3.Size = new Size(375, 20);
            label3.TabIndex = 3;
            label3.Text = "Para continuar, basta acessar as opções do menu acima";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 301);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estudo de Formulários";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuAlertas;
        private ToolStripMenuItem MenuLogin;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}