using KidsSP.Controllers;
using KidsSP.Database;
using KidsSP.Models;
using KidsSP.Models.Users;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KidsSP
{
    public partial class RegisterFamilyUnitForm : Form
    {
        private List<Parent> parents;
        private List<Child> children;
        public RegisterFamilyUnitForm()
        {
            this.parents = new List<Parent>();
            this.children = new List<Child>();
            InitializeComponent();
        }

        private void btnRegisterFamilyUnit_Click(object sender, EventArgs e)
        {
            //Get family unit name
            string familyUnitName = tbxFamilyUnitName.Text;
            //create new FamilyUnit(name, parents, children)
            FamilyUnit familyUnit = new FamilyUnit(familyUnitName, this.children, this.parents);
            //if theres a comment -> familyUnit.Comment = comment;
            if (rtbComment.Text.Length > 0)
            {
                familyUnit.Comment = rtbComment.Text;
            }

            //Validate & Register
            if (ModelValidator.ValidateFamilyUnit(familyUnit))
                AdminController.ApproveFamilyUnit(familyUnit);
            else
                AdminController.RejectFamilyUnit(familyUnit);
        }

        private void btnAddParent_Click(object sender, EventArgs e)
        {
            string parentFirstName = tbxParentFirstName.Text;
            string parentLastName = tbxParentLastName.Text;
            string parentPhoneNr = tbxParentPhoneNr.Text;
            string email = tbxEmail.Text;
            DateTime parentDoB = dtpParentDoB.Value; 
            Parent parent = new Parent(parentFirstName,parentLastName, parentPhoneNr, email, parentDoB);
            this.parents.Add(parent);
            UpdateGUI();
        }

        private void UpdateGUI()
        {
            lbxChildren.Items.Clear();
            lbxParents.Items.Clear();

            foreach (var parent in this.parents)
            {
                lbxParents.Items.Add(parent.ToString());
            }
            foreach (var child in this.children)
            {
                lbxChildren.Items.Add(child.ToString());
            }
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            string childFirstName = tbxChildFirstName.Text;
            string childLastNamme = tbxChildLastName.Text;
            DateTime childDoB = dtpChildDoB.Value;
            Child child = new Child(childFirstName, childLastNamme, childDoB);
            this.children.Add(child);
            UpdateGUI();
        }

        private void RegisterFamilyUnitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
