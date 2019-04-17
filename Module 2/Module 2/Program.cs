////using System;
////namespace Module_2
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            for (int i = 0; i < 8; i++)
////            {
////                for (int j = 0; j < 8; j++)
////                {
////                   int c = (j % 2 + i % 2) % 2 ;
////                    switch (c)
////                    {
////                        case 0:
////                            Console.Write("X");
////                            break;
////                        case 1:
////                            Console.Write("O");
////                            break;
////                        default:
////                            break;
////                    }
////                }
////                Console.WriteLine();
////            }
////        }
////    }
////}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication2
//{
//    class Program
//    {
//        static void Main()
//        {

//            string prevSquare = "O"; //set first square to be opposite start char
//            string currLine = "";

//            for (int x = 0; x < 8; x++)
//            {
//                currLine = "";
//                for (int y = 0; y < 8; y++)
//                {
//                    prevSquare = flipIt(prevSquare);
//                    currLine += prevSquare;
//                }
//                Console.WriteLine(currLine);
//                prevSquare = flipIt(prevSquare); // alternate X and O lines
//            }
//            Console.ReadKey();
//        }
//        static string flipIt(string square)
//        {
//            string flipped = "O"; //saves an else step by defining and setting here
//            if (square == "O")
//            {
//                flipped = "X";
//            }
//            return flipped;
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                {
                    for (j = 0; j < 8; j++)
                    {
                        if (j % 2 == 0)
                            Console.Write("X");
                        else
                            Console.Write("O");
                    }
                    Console.Write("\n");
                    for (k = 0; k < 8; k++)
                    {
                        if (k % 2 == 0)
                            Console.Write("O");
                        else
                            Console.Write("X");
                    }
                    Console.Write("\n");
                }
            }
            Console.ReadKey();
        }
    }
}