using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newAPILosty.Models
{
    public class Questions
    {
        public int questionId { get; set; }
        public string questionContent { get; set; }

        public Questions(int questionId, string questionContent)
        {
            this.questionId = questionId;
            this.questionContent = questionContent;
        }
    }
}