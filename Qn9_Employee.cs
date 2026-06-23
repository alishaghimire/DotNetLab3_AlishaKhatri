using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Lab3_Alisha_Khatri
{


    class EmployeeCRUD
    {
        static string connectionString = "SERVER=localhost;DATABASE=dotnet;UID=root;PASSWORD=;";

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n--- Employee CRUD Menu ---");
                Console.WriteLine("1. Create (Insert Employee)");
                Console.WriteLine("2. Read (View Employees)");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: InsertEmployee(); break;
                    case 2: ReadEmployees(); break;
                    case 3: UpdateEmployee(); break;
                    case 4: DeleteEmployee(); break;
                    case 5: return;
                    default: Console.WriteLine("Invalid choice!"); break;
                }
            }
        }

        static void InsertEmployee()
        {
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Department: ");
            string dept = Console.ReadLine();
            Console.Write("Enter Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Employee (Name, Department, Salary) VALUES (@Name, @Dept, @Salary)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Dept", dept);
                cmd.Parameters.AddWithValue("@Salary", salary);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee Inserted Successfully!");
            }
        }

        static void ReadEmployees()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Employee";
                MySqlCommand cmd = new MySqlCommand(query, con);

                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("\n--- Employee Records ---");
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}, Dept: {reader["Department"]}, Salary: {reader["Salary"]}");
                }
            }
        }

        static void UpdateEmployee()
        {
            Console.Write("Enter Employee ID to Update: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter New Department: ");
            string dept = Console.ReadLine();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "UPDATE Employee SET Department=@Dept WHERE Id=@Id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Dept", dept);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee Updated Successfully!");
            }
        }

        static void DeleteEmployee()
        {
            Console.Write("Enter Employee ID to Delete: ");
            int id = int.Parse(Console.ReadLine());

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM Employee WHERE Id=@Id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee Deleted Successfully!");
            }
        }
    }


}
