using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaSach.DA
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance 
        {
          get { if (instance == null) instance = new DataProvider(); return instance; }
          private set => instance = value; 
        }

        private DataProvider() { }
        
        private string stringconnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = E:\C#\QLNS\QLNS.mdf; Integrated Security = True; Connect Timeout = 30";

        public DataTable ExecuteQuery(string query, object[] paramater =null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(stringconnection))
            {
                connection.Open();
                SqlDataAdapter da;
                da = new SqlDataAdapter(query, connection);
                connection.Close();
                da.Fill(data);
            }

            return data;
        }

        public void ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(stringconnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
