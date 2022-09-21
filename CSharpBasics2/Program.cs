using System;

namespace Program
{
    public class Program
    {

        public static void Main(string[] args)
        {
            /* 
                Todays Topic Conditional Statements 
                - if else condition
                - switch statement
                - ternary operators             
            */


            // if (false)
            // {
            //     Console.WriteLine("I am hit !!");
            // }
            // else if (true)
            // {
            //     Console.WriteLine("else If got hit !!");
            // }
            // else if (true)
            // {
            //     Console.WriteLine("else If got hit !!");
            // }
            // else if (true)
            // {
            //     Console.WriteLine("else If got hit !!");
            // }
            // else if (true)
            // {
            //     Console.WriteLine("else If got hit !!");
            // }
            // else
            // {
            //     Console.WriteLine("This is else block");
            // }


            // Switch Statement 
            // var valueTocheck = 3;
            // switch (valueTocheck)
            // {
            //     case 1:
            //         Console.WriteLine("First got printed !!");
            //         break;
            //     case 2:
            //         Console.WriteLine("Second one got printed !!");
            //         break;
            //     default:
            //         Console.WriteLine("Default one got printed !!");
            //         break;
            // }

            // Tertiary statement
            // int amount = 110000;
            // var test = amount > 10001 ? "Good Credit" : "Bad Credit";
            // Console.WriteLine(test);

            // if (amount > 10001)
            // {
            //     var test = "Good Credit";
            //     Console.WriteLine(test);
            // }
            // else
            // {
            //     var test = "Bad Credit";
            //     Console.WriteLine(test);
            // }

            /*---------
            Write a Program which accepts the percentage of student and print the grade as per below description 
            grade > 90% -> A++
            grade = 90% -> A+
            grade < 90% and grade > 80% -> A
            grade = 80 and grade < 85%  -> B+
            grade > 70 and grade <80 -> C+

            if the percentage is not recongzable then print "Incorrect Value            
            
            */

            // ITERATION 
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    continue;
                }

                Console.WriteLine("Print the values " + i);
            }
            // int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // foreach (var digit in num)
            // {
            //     Console.WriteLine("Digit -> " + digit);
            // }

            // int i = 0;
            // while (i < 10)
            // {
            //     Console.WriteLine("Digit -> " + i);
            //     i++;
            // }

            // do
            // {
            //     Console.WriteLine("Digit -> " + i);
            //     i++;
            // }
            // while (i < 10);


            /*
             
            Create an array 10 students and do assertions for the percentage problems  
            
            */


        }
    }

}