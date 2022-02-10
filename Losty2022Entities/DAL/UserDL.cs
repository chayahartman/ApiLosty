
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class UserDL
    {
        public List<tblUser> GetAllUsers()
        {
           
            List<tblUser> lsUsers=new List<tblUser>();
            using (losty2022Entities db = new losty2022Entities())
            {

               foreach(tblUser u in db.tblUsers)
                {
                    lsUsers.Add(u);

                }

            }
            return lsUsers;
        }
    }
}
