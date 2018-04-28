﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Library.Repository
{
    public sealed class DbConnection
    {
        private static DbConnection _instance;
        private static object _lockThis = new object();

        private DbConnection() { }

        public static DbConnection createConnection()
        {
            lock (_lockThis)
            {
                if (_instance == null) _instance = new DbConnection();
            }
            return _instance;
        }

        public bool createQuery(string query)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
    }
}
