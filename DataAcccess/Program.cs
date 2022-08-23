using System;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace DataAcccess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my first database app");
            ConnectDB();
            Console.ReadKey();
        }


       static void ConnectDB()
        {
            string connString = "Data Source=.;Initial Catalog=AdventureWorksLT2019;Integrated Security=True";
            
            SqlConnection connect = new SqlConnection(connString);
            connect.Open();
            string sql = "select top 10 * from SalesLT.Product";
            SqlCommand cmd = new SqlCommand(sql,connect);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"the product is {reader["Name"]} and price is {reader["Listprice"]}. Thanks");
            }



        }
    }

    
}
