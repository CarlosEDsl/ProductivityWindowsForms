using System;
using System.Windows.Forms;

namespace Productivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            var register = new Registro();

            this.Hide();
            register.ShowDialog();

            this.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            var login = new Login();

            this.Hide();
            login.ShowDialog();

            this.Show();
        }
    }
}
