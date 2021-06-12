using KidsSP.Models;
using KidsSP.Models.Enum;
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
            var unit = db.FamilyUnitStatuses.FirstOrDefault(u => u.Id == familyUnit.Id);
            if (unit != null)
            {
                unit.Status = RegistrationStatus.Approved.ToString();
            }
            else
            {
                db.FamilyUnitStatuses.Add(new FamilyUnitStatus(familyUnit, RegistrationStatus.Approved));
            }
            db.SaveChanges();
        }
        public static void RejectFamilyUnit(FamilyUnit familyUnit)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var unit = db.FamilyUnitStatuses.FirstOrDefault(u => u.Id == familyUnit.Id);
            if (unit != null)
            {
                unit.Status = RegistrationStatus.Rejected.ToString();
            }
            else
            {
                db.FamilyUnitStatuses.Add(new FamilyUnitStatus(familyUnit, RegistrationStatus.Rejected));
            }
            db.SaveChanges();
        }
        public static string GetFamilyUnitStatus(string familyUnitName)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var unit = db.FamilyUnitStatuses.FirstOrDefault(s => s.FamilyUnit.FamilyUnitName == familyUnitName);
            if (unit == null)
            {
                return $"Family Unit not found";
            }
            return unit.Status;
        }
    }
}
