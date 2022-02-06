using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newAPILosty.Models
{
    public class QuestionsFindings
    {
        public int FindingId { get; set; }
        public int QuestionId { get; set; }

        public QuestionsFindings(int findingId, int questionId)
        {
            FindingId = findingId;
            QuestionId = questionId;
        }
    }
}