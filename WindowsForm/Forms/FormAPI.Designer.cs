namespace WindowsForm.Forms
{
    partial class FormAPI
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
            btnConsultar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblCompra = new Label();
            lblVenda = new Label();
            lblVariacao = new Label();
            btnVoltar = new Button();
            label1 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.Location = new Point(343, 253);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(109, 36);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 99);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 2;
            label2.Text = "Compra:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 143);
            label3.Name = "label3";
            label3.Size = new Size(70, 28);
            label3.TabIndex = 3;
            label3.Text = "Venda:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 185);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 4;
            label4.Text = "Variação:";
            // 
            // lblCompra
            // 
            lblCompra.BackColor = SystemColors.InactiveCaption;
            lblCompra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompra.ForeColor = SystemColors.ActiveCaptionText;
            lblCompra.Location = new Point(137, 99);
            lblCompra.Name = "lblCompra";
            lblCompra.Size = new Size(266, 28);
            lblCompra.TabIndex = 5;
            lblCompra.Text = "0,0";
            lblCompra.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVenda
            // 
            lblVenda.BackColor = SystemColors.InactiveCaption;
            lblVenda.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVenda.ForeColor = SystemColors.ActiveCaptionText;
            lblVenda.Location = new Point(137, 143);
            lblVenda.Name = "lblVenda";
            lblVenda.Size = new Size(266, 28);
            lblVenda.TabIndex = 6;
            lblVenda.Text = "0,0";
            lblVenda.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVariacao
            // 
            lblVariacao.BackColor = SystemColors.InactiveCaption;
            lblVariacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVariacao.ForeColor = SystemColors.ActiveCaptionText;
            lblVariacao.Location = new Point(137, 185);
            lblVariacao.Name = "lblVariacao";
            lblVariacao.Size = new Size(266, 28);
            lblVariacao.TabIndex = 7;
            lblVariacao.Text = "0,0";
            lblVariacao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.Location = new Point(217, 253);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(109, 36);
            btnVoltar.TabIndex = 8;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(220, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 38);
            label1.TabIndex = 9;
            label1.Text = "API";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(166, 47);
            label5.Name = "label5";
            label5.Size = new Size(163, 25);
            label5.TabIndex = 11;
            label5.Text = "Variação do Dólar";
            // 
            // FormAPI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 301);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnVoltar);
            Controls.Add(lblVariacao);
            Controls.Add(lblVenda);
            Controls.Add(lblCompra);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnConsultar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAPI";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsultar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblCompra;
        private Label lblVenda;
        private Label lblVariacao;
        private Button btnVoltar;
        private Label label1;
        private Label label5;
    }
}