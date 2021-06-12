using KidsSP.Database;
using KidsSP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsSP.Controllers
{
    public class AdminController
    {
        public static void ApproveFamilyUnit(FamilyUnit familyUnit)
        {
            foreach (var parent in familyUnit.Parents)
            {
                string username = parent.FirstName[0] + parent.LastName;
                string parentPassword = Guid.NewGuid().ToString().Substring(0, 8);

                parent.PasswordHash = PasswordHasher.HashPassword(parentPassword);
                parent.Username = username;
            }
            DatabaseController.RegisterFamilyUnit(familyUnit);
            //TODO: Add some sort of notification service to send the parent username and password details
        }
        public static void RejectFamilyUnit(FamilyUnit familyUnit)
        {
            DatabaseController.RejectFamilyUnit(familyUnit);
        }
    }
}
