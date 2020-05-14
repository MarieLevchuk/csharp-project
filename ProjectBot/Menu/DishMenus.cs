using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBot.Menu
{
    public class DishMenus
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("order_by")]
        public int OrderBy { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("keeper_code")]
        public string KeeperCode { get; set; }

        [JsonProperty("dishes")]
        public IEnumerable<Dishes> Dishes { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
