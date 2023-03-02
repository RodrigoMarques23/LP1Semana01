using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;
            string s = "Um tab\t e um emoji \u1F49 ";
            string b = @"Isto \u1F49 não é um emoji";
            string c = "ola" + "mundo";
            string a = "Isto é um" + x + "(cinco)";
            string u = String.Format("1+1={0}",2);

            Console.WriteLine(s);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine($"O Valor de x e' {x}");
            Console.WriteLine($"O Valor de x + y e' {x + y}");
            Console.WriteLine(u);
            Console.WriteLine(@"Verbatim, X={0}",x);

        }
    }
}
