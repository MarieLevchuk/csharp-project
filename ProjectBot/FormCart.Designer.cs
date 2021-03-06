﻿namespace ProjectBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCart));
            this.TBoxName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblPhoneNum = new System.Windows.Forms.Label();
            this.LblCount = new System.Windows.Forms.Label();
            this.LblItemsCount = new System.Windows.Forms.Label();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.LblSum = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblSplitter = new System.Windows.Forms.Label();
            this.CheckBoxEmail = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.MTBoxPhoneNum = new System.Windows.Forms.MaskedTextBox();
            this.TBoxEmail = new System.Windows.Forms.TextBox();
            this.CBoxOrder = new System.Windows.Forms.ComboBox();
            this.BtnRemovePosition = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBoxName
            // 
            this.TBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.TBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TBoxName.Location = new System.Drawing.Point(232, 397);
            this.TBoxName.MinimumSize = new System.Drawing.Size(0, 28);
            this.TBoxName.Name = "TBoxName";
            this.TBoxName.Size = new System.Drawing.Size(205, 23);
            this.TBoxName.TabIndex = 23;
            this.TBoxName.Text = "Name";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.LblName.Location = new System.Drawing.Point(26, 397);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(113, 25);
            this.LblName.TabIndex = 22;
            this.LblName.Text = "Your name:";
            // 
            // LblPhoneNum
            // 
            this.LblPhoneNum.AutoSize = true;
            this.LblPhoneNum.BackColor = System.Drawing.Color.Transparent;
            this.LblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPhoneNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.LblPhoneNum.Location = new System.Drawing.Point(26, 445);
            this.LblPhoneNum.Name = "LblPhoneNum";
            this.LblPhoneNum.Size = new System.Drawing.Size(190, 25);
            this.LblPhoneNum.TabIndex = 20;
            this.LblPhoneNum.Text = "Your phone number:";
            // 
            // LblCount
            // 
            this.LblCount.BackColor = System.Drawing.Color.Transparent;
            this.LblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.LblCount.Location = new System.Drawing.Point(348, 342);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(86, 25);
            this.LblCount.TabIndex = 19;
            this.LblCount.Text = "0";
            this.LblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblItemsCount
            // 
            this.LblItemsCount.AutoSize = true;
            this.LblItemsCount.BackColor = System.Drawing.Color.Transparent;
            this.LblItemsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblItemsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.LblItemsCount.Location = new System.Drawing.Point(26, 342);
            this.LblItemsCount.Name = "LblItemsCount";
            this.LblItemsCount.Size = new System.Drawing.Size(59, 25);
            this.LblItemsCount.TabIndex = 18;
            this.LblItemsCount.Text = "Items";
            // 
            // BtnBuy
            // 
            this.BtnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(122)))));
            this.BtnBuy.FlatAppearance.BorderSize = 0;
            this.BtnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.BtnBuy.Location = new System.Drawing.Point(31, 614);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(406, 44);
            this.BtnBuy.TabIndex = 17;
            this.BtnBuy.Text = "BUY";
            this.BtnBuy.UseVisualStyleBackColor = false;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // LblSum
            // 
            this.LblSum.BackColor = System.Drawing.Color.Transparent;
            this.LblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblSum.Location = new System.Drawing.Point(322, 566);
            this.LblSum.Name = "LblSum";
            this.LblSum.Size = new System.Drawing.Size(115, 29);
            this.LblSum.TabIndex = 16;
            this.LblSum.Text = "BYN";
            this.LblSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.BackColor = System.Drawing.Color.Transparent;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblTotal.Location = new System.Drawing.Point(26, 566);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(68, 29);
            this.LblTotal.TabIndex = 10;
            this.LblTotal.Text = "Total";
            // 
            // LblSplitter
            // 
            this.LblSplitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(122)))));
            this.LblSplitter.Location = new System.Drawing.Point(31, 548);
            this.LblSplitter.Name = "LblSplitter";
            this.LblSplitter.Size = new System.Drawing.Size(406, 2);
            this.LblSplitter.TabIndex = 9;
            // 
            // CheckBoxEmail
            // 
            this.CheckBoxEmail.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxEmail.FlatAppearance.BorderSize = 0;
            this.CheckBoxEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.CheckBoxEmail.Location = new System.Drawing.Point(31, 486);
            this.CheckBoxEmail.Name = "CheckBoxEmail";
            this.CheckBoxEmail.Size = new System.Drawing.Size(204, 47);
            this.CheckBoxEmail.TabIndex = 6;
            this.CheckBoxEmail.Text = "Send me e-mail";
            this.CheckBoxEmail.UseVisualStyleBackColor = false;
            this.CheckBoxEmail.CheckedChanged += new System.EventHandler(this.CheckBoxEmail_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(74, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "CART";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.pictureBox1.BackgroundImage = global::ProjectBot.Properties.Resources.cart;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 48);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.AutoSize = true;
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Font = new System.Drawing.Font("Monospac821 BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.BtnExit.Location = new System.Drawing.Point(439, 14);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(32, 34);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "x";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(475, 65);
            this.splitter1.TabIndex = 24;
            this.splitter1.TabStop = false;
            this.splitter1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitter1_MouseDown);
            this.splitter1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitter1_MouseMove);
            this.splitter1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitter1_MouseUp);
            // 
            // MTBoxPhoneNum
            // 
            this.MTBoxPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MTBoxPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MTBoxPhoneNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MTBoxPhoneNum.Location = new System.Drawing.Point(232, 449);
            this.MTBoxPhoneNum.Mask = "+375(00) 000-000-0";
            this.MTBoxPhoneNum.MinimumSize = new System.Drawing.Size(0, 28);
            this.MTBoxPhoneNum.Name = "MTBoxPhoneNum";
            this.MTBoxPhoneNum.Size = new System.Drawing.Size(205, 23);
            this.MTBoxPhoneNum.TabIndex = 25;
            // 
            // TBoxEmail
            // 
            this.TBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.TBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TBoxEmail.Location = new System.Drawing.Point(232, 497);
            this.TBoxEmail.MinimumSize = new System.Drawing.Size(0, 28);
            this.TBoxEmail.Name = "TBoxEmail";
            this.TBoxEmail.Size = new System.Drawing.Size(205, 23);
            this.TBoxEmail.TabIndex = 26;
            this.TBoxEmail.Text = "e-mail";
            this.TBoxEmail.Visible = false;
            // 
            // CBoxOrder
            // 
            this.CBoxOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBoxOrder.FormattingEnabled = true;
            this.CBoxOrder.Location = new System.Drawing.Point(28, 82);
            this.CBoxOrder.Name = "CBoxOrder";
            this.CBoxOrder.Size = new System.Drawing.Size(406, 198);
            this.CBoxOrder.TabIndex = 27;
            this.CBoxOrder.Text = "Items to order:";
            this.CBoxOrder.SelectedIndexChanged += new System.EventHandler(this.CBoxOrder_SelectedIndexChanged);
            // 
            // BtnRemovePosition
            // 
            this.BtnRemovePosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.BtnRemovePosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemovePosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemovePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRemovePosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.BtnRemovePosition.Location = new System.Drawing.Point(31, 286);
            this.BtnRemovePosition.Name = "BtnRemovePosition";
            this.BtnRemovePosition.Size = new System.Drawing.Size(204, 45);
            this.BtnRemovePosition.TabIndex = 28;
            this.BtnRemovePosition.Text = "Remove this position";
            this.BtnRemovePosition.UseVisualStyleBackColor = false;
            this.BtnRemovePosition.Click += new System.EventHandler(this.BtnRemovePosition_Click);
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 680);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRemovePosition);
            this.Controls.Add(this.CBoxOrder);
            this.Controls.Add(this.TBoxEmail);
            this.Controls.Add(this.MTBoxPhoneNum);
            this.Controls.Add(this.TBoxName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblPhoneNum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.LblItemsCount);
            this.Controls.Add(this.CheckBoxEmail);
            this.Controls.Add(this.BtnBuy);
            this.Controls.Add(this.LblSum);
            this.Controls.Add(this.LblSplitter);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCart";
            this.Text = "FormCart";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BtnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblSplitter;
        private System.Windows.Forms.CheckBox CheckBoxEmail;
        private System.Windows.Forms.TextBox TBoxName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblPhoneNum;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MaskedTextBox MTBoxPhoneNum;
        private System.Windows.Forms.TextBox TBoxEmail;
        private System.Windows.Forms.Button BtnRemovePosition;
        public System.Windows.Forms.ComboBox CBoxOrder;
        public System.Windows.Forms.Label LblSum;
        public System.Windows.Forms.Label LblItemsCount;
        public System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}