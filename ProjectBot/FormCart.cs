using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectBot.Menu;
using System.Net.Mail;
using System.Net;
using Logging;

namespace ProjectBot
{
    public partial class FormCart : Form
    {
        private FormMenu formMenu;
        private FormError formError;
        private Dishes _dishToRemove;
        string _emptyPhoneNumField;
        string _emptyNameField;
        string _emptyEmailField;

        public string ClientName { get; private set; }
        public string ClientPhoneNum { get; private set; }
        public string ClientEmail { get; private set; }

        public FormCart(FormMenu form)
        {
            InitializeComponent();
            formMenu = form;
            formError = new FormError();

            _emptyPhoneNumField = MTBoxPhoneNum.Text;
            _emptyNameField = TBoxName.Text;
            _emptyEmailField = TBoxEmail.Text;

            CBoxOrder.SelectedIndexChanged += CBoxOrder_SelectedIndexChanged;
        }

        private void CheckBoxEmail_CheckedChanged(object sender, EventArgs e)
        {
            Logger.Log.Info("Checkbox checked/unchecked");

            if (CheckBoxEmail.Checked)
            {
                TBoxEmail.Visible = true;
                TBoxEmail.Enabled = true;                
            }
            else
            {
                TBoxEmail.Visible = false;
                TBoxEmail.Enabled = false;
            }                
        }

        private void CBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logger.Log.Info("Selected dish from the Order");

            _dishToRemove = CBoxOrder.SelectedItem as Dishes;
        }

        private void BtnRemovePosition_Click(object sender, EventArgs e)
        {
            Logger.Log.Info("Button \"Remove\" clicked");

            CBoxOrder.Items.Remove(_dishToRemove);
            RefreshInfo(_dishToRemove);
        }

        private void RefreshInfo(Dishes dish)
        {
            Logger.Log.Info("Method \"Refresh Info\" called");

            if (dish!=null) 
            {
                Bot.Count = CBoxOrder.Items.Count;
                LblCount.Text = Bot.Count.ToString();
                Bot.Sum -= dish.Cost * FormMenu.coeffOfDenomination;
                LblSum.Text = $"{Bot.Sum} BYN";
            }
            else
            {
                Logger.Log.Warn("Error: Dish isn't selected");

                formError.LblErrorMessage.Text = "Please select item to remove";
                formError.Show();
            }
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            Logger.Log.Info("Button \"Buy\" clicked");

            CheckOrderInfo();
            SaveInfoFile();
            if (CheckBoxEmail.Checked)
            {
                //SendEmail();
            }
            if (flagName && flagPhone && flagEmail)
            {
                CallSuccessfulMessage();
            }               
        }

        bool flagName, flagPhone, flagEmail;
        private void CheckOrderInfo()
        {
            Logger.Log.Info("Method \"Check Order Info\" called");

            if (CBoxOrder.Items.Count != 0)
            {
                if (MTBoxPhoneNum.Text.Equals(_emptyPhoneNumField))
                {
                    Logger.Log.Warn("Error: empty Phone Number");

                    flagPhone = false;
                    formError.LblErrorMessage.Text = "Please enter your phone number";
                    formError.Show();
                }
                else
                {
                    flagPhone = true;
                    ClientPhoneNum = MTBoxPhoneNum.Text;
                }
                if (TBoxName.Text.Equals(_emptyNameField))
                {
                    Logger.Log.Warn("Error: empty Name");

                    flagName = false;
                    formError.LblErrorMessage.Text = "Please enter your name";
                    formError.Show();
                }
                else
                {
                    flagName = true;
                    ClientName = TBoxName.Text;
                }
                if (CheckBoxEmail.Checked && TBoxEmail.Text.Equals(_emptyEmailField))
                {
                    Logger.Log.Warn("Error: empty Email");

                    flagEmail = false;
                    formError.LblErrorMessage.Text = "Please enter your e-mail";
                    formError.Show();
                }
                else
                {
                    flagEmail = true;
                    ClientEmail = TBoxEmail.Text;
                }
            }
            else
            {
                Logger.Log.Warn("Error: Dish isn't selected");

                formError.LblErrorMessage.Text = "Please choose dishes to order";
                formError.Show();
            }            
        }
        private void SaveInfoFile()
        {
            Logger.Log.Info("Method \"Save Info File\" called");

            string orderInfoFile = $"Hi {ClientName}! You made an order in the cafe SUCHIVESLA. Thank you for choosing us!";  

            using (FileStream fstream = new FileStream($@"..\..\order.txt", FileMode.OpenOrCreate))
            {                
                byte[] array = Encoding.Default.GetBytes(orderInfoFile);
                fstream.Write(array, 0, array.Length);
            }
        }
        //private void SendEmail()
        //{
        //    string textFromFile;
        //    using (FileStream fstream = File.OpenRead($@"..\..\order.txt"))
        //    {
        //        byte[] array = new byte[fstream.Length];
        //        fstream.Read(array, 0, array.Length);
        //        textFromFile = Encoding.Default.GetString(array);
        //    }            
        //    MailAddress from = new MailAddress(" ", "Sushivesla");
        //    MailAddress to = new MailAddress(ClientEmail);
        //    MailMessage message = new MailMessage(from,to);
        //    message.Subject = "Your order";
        //    message.Body = textFromFile;
        //    message.IsBodyHtml = true;
        //    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        //    smtp.Credentials = new NetworkCredential(" ", " ");
        //    smtp.EnableSsl = true;
        //    smtp.Send(message);
        //}

        private void CallSuccessfulMessage()
        {
            Logger.Log.Info("Method \"CallSuccessful Message\" called");

            formError.LblErrorMessage.Text = "Your order has been successfully created";
            formError.BtnOkay.BackColor = formMenu.BtnAddToCart.BackColor;
            formError.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Logger.Log.Info("Button \"Close Order Form\" clicked");

            Hide();
        }

        #region DragControl
        int mouseX;
        int mouseY;
        bool mouseDown;
        private void splitter1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void splitter1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 30;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void splitter1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion
    }
}
