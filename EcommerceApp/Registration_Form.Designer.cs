namespace EcommerceApp
{
    partial class Registration_Form
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
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1307, 50);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(482, 4);
            label2.Name = "label2";
            label2.Size = new Size(338, 43);
            label2.TabIndex = 2;
            label2.Text = "Registration Form";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(1307, 521);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGreen;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(578, 426);
            button2.Name = "button2";
            button2.Size = new Size(148, 50);
            button2.TabIndex = 2;
            button2.Text = "REGISTER";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(262, 359);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(741, 31);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(262, 321);
            label4.Name = "label4";
            label4.Size = new Size(112, 30);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(262, 269);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(741, 31);
            textBox4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(262, 231);
            label5.Name = "label5";
            label5.Size = new Size(54, 30);
            label5.TabIndex = 4;
            label5.Text = "City";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(262, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(741, 31);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(262, 145);
            label3.Name = "label3";
            label3.Size = new Size(69, 30);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(741, 31);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 52);
            label1.Name = "label1";
            label1.Size = new Size(74, 30);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // Registration_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Registration_Form";
            Size = new Size(1307, 571);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Button button2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
    }
}
