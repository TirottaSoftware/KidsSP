using KidsSP.Database;
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
    public partial class MainForm : Form
    {
        private ApplicationDbContext db;
        public MainForm()
        {
            db = new ApplicationDbContext();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            User user = db.Users.FirstOrDefault(u => u.Username == username);
            if(user != null)
            {
                string userHashedPassword = user.PasswordHash;

                if (PasswordHasher.VerifyPassword(userHashedPassword, password))
                {
                    if (user.GetType().Name == nameof(Admin))
                    {
                        AdminDashboard adminForm = new AdminDashboard((Admin)user);
                        this.Hide();
                        adminForm.Show();
                    }
                }
                else
                    MessageBox.Show("Invalid credentials");
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            RegisterFamilyUnitForm registerFamilyUnitForm = new RegisterFamilyUnitForm();
            this.Hide();
            registerFamilyUnitForm.ShowDialog();
            //string hashedPassword = PasswordHasher.HashPassword(tbxPassword.Text);
            //string username = tbxUsername.Text;
            //string email = username + "@gmail.com";

            //User user = new Admin(username, email, hashedPassword);
            //db.Users.Add(user);
            //db.SaveChanges();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
