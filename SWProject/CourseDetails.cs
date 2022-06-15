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
using System.Collections;
using System.Linq;
namespace SWProject
{

    public partial class CourseDetails : Form
    {
        user user;
        string path = "Data Source=ORCL;User Id=hr;Password=hr";
        OracleConnection conn;
        Database db;
        OracleDataReader dr;
        OracleDataAdapter adapter;
        DataSet dataSet;
        string Sqlattendance = @"SELECT NVL(M.GRADE,0) GRADE,U3.NAME STUDENT_NAME,U3.EMAIL STUDENT_EMAIL
        ,U2.NAME ASSISTANT_NAME,U2.EMAIL ASSISTANT_EMAIL,NVL(m.ATTENDANCE_DAY,0) ATTENDANCE_DAY,
        C.NAME COURSE_NAME,DP.NAME DEPARTMENT_NAME
        FROM COURSE_DETAILS M 
        INNER JOIN USERS U ON U.PK = M.professor
        INNER JOIN USERS U2 ON U2.PK = M.ASSISTANT
        INNER JOIN USERS U3 ON U3.PK = M.STUDENT
        INNER JOIN COURSE C ON C.PK = M.COURSE
        INNER JOIN department DP ON DP.PK =C.department
        WHERE U.PK=:STUDENT AND C.PK=:COURSE";

        public CourseDetails(user user)
        {
            this.user= user;
            InitializeComponent();
        }

        private void CourseDetails_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(path);
            conn.Open();
            dr = user.getCourses();
            while(dr.Read())
             {
                cmb_courses.Items.Add(dr["TEXT"].ToString());  
             }

        }

        private void CourseDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void CourseDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
             conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_courses_SelectedIndexChanged(object sender, EventArgs e)
        {
          this.fillData();
        }
        public void fillData()
        {
            string course = cmb_courses.SelectedItem.ToString();
            string [] cours_id  = course.Split('-');

            db = new Database(conn);
            db.query=@"SELECT COUNT (*) 
                        FROM course_details M
                        INNER JOIN USERS U ON U.PK =m.professor
                        INNER JOIN course C ON C.PK= M.COURSE
                        WHERE U.PK=:PROFESSOR AND C.PK=:COURSE";
            db.Pararmters["PROFESSOR"] =user.id.ToString();
            db.Pararmters["COURSE"] =cours_id[0];
            dr = db.getData();
            while (dr.Read())
            {
                student_count.Text=dr[0].ToString();
            }
            adapter = new OracleDataAdapter(Sqlattendance,path);
            adapter.SelectCommand.Parameters.Add("PROFESSOR",user.id.ToString());
            adapter.SelectCommand.Parameters.Add("COURSE",cours_id[0]);
            dataSet = new DataSet();
            adapter.Fill(dataSet,"DataTable1");

            dataSet.Tables[0].Columns["DEPARTMENT_NAME"].ColumnName =user.lang=="ar"? "القسم": "Department";
            dataSet.Tables[0].Columns["COURSE_NAME"].ColumnName = user.lang=="ar"? "الكورس": "COURSE";
            dataSet.Tables[0].Columns["STUDENT_NAME"].ColumnName = user.lang=="ar"? "اسم الطالب": "Student Name";
            dataSet.Tables[0].Columns["STUDENT_EMAIL"].ColumnName = user.lang=="ar"? "اميل الطالب": "Student Email";

            dataSet.Tables[0].Columns["ASSISTANT_NAME"].ColumnName = user.lang=="ar"? "اسم المعيد": "Assistant Name";
            dataSet.Tables[0].Columns["ASSISTANT_EMAIL"].ColumnName = user.lang=="ar"? "اميل المعيد": "Assistant Email";

            dataSet.Tables[0].Columns["ATTENDANCE_DAY"].ColumnName = user.lang=="ar"? "عدد ايام الحضور": "Attendance Day";
            dataSet.Tables[0].Columns["GRADE"].ColumnName = user.lang=="ar"? "مجموع الدرجات ": "Total Grades";
            
            dataGridView1.DataSource= dataSet.Tables[0];
        }
        public void UpdateData()    
        {
            adapter.UpdateCommand = new OracleCommandBuilder(adapter).GetUpdateCommand();
            adapter.Update(dataSet.Tables[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void Report_Click(object sender, EventArgs e)
        {
        
             string Sqlattendance = @"SELECT M.PK,NVL(M.GRADE,0) GRADE,U3.NAME STUDENT_NAME,U3.EMAIL STUDENT_EMAIL
                                    ,U2.NAME ASSISTANT_NAME,U2.EMAIL ASSISTANT_EMAIL,NVL(m.ATTENDANCE_DAY,0) ATTENDANCE_DAY,
                                    C.NAME COURSE_NAME,DP.NAME DEPARTMENT_NAME
                                    FROM COURSE_DETAILS M 
                                    INNER JOIN USERS U ON U.PK = M.professor
                                    INNER JOIN USERS U2 ON U2.PK = M.ASSISTANT
                                    INNER JOIN USERS U3 ON U3.PK = M.STUDENT
                                    INNER JOIN COURSE C ON C.PK = M.COURSE
                                    INNER JOIN department DP ON DP.PK =C.department
                                    WHERE U.PK=:professor";
            adapter = new OracleDataAdapter(Sqlattendance,path);
            adapter.SelectCommand.Parameters.Add("professor",user.id.ToString());

            DataSet1 dataset = new DataSet1();
            adapter.Fill(dataset,"DataTable1");

            ProfessorReporting professorset = new ProfessorReporting();
            professorset.SetDataSource(dataset);
            ProfessorReports professor = new ProfessorReports();
            professor.professorRP.ReportSource=professorset;
            professor.ShowDialog();
        }

        private void back_Click(object sender, EventArgs e)
        {
            menu menu = new menu(user);
            this.Hide();
            menu.ShowDialog();
            this.Close();
       
        }
    }
}
