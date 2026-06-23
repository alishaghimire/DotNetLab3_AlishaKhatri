//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
//using System.Data;
//namespace Lab3_Alisha_Khatri
//{
//    internal class Qn3_Select
//    {
//        static void Main(string[] args)
//        {

//            string ConnectionString = "SERVER=localhost;DATABASE=dotnet;UID=root;PASSWORD=;";
//            MySqlConnection connect = new MySqlConnection(ConnectionString);
//            try
//            {
//                connect.Open();
//                Console.WriteLine("Connection Success");
//                MySqlCommand cmd = new MySqlCommand("select * from student", connect);
//                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
//                DataTable dt = new DataTable(); adapter.Fill(dt);
//                if (dt.Rows.Count != 0)
//                {
//                    Console.WriteLine("ID\tName     \tRoll\tSemester");
//                    for (int i = 0; i < dt.Rows.Count; i++)
//                    {
//                        string id = dt.Rows[i]["id"].ToString();
//                        string name = dt.Rows[i]["name"].ToString();
//                        string semester = dt.Rows[i]["semester"].ToString();
//                        string roll = dt.Rows[i]["roll"].ToString();
//                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", id, name, roll, semester);
//                    }
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

