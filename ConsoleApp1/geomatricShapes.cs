//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class geomatricShapes
//    {
//        public static void Main(string[] args)
//        {
//            int r, l, w, b,h, ln, shape;
//            double area = 0;
//            Console.WriteLine("Input The 1 for to calculate the area of the Circle ", '\n');
//            Console.WriteLine("Input The 2 for to calculate the area of the rectagular ", '\n');
//            Console.WriteLine("Input The 3 for to calculate the area of the triangle ", '\n');
//            Console.WriteLine("Input The 4 for to calculate the area of the square ", '\n');
//            Console.WriteLine("Enter the Shape input to calculate the area of that shape");
//            shape = Convert.ToInt32(Console.ReadLine());

//            switch (shape)
//            {
//                case 1: 
//                    Console.WriteLine("Enter the redius of the circle: ");
//                    r = Convert.ToInt32(Console.ReadLine());
//                    area = 3.14 * r * r;
//                    break;
                    
//                case 2:
//                    Console.WriteLine("Enter the length of the rectangular : ");
//                    l = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("Enter the width of the rectangular : ");
//                    w = Convert.ToInt32(Console.ReadLine());
//                    area = l * w;
//                    break;

//                case 3:
//                    Console.WriteLine("Enter the base of the triangle : ");
//                    b = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("Enter the heigth of the triangle : ");
//                    h = Convert.ToInt32(Console.ReadLine());
//                    area = 0.5 * b * h;
//                    break;

//                case 4:
//                    Console.WriteLine("Enter the Length of the Sqaure : ");
//                    ln = Convert.ToInt32(Console.ReadLine());
//                    area = ln * 4;
//                    break;

//            }
//            Console.Write("the area is : {0}", area);
//        }
//    }
//}
