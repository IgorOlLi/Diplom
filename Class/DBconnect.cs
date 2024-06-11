using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    internal class DBconnect
    {
        static string host = "127.0.0.1";
        static string port = "3306";
        static string database = "diplom";
        static string username = "root";
        static string password = "";
        public static MySqlConnection GetDBConnection()
        { 
            string connString = $"server={host};port={port};user={username};database={database};password={password};";
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}
