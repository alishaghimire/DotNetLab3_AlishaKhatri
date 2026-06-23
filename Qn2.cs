//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab3_Alisha_Khatri
//{

//    class Employee
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public double Salary { get; set; }
//        public string Address { get; set; }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Employee> employees = new List<Employee>()
//        {
//            new Employee { Id = 1, Name = "Ram", Salary = 60000, Address = "Kathmandu" },
//            new Employee { Id = 2, Name = "Shyam", Salary = 45000, Address = "Pokhara" },
//            new Employee { Id = 3, Name = "Hari", Salary = 70000, Address = "Kathmandu" },
//            new Employee { Id = 4, Name = "Sita", Salary = 55000, Address = "Butwal" }
//        };

//            // LINQ Query
//            var result = employees.Where(e => e.Salary > 50000 &&
//                                              e.Address == "Kathmandu");

//            Console.WriteLine("Employees with Salary > 50000 and Address = Kathmandu:");

//            foreach (var emp in result)
//            {
//                Console.WriteLine("ID: " + emp.Id +
//                                  ", Name: " + emp.Name +
//                                  ", Salary: " + emp.Salary +
//                                  ", Address: " + emp.Address);
//            }

//            Console.ReadLine();
//        }
//    }
//}
