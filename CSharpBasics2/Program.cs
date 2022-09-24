using System;
using System.Runtime.InteropServices;

namespace Program
{
    public class Program
    {
        class A
        {
            public virtual void someMethod()
            {
                Console.WriteLine("This is base class method");
            }
        }

        class B : Demo, D, X
        {
            public void someContractBody()
            {
                throw new NotImplementedException();
            }

            public void someContractBody(string b)
            {
                throw new NotImplementedException();
            }

            //public void someMethodInClassB()
            //{

            //}

            //public override void someMethod()
            //{
            //    base.someMethod();
            //    Console.WriteLine("This is someMethod now being overriden in child class");
            //}
            public override void someMethod()
            {
                throw new NotImplementedException();
            }
        }

        public static void Main(string[] args)
        {
            // session 6
            // Runtime Polymorphisms

            /*
             what is class 
            what is struc
            -> what is interface ?
             
             */

            //B b = new B();
            //b.someMethod();

            /// implementation -> forming a contract between two class
            /// 
            //var input = Console.ReadLine();
            //Console.WriteLine("This is the input we got from console : =====> " +input);
            Console.WriteLine("Enter a number a: ");
            var a = Console.ReadLine();
            Console.WriteLine("Enter a number b: ");
            var b = Console.ReadLine();
            /*
             Debugging key shortcuts for vs
            f10 -> step over 
            f11 -> step in
            f5 -> continue
             
             */


            var c = Convert.ToInt32(a) + Convert.ToInt32(b);

            Console.WriteLine("Sum of a + b = " +c);
            Console.ReadKey(); // Hold the console window untill we dont press any key on our keyboard


        }

    }

    interface D
    {
        void someContractBody();
    }

    interface X
    {
        void someContractBody(string b);
    }


    public abstract class Demo
    {
        public abstract void someMethod();

        public void someMethod2()
        {
            Console.WriteLine("some functionality");
        }
    }

    public abstract class Demo2
    {
        
    }

}