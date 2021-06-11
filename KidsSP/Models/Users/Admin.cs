using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsSP.Models.Users
{
    public class Admin : User
    {
        public Admin()
        {
        }

        public Admin(string username, string email, string pwdHash) : base(username, email, pwdHash)
        {
        }
    }
}
