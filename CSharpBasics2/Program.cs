using System;
using System.Runtime.InteropServices;

namespace Program
{
    public class Program
    {

        public static void Main(string[] args)
        {
            /// Session 8 - Generics 
            /// Let say there is a case you wanna create your own list api
            /*
            var integerList = new CustomList();

            integerList.Add(1);
            integerList.Add(2);
            integerList.Add(3);
            integerList.Add("string");
            integerList.Add(9.0);

            var genericListing = new GenericList<Customer>();
            genericListing.Add(new Customer
            {
                Id = 1,
                CustomerName = "John"
            });

            var listAPI = new List<int>();

            } */
            // boxing and un-boxing
            // boxing - converting value type to object type 
            // un-boxing - converting object type to value type 

            // binary search and lenear search -> 

            // Dictionary Genrics :
            // Dictionary - Dictionary is a DataStructure that user a hash table to store and retrieve objects 
            // which provide very fast way to save and retrieve objects 
            // --- there are represented as key-value pair
            var someGenerics = new GenericDictionary<string, Customer>();
            someGenerics.Add("retail", new Customer());
            someGenerics.Add("wholesale", new Customer());
            someGenerics.Add("vendor", new Customer());

        }
    }



    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

    
    }

    public class UtilitiesSec<T> where T : IComparable
    {
        public int Max(int a, int b)
        {
            return a > b? a : b;
        }

        public T Max(T a , T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    public class GeneCustomer<T> where  T: Customer
    {

    }

    public class Nullable<T> where T : struct
    {

    }






    public class GenericDictionary<Tkey, TValue>
    {
        public void Add(Tkey key, TValue value)
        {

        }
    }

    
    
    
    
    
    
    
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
    }

    public class CustomList
    {
        public void Add (object number) 
        {
            throw new NotImplementedException();
        }

        public int this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericList<T>
    {
        public void Add(T value)
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }



}