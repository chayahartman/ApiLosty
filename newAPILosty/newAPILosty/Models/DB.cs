using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace newAPILosty.Models
{
    public static class DB
    {
        //רשימת פרמטרים
        public static List<SqlParameter> lsParam = new List<SqlParameter>();

        //רשימת משתמשים
        public static List<Users> lsUsers = new List<Users>();
        //רשימת פריטים
        public static List<Items> lsItems = new List<Items>();
        //רשימת אבדות
        public static List<Losses> lsLosses = new List<Losses>();
        //רשימת מציאות
        public static List<Findings> lsFindings = new List<Findings>();
        // הגדרות מייל  רשימת
        public static List<EmailSettings> lsEmailSettings = new List<EmailSettings>();
        //רשימת שאלות
        public static List<Questions> lsQuestions = new List<Questions>();
        //רשימת שאלות  למציאות
        public static List<QuestionsFindings> lsQuestionsFindings = new List<QuestionsFindings>();
    }
}