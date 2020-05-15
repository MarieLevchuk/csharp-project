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
        private Dishes _dishToRemove;
        public double Sum { get; set; }
        public int Count { get; set; }
        public FormCart(FormMenu form)
        {
            InitializeComponent();
            formMenu = form;         
            
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
