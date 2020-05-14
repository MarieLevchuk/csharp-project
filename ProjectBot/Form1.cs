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
        FormCart formCart;
        FormError formError;
        public Dishes selectedDish;
        //public List<Dishes> DishesToOrder { get; set; }
        public FormMenu()
        {
            InitializeComponent();
            formCart = new FormCart(this);
            formError = new FormError();

            var myMenu = JsonConvert.DeserializeObject<Menus>(File.ReadAllText("data.json"));
            
            CBoxMenu.DataSource = myMenu.DishMenus;
            CBoxMenu.DisplayMember = "Title";
            CBoxMenu.SelectedIndexChanged += CBoxMenu_SelectedIndexChanged;
        }

        private void CBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            DishMenus dishMenus = CBoxMenu.SelectedItem as DishMenus;
            CBoxDishes.DataSource = dishMenus.Dishes;
            CBoxDishes.DisplayMember = "Title";            
        }
        private void CBoxDishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDish = CBoxDishes.SelectedItem as Dishes;
            PictureBox1.ImageLocation = selectedDish.Image;
            LblDish.Text = selectedDish.Title;
            LblIngredients.Text = selectedDish.Body;
            LblPrice.Text = $"{selectedDish.Cost * coeffOfDenomination} BYN";
            string botAnswer = "Exellent choice! Now click \"Add to cart\"";
            LblBotBottom.Text = botAnswer.ToLower();

           
        }
        string botHint = "Click on the CART to view your order";
        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            if (selectedDish.IsAvailable)
            {
                formCart.CBoxOrder.Items.Add(selectedDish);
                formCart.CBoxOrder.DisplayMember = "Title";
                LblBotBottom.Text = botHint;
                formCart.LblSum.Text = $"{GetSum(selectedDish)} BYN";
            }
            else
                formError.Show();                          
        }
        private double GetSum(Dishes dish)
        {
            formCart.Sum += dish.Cost * coeffOfDenomination;
            return formCart.Sum;
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
            formCart.Show();
        }

        
    }
}
