﻿using System;
using System.Windows.Forms;
using Logging;

namespace ProjectBot
{
    public partial class FormError : Form
    {
        
        public FormError()
        {
            InitializeComponent();
        }

        private void BtnOkay_Click(object sender, EventArgs e)
        {
            Logger.Log.Info("Method \"Close Error Window\" called");

            Hide();
        }

        #region DragControl
        int mouseX;
        int mouseY;
        bool mouseDown;
        private void PnlDrag_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void PnlDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 60;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void PnlDrag_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion
    }
}
