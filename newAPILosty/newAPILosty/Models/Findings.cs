using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newAPILosty.Models
{
    public class Findings
    {
        public int FindingId { get; set; }
        public int UserId { get; set; }
        public string FindingName { get; set; }
        public int ItemId { get; set; }
        public string FindingDate { get; set; }
        public string FindinigLocation { get; set; }
        public int FindingStatus { get; set; }
        public string FindingDescription { get; set; }
        public string FindingModel { get; set; }

        public Findings(int findingId, int userId, string findingName, int itemId, string findingDate,
        string findinigLocation, int findingStatus, string findingDescription, string findingModel)
        {
            FindingId = findingId;
            UserId = userId;
            FindingName = findingName;
            ItemId = itemId;
            FindingDate = findingDate;
            FindinigLocation = findinigLocation;
            FindingStatus = findingStatus;
            FindingDescription = findingDescription;
            FindingModel = findingModel;
        }
    }
}