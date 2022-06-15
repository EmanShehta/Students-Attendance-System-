using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Windows.Forms;

namespace SWProject
{
    public partial class TakeAttendance : Form
    {
        string path = "Data Source=ORCL;User Id=hr;Password=hr";
        OracleConnection conn;
        Database db;
        OracleDataReader dr;
        user LoggedUsered;
        public TakeAttendance(user user)
        {
            LoggedUsered=user;
            InitializeComponent();
        }

        private void TakeAttendance_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(path);
            conn.Open();
            db = new Database(conn);
            dr = LoggedUsered.getCourses();
            while(dr.Read())
             {
                Courses_id.Items.Add(dr["TEXT"].ToString());  
             }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string course = Courses_id.SelectedItem.ToString();
            string [] cours_id  = course.Split('-');

            string stud_id = student_id.Text.ToString();

            db = new Database(conn);
            db.query = @"SELECT M.PK
                     FROM COURSE_DETAILS M
                     INNER JOIN COURSE C ON C.PK=M.COURSE
                     INNER JOIN USERS U ON U.PK = M.STUDENT
                     WHERE U.STUDENT_ID =:ID AND C.PK = :COURSE";

            db.Pararmters["ID"]=stud_id;
            db.Pararmters["COURSE"]=cours_id[0];

            dr = db.getData();

            string Course_details = "0"; 
            while(dr.Read())
            {
                    Course_details = dr[0].ToString();
            }
           
            db = new Database(conn);
            db.query=@"INSERT INTO ATTENDANCES(COURSE_DETAILS)
                    VALUES(:COURSE_DETAILS)";
            db.Pararmters["COURSE_DETAILS"] = Course_details;
            int res = db.ExcuteQuery();

            if(res == 1)
             {
                MessageBox.Show("The Attendace has been taken");
                student_id.Text="";
                Courses_id.Text="";
             }else
             {                
                MessageBox.Show("Sorry ID or Student isnt enrolled in this course");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click_1(object sender, EventArgs e)
        {
             menu menu = new menu(LoggedUsered);
            this.Hide();
            menu.ShowDialog();
            this.Dispose();
        }
    }
}
