using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProjectBot.Menu
{
    public class Dishes
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("menu_type")]
        public int Menu_type { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("portion")]
        public int Portion { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("item_number")]
        public string Item_number { get; set; }

        [JsonProperty("calories")]
        public string Calories { get; set; }

        [JsonProperty("wok_size")]
        public string Wok_size { get; set; }

        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("is_new")]
        public bool Is_new { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }
}
