using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s= "Um tab\t e um emoji \u1F49 ";
            string b= @"Isto \u1F49 não é um emoji";

            Console.WriteLine(s);
            Console.WriteLine(b);
        }
    }
}
