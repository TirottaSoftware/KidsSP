using KidsSP.Models;
using KidsSP.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsSP.Controllers
{
    public class FamilyUnitManager
    {
        public void AddParent(Parent parent)
        {
            //DBController.RegisterParent(parent);
        }
        public void AddChild(Child child)
        {
            //DBController.RegisterChild(child);
        }
        public void UpdateParent(Parent parent, Parent updatedParent)
        {
            //DBController.UpdateUser(parent, updatedParent);
        }
        public void UpdateChild(Child child, Child updatedChild)
        {
            //DBController.UpdateChild(child, updatedChild);
        }
        public void UpdateFamilyUnit(FamilyUnit unit, FamilyUnit updatedFamilyUnit)
        {

        }
    }
}
