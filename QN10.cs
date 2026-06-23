using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Lab3_Alisha_Khatri
{

    class TourismInfo
    {
        static string connectionString = "SERVER=localhost;DATABASE=dotnet;UID=root;PASSWORD=;";

        static void Main()
        {
            Console.WriteLine("--- Tourism Information Entry ---");

            Console.Write("Enter Tour Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter Duration: ");
            string duration = Console.ReadLine();

            DateTime createdDate = DateTime.Now;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO TourDestination (Title, Description, Duration, CreatedDate) " +
                               "VALUES (@Title, @Description, @Duration, @CreatedDate)";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Duration", duration);
                cmd.Parameters.AddWithValue("@CreatedDate", createdDate);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Tourism Information Saved Successfully!");
            }
        }
    }

}
