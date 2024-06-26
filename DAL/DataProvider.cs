﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataProvider
    {
        public static SqlConnection OpenConnection()
        {
            string strConnection = @"server=DANGLAI_PC\DANGLAI_PC;"
                + "database=FAMILY_DOCTOR;Integrated Security=True;"
                + "Trusted_Connection=true";

            //string strConnection = @"server=(LocalDB)\MSSQLLocalDB;"
            //    + "database=FAMILY_DOCTOR;Integrated Security=True;"
            //    + "Trusted_Connection=true";

            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            return connection;
        }

        private static void CloseConnection(SqlConnection connection)
        {
            connection.Close();
        }
        public static DataTable Execute(string query)
        {
            SqlConnection connection = OpenConnection();
            DataTable table = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(table);
            }
            catch
            {
                table = null;
            }
            CloseConnection(connection);
            return table;
        }

        public static bool ExecuteNonQuery(string query)
        {
            SqlConnection connection = OpenConnection();
            int result;
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                result = command.ExecuteNonQuery();
            }
            catch
            {
                result = 0;
            }
            CloseConnection(connection);
            return result > 0;
        }
    }
}
