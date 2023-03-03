using System;

namespace ArgLongStrings
{
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            foreach (string arg in args)//Run through every arg passed
            {
                if (arg.Length > 4)//verify if arg is longer than 4 chars
                {
                    string arg2 = arg.ToUpper();//transform to upper
                    Console.WriteLine(arg2);//print arg
                }
            }
        }
    }
}
