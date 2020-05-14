using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBot.Menu
{
    public class Menus
    {
        [JsonProperty("dishMenus")]
        public IEnumerable<DishMenus> DishMenus { get; set; }
    }
}
