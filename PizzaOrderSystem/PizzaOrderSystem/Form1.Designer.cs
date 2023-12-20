namespace PizzaOrderSystem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ItalianAmount = new System.Windows.Forms.TextBox();
            this.CheeseAmount = new System.Windows.Forms.TextBox();
            this.PeporoniAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassicAmount = new System.Windows.Forms.TextBox();
            this.ItalianBox = new System.Windows.Forms.CheckBox();
            this.CheeseBox = new System.Windows.Forms.CheckBox();
            this.PeporoniBox = new System.Windows.Forms.CheckBox();
            this.ClassicBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AdresstxtBox = new System.Windows.Forms.TextBox();
            this.NumbertxtBox = new System.Windows.Forms.TextBox();
            this.NametxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SearcBox = new System.Windows.Forms.TextBox();
            this.ShowCancelledButton = new System.Windows.Forms.Button();
            this.ShowDeliveredButton = new System.Windows.Forms.Button();
            this.ShowPendingButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.logout = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizeria";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.ItalianAmount);
            this.groupBox1.Controls.Add(this.CheeseAmount);
            this.groupBox1.Controls.Add(this.PeporoniAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ClassicAmount);
            this.groupBox1.Controls.Add(this.ItalianBox);
            this.groupBox1.Controls.Add(this.CheeseBox);
            this.groupBox1.Controls.Add(this.PeporoniBox);
            this.groupBox1.Controls.Add(this.ClassicBox);
            this.groupBox1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(46, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 313);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PizzaOrderSystem.Properties.Resources.italian;
            this.pictureBox4.Location = new System.Drawing.Point(6, 238);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PizzaOrderSystem.Properties.Resources.cheese;
            this.pictureBox3.Location = new System.Drawing.Point(6, 171);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PizzaOrderSystem.Properties.Resources.peporni;
            this.pictureBox2.Location = new System.Drawing.Point(6, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PizzaOrderSystem.Properties.Resources.classic;
            this.pictureBox1.Location = new System.Drawing.Point(6, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ItalianAmount
            // 
            this.ItalianAmount.Location = new System.Drawing.Point(285, 236);
            this.ItalianAmount.Name = "ItalianAmount";
            this.ItalianAmount.Size = new System.Drawing.Size(57, 26);
            this.ItalianAmount.TabIndex = 8;
            this.ItalianAmount.TextChanged += new System.EventHandler(this.ItalianAmount_TextChanged);
            // 
            // CheeseAmount
            // 
            this.CheeseAmount.Location = new System.Drawing.Point(285, 179);
            this.CheeseAmount.Name = "CheeseAmount";
            this.CheeseAmount.Size = new System.Drawing.Size(57, 26);
            this.CheeseAmount.TabIndex = 7;
            this.CheeseAmount.TextChanged += new System.EventHandler(this.CheeseAmount_TextChanged);
            // 
            // PeporoniAmount
            // 
            this.PeporoniAmount.Location = new System.Drawing.Point(285, 129);
            this.PeporoniAmount.Name = "PeporoniAmount";
            this.PeporoniAmount.Size = new System.Drawing.Size(57, 26);
            this.PeporoniAmount.TabIndex = 6;
            this.PeporoniAmount.TextChanged += new System.EventHandler(this.PeporoniAmount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(281, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ClassicAmount
            // 
            this.ClassicAmount.Location = new System.Drawing.Point(285, 67);
            this.ClassicAmount.Name = "ClassicAmount";
            this.ClassicAmount.Size = new System.Drawing.Size(57, 26);
            this.ClassicAmount.TabIndex = 4;
            this.ClassicAmount.TextChanged += new System.EventHandler(this.ClassicAmount_TextChanged);
            // 
            // ItalianBox
            // 
            this.ItalianBox.AutoSize = true;
            this.ItalianBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ItalianBox.Location = new System.Drawing.Point(76, 238);
            this.ItalianBox.Name = "ItalianBox";
            this.ItalianBox.Size = new System.Drawing.Size(78, 24);
            this.ItalianBox.TabIndex = 3;
            this.ItalianBox.Text = "Italian";
            this.ItalianBox.UseVisualStyleBackColor = true;
            this.ItalianBox.CheckedChanged += new System.EventHandler(this.ItalianBox_CheckedChanged);
            // 
            // CheeseBox
            // 
            this.CheeseBox.AutoSize = true;
            this.CheeseBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CheeseBox.Location = new System.Drawing.Point(76, 181);
            this.CheeseBox.Name = "CheeseBox";
            this.CheeseBox.Size = new System.Drawing.Size(157, 24);
            this.CheeseBox.TabIndex = 2;
            this.CheeseBox.Text = "Cheese Overload";
            this.CheeseBox.UseVisualStyleBackColor = true;
            this.CheeseBox.CheckedChanged += new System.EventHandler(this.CheeseBox_CheckedChanged);
            // 
            // PeporoniBox
            // 
            this.PeporoniBox.AutoSize = true;
            this.PeporoniBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PeporoniBox.Location = new System.Drawing.Point(76, 131);
            this.PeporoniBox.Name = "PeporoniBox";
            this.PeporoniBox.Size = new System.Drawing.Size(98, 24);
            this.PeporoniBox.TabIndex = 1;
            this.PeporoniBox.Text = "Peporoni";
            this.PeporoniBox.UseVisualStyleBackColor = true;
            this.PeporoniBox.CheckedChanged += new System.EventHandler(this.PeporoniBox_CheckedChanged);
            // 
            // ClassicBox
            // 
            this.ClassicBox.AutoSize = true;
            this.ClassicBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClassicBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClassicBox.Location = new System.Drawing.Point(76, 69);
            this.ClassicBox.Name = "ClassicBox";
            this.ClassicBox.Size = new System.Drawing.Size(85, 24);
            this.ClassicBox.TabIndex = 0;
            this.ClassicBox.Text = "Classic";
            this.ClassicBox.UseVisualStyleBackColor = true;
            this.ClassicBox.CheckedChanged += new System.EventHandler(this.ClassicBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.ClearButton);
            this.groupBox2.Controls.Add(this.AdresstxtBox);
            this.groupBox2.Controls.Add(this.NumbertxtBox);
            this.groupBox2.Controls.Add(this.NametxtBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Location = new System.Drawing.Point(46, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 178);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Info";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.LightGray;
            this.ClearButton.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearButton.Location = new System.Drawing.Point(323, 135);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(82, 37);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click_1);
            // 
            // AdresstxtBox
            // 
            this.AdresstxtBox.Location = new System.Drawing.Point(174, 104);
            this.AdresstxtBox.Name = "AdresstxtBox";
            this.AdresstxtBox.Size = new System.Drawing.Size(231, 26);
            this.AdresstxtBox.TabIndex = 6;
            this.AdresstxtBox.TextChanged += new System.EventHandler(this.AdresstxtBox_TextChanged);
            // 
            // NumbertxtBox
            // 
            this.NumbertxtBox.Location = new System.Drawing.Point(174, 68);
            this.NumbertxtBox.Name = "NumbertxtBox";
            this.NumbertxtBox.Size = new System.Drawing.Size(231, 26);
            this.NumbertxtBox.TabIndex = 6;
            this.NumbertxtBox.TextChanged += new System.EventHandler(this.NumbertxtBox_TextChanged);
            // 
            // NametxtBox
            // 
            this.NametxtBox.Location = new System.Drawing.Point(174, 32);
            this.NametxtBox.Name = "NametxtBox";
            this.NametxtBox.Size = new System.Drawing.Size(231, 26);
            this.NametxtBox.TabIndex = 5;
            this.NametxtBox.TextChanged += new System.EventHandler(this.NametxtBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Adress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Contact Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.SearcBox);
            this.groupBox3.Controls.Add(this.ShowCancelledButton);
            this.groupBox3.Controls.Add(this.ShowDeliveredButton);
            this.groupBox3.Controls.Add(this.ShowPendingButton);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(500, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(619, 625);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Information";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Search";
            // 
            // SearcBox
            // 
            this.SearcBox.Location = new System.Drawing.Point(105, 38);
            this.SearcBox.Name = "SearcBox";
            this.SearcBox.Size = new System.Drawing.Size(310, 26);
            this.SearcBox.TabIndex = 6;
            this.SearcBox.TextChanged += new System.EventHandler(this.SearcBox_TextChanged);
            // 
            // ShowCancelledButton
            // 
            this.ShowCancelledButton.BackColor = System.Drawing.Color.LightGray;
            this.ShowCancelledButton.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCancelledButton.Location = new System.Drawing.Point(307, 526);
            this.ShowCancelledButton.Name = "ShowCancelledButton";
            this.ShowCancelledButton.Size = new System.Drawing.Size(108, 66);
            this.ShowCancelledButton.TabIndex = 5;
            this.ShowCancelledButton.Text = "Cancelled";
            this.ShowCancelledButton.UseVisualStyleBackColor = false;
            this.ShowCancelledButton.Click += new System.EventHandler(this.ShowCancelledButton_Click);
            // 
            // ShowDeliveredButton
            // 
            this.ShowDeliveredButton.BackColor = System.Drawing.Color.LightGray;
            this.ShowDeliveredButton.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDeliveredButton.Location = new System.Drawing.Point(173, 526);
            this.ShowDeliveredButton.Name = "ShowDeliveredButton";
            this.ShowDeliveredButton.Size = new System.Drawing.Size(108, 66);
            this.ShowDeliveredButton.TabIndex = 4;
            this.ShowDeliveredButton.Text = "Delivered";
            this.ShowDeliveredButton.UseVisualStyleBackColor = false;
            this.ShowDeliveredButton.Click += new System.EventHandler(this.ShowDeliveredButton_Click);
            // 
            // ShowPendingButton
            // 
            this.ShowPendingButton.BackColor = System.Drawing.Color.LightGray;
            this.ShowPendingButton.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPendingButton.Location = new System.Drawing.Point(31, 526);
            this.ShowPendingButton.Name = "ShowPendingButton";
            this.ShowPendingButton.Size = new System.Drawing.Size(108, 66);
            this.ShowPendingButton.TabIndex = 3;
            this.ShowPendingButton.Text = "Pending";
            this.ShowPendingButton.UseVisualStyleBackColor = false;
            this.ShowPendingButton.Click += new System.EventHandler(this.ShowPendingButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(557, 409);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.LightGray;
            this.DeleteButton.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(174, 26);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(108, 66);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.LightGray;
            this.AddButton.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(25, 26);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(108, 66);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Submit";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // logout
            // 
            this.logout.Image = global::PizzaOrderSystem.Properties.Resources.ourt;
            this.logout.Location = new System.Drawing.Point(1060, 18);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(59, 51);
            this.logout.TabIndex = 4;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.DeleteButton);
            this.groupBox4.Controls.Add(this.AddButton);
            this.groupBox4.Location = new System.Drawing.Point(46, 581);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 125);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::PizzaOrderSystem.Properties.Resources.ffnaf_background;
            this.ClientSize = new System.Drawing.Size(1154, 727);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PeporoniAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClassicAmount;
        private System.Windows.Forms.CheckBox ItalianBox;
        private System.Windows.Forms.CheckBox CheeseBox;
        private System.Windows.Forms.CheckBox PeporoniBox;
        private System.Windows.Forms.CheckBox ClassicBox;
        private System.Windows.Forms.TextBox ItalianAmount;
        private System.Windows.Forms.TextBox CheeseAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox AdresstxtBox;
        private System.Windows.Forms.TextBox NumbertxtBox;
        private System.Windows.Forms.TextBox NametxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button ShowCancelledButton;
        private System.Windows.Forms.Button ShowDeliveredButton;
        private System.Windows.Forms.Button ShowPendingButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox SearcBox;
        private System.Windows.Forms.Label label6;
    }
}

