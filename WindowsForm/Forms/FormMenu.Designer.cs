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
            label4 = new Label();
            btnLogin = new Button();
            btnAPI1 = new Button();
            btnAPI2 = new Button();
            lblSair = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(253, 9);
            label4.Name = "label4";
            label4.Size = new Size(116, 38);
            label4.TabIndex = 4;
            label4.Text = "Revisão";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.HotTrack;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(181, 121);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(239, 41);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Tela de Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnAPI1
            // 
            btnAPI1.BackColor = Color.White;
            btnAPI1.Cursor = Cursors.Hand;
            btnAPI1.FlatStyle = FlatStyle.Flat;
            btnAPI1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAPI1.ForeColor = SystemColors.HotTrack;
            btnAPI1.Location = new Point(30, 208);
            btnAPI1.Name = "btnAPI1";
            btnAPI1.Size = new Size(238, 41);
            btnAPI1.TabIndex = 6;
            btnAPI1.Text = "API com 1 Objeto";
            btnAPI1.UseVisualStyleBackColor = false;
            btnAPI1.Click += btnAPI1_Click;
            // 
            // btnAPI2
            // 
            btnAPI2.BackColor = Color.White;
            btnAPI2.Cursor = Cursors.Hand;
            btnAPI2.FlatStyle = FlatStyle.Flat;
            btnAPI2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAPI2.ForeColor = SystemColors.HotTrack;
            btnAPI2.Location = new Point(332, 208);
            btnAPI2.Name = "btnAPI2";
            btnAPI2.Size = new Size(238, 41);
            btnAPI2.TabIndex = 7;
            btnAPI2.Text = "API com uma Lista de Objetos";
            btnAPI2.UseVisualStyleBackColor = false;
            btnAPI2.Click += btnAPI2_Click;
            // 
            // lblSair
            // 
            lblSair.AutoSize = true;
            lblSair.Cursor = Cursors.Hand;
            lblSair.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSair.ForeColor = SystemColors.HotTrack;
            lblSair.Location = new Point(278, 308);
            lblSair.Name = "lblSair";
            lblSair.Size = new Size(41, 23);
            lblSair.TabIndex = 8;
            lblSair.Text = "Sair";
            lblSair.Click += lblSair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(48, 56);
            label1.Name = "label1";
            label1.Size = new Size(521, 25);
            label1.TabIndex = 10;
            label1.Text = "Explorando Windows Forms: Um Resumo por Renan Guedes";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 368);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(lblSair);
            Controls.Add(btnAPI2);
            Controls.Add(btnAPI1);
            Controls.Add(btnLogin);
            Controls.Add(label4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Button btnLogin;
        private Button btnAPI1;
        private Button btnAPI2;
        private Label lblSair;
        private Label label1;
    }
}