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

            checked
            {
                // 999999999999993333333333333 
                //  testVar =  999999999999993333333333333;

                byte num = 255;

                byte num2 = (byte)(num + 1);

                Console.WriteLine(num2);
            }
          

            


          

            /*
             TYPES: 
             
            C#                  |                   .NET

            byte                |               Byte       
            short               |               Int16
            int                 |               Int32
            long                |               Int64
            float               |               Single 
            double              |               Double - 8
            decimal             |               Decimal - 16
            char                |               Char
            bool                |               Boolean            
             
             
             */
        }

        public string ReturnSomeText()
        {
            return "Hello !";
        }
    }


    class Car
    {
        public Decimal Name { get; set; }

        public void Start()
        {
            string num = "1273642234";
            int number = Convert.ToInt32(num);
            Console.WriteLine("Start the car");
        }
    }
}