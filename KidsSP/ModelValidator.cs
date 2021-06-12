using KidsSP.Models;
using KidsSP.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsSP
{
    public static class ModelValidator
    {
        public static bool ValidateFamilyUnit(FamilyUnit familyUnit)
        {
            if (String.IsNullOrWhiteSpace(familyUnit.FamilyUnitName))
            {
                return false;
            }
            if (familyUnit.Children.Count == 0)
            {
                return false;
            }
            if (familyUnit.Children.Count == 0 || familyUnit.Children.Count > 4)
            {
                return false;
            }
            foreach (var child in familyUnit.Children)
            {
                if (!ValidateChild(child))
                {
                    return false;
                }
            }
            foreach (var parent in familyUnit.Parents)
            {
                if (!ValidateParent(parent))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool ValidateChild(Child child)
        {
            if (String.IsNullOrEmpty(child.FirstName) || String.IsNullOrEmpty(child.LastName))
            {
                return false;
            }
            if (child.DateOfBirth > DateTime.Now)
            {
                return false;
            }
            return true;
        }
        private static bool ValidateParent(Parent parent)
        {
            if (String.IsNullOrEmpty(parent.FirstName) || 
                String.IsNullOrEmpty(parent.LastName) || 
                String.IsNullOrEmpty(parent.PhoneNumber) || 
                String.IsNullOrEmpty(parent.Email))
            {
                return false;
            }
            return true;
        }
    }
}
