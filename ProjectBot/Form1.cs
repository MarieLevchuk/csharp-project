using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using ProjectBot.Menu;
using Logging;

namespace ProjectBot
{
    public partial class FormMenu : Form
    {
        public const double coeffOfDenomination= 0.0001;
        FormCart formCart;
        FormError formError;
        public Dishes selectedDish;
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

            Logger.Log.Info("Select Menu item");

            DishMenus dishMenus = CBoxMenu.SelectedItem as DishMenus;
            CBoxDishes.DataSource = dishMenus.Dishes;
            CBoxDishes.DisplayMember = "Title";            
        }
        private void CBoxDishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logger.Log.Info("Select Dish");

            selectedDish = CBoxDishes.SelectedItem as Dishes;
            PictureBox1.ImageLocation = selectedDish.Image;
            LblDish.Text = selectedDish.Title;
            LblIngredients.Text = selectedDish.Body;
            LblPrice.Text = $"{selectedDish.Cost * coeffOfDenomination} BYN";
            LblBotBottom.Text = Bot.BotAnswer().ToLower();           
        }

        
        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            Logger.Log.Info("Button \"Add to cart\" clicked");

            if (selectedDish.IsAvailable)
            {
                formCart.CBoxOrder.Items.Add(selectedDish);
                formCart.CBoxOrder.DisplayMember = "Title";
                LblBotBottom.Text =Bot.BotHint();
                GetInfo(selectedDish);
            }
            else
            {
                Logger.Log.Warn("Error: Dish isn't available");

                formError.Show();
            }
                                         
        }        
        private void GetInfo(Dishes dish)
        {
            Logger.Log.Info("Method \"Get Info\" called");

            Bot.Count = formCart.CBoxOrder.Items.Count;
            formCart.LblCount.Text = Bot.Count.ToString();
            Bot.Sum += dish.Cost * coeffOfDenomination;
            formCart.LblSum.Text = $"{Bot.Sum} BYN";
        }
        private void BtnCart_Click(object sender, EventArgs e)
        {
            Logger.Log.Info("Button \"Cart\" clicked");

            formCart.Show();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Logger.Log.Info("Application closed");

            Application.Exit();
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
                mouseX = MousePosition.X - 340;
                mouseY = MousePosition.Y-20;

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
