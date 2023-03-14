using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_EX_07
{
    internal class Adder
    {
        public static int Add(int n1, int n2 )
        {
            return n1 + n2;
        }
        public static double Add(double n1, double n2)
        { 
            return n1 + n2; 
        }
        public static double Add(string n1, string n2)
        {
            return Convert.ToDouble(n1) + Convert.ToDouble(n2);
        }
    }
}
