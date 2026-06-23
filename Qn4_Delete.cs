//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
//using System.Data;
//namespace Lab3_Alisha_Khatri
//{
//    internal class Qn4_Delete
//    {
//        static void Main(string[] args)
//        {

//            string ConnectionString = "SERVER=localhost;DATABASE=dotnet;UID=root;PASSWORD=;";
//            MySqlConnection connect = new MySqlConnection(ConnectionString);
//            try
//            {
//                connect.Open();
//                Console.WriteLine("Connection Success");
//                Console.WriteLine("Enter student id?");
//                int id = Convert.ToInt32(Console.ReadLine());
//                MySqlCommand cmd = new MySqlCommand("delete from student where id=@sid", connect);
//                cmd.Parameters.AddWithValue("@sid", id);
//                int num = cmd.ExecuteNonQuery();
//                if (num == 1)
//                {
//                    Console.WriteLine("Student Deleted Successfully");
//                }
//                else
//                {
//                    Console.WriteLine("Student Delete Failed");
//                }
//            }
//            catch (MySqlException ex)
//            {
//                Console.WriteLine("Database Error: " + ex.Message);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error:" + ex.Message);
//            }
//        }
//    }
//}

