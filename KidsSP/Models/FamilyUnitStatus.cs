using KidsSP.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsSP.Models
{
    public class FamilyUnitStatus
    {
        [Key]
        public int Id { get; set; }
        public int FamilyUnitId { get; set; }
        public virtual FamilyUnit FamilyUnit { get; set; }
        public string Status { get; set; }
        public FamilyUnitStatus()
        {

        }
        public FamilyUnitStatus(FamilyUnit unit, RegistrationStatus status)
        {
            this.FamilyUnit = unit;
            this.Status = status.ToString();
        }
    }
}
