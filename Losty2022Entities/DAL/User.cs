using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string userPassword { get; set; }
        public bool isManager { get; set; }
        public User(int userId, string userName, string userEmail, string userPassword, bool isManager)
        {
            this.userId = userId;
            this.userName = userName;
            this.userEmail = userEmail;
            this.userPassword = userPassword;
            this.isManager = isManager;
        }
        public User(string user)
        {
            this.userName = user;
        }


    }
}