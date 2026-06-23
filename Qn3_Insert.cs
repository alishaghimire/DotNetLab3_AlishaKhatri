//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MySql.Data.MySqlClient;

//namespace Lab3_Alisha_Khatri
//{
//    internal class Qn3_Insert
//    {
//        static void Main(string[] args)
//        {

//            string ConnectionString = "SERVER=localhost;DATABASE=dotnet;UID=root;PASSWORD=;";
//            MySqlConnection connect = new MySqlConnection(ConnectionString);
//            try
//            {
//                connect.Open();
//                Console.WriteLine("Connection Success");
//                Console.WriteLine("Enter student name?");
//                string name = Console.ReadLine();
//                Console.WriteLine("Enter student roll?");
//                int roll = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter student semester?");
//                int semester = int.Parse(Console.ReadLine());
//                MySqlCommand cmd = new MySqlCommand("Insert into student (name, roll, semester) values(@name,@roll,@semester)", connect); cmd.Parameters.AddWithValue("@name", name); cmd.Parameters.AddWithValue("@roll", roll); cmd.Parameters.AddWithValue("@semester", semester);                 /*cmd.Parameters.AddWithValue("@name", "Kazol");                 cmd.Parameters.AddWithValue("@roll", 10);                 cmd.Parameters.AddWithValue("@semester", 5);*/                 int num = cmd.ExecuteNonQuery(); if (num == 1)
//                {
//                    Console.WriteLine("Student Added Successfully");
//                }
//                else
//                {
//                    Console.WriteLine("Student Addtion Failed");
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

