using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;
namespace SWProject
{
    class Database
    {
         OracleCommand cmd =new OracleCommand();

        public string query;
        public  Dictionary<string,string>Pararmters= new Dictionary<string, string>();

         public Database(OracleConnection conn)
         {
                cmd.Connection=conn;
         }

        public int ExcuteQuery()
         {
                cmd.CommandText=query;
               foreach(var key in Pararmters)
                {
                    cmd.Parameters.Add(key.Key,key.Value);
                }

                cmd.CommandType=CommandType.Text;
            int res;
                try
                {
                    res=cmd.ExecuteNonQuery();
                }catch(Exception e)
                {
                    res=-1;
                }
               
               return res;
         }
        public OracleDataReader getData()
         {
                cmd.CommandText=query;
               foreach(var key in Pararmters)
                {
                    cmd.Parameters.Add(key.Key,key.Value);
                }
                cmd.CommandType=CommandType.Text;
                
               return cmd.ExecuteReader();
        }
        public int getProcudervalue()
        {
            cmd.CommandText=query;
            cmd.CommandType=CommandType.StoredProcedure;
             foreach(var key in Pararmters)
                {
                    cmd.Parameters.Add(key.Key,key.Value);
                }
             cmd.Parameters.Add("COUNT_ATT",OracleDbType.Int32,ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            string value =cmd.Parameters["COUNT_ATT"].Value.ToString();
             
            return Convert.ToInt32(value); 
        }

        public OracleDataReader getDataProcedure()
        {
                cmd.CommandText=query;
                cmd.CommandType=CommandType.StoredProcedure;
                foreach(var key in Pararmters)
                    {
                        cmd.Parameters.Add(key.Key,key.Value);
                    }
                cmd.Parameters.Add("DATA_ALL",OracleDbType.RefCursor,ParameterDirection.Output);
               return cmd.ExecuteReader(); 
        }

    }
}
