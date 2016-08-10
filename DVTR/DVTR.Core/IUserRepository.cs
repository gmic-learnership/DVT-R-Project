using DVTR.DVTR.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVTR.DVTR.Core
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        void AddUser(User user);
        void Save();
        string GetUserPassword(string loginName);
    }
}
