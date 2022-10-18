namespace DYNAMICS;

public static class Program
{
    public static void Main(string[] args)
    {
        
        // Dynamics
        /*
         * Static Typed language 
         * Dynamics - > Javascript , Ruby, Python 
         * 
         */
        /*var name = Name();
        dynamic a = "Ravi";
        a = 10;
        dynamic b = "ravi";
        b++;
        //b = Convert.ToString(10);
        
        Console.WriteLine(b); */

        dynamic obj = "RAVI";
        obj.GetHashCode();

        dynamic ob2 = "RAVI";
        ob2.Optimize();

        //var methodInfo = obj.GetType().GetMethod("GetHashCode");
        //methodInfo.Invoke(null, null);

    }

    public static string Name()
    {
        return "Ravi";
    }
}