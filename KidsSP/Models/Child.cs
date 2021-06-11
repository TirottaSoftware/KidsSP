using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsSP.Models
{
    public class Child
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int FamilyUnitId { get; set; }
        public virtual FamilyUnit FamilyUnit { get; set; }
        public Child(string firstName, string lastName, DateTime dob)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dob;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}