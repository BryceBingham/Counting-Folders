using System;
 
public class Example
{
    public static bool isAlphaNumeric(char c)
    {
        return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
    }
 
    public static void Main()
    {
        string alphOnly;
        {
            Console.WriteLine("Enter your sentance to count!");
            string input = Console.ReadLine();
            alphOnly = input;
        }
        alphOnly = String.Concat(Array.FindAll(alphOnly.ToCharArray(), isAlphaNumeric));
        {
            int result = alphOnly.Length;
            Console.WriteLine("This is the amount of letters inside your sentance: " + result);
        }
    }
}