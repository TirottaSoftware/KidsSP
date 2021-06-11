using KidsSP.Models;
using KidsSP.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsSP.Database
{
    public static class DatabaseController
    {
        public static void RegisterFamilyUnit(FamilyUnit familyUnit)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.FamilyUnits.Add(familyUnit);
            db.SaveChanges();
        }
        public static void RegisterParent(string username, string firstName, string lastName, string phoneNr, string email, DateTime dob, string password)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            string hashedPassword = PasswordHasher.HashPassword(password);

            User user = new Parent(username,firstName, lastName, phoneNr, email, dob , hashedPassword);
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}
