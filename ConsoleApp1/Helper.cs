using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Helper
    {
        public void AddALine()
        {
            string ReturnChar = "\n";
            Console.Write(ReturnChar);
        }

        public void NumLoop()
        {

            for (int x = 2; x < 10; x++)
            {
                Console.Write(x);
                AddALine();
            }
        }

        public void MakeAnArray()
        {
            int[] numArray = new int[]
               {
                1,2,3,4,5,6,7,8
               };
            for (int x = 1; x < numArray.Length; x++)
            {
                Console.Write(numArray[x]);
            }
            Console.ReadKey();
        }

        public void CreateArrayWords()
        {
            string[] wordArray = new string[] { "The", "First", "Four", "Words" };
            foreach (string word in wordArray)
                Console.WriteLine($"{word}");
            Console.ReadKey();
        }

        public void PrintWordArray()
        {
            
        }
    }
}
