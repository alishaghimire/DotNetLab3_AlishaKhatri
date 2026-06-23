//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab3_Alisha_Khatri
//{
//    internal class Qn4_update
//    {
//        static void Main(string[] args)

//        {

//            string ConnectionString = "SERVER=localhost;DATABASE=dotnet;UID=root;PASSWORD=;";

//            MySqlConnection connect = new MySqlConnection(ConnectionString);



//            try

//            {

//                connect.Open();

//                Console.WriteLine("Connection Success");



//                Console.WriteLine("Enter Student ID to Update:");

//                int id = Convert.ToInt32(Console.ReadLine());



//                Console.WriteLine("Enter New Name:");

//                string name = Console.ReadLine();



//                Console.WriteLine("Enter New Roll:");

//                int roll = Convert.ToInt32(Console.ReadLine());



//                Console.WriteLine("Enter New Semester:");

//                int semester = Convert.ToInt32(Console.ReadLine());



//                MySqlCommand cmd = new MySqlCommand(

//                    "UPDATE student SET name=@name, roll=@roll, semester=@semester WHERE id=@id",

//                    connect);



//                cmd.Parameters.AddWithValue("@id", id);

//                cmd.Parameters.AddWithValue("@name", name);

//                cmd.Parameters.AddWithValue("@roll", roll);

//                cmd.Parameters.AddWithValue("@semester", semester);



//                int num = cmd.ExecuteNonQuery();



//                if (num == 1)

//                {

//                    Console.WriteLine("Student Updated Successfully");

//                }

//                else

//                {

//                    Console.WriteLine("Student Update Failed");

//                }

//            }

//            catch (MySqlException ex)

//            {

//                Console.WriteLine("Database Error: " + ex.Message);

//            }

//            catch (Exception ex)

//            {

//                Console.WriteLine("Error: " + ex.Message);

//            }



//            Console.ReadLine();

//        }

//    }
//}
