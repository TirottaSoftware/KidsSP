using KidsSP.Controllers;
using KidsSP.Models;
using KidsSP.Models.Users;
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
        private FamilyUnitManager manager;
        public ParentDashboard(FamilyUnit familyUnit)
        {
            this.familyUnit = familyUnit;
            this.manager = new FamilyUnitManager();
            InitializeComponent();
            foreach (var parent in this.familyUnit.Parents)
            {
                lbxParents.Items.Add(parent);
            }
        }

        private void btnAddParent_Click(object sender, EventArgs e)
        {
            //Open new form
        }

        private void btnSaveParent_Click(object sender, EventArgs e)
        {
            Parent p = (Parent)lbxParents.SelectedItem;
            string firstName = tbxParentFirstName.Text;
            string lastName = tbxParentLastName.Text;
            string email = tbxParentEmail.Text;
            string phoneNr = tbxParentPhoneNr.Text;
            Parent updatedParent = new Parent(firstName, lastName, phoneNr, email, p.DateOfBirth);
            manager.UpdateParent(p, updatedParent);
        }

        private void btnSaveChild_Click(object sender, EventArgs e)
        {
            Child c = (Child)lbxChildren.SelectedItem;
            string firstName = tbxChildFirstName.Text;
            string lastName = tbxChildLastName.Text;
            Child updatedChild = new Child(firstName, lastName, c.DateOfBirth);
            manager.UpdateChild(c, updatedChild);
        }
    }
}
