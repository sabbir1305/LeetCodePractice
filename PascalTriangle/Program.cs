using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var sln = new Solution();
            var result = sln.Generate(5);
            string comma = "";
            Console.WriteLine("[");
            foreach (var item in result)
            {
                comma = "";
                Console.Write("[");
                foreach (var data in item)
                {
                    Console.Write(comma+data);
                    comma = ",";
                }
                Console.Write("]");
                Console.WriteLine();
            }
            Console.Write("]");




        }
    }
}
