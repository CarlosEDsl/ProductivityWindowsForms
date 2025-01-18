using Productivity.Controllers;
using Productivity.Models;
using System;
using System.Windows.Forms;

namespace Productivity
{
    public partial class Registro : Form
    {
        private UserController userController;
        public Registro()
        {
            InitializeComponent();
            userController = UserController.Instance;
        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void register_Click(object sender, EventArgs e)
        {
            string email = this.emailbox.Text;
            string password = this.passbox.Text;
            string name = this.namebox.Text;
            string cell = this.telebox.Text;

            User user = new User(email, password, name, cell);
            user.Id = 0;

            User userRegistered = await userController.Register(user);
            if (userRegistered != null)
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
