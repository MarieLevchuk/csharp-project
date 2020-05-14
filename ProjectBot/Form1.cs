using Newtonsoft.Json;
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

namespace ProjectBot
{
    public partial class FormMenu : Form
    {
        public const double coeffOfDenomination= 0.0001;
        public FormMenu()
        {
            InitializeComponent();
            var myMenu = JsonConvert.DeserializeObject<Menus>(File.ReadAllText("data.json"));
            
            CBoxMenu.DataSource = myMenu.DishMenus;
            CBoxMenu.DisplayMember = "Title";
            CBoxMenu.SelectedIndexChanged += CBoxMenu_SelectedIndexChanged;
        }

        private void CBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            DishMenus dishMenus = CBoxMenu.SelectedItem as DishMenus;
            CBoxDishes.Visible = true;
            CBoxDishes.DataSource = dishMenus.Dishes;
            CBoxDishes.DisplayMember = "Title";            
        }
        private void CBoxDishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dishes dish = CBoxDishes.SelectedItem as Dishes;
            PictureBox1.ImageLocation = dish.Image;
            LblDish.Text = dish.Title;
            LblIngredients.Text = dish.Body;            
            LblPrice.Text = $"{dish.Cost*coeffOfDenomination} BYN";
            string botAnswer = "Exellent choice! Now click \"Add to cart\"";
            LblBotBottom.Text = botAnswer.ToLower();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnHide_Click(object sender, EventArgs e)
        {
           // Hide();
        }

        private void BtnCart_Click(object sender, EventArgs e)
        {
            FormCart formCart = new FormCart();
            formCart.Show();
        }
    }
}
