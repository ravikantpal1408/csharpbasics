using System;
using System.Runtime.InteropServices;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Session 9 : Delegates
            /*
                An object that knows how to call a method or a group of method 
                A reference to a function 

                - Multicast delegate -> allows you to point to multiple functions 
                - Delegate -> allow you to point to a single function
             */


            var process = new PhotoProcessor();

            var filters = new PhotoFilter();

            Action<Photo> handler = filters.ApplyBrightness;
            handler += filters.ApplyContrast;
            handler += process.CustomFilter;

            process.Process("path", handler);

            Console.ReadKey();

            /*
             * 16 params they both can take
             * 
             Func -> when you are using functions 
             Action -> when you are using method 
             */


        }
          
    }



    public class Photo
    {
    
        public static Photo PhotoLoad(string path)
        {
            return new Photo();   
        }

        public void Save()
        {
            Console.WriteLine("Photo saved to paths :::" );
        }
    }

    public class PhotoFilter
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply Brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply Contrast");
        }
        public void ApplyResize(Photo photo)
        {
            Console.WriteLine("Apply Resize");
        }
    
    }

    public class PhotoProcessor
    {
        public delegate void PhotoFilterHadler (Photo photo);
        
        public void Process (string path, Action<Photo> photoHandler)
        {
            var photo =  Photo.PhotoLoad(path);          

            photoHandler(photo);

            photoHandler += CustomFilter;        

            photo.Save();
        }

        public void CustomFilter (Photo photo)
        {
            Console.WriteLine("Custom filter");
        }
    }

}