//using System;
//namespace ConsoleApp
//{
//    class ReverseEachWord
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter string: ");
//            string str = Console.ReadLine();
//            string result = string.Empty;
//            string[] arr = str.Split(" ");
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (i != arr.Length - 1)
//                {
//                    result += ReverseString(arr[i]) + " ";
//                }
//                else
//                {
//                    result += ReverseString(arr[i]);
//                }
//            }
//            Console.WriteLine("Reverse String : {0} ", result);
//            Console.ReadLine();
//        }
 
//        static string ReverseString(string str)
//        {
//            string result = "";
//            if (string.IsNullOrEmpty(str))
//                return string.Empty;

//            for (int i = str.Length - 1; i >= 0; i--)
//            {
//                result += str[i];
//            }
//            return result;
//        }
//    }
//}