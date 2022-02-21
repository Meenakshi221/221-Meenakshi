using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                //Creating Connection
                con = new SqlConnection(@"data source=(localdb)\MSSQLLocalDB;database=Customer_DB;
                                            integrated security=SSPI");
                //writing sql query
                SqlCommand cm = new SqlCommand("select * from CustomerDetails", con);

                //Open command
                con.Open();

                //Executing the sql 
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["Name"] + "      " + sdr["Location"] + "     " + sdr["PhoneNumber"]);
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something is wrong " + e);
            }
        }
       

    }
}
