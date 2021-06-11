using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsSP.Models.Users
{
    public class Receptionist : User
    {
        public Receptionist()
        {
        }

        public Receptionist(string username, string email, string pwdHash) : base(username, email, pwdHash)
        {
        }
    }
}
