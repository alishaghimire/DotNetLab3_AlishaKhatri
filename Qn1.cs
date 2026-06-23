//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab3_Alisha_Khatri
//{
//    internal class Qn1
//    {

//        // Declare delegate
//        public delegate void MyDelegate();

//        // Methods to be called
//        static void Method1()
//        {
//            Console.WriteLine("Method 1 Executed");
//        }

//        static void Method2()
//        {
//            Console.WriteLine("Method 2 Executed");
//        }

//        static void Method3()
//        {
//            Console.WriteLine("Method 3 Executed");
//        }

//        static void Main(string[] args)
//        {
//            // Create delegate instance
//            MyDelegate del;

//            // Add methods to delegate
//            del = Method1;
//            del += Method2;
//            del += Method3;

//            Console.WriteLine("Invoking Multicast Delegate:");
//            del();

//            Console.ReadLine();
//        }
//    }
//}


