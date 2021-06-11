using KidsSP.Models;
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
            //foreach (var child in familyUnit.Children)
            //{
            //    //if(!ValidateChild(child)) throw
            //}
            //foreach (var parent in familyUnit.Parents)
            //{
            //    //if(!ValidateParent(parent)) throw
            //}
            return true;
        }
    }
}
