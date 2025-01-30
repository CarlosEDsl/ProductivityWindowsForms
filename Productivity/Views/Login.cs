using Productivity.Controllers;
using System;
using System.Windows.Forms;

namespace Productivity
{
    public partial class Login : Form
    {
        private static Login instance;

        public static Login Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Login();
                }
                return instance;
            }
        }

        private UserController userController;

        private Login()
        {
            InitializeComponent();
            userController = UserController.Instance;
            FormClosed += (s, e) => instance = null;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = this.emailForm.Text;
                string password = this.passForm.Text;

                bool loggin = await userController.Login(email, password);

                if (loggin)
                {
                    var menu = Productivity.Menu.Instance;
                    this.Hide();
                    menu.ShowDialog();

                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos",
                        "",
                        MessageBoxButtons.OK);

                    emailForm.Focus();
                    passForm.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro", ex.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
