using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Windows.Forms;
namespace SWProject
{
    public   class user
    {
        public string name;
        public string email;
        public int id;
        public Int64 student_id;
        public string lang;
        public int Roles =0;
        Database db;
        OracleConnection conn;
        OracleDataReader dr;
        public  Dictionary<int,string>Localisation= new Dictionary<int,string>();
        string path = "Data Source=ORCL;User Id=hr;Password=hr";
        public user()
        {
            
            conn = new OracleConnection(path);
            conn.Open();
        }
        public bool  Login(string email,string password)
        {

            SHA256CryptoServiceProvider x1 = new SHA256CryptoServiceProvider();
            byte[] bs1 = System.Text.Encoding.UTF8.GetBytes(password);
            bs1 = x1.ComputeHash(bs1);
            System.Text.StringBuilder s1 = new System.Text.StringBuilder();

            foreach (byte b in bs1)
            {
                s1.Append(b.ToString("x2").ToLower());
            }
            db = new Database(conn);
        
            db.query=@"SELECT  *  FROM USERS WHERE (EMAIL =:EMAIL)  AND (PASSWORD=:PASSWORD)";
            db.Pararmters["EMAIL"]=email;
            db.Pararmters["PASSWORD"]=s1.ToString(); 
            dr= db.getData();
            while(dr.Read())
            {
                email = dr["EMAIL"].ToString();
                name = dr["NAME"].ToString();
                lang = dr["lang"].ToString();
                student_id =Int64.Parse(dr["USER_ID"].ToString());
                id = int.Parse(dr["PK"].ToString());
                Roles = int.Parse(dr["ROLES"].ToString());
                return  true;
            }
            /*db.query="LOGINFORM";
            db.Pararmters["P_EMAIL_ID"] =email_id;
            db.Pararmters["P_PASSWORD"] =s1.ToString();
            if(db.getProcudervalue() !=0)
            {
                
                return true;
            }*/
            return  false;
        }
        public OracleDataReader getCourses()
        {
            db = new Database(conn);
            db.query="GETCOURSES";
            db.Pararmters["P_ID"] =id.ToString();
            dr= db.getDataProcedure();
            return dr;
        }
        public int register(string user_name,string email,string role)
        {
            
            SHA256CryptoServiceProvider x1 = new SHA256CryptoServiceProvider();
            byte[] bs1 = System.Text.Encoding.UTF8.GetBytes("123456789");
            bs1 = x1.ComputeHash(bs1);
            System.Text.StringBuilder s1 = new System.Text.StringBuilder();

            foreach (byte b in bs1)
            {
                s1.Append(b.ToString("x2").ToLower());
            }
            db = new Database(conn);
            db.query=@"INSERT INTO USERS(NAME,EMAIL,PASSWORD,ROLES,CREATED_BY)
                    VALUES(:NAME,:EMAIL,:PASSWORD,:ROLES,:ID)";
            db.Pararmters["NAME"] = user_name;
            db.Pararmters["EMAIL"] = email;
            db.Pararmters["PASSWORD"] = s1.ToString();
            db.Pararmters["ROLES"] = role;
            db.Pararmters["ID"] = id.ToString();
            int result =0;
            try
            {
                result=db.ExcuteQuery();
                
            }catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());  
            }
            return result;
        }
        public string getName(int id)
        {

            return Localisation[id];

        }
    }
}
