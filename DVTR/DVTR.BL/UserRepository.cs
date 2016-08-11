using DVTR.DVTR.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DVTR.DVTR.DAL;

namespace DVTR.DVTR.BL
{
    public class UserRepository : IUserRepository
    {
        DvtRecruitEntities db = new DvtRecruitEntities();
        public void AddUser(User user)
        {
            db.Users.Add(user);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<User> GetUsers()
        {
            return db.Users.ToList();
        }

        public string GetUserPassword(string loginName)
        {
            
                var user = db.Users.Where(u => u.UserName.ToLower().Equals(loginName));

                if (user.Any())
                {
                    return user.FirstOrDefault().Password;
                }
                else
                {
                    return string.Empty;
                }
            
        }
        public List<Education> GetUserEductionList(int personID)
        {
            return db.Educations.Where(u => u.PersonId.Equals(personID)).ToList();
        }

    }
}