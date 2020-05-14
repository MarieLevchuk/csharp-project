using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBot
{
    public partial class FormCart : Form
    {
        private FormMenu formMenu;
        public double Sum;
        public FormCart(FormMenu form)
        {
            InitializeComponent();
            formMenu = form;
            
            
            //CBoxOrder.SelectedIndexChanged += CBoxOrder_SelectedIndexChanged;
        }

        private void CBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
