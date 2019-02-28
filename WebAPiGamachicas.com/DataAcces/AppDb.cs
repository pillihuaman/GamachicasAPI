using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WebAPiGamachicas.com.DataAcces
{
    public class AppDb 
    {
   
        //public  string ConnectionString { get; set; }

        //public AppDb(string connectionString=null)
        //{
        //    ConnectionString = connectionString;
        //}

        public   MySqlConnection GetConnection()
        {
            return new MySqlConnection(null);
        }

        //public AppDb(string connectionString)
        //{
        //    Connection = new MySqlConnection(connectionString);
        //}

        //public void Dispose()
        //{
        //    Connection.Close();
        //}
    }
}
