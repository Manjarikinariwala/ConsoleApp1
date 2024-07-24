//using System;
//using System.Text;
//namespace ConsoleApp1
//{
//    class FindSubString
//    {
//        static void Main(string[] args)
//        {
//            string str;
//            Console.WriteLine("Enter a string: ");
//            str = Console.ReadLine();
//            for (int i = 0; i < str.Length; i++)
//            {
//                StringBuilder newString = new StringBuilder();
//                for (int j = i; j < str.Length; j++)
//                {
//                    newString.Append(str[j]);
//                    Console.Write(newString + "\n");
//                }
//            }
//            Console.ReadLine();
//        }
//    }
//}