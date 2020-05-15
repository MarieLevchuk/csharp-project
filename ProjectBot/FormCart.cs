using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectBot.Menu;

namespace ProjectBot
{
    public partial class FormCart : Form
    {
        private FormMenu formMenu;
        private FormError formError;
        private Dishes _dishToRemove;

        public string ClientName { get; private set; }
        public string ClientPhoneNum { get; private set; }
        public string ClientEmail { get; private set; }
        public double Sum { get; set; }
        public int Count { get; set; }

        public FormCart(FormMenu form)
        {
            InitializeComponent();
            formMenu = form;
            formError = new FormError();

            CBoxOrder.SelectedIndexChanged += CBoxOrder_SelectedIndexChanged;
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
            Count = CBoxOrder.Items.Count;
            LblCount.Text = Count.ToString();
            Sum -= dish.Cost * FormMenu.coeffOfDenomination;
            LblSum.Text = $"{Sum} BYN";
        }
        private void BtnBuy_Click(object sender, EventArgs e)
        {
            CheckOrderInfo();
        }
        private void CheckOrderInfo()
        {
            if (TBoxName.Text.Equals("Name"))
            {
                formError.LblErrorMessage.Text = "Please enter your name";
                formError.Show();
                TBoxName.SelectAll();
            }
            else
                ClientName = TBoxName.Text;

            if (MTBoxPhoneNum.Text.Equals(default))
            {
                formError.LblErrorMessage.Text = "Please enter your phone number";
                formError.Show();
            }
            else
                ClientPhoneNum = MTBoxPhoneNum.Text;
            if (CheckBoxEmail.Checked)
            {
                ClientEmail = TBoxEmail.Text;
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        
    }
}
