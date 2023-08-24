namespace WindowsForm
{
    partial class FormAlerts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 271);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipos de Alerta em C#";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.HighlightText;
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(25, 224);
            button5.Name = "button5";
            button5.Size = new Size(173, 29);
            button5.TabIndex = 4;
            button5.Text = "Alerta Crítico / Sonoro";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HighlightText;
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(25, 180);
            button4.Name = "button4";
            button4.Size = new Size(227, 29);
            button4.TabIndex = 3;
            button4.Text = "Alerta com Sim, Não e Cancelar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.InactiveBorder;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(25, 136);
            button3.Name = "button3";
            button3.Size = new Size(173, 29);
            button3.TabIndex = 2;
            button3.Text = "Alerta com Sim ou Não";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HighlightText;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(25, 91);
            button2.Name = "button2";
            button2.Size = new Size(188, 29);
            button2.TabIndex = 1;
            button2.Text = "Alerta Simples com Título";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HighlightText;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(25, 46);
            button1.Name = "button1";
            button1.Size = new Size(124, 29);
            button1.TabIndex = 0;
            button1.Text = "Alerta Simples";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // FormAlerts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 301);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAlerts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estudo de Alertas";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}