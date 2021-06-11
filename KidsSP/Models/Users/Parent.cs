using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsSP.Models.Users
{
    public class Parent : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Parent()
        {
        }
        public Parent(string firstName, string lastName, string phoneNr, string email, DateTime dob)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNr;
            this.DateOfBirth = dob;
            this.Email = email;
        }
        public Parent(string username, string email, string pwdHash) : base(username, email, pwdHash)
        {
        }
        public Parent(string username, string firstName, string lastName, string phoneNr, string email, DateTime dob, string pwdHash) : base(username, email, pwdHash)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNr;
            this.DateOfBirth = dob;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
