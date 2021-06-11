using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsSP.Models
{
    public abstract class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        protected User()
        {

        }
        protected User(string username, string email, string pwdHash)
        {
            this.Username = username;
            this.Email = email;
            this.PasswordHash = pwdHash;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}| {this.Username}: {this.Email}";
        }
    }
}
