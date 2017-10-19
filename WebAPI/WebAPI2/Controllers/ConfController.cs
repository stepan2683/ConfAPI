using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI2.Controllers
{
    public class ConfController : ApiController
    {
        [HttpGet]
        public void GetAll()
        {
            var cs = $"Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword; ";

            var server = "c228wq.forpsi.com";
            var database = "f96194";
            var uid = "f96194";
            var password = "8VeqtaX";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            var connection = new SqlConnection(connectionString);




            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand command = new SqlCommand("Select id from test where name=@zip", conn);
            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader["id"]));
                }
            }

            conn.Close();

        }
    }
}
