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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblCompra = new Label();
            lblVenda = new Label();
            lblVariacao = new Label();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.Location = new Point(346, 253);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(109, 36);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(476, 75);
            label1.TabIndex = 1;
            label1.Text = "Dólar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            // FormAPI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 301);
            Controls.Add(lblVariacao);
            Controls.Add(lblVenda);
            Controls.Add(lblCompra);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConsultar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAPI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estudo de API";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsultar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblCompra;
        private Label lblVenda;
        private Label lblVariacao;
    }
}