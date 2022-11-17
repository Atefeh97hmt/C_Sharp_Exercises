using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace C_Sharp_Exercises
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // The code provided will print ‘Hello World’ to the console.
//            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
//            Console.WriteLine("Hello World!");
//            Console.ReadKey();

//            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
//        }
//    }
//}

////////////////////////Add two numbers///////////////////////////
//namespace MyExercises
//{
//    class sum
//    {
//        static void Main()
//        {
//            int a = 100;
//            int b = 60;
//            int sum = a + b;
//            Console.WriteLine(sum);
//            Console.ReadKey();

//        }
//    }
//}

////////////////////////Add two numbers that user enter///////////////////////////
namespace MyExercises
{
    class sum
    {
        static void Main()
        {
            //int number1;
            //int number2;
            Console.WriteLine("Please enter the number1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number2");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int result = number1 + number2;
            Console.WriteLine("sum of two numbers:" + result.ToString());
            Console.ReadKey();
        }
    }
}
