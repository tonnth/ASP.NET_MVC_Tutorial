using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
namespace Tutorial.Connect
{
    public class DBConnect
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection connect = null;
            connect = new MySqlConnection("server=localhost;user id=root;password=1234;database=websitebansach; SslMode=none");
            return connect;
        }
    }
}