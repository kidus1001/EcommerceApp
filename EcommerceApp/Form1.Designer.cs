namespace EcommerceApp
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1285, 56);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Cart_Image;
            pictureBox1.Location = new Point(425, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 7F);
            button4.Location = new Point(1057, 0);
            button4.Name = "button4";
            button4.Size = new Size(141, 56);
            button4.TabIndex = 5;
            button4.Text = "Login";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(918, 0);
            button3.Name = "button3";
            button3.Size = new Size(141, 56);
            button3.TabIndex = 4;
            button3.Text = "Register";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(474, 9);
            label2.Name = "label2";
            label2.Size = new Size(43, 32);
            label2.TabIndex = 1;
            label2.Text = "(0)";
            // 
            // button2
            // 
            button2.Location = new Point(261, 0);
            button2.Name = "button2";
            button2.Size = new Size(160, 56);
            button2.TabIndex = 3;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(125, 0);
            button1.Name = "button1";
            button1.Size = new Size(141, 56);
            button1.TabIndex = 2;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 12);
            label1.Name = "label1";
            label1.Size = new Size(55, 27);
            label1.TabIndex = 1;
            label1.Text = "HEC";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(175, 151);
            label3.Name = "label3";
            label3.Size = new Size(1008, 84);
            label3.TabIndex = 1;
            label3.Text = "WELCOME TO HiLCoE's NON-OFFICIAL";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(288, 252);
            label4.Name = "label4";
            label4.Size = new Size(762, 84);
            label4.TabIndex = 2;
            label4.Text = "E-COMMERCE APPLICATION";
            label4.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(1285, 541);
            panel2.TabIndex = 3;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1285, 597);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E-Commerce Application";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
    }
}
