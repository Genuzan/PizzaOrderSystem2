namespace PizzaOrderSystem
{
    partial class DriverForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DeliveredButton = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.CancelledButton = new System.Windows.Forms.Button();
            this.SearcBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(46, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(727, 399);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // DeliveredButton
            // 
            this.DeliveredButton.Location = new System.Drawing.Point(18, 43);
            this.DeliveredButton.Name = "DeliveredButton";
            this.DeliveredButton.Size = new System.Drawing.Size(108, 62);
            this.DeliveredButton.TabIndex = 1;
            this.DeliveredButton.Text = "Delivered";
            this.DeliveredButton.UseVisualStyleBackColor = true;
            this.DeliveredButton.Click += new System.EventHandler(this.DeliveredButton_Click);
            // 
            // logout
            // 
            this.logout.Image = global::PizzaOrderSystem.Properties.Resources.ourt;
            this.logout.Location = new System.Drawing.Point(870, 35);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(59, 51);
            this.logout.TabIndex = 5;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // CancelledButton
            // 
            this.CancelledButton.Location = new System.Drawing.Point(20, 129);
            this.CancelledButton.Name = "CancelledButton";
            this.CancelledButton.Size = new System.Drawing.Size(108, 62);
            this.CancelledButton.TabIndex = 6;
            this.CancelledButton.Text = "Cancelled";
            this.CancelledButton.UseVisualStyleBackColor = true;
            this.CancelledButton.Click += new System.EventHandler(this.CancelledButton_Click);
            // 
            // SearcBox
            // 
            this.SearcBox.Location = new System.Drawing.Point(24, 22);
            this.SearcBox.Name = "SearcBox";
            this.SearcBox.Size = new System.Drawing.Size(310, 26);
            this.SearcBox.TabIndex = 7;
            this.SearcBox.TextChanged += new System.EventHandler(this.SearcBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CancelledButton);
            this.groupBox2.Controls.Add(this.DeliveredButton);
            this.groupBox2.Location = new System.Drawing.Point(786, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 222);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SearcBox);
            this.groupBox3.Location = new System.Drawing.Point(46, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 68);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pizeria";
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaOrderSystem.Properties.Resources.ffnaf_background;
            this.ClientSize = new System.Drawing.Size(951, 609);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DriverForm";
            this.Text = "DriverForm";
            this.Load += new System.EventHandler(this.DriverForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button DeliveredButton;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button CancelledButton;
        private System.Windows.Forms.TextBox SearcBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
    }
}