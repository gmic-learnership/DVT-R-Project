using DVTR.DVTR.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DVTR.BL
{
    public class LoginMethod
    {
        public static List<User> GetUserPassword(string loginName,string username)
        {
            List<User> mylist = null;
            using (DvtRecruitEntities db = new DvtRecruitEntities())
            {
               var user = db.Users.Where(u => u.UserName.ToLower().Equals(loginName));
                /*
                if (user.Any())
                {
                    return user.FirstOrDefault().Password;
                }
                else
                {
                    return string.Empty;
                }*/
                mylist = (from x in db.Users where x.UserName == username && x.Password == loginName select x).ToList();
            }
            return mylist;
            
        }
    }
}