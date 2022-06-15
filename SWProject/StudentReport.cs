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
    public partial class StudentReport : Form
    {
        user user;
        string path = "Data Source=ORCL;User Id=hr;Password=hr";
        OracleConnection conn;
        Database db;
        OracleDataReader dr;
        OracleDataAdapter adapter;
        DataSet dataSet;
        user Loggeduser;
        public StudentReport(user user)
        {
            this.user=user;

            InitializeComponent();
        }

        private void StudentReportCourse_Load(object sender, EventArgs e)
        {
        }
    }
}
