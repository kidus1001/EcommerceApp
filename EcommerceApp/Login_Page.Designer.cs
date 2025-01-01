namespace EcommerceApp
{
    partial class Login_Page
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            panel1 = new Panel();
            panel2 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(24, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(1236, 504);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(399, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(505, 313);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(60, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(354, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 31);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(178, 236);
            button1.Name = "button1";
            button1.Size = new Size(126, 45);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 142);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuText;
            label2.Location = new Point(55, 48);
            label2.Name = "label2";
            label2.Size = new Size(139, 32);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            label2.Click += label2_Click;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            Controls.Add(panel1);
            Name = "Login_Page";
            Size = new Size(1307, 542);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
