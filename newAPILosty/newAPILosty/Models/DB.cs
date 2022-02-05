using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newAPILosty.Models
{
    public static class DB
    {
        //רשימת פריטים
        public static List<Items> lsItems = new List<Items>();
        //רשימת אבדות
        public static List<Losses> lsLosses = new List<Losses>();
       // הגדרות מייל  רשימת
        public static List<EmailSettings> lsEmailSettings = new List<EmailSettings>();
        //רשימת שאלות
        public static List<Questions> lsQuestions = new List<Questions>();
    }
}