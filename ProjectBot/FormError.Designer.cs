namespace ProjectBot
{
    partial class FormError
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
            this.BtnOkay = new System.Windows.Forms.Button();
            this.LblErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnOkay
            // 
            this.BtnOkay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.BtnOkay.FlatAppearance.BorderSize = 0;
            this.BtnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOkay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnOkay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.BtnOkay.Location = new System.Drawing.Point(27, 153);
            this.BtnOkay.Name = "BtnOkay";
            this.BtnOkay.Size = new System.Drawing.Size(344, 44);
            this.BtnOkay.TabIndex = 18;
            this.BtnOkay.Text = "OKAY";
            this.BtnOkay.UseVisualStyleBackColor = false;
            this.BtnOkay.Click += new System.EventHandler(this.BtnOkay_Click);
            // 
            // LblErrorMessage
            // 
            this.LblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblErrorMessage.Location = new System.Drawing.Point(61, 27);
            this.LblErrorMessage.Name = "LblErrorMessage";
            this.LblErrorMessage.Size = new System.Drawing.Size(285, 96);
            this.LblErrorMessage.TabIndex = 19;
            this.LblErrorMessage.Text = "Oops! Sorry, but this dish is currently unavailble. Please choose another";
            this.LblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(403, 232);
            this.Controls.Add(this.LblErrorMessage);
            this.Controls.Add(this.BtnOkay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormError";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOkay;
        public System.Windows.Forms.Label LblErrorMessage;
    }
}