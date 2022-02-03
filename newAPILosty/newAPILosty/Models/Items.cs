using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newAPILosty.Models
{
    //[Serializable]
    public class Items
    {
        
        public int itemId { get; set; }
        public string itemName { get; set; }

        public Items(int itemId, string itemName)
        {
            this.itemId = itemId;
            this.itemName = itemName;
        }
    }
}