namespace EcommerceApp
{
    partial class welcome_page
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
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 24F, FontStyle.Italic);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(288, 252);
            label4.Name = "label4";
            label4.Size = new Size(762, 84);
            label4.TabIndex = 2;
            label4.Text = "E-COMMERCE APPLICATION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 24F, FontStyle.Italic);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(175, 151);
            label3.Name = "label3";
            label3.Size = new Size(1008, 84);
            label3.TabIndex = 1;
            label3.Text = "WELCOME TO HiLCoE's NON-OFFICIAL";
            // 
            // welcome_page
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "welcome_page";
            Size = new Size(1195, 459);
            Load += welcome_page_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
    }
}
