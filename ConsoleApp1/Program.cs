using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper h1 = new Helper();
            int num = 1;
            Console.WriteLine(num.ToString());
            Console.ReadKey();
            Console.WriteLine();
            h1.NumLoop();
            Console.ReadKey();
            h1.MakeAnArray();
            h1.CreateArrayWords();
        }   
    }

}
