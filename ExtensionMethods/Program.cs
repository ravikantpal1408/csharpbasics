namespace ExtensionMethods;

public static class Program
{
    public static void Main(string[] args)
    {
        string post = "this is supposed to be very long long post blah blah ....";

        var shortenedPost = post.Shorten(5);

        Console.WriteLine(shortenedPost);
    }
}

