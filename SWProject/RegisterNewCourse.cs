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

namespace SWProject
{
    public partial class RegisterNewCourse : Form
    {
        string path = "Data Source=ORCL;User Id=hr;Password=hr";
        OracleConnection conn;
        Database db;
        OracleDataReader dr;
        user user;
        public RegisterNewCourse(user user)
        {
            this.user=user;
            InitializeComponent();
        }

        private void RegisterNewCourse_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(path);
            conn.Open();
            db= new Database(conn);
            getAllDepartment();
        }

        private void RegisterNewCourse_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
        }
        private void getAllDepartment()
         {
            db.query=@"SELECT PK || '-' || NAME TEXT FROM DEPARTMENT";
            dr= db.getData();
            while(dr.Read())
            {
                cmb_Department.Items.Add(dr["TEXT"].ToString());
            }
         }

        private void button1_Click(object sender, EventArgs e)
        {
           RegisterCourse();
        }
        private void RegisterCourse()
          {
            
            string [] dep_id  = cmb_Department.SelectedItem.ToString().Split('-');
            if(dep_id[0]==" ")
            {
                MessageBox.Show("Please Enter Department");
            }
            string course_name=textBox1.Text;
            db.query=@"INSERT INTO COURSE(NAME,DEPARTMENT)
                       VALUES(:COURSE_NAME,:DEP_NAME)";
            db.Pararmters["COURSE_NAME"]=course_name;
            db.Pararmters["DEP_NAME"]=dep_id[0];
            int result = db.ExcuteQuery();
            if(result==1)
            {
                cmb_Department.Text="";
                textBox1.Text="";
                 MessageBox.Show("Course hasb been registered");
            }else
            {
                MessageBox.Show("Invalid Data");
            }
            
          }

        private void button2_Click(object sender, EventArgs e)
        {
            AssignCourses ass = new AssignCourses(user);
            this.Hide();
            ass.ShowDialog();
            this.Dispose();
        }
    }
}
