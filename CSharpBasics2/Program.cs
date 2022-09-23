using System;
using System.Runtime.InteropServices;

namespace Program
{
    public class Program
    {
        /*
         1- File
         2- Directory 
         3- Oops (runtime polymorphism)
         4- Access specifier         
         */

        protected static void Main(string[] args)
        {
            // Session 5
            // 

            var path = @"C:\Workspace\csharpbasics\CSharpBasics2\some-folder\some-dir";

            //if(File.Exists(path))
            //{
            //    //File.WriteAllText(path, "This is the csharp class we having");
               
            //}

            Directory.CreateDirectory(path);
            // OOps-> Obeject Oriented Programming Concepts
            /*
             1- Polymorphism
             2- Encapsulation 
             3- Inheritance
             4- Abstraction

             
             */


        }

        public void Start()
        {

        }
        public void Start(string withSomeParams)
        {

        }

        public void Start(string withSomeParams, int startTime)
        {

        }
    }

    

    public class A
    {
        public some_interface _method;
        A(some_interface method)
        {
            _method = method;
        }


        public void functionality()
        {
            var func =  _method.methodOne();
            Console.WriteLine(func);
        }
    }

    public interface some_interface
    {
        public string methodOne();
    }

    class B : some_interface
    {
        public string methodOne()
        {
            // 1000 line
            return "some functionality";
        }
    }

    private class Z
    {

    }

}