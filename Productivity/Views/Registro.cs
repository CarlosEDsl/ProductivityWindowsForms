using Productivity.Controllers;
using Productivity.Models;
using System;
using System.Windows.Forms;

namespace Productivity
{
    public partial class Registro : Form
    {
        private static Registro instance;

        public static Registro Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Registro();
                }
                return instance;
            }
        }

        private UserController userController;

        private Registro()
        {
            InitializeComponent();
            userController = UserController.Instance;
            FormClosed += (s, e) => instance = null;
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

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Erro! Nome vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Erro! Email vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Erro! Senha vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Erro! Senha muito curta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (name.Length < 5)
            {
                MessageBox.Show("Erro! Nome muito curto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (email.Length < 5)
            {
                MessageBox.Show("Erro! Email muito curto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
