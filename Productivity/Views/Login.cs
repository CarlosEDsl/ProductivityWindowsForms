using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productivity
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(emailForm.Text.Equals("Teste") && passForm.Text.Equals("123"))
                {
                    var menu = new Menu();
                    this.Hide();
                    menu.ShowDialog();

                    this.Show();
                } else
                {
                    MessageBox.Show("Usuário ou senha incorretos",
                        "", 
                        MessageBoxButtons.OK);

                    emailForm.Focus();
                    passForm.Text = "";
                }
            }
            catch (Exception ex) { 
                MessageBox.Show("Erro", ex.Message, 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
