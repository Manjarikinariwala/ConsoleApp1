//using System;
//namespace ConsoleApp1
//{
//    class factorial
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter The Number!");
//            int number = Convert.ToInt32(Console.ReadLine());
//            long fact = GetFactirial(number);
//            Console.WriteLine("{0} factorial is {1}", number, fact);
//            Console.ReadLine();
//        }

//        private static long GetFactirial(int number)
//        {
//            if (number == 0)
//            {
//                return 1;
//            }
//            return number * GetFactirial(number - 1);
//        }
//    }
//}