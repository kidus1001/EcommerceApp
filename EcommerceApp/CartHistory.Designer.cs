namespace EcommerceApp
{
    partial class CartHistory
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1299, 61);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(141, 32);
            label1.TabIndex = 0;
            label1.Text = "My History";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column5, Column2, Column3, Column4, Column6 });
            dataGridView1.Location = new Point(13, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1096, 429);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(1136, 350);
            button1.Name = "button1";
            button1.Size = new Size(135, 53);
            button1.TabIndex = 3;
            button1.Text = "Clear History";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 128, 255);
            button2.Location = new Point(1136, 259);
            button2.Name = "button2";
            button2.Size = new Size(135, 53);
            button2.TabIndex = 4;
            button2.Text = "Delete History";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Column5
            // 
            Column5.HeaderText = "User ID";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 120;
            // 
            // Column2
            // 
            Column2.HeaderText = "Product ID";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 140;
            // 
            // Column3
            // 
            Column3.HeaderText = "Product Name";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 350;
            // 
            // Column4
            // 
            Column4.HeaderText = "Amount";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 120;
            // 
            // Column6
            // 
            Column6.HeaderText = "Date Ordered";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 300;
            // 
            // CartHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "CartHistory";
            Size = new Size(1299, 500);
            Load += CartHistory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private Button button1;
        private Button button2;
        public DataGridView dataGridView1;
    }
}
