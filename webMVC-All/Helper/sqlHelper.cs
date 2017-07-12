using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace webMVC_All.Helper
{
    public class sqlHelper
    {
        public static DataTable Query(string str, params SqlParameter[] sp)
        {
            try {
                sqlConnection.connection.Open();
            }catch
            {
                sqlConnection.connection.Close();
            }
       
            if (sqlConnection.connection.State == ConnectionState.Open)
            {
                SqlDataAdapter da = null;
                SqlCommand sc = null;
                if (str.Contains(" "))
                {
                    da = new SqlDataAdapter(str, sqlConnection.connection);
                }
                else
                {
                    sc = new SqlCommand(str, sqlConnection.connection);
                    sc.CommandType = CommandType.Text;
                    if (sp.Length > 0)
                    {

                        foreach (SqlParameter p in sp)
                        {
                            sc.Parameters.Add(p);
                        }
                    }
                    da = new SqlDataAdapter(sc);
                }
                DataTable dt = new DataTable();
                da.Fill(dt);
                sqlConnection.connection.Close();
                return dt;
            }
            return null;
        }
        public static void NonQuery (string str,params SqlParameter [] sp)
        {
            sqlConnection.connection.Open();
            SqlCommand sc = new SqlCommand(str, sqlConnection.connection);
            if(str.Contains(" "))
            {
                sc.CommandType= CommandType.Text;
            }
            else
            {        
                sc.CommandType = CommandType.StoredProcedure;
                if (sp.Length > 0)
                {

                    foreach (SqlParameter p in sp)
                    {
                        sc.Parameters.Add(p);
                    }
                }
            }
            sc.ExecuteNonQuery();
            sqlConnection.connection.Close();
          
        }
    }
}