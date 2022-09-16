using System;

namespace Program
{
    public class Program
    {
        private string FirstName;

        /*
         C -> Programming language, thats developed and maintained by Microsoft
        .NET Core -> Framework 
         
        CLR -> Common Langiage Runtime 

        C# -> IL (Intermediate Language : i0LXxH) ->(JIT Compilation Happens) -> Native Machine Code 01010101

        Naming Conventions :

        Pascal Case : CustomerName

        Camel Case : customerNameOfDlfTower

        Hungarian Notation : strCustomerName

        snake : customer_name_of_dlf_tower

         */
        public static void Main(string[] args)
        {
            // Scope
            byte a = 1;
            {
                
                byte b = 2;
                {
                    byte c = 3;
                    
                }

               
            }

            // Type Conversion
            /*
             1- Implicit Type Conversion
             */

            byte num = 1;
            int numBig = num;

            int i =  1;
            i /= 2;
            i = i / 2;
            byte j = (byte) i; /// Explicit Cast

            string h = "123";
            int t = Convert.ToInt32(h); // -> Types between different compatible types 
            int u = int.Parse(h);

            // false || fasle

            // Operators
            /*
            1 - Arithmatic Operators -> (+ , _ , * ,  % ,/) increment /decrement ++ , --
            2 - Assignment Operators -> =, +=, -=, *=, /=
            3 - Logical Operators -> &&, ||  -- or , !
            4 - Bitwise Operators -> & , | 
            5 - Comparision Operators -> ==, != , > , >= , <, <=
             */

            // -> Arrays -> staic data collector
            int[] numArr = new int[4] {1,2,3,4};
            //numArr[0] = 1;
            //numArr[1] = 2;
            //numArr[2] = 3;
            //numArr[3] = 4;
            // jagged Array -> Array within an Array 
            Console.WriteLine(numArr[0]);
            
        }

        // Structures


        public string ReturnSomeText()
        {
            _ = Car.Name;
            return "Hello !";
        }
    }

    public struct RgbColor
    {
        public int red;
        public int green;
        public int blue;
    }

    



    class Car
    {
        public static Decimal Name { get; set; }

       
        public static void Start()
        {
            string num = "1273642234";
            int number = Convert.ToInt32(num);
            Console.WriteLine("Start the car");
        }
    }
}