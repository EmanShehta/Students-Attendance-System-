using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace SWProject
{
    public partial class AssignCourses : Form
    {
        
        string path = "Data Source=ORCL;User Id=hr;Password=hr";
        OracleConnection conn;
        Database db;
        OracleDataReader dr;
        user user;
        public AssignCourses(user user)
        {
            this.user=user;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu menu = new menu(user);
            this.Hide();
            menu.ShowDialog();
            this.Dispose();
        }

        private void AssignCourses_Load(object sender, EventArgs e)
        {
            
            conn = new OracleConnection(path);
            conn.Open();
            db= new Database(conn);
            getAllCourses();
            getAllUsers();
            getAllAssistant();
            getAllProfessors();

        }
        private void getAllUsers()
        { 
            db.query=@"SELECT PK || '-' || NAME TEXT FROM USERS WHERE ROLES=0";
            dr= db.getData();
            while(dr.Read())
            {
                cmb_user.Items.Add(dr["TEXT"].ToString());
            }
            
        }
        private void getAllCourses()
        {
            
            db.query=@"SELECT PK || '-' || NAME TEXT FROM course";
            dr= db.getData();
            while(dr.Read())
            {
                cmb_course.Items.Add(dr["TEXT"].ToString());
            }
            
            
        }
        private void getAllAssistant()
        {
             db.query=@"SELECT PK || '-' || NAME TEXT FROM USERS WHERE ROLES=3";
            dr= db.getData();
            while(dr.Read())
            {
                cmb_assistant.Items.Add(dr["TEXT"].ToString());
            }
            
            
            
        }
         private void getAllProfessors()
        {
             db.query=@"SELECT PK || '-' || NAME TEXT FROM USERS WHERE ROLES=2";
            dr= db.getData();
            while(dr.Read())
            {
                cmb_professor.Items.Add(dr["TEXT"].ToString());
            }
            
            
            
        }

        private void AssignCourses_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string [] cours_id  = cmb_course.SelectedItem.ToString().Split('-');
            string [] user_id  = cmb_user.SelectedItem.ToString().Split('-');
            string [] Assistant_id  = cmb_assistant.SelectedItem.ToString().Split('-');
            string [] Professor_id  = cmb_professor.SelectedItem.ToString().Split('-');

            db.query=@"INSERT INTO course_Details(course,student,professor,assistant)
                       VALUES(:COURSE,:STUDENT,:PROFESSOR,:ASSISTANT)";

            db.Pararmters["COURSE"]=cours_id[0];
            db.Pararmters["USER"]=user_id[0];
            db.Pararmters["PROFESSOR"]=Professor_id[0];
            db.Pararmters["ASSISTANT"]=Assistant_id[0];

            int result = db.ExcuteQuery();

            if(result == 1)
            {
                cmb_assistant.Text="";
                cmb_course.Text="";
                cmb_user.Text="";
                cmb_professor.Text="";
                MessageBox.Show("Course Has been assigned");

            }
            else
            {
                MessageBox.Show("Invalid Data");
            }

        }

        private void RegisterCourse_Click(object sender, EventArgs e)
        {
            RegisterNewCourse re = new RegisterNewCourse(user);
            this.Hide();
            re.ShowDialog();
            this.Dispose();
        }
    }
}
