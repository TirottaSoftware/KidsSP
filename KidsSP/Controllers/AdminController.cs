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
                DatabaseController.RegisterParent(
                    username,
                    parent.FirstName, 
                    parent.LastName, 
                    parent.PhoneNumber,
                    parent.Email,
                    parent.DateOfBirth, 
                    parentPassword);
            }
            DatabaseController.RegisterFamilyUnit(familyUnit);
        }
        public static void RejectFamilyUnit(FamilyUnit familyUnit)
        {
            //TODO: Add registration status checking
        }
    }
}
