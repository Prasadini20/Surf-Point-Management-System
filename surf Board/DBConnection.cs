using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace surf_Board
{
    internal class DBConnection
    {
        public static MySqlConnection GetConnection()
        {
            string conn = "server=localhost;database=surf_point_db;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conn);
            return con;
        }
    }
}
