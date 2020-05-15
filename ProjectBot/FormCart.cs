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
        //public double Sum { get; set; }
        //public int Count { get; set; }

        public FormCart(FormMenu form)
        {
            InitializeComponent();
            formMenu = form;
            formError = new FormError();

            _emptyPhoneNumField = MTBoxPhoneNum.Text;
            _emptyNameField = TBoxName.Text;
            _emptyEmailField = TBoxEmail.Text;

            CBoxOrder.SelectedIndexChanged += CBoxOrder_SelectedIndexChanged;

            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private void CheckBoxEmail_CheckedChanged(object sender, EventArgs e)
        {
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
            _dishToRemove = CBoxOrder.SelectedItem as Dishes;
        }

        private void BtnRemovePosition_Click(object sender, EventArgs e)
        {
            CBoxOrder.Items.Remove(_dishToRemove);
            RefreshInfo(_dishToRemove);
        }
        private void RefreshInfo(Dishes dish)
        {
            Bot.Count = CBoxOrder.Items.Count;
            LblCount.Text = Bot.Count.ToString();
            Bot.Sum -= dish.Cost * FormMenu.coeffOfDenomination;
            LblSum.Text = $"{Bot.Sum} BYN";
        }
        private void BtnBuy_Click(object sender, EventArgs e)
        {            
            CheckOrderInfo();
            SaveInfoFile();
            if (CheckBoxEmail.Checked)
            {
                // SendEmail();
            }

        }

        private void CheckOrderInfo()
        {
            if (CBoxOrder.Items.Count != 0)
            {
                if (MTBoxPhoneNum.Text.Equals(_emptyPhoneNumField))
                {
                    formError.LblErrorMessage.Text = "Please enter your phone number";
                    formError.Show();
                }
                else
                    ClientPhoneNum = MTBoxPhoneNum.Text;
                if (TBoxName.Text.Equals(_emptyNameField))
                {
                    formError.LblErrorMessage.Text = "Please enter your name";
                    formError.Show();
                }
                else
                    ClientName = TBoxName.Text;
                if (CheckBoxEmail.Checked && TBoxEmail.Text.Equals(_emptyEmailField))
                {
                    formError.LblErrorMessage.Text = "Please enter your e-mail";
                    formError.Show();
                }
                else
                    ClientEmail = TBoxEmail.Text;
            }
            else
            {
                formError.LblErrorMessage.Text = "Please choose dishes to order";
                formError.Show();
            }

            
        }
        private void SaveInfoFile()
        {
            string orderInfoFile = $"Hi {ClientName}! You made an order in the cafe SUCHIVESLA. Thank you for choosing us!";  

            using (FileStream fstream = new FileStream($@"..\..\order.txt", FileMode.OpenOrCreate))
            {                
                byte[] array = Encoding.Default.GetBytes(orderInfoFile);
                fstream.Write(array, 0, array.Length);
            }
        }
        private void SendEmail()
        {
            string textFromFile;
            using (FileStream fstream = File.OpenRead($@"..\..\order.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                textFromFile = Encoding.Default.GetString(array);
            }            
            MailAddress from = new MailAddress(" ", "Sushivesla");
            MailAddress to = new MailAddress(ClientEmail);
            MailMessage message = new MailMessage(from,to);
            message.Subject = "Your order";
            message.Body = textFromFile;
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(" ", " ");
            smtp.EnableSsl = true;
            smtp.Send(message);
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }        
    }
}
