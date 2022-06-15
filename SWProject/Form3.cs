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
    public partial class Form3 : Form
    {
         string path = "Data Source=ORCL;User Id=hr;Password=hr";
        OracleConnection conn;
        Database db;
        OracleDataReader dr;
        user user;

        public Form3(user user)
        {
            this.user= user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string messge = message.Text.ToString();
            string course = Courses_id.SelectedItem.ToString();
            string [] cours_id  = course.Split('-');
            db = new Database(conn);
            db.query= @"INSERT INTO course_coplaint(COURSE,STUDENT,MESSAGE)
                        VALUES(:COURSE,:STUDENT,:MESSAGE)";
            db.Pararmters["COURSE"] = course[0].ToString();
            db.Pararmters["STUDENT"] = "10";
            db.Pararmters["MESSAGE"] = messge;

            int re = db.ExcuteQuery();
            if(re == 1)
             {
                
                    MessageBox.Show("You Message has been sent Successffull");
                    message.Text=  " ";
                Courses_id.Text= " ";

            }
            else
            {
                MessageBox.Show("Enter Valid data");
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
             conn = new OracleConnection(path);
            conn.Open();
            db = new Database(conn);
                    db.query = @"SELECT C.PK ||'-'|| C.NAME TEXT
                    FROM COURSE_DETAILS M 
                    INNER JOIN COURSE C ON C.PK=M.COURSE
                    INNER JOIN USERS U ON U.PK = M.STUDENT
                    WHERE U.PK=:PK";
                    db.Pararmters["PK"] ="10";
             dr = db.getData();
            while(dr.Read())
             {
                Courses_id.Items.Add(dr["TEXT"].ToString());  
             }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            menu menu = new menu(user);
            this.Hide();
            menu.ShowDialog();
            this.Close();
               
        }

        private void Courses_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
