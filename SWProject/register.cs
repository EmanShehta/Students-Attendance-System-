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
    public partial class register : Form
    {
        user user;
        public register(user user)
        {
            this.user=user;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            menu menu = new menu(user);
            menu.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void register_user_Click(object sender, EventArgs e)
        {
            

             string roles = role.SelectedItem.ToString();
            string [] user_role  = roles.Split('-');

            int result =user.register(user_name.Text.ToString(),user_email.Text.ToString(),user_role[0]);
            if(result==1)
            {
                 MessageBox.Show("User has been Registered");
                menu menu = new menu(user);
                this.Hide();
                this.Close();
                menu.ShowDialog();
                
            }
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
