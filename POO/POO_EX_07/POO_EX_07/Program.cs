using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_EX_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Adder.Add(1, 2));
                Console.WriteLine(Adder.Add(1.90089, 4.567008));
                Console.WriteLine(Adder.Add("2,567", "2,5"));
            }catch(Exception error) 
            {
                Console.WriteLine(error.Message);
            }
            Console.ReadKey();
        }
    }
}
