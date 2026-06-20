using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace surf_Board
{
   
        class DBConnection
        {
            private static string connectionString = "server=localhost;user=root;password=;database=aquaridedb";

            public static MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
        }
    
}
