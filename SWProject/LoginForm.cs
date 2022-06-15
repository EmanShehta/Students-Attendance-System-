using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWProject
{
    public partial class LoginForm : Form
    {
        user user;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userpassword= password.Text.ToString(),useremail = email.Text.ToString();

            user = new user();
            bool login = user.Login(useremail,userpassword);

            if(login)
            {
                 menu Menu = new menu(user);
                 this.Hide();
                 Menu.ShowDialog();
                 this.Close();
            }else
            {
                
                MessageBox.Show("Invlaid (Email) or Password");
            }
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
    }
}
