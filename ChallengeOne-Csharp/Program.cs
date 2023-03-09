using System;

namespace ChallengeOne_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString;
            Console.Write("Please enter your name and press enter: ");
            myString = Console.ReadLine();
            Console.WriteLine(myString.ToUpper());
            Console.WriteLine(myString.ToLower());
            Console.WriteLine(myString.Trim());
            Console.Write("Enter a value to Sub, in digits: ");
            int sub1 = Int32.Parse(Console.ReadLine());
            int sub2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(myString.Substring(sub1, sub2));
            Console.ReadKey();
        }
    }
}
