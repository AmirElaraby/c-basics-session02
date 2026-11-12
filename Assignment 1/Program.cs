using System;

class Book
{
    public string Titel { get; set; }
    public int Page { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        int number = 0;

        try
        {
            int result = 10 / number;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("You cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Done");
        }

        Book book = new Book
        {
            Page = 1111,
            Titel = "books"
        };

        Console.WriteLine(book.ToString());
        Console.WriteLine(book.Equals(book));
        Console.WriteLine(book.GetType());
        Console.WriteLine(book.GetHashCode());
    }
}