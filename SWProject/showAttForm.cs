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
using System.Windows.Forms;

namespace SWProject
{
    public partial class showAttForm : Form
    {
        string path = "Data Source=ORCL;User Id=hr;Password=hr";
        OracleConnection conn;
        Database db;
        OracleDataReader dr;
        OracleDataAdapter adapter;
        DataSet dataSet;
        user Loggeduser;
        public showAttForm(user user)
        {
            Loggeduser = user;
            InitializeComponent();
        }

        private void showAttForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(path);
            conn.Open();
            dr = Loggeduser.getCourses();
            while(dr.Read())
             {
                Courses_id.Items.Add(dr["TEXT"].ToString());  
             }

        }

        private void Courses_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            string course = Courses_id.SelectedItem.ToString();
            string [] cours_id  = course.Split('-');

            db = new Database(conn);
          db.query="GET_ATT";
          db.Pararmters["P_student"] =Loggeduser.id.ToString();
          db.Pararmters["P_COURSE"] =cours_id[0];
          attendace_day.Text=db.getProcudervalue().ToString();

           string Sqlattendance = @"select DP.NAME DEPARTMENT_NAME,c.name COURSE_NAME,TO_CHAR(M.TRX_DATE,'DD/MM/YYYY HH:MM') TRX_DATE
                                    from attendances M
                                    INNER JOIN COURSE_DETAILS CD ON CD.PK = M.COURSE_DETAILS
                                    INNER JOIN COURSE C ON C.PK = CD.COURSE
                                    INNER JOIN USERS U ON U.PK = CD.STUDENT
                                    INNER JOIN department DP ON DP.PK =C.department
                                    WHERE U.PK=:STUDENT AND C.PK=:COURSE";
            adapter = new OracleDataAdapter(Sqlattendance,path);
            adapter.SelectCommand.Parameters.Add("STUDENT",Loggeduser.id.ToString());
            adapter.SelectCommand.Parameters.Add("COURSE",cours_id[0]);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataSet.Tables[0].Columns["TRX_DATE"].ColumnName = "ايام الحضور";
            dataSet.Tables[0].Columns["COURSE_NAME"].ColumnName = "اسم الكورس";
            dataSet.Tables[0].Columns["DEPARTMENT_NAME"].ColumnName = "اسم القسم";
            attendanceDate.DataSource= dataSet.Tables[0];

            /*while(dr.Read())
            {
                attendace_day.Text = dr[0].ToString(); 
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void attendanceDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            menu menu = new menu(Loggeduser);
            this.Hide();
            menu.ShowDialog();
            this.Close();

        }

        private void AttendanceReport_Click(object sender, EventArgs e)
        {
            ShowReport();
        }
        private void ShowReport()
        {
             string Sqlattendance = @"select TO_CHAR(M.TRX_DATE,'DD/MM/YYYY HH:MM') TRX_DATE,C.NAME,DP.NAME DEP_NAME,CD.ATTENDANCE_DAY TOTAL
                                    from attendances M
                                    INNER JOIN COURSE_DETAILS CD ON CD.PK = M.COURSE_DETAILS
                                    INNER JOIN COURSE C ON C.PK = CD.COURSE
                                    INNER JOIN USERS U ON U.PK = CD.STUDENT
                                    INNER JOIN department DP ON DP.PK =C.department
                                    WHERE U.PK=:STUDENT";
            adapter = new OracleDataAdapter(Sqlattendance,path);
            adapter.SelectCommand.Parameters.Add("STUDENT",Loggeduser.id.ToString());

            DataSet1 dataset = new DataSet1();
            adapter.Fill(dataset,"DataTable1");

            StudentReporting st = new StudentReporting();
            st.SetDataSource(dataset);
            StudentReport student = new StudentReport(Loggeduser);
            student.StudentReportCourse.ReportSource=st;
            student.ShowDialog();
            
            
            
         }
    }
}
