using KidsSP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsSP.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(): base()
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<FamilyUnit> FamilyUnits { get; set; }
        public DbSet<FamilyUnitStatus> FamilyUnitStatuses { get; set; }
    }
}
