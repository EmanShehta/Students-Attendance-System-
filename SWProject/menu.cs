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
    public partial class menu : Form
    {
        user userLogged;
        public menu(user user)
        {
            userLogged= user;
            InitializeComponent();
            if(user.Roles==0)
            {
                take_attadnace.Visible=false;
                register_user.Visible=false;
                CourseDetails.Visible=false;
                assignCourse.Visible=false;
                registerCourse.Visible=false;
            }else if(user.Roles ==3)
             {
                Attendance_details.Visible=false;
                register_user.Visible=false;
                CourseDetails.Visible=false;
                assignCourse.Visible=false;
                registerCourse.Visible=false;
            }else if (user.Roles == 2)
            {
                Attendance_details.Visible=false;
                register_user.Visible=false;
                assignCourse.Visible=false;
                registerCourse.Visible=false;
            }
            else if(user.Roles ==1)
             {
                take_attadnace.Visible=false;
                Attendance_details.Visible=false;   
                make_complaint.Visible=false;
                 CourseDetails.Visible=false;
                
              }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TakeAttendance me = new TakeAttendance(userLogged);
            this.Hide();
            me.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 me = new Form3(userLogged);
            this.Hide();
            me.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showAttForm me = new showAttForm(userLogged);
            this.Hide();
            me.ShowDialog();
            this.Close();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void take_attadnace_Click(object sender, EventArgs e)
        {
             TakeAttendance me = new TakeAttendance(userLogged);
            this.Hide();
            me.ShowDialog();
            this.Close();

        }

        private void make_complaint_Click(object sender, EventArgs e)
        {
            Form3 me = new Form3(userLogged);
            this.Hide();
            me.ShowDialog();
            this.Close();

        }

        private void Attendance_details_Click(object sender, EventArgs e)
        {
            showAttForm me = new showAttForm(userLogged);
            this.Hide();
            me.ShowDialog();
            this.Close();
        }

        private void register_user_Click(object sender, EventArgs e)
        {
            register regist = new register(userLogged);
            this.Hide();
            regist.ShowDialog();
            this.Close();
        }

        private void CourseDetails_Click(object sender, EventArgs e)
        {
            CourseDetails cd =new CourseDetails(userLogged);

            this.Hide();
            cd.ShowDialog();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Dispose();
        }

        private void assignCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignCourses assign = new AssignCourses(userLogged);
            this.Hide();
            assign.ShowDialog();
            this.Dispose();
        }

        private void registerCourse_Click(object sender, EventArgs e)
        {
            RegisterNewCourse re = new RegisterNewCourse(userLogged);
            this.Hide();
            re.ShowDialog();
            this.Dispose();
        }
    }
}
