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
          
                mylist = (from x in db.Users where x.UserName == username && x.Password == loginName select x).ToList();

               
            }
            return mylist;
            
        }
        /////////////////////////////////////////////////////////////
        public static List<Person> GetPersonID(List<User> userList)
        {
            List<Person> personList = null;
            using (DvtRecruitEntities db = new DvtRecruitEntities())
            {
              

                foreach (var item in userList)
                {
                    personList = (from y in db.People where y.UserId == item.UserId select y).ToList();
                }

            }
            return personList;

        }

        public static List<EmploymentType> getEmploymentType()
        {
            List<EmploymentType> empType = null;
            using (DvtRecruitEntities db = new DvtRecruitEntities())
            {



                empType = (from y in db.EmploymentTypes select y).ToList();
            }
               
                return empType;
        }

    }
}