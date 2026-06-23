//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab3_Alisha_Khatri
//{
//    // Custom Exception Class
//    class AgeException : Exception
//    {
//        public AgeException(string message) : base(message)
//        {
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            int age = 15;

//            try
//            {
//                if (age < 18)
//                {
//                    throw new AgeException("Age must be 18 or above.");
//                }

//                Console.WriteLine("Eligible.");
//            }
//            catch (AgeException e)
//            {
//                Console.WriteLine("Custom Exception: " + e.Message);
//            }
//        }
//    }
//}
