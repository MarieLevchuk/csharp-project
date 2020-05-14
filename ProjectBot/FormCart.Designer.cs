namespace ProjectBot
{
    partial class FormCart
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
            this.gradientPanel1 = new ProjectBot.FormDesign.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CheckBoxEmail = new System.Windows.Forms.CheckBox();
            this.TBoxEmail = new System.Windows.Forms.TextBox();
            this.LblSplitter = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblSum = new System.Windows.Forms.Label();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.LblItemsCount = new System.Windows.Forms.Label();
            this.LblCount = new System.Windows.Forms.Label();
            this.LblPhoneNum = new System.Windows.Forms.Label();
            this.TBoxPhone = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.TBoxName = new System.Windows.Forms.TextBox();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(122)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.gradientPanel1.Controls.Add(this.TBoxName);
            this.gradientPanel1.Controls.Add(this.LblName);
            this.gradientPanel1.Controls.Add(this.TBoxPhone);
            this.gradientPanel1.Controls.Add(this.LblPhoneNum);
            this.gradientPanel1.Controls.Add(this.LblCount);
            this.gradientPanel1.Controls.Add(this.LblItemsCount);
            this.gradientPanel1.Controls.Add(this.BtnBuy);
            this.gradientPanel1.Controls.Add(this.LblSum);
            this.gradientPanel1.Controls.Add(this.LblTotal);
            this.gradientPanel1.Controls.Add(this.LblSplitter);
            this.gradientPanel1.Controls.Add(this.TBoxEmail);
            this.gradientPanel1.Controls.Add(this.CheckBoxEmail);
            this.gradientPanel1.Controls.Add(this.richTextBox1);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.BtnExit);
            this.gradientPanel1.Controls.Add(this.splitter1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(482, 675);
            this.gradientPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.pictureBox1.BackgroundImage = global::ProjectBot.Properties.Resources.cartRed;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(14, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 40);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.AutoSize = true;
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Font = new System.Drawing.Font("Monospac821 BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.BtnExit.Location = new System.Drawing.Point(443, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(32, 34);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "x";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(482, 43);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "CART";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(35, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(406, 237);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // CheckBoxEmail
            // 
            this.CheckBoxEmail.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxEmail.Checked = true;
            this.CheckBoxEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxEmail.FlatAppearance.BorderSize = 0;
            this.CheckBoxEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxEmail.ForeColor = System.Drawing.Color.Maroon;
            this.CheckBoxEmail.Location = new System.Drawing.Point(35, 466);
            this.CheckBoxEmail.Name = "CheckBoxEmail";
            this.CheckBoxEmail.Size = new System.Drawing.Size(204, 47);
            this.CheckBoxEmail.TabIndex = 6;
            this.CheckBoxEmail.Text = "Send me e-mail";
            this.CheckBoxEmail.UseVisualStyleBackColor = false;
            // 
            // TBoxEmail
            // 
            this.TBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.TBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TBoxEmail.Location = new System.Drawing.Point(236, 477);
            this.TBoxEmail.MinimumSize = new System.Drawing.Size(0, 28);
            this.TBoxEmail.Name = "TBoxEmail";
            this.TBoxEmail.Size = new System.Drawing.Size(205, 28);
            this.TBoxEmail.TabIndex = 7;
            this.TBoxEmail.Text = "email@mail.com";
            // 
            // LblSplitter
            // 
            this.LblSplitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(122)))));
            this.LblSplitter.Location = new System.Drawing.Point(35, 528);
            this.LblSplitter.Name = "LblSplitter";
            this.LblSplitter.Size = new System.Drawing.Size(406, 2);
            this.LblSplitter.TabIndex = 9;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.BackColor = System.Drawing.Color.Transparent;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTotal.ForeColor = System.Drawing.Color.Maroon;
            this.LblTotal.Location = new System.Drawing.Point(30, 546);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(73, 29);
            this.LblTotal.TabIndex = 10;
            this.LblTotal.Text = "Total";
            this.LblTotal.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblSum
            // 
            this.LblSum.BackColor = System.Drawing.Color.Transparent;
            this.LblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSum.ForeColor = System.Drawing.Color.Maroon;
            this.LblSum.Location = new System.Drawing.Point(326, 546);
            this.LblSum.Name = "LblSum";
            this.LblSum.Size = new System.Drawing.Size(115, 29);
            this.LblSum.TabIndex = 16;
            this.LblSum.Text = "BYN";
            this.LblSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnBuy
            // 
            this.BtnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.BtnBuy.FlatAppearance.BorderSize = 0;
            this.BtnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.BtnBuy.Location = new System.Drawing.Point(35, 594);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(406, 44);
            this.BtnBuy.TabIndex = 17;
            this.BtnBuy.Text = "BUY";
            this.BtnBuy.UseVisualStyleBackColor = false;
            // 
            // LblItemsCount
            // 
            this.LblItemsCount.AutoSize = true;
            this.LblItemsCount.BackColor = System.Drawing.Color.Transparent;
            this.LblItemsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblItemsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.LblItemsCount.Location = new System.Drawing.Point(30, 322);
            this.LblItemsCount.Name = "LblItemsCount";
            this.LblItemsCount.Size = new System.Drawing.Size(49, 25);
            this.LblItemsCount.TabIndex = 18;
            this.LblItemsCount.Text = "Item";
            // 
            // LblCount
            // 
            this.LblCount.BackColor = System.Drawing.Color.Transparent;
            this.LblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.LblCount.Location = new System.Drawing.Point(352, 322);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(86, 25);
            this.LblCount.TabIndex = 19;
            this.LblCount.Text = "0";
            this.LblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPhoneNum
            // 
            this.LblPhoneNum.AutoSize = true;
            this.LblPhoneNum.BackColor = System.Drawing.Color.Transparent;
            this.LblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPhoneNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.LblPhoneNum.Location = new System.Drawing.Point(30, 425);
            this.LblPhoneNum.Name = "LblPhoneNum";
            this.LblPhoneNum.Size = new System.Drawing.Size(190, 25);
            this.LblPhoneNum.TabIndex = 20;
            this.LblPhoneNum.Text = "Your phone number:";
            // 
            // TBoxPhone
            // 
            this.TBoxPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.TBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxPhone.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TBoxPhone.Location = new System.Drawing.Point(236, 425);
            this.TBoxPhone.MinimumSize = new System.Drawing.Size(0, 28);
            this.TBoxPhone.Name = "TBoxPhone";
            this.TBoxPhone.Size = new System.Drawing.Size(205, 28);
            this.TBoxPhone.TabIndex = 21;
            this.TBoxPhone.Text = "+375(##)#######";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.LblName.Location = new System.Drawing.Point(30, 377);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(113, 25);
            this.LblName.TabIndex = 22;
            this.LblName.Text = "Your name:";
            // 
            // TBoxName
            // 
            this.TBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.TBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TBoxName.Location = new System.Drawing.Point(236, 377);
            this.TBoxName.MinimumSize = new System.Drawing.Size(0, 28);
            this.TBoxName.Name = "TBoxName";
            this.TBoxName.Size = new System.Drawing.Size(205, 28);
            this.TBoxName.TabIndex = 23;
            this.TBoxName.Text = "Name";
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 675);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCart";
            this.Text = "FormCart";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FormDesign.GradientPanel gradientPanel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label BtnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblSplitter;
        private System.Windows.Forms.TextBox TBoxEmail;
        private System.Windows.Forms.CheckBox CheckBoxEmail;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label LblSum;
        private System.Windows.Forms.TextBox TBoxName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TBoxPhone;
        private System.Windows.Forms.Label LblPhoneNum;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Label LblItemsCount;
        private System.Windows.Forms.Button BtnBuy;
    }
}