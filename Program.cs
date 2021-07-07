using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace FFX_PostcodeParser
{
    class Program
    {
        static Boolean loop = true;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Would you like to input a postcode? Y/N");
                String response = Console.ReadLine();

                switch (response)
                {
                    case "Y":
                        Console.WriteLine("Please input a postcode...");
                        String postcode = Console.ReadLine();
                        new PrintResults(new Postcode(postcode));
                        break;

                    case "N":
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("That is an unrecognised input. Let's try again.");
                        break;
                }
            } while (loop);
        }
    }
}
