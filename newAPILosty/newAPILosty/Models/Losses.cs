using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newAPILosty.Models
{
    public class Losses
    {
        public int lostId { get; set; }
        public int userId { get; set; }
        public string lostName { get; set; }
        public int itemId { get; set; }
        public string lostDate { get; set; }
        public string lostLocation { get; set; }
        public int lostStatus { get; set; }
        public string lostDescription { get; set; }
        public string lostModel { get; set; }
        public string returnDate { get; set; }

        public Losses(int lostId, int userId, string lostName, int itemId, string lostDate, string lostLocation, int lostStatus, string lostDescription, string lostModel, string returnDate)
        {
            this.lostId = lostId;
            this.userId = userId;
            this.lostName = lostName;
            this.itemId = itemId;
            this.lostDate = lostDate;
            this.lostLocation = lostLocation;
            this.lostStatus = lostStatus;
            this.lostDescription=lostDescription;
            this.lostModel = lostModel;
            this.returnDate = returnDate;

        }

       
    }
}