using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHairLibrary.Database
{

    public class DatabaseFacade
    {
        private OrderRepository oRep = OrderRepository.Instance;
        private static string connectionString =
          "Server=ealdb1.eal.local; Database=ejl78_db; User Id=ejl78_usr; Password=Baz1nga78;";

        private List<Order> GetOrders()
        {
            
        
            using (SqlConnection sqlConnection1 = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                cmd.CommandText = "SELECT * FROM OrderLine";
                cmd.CommandType = CommandType.Text;

                cmd.Connection = sqlConnection1;
                sqlConnection1.Open();
                reader = cmd.ExecuteReader();
               
                
                sqlConnection1.Close();
            }

        }
       

    }
}
