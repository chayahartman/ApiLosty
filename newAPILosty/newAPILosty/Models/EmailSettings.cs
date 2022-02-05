using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newAPILosty.Models
{
    public class EmailSettings
    {
        public int emailSettingsId { get; set; }
        public int userId { get; set; }
        public bool emailAboutBewRequest { get; set; }
        public bool emailFromAnotherUser { get; set; }
        public bool systemEmailAboutExistsRequest { get; set; }

        public EmailSettings(int em,int userId,bool eabr,bool efau,bool seaer)
        {
            this.emailSettingsId = em;
            this.userId = userId;
            this.emailAboutBewRequest = eabr;
            this.emailFromAnotherUser = efau;
            this.systemEmailAboutExistsRequest = seaer;
        }
    }
}