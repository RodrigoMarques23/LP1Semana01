using System;

namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string arg in args)
            {
                Console.WriteLine("Arg is:");
                Console.WriteLine(arg);
            }
        }
    }
}
