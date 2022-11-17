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
//namespace MyExercises
//{
//    class sum
//    {
//        static void Main()
//        {
//            //int number1;
//            //int number2;
//            Console.WriteLine("Please enter the number1");
//            int number1 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Please enter the number2");
//            int number2 = Convert.ToInt32(Console.ReadLine());
//            int result = number1 + number2;
//            Console.WriteLine("sum of two numbers:" + result.ToString());
//            Console.ReadKey();
//        }
//    }
//}


////////////////////////average of five numbers that user enter///////////////////////////
//namespace C_Sharp_Exercises
//{

//    class average
//    {
//        static void Main()
//        {
//            //int number1;
//            //int number2;
//            Console.WriteLine("Please enter the number1");
//            int number1 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Please enter the number2");
//            int number2 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Please enter the number3");
//            int number3 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Please enter the number4");
//            int number4 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Please enter the number5");
//            int number5 = Convert.ToInt32(Console.ReadLine());
//            int average = (number1 + number2 + number3 + number4 + number5) / 5;
//            Console.WriteLine("average of five numbers:" + average.ToString());
//            Console.ReadKey();
//        }
//    }
//}

////////////////////////average of five numbers that user enter with loop///////////////////////////
//namespace C_Sharp_Exercises
//{


//    class average
//    {
//        static void Main()
//        {

//            int[] number = new int[5];
//            for( int i=0; i < number.Length; i++)
//            {
//                Console.WriteLine("please enter a number:");
//                number[i] = Convert.ToInt32(Console.ReadLine());
//            }

//            int sum = 0;
//            for (int i = 0; i < number.Length; ++i)
//            {
//                sum += number[i];
//            }

//            Console.WriteLine("average of five numbers is: {0}", sum / number.Length);
//            Console.ReadKey();

//        }

//    }

//}


////////////////////////average of n user input numbers///////////////////////////
namespace C_Sharp_Exercises
{


    class average
    {
        static void Main(string[] args)
        {
            int Total, Sum = 0;
            int Average;

            Console.WriteLine("How many numbers do you want the average of? ");
            Total = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Total; i++)
            {
                Console.WriteLine("Please enter a number: ");
                int Value = Convert.ToInt32(Console.ReadLine());
                Sum += Value;
            }

            Average = Sum / Total;

            Console.WriteLine("The average is: " + Average);
            Console.ReadKey();
        }
    }

}