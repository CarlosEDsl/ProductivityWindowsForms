using System;
using System.Windows.Forms;

namespace Productivity
{
    public partial class Form1 : Form
    {
        public static Form1 instance;

        public static Form1 Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Form1();
                }
                return instance;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            var register = Productivity.Registro.Instance;

            this.Hide();
            register.ShowDialog();

            this.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            var login = Productivity.Login.Instance;

            this.Hide();
            login.ShowDialog();

            this.Show();
        }
    }
}
