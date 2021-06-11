using KidsSP.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsSP.Models
{
    public class FamilyUnit
    {
        private List<Child> children;
        private List<Parent> parents;
        [Key]
        public int Id { get; set; }
        public string FamilyUnitName { get; set; }
        public string Comment { get; set; }
        public List<Child> Children => this.children;
        public List<Parent> Parents => this.parents;
        public FamilyUnit(string familyUnitName, List<Child> children, List<Parent> parents)
        {
            this.FamilyUnitName = familyUnitName;
            this.children = children;
            this.parents = parents;
        }
    }
}
