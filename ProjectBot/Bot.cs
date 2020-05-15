using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectBot.Menu;

namespace ProjectBot
{
    public class Bot
    {
        public static double Sum { get; set; }
        public static int Count { get; set; }
        
        public static string BotAnswer()
        {
            return "Exellent choice!Now click \"Add to cart\"";
        }
        public static string BotHint() 
        {
            return "Click on the CART to view your order";
        } 
    }
}
