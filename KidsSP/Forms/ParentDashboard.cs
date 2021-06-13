using KidsSP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidsSP
{
    public partial class ParentDashboard : Form
    {
        private FamilyUnit familyUnit;
        public ParentDashboard(FamilyUnit familyUnit)
        {
            this.familyUnit = familyUnit;
            InitializeComponent();
        }
    }
}
