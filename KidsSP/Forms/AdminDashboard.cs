using KidsSP.Database;
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
    public partial class AdminDashboard : Form
    {
        private Admin admin;
        private ApplicationDbContext db;
        public AdminDashboard(Admin admin)
        {
            this.admin = admin;
            this.db = new ApplicationDbContext();
            InitializeComponent();
            foreach (var user in db.Users)
            {
                lbxUsers.Items.Add(user.ToString()); 
            }
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
