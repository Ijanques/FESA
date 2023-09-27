using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_EX3
{
    internal class Employee
    {
        private int cod;
        private string name;
        private string rg;
        private double wage;

        public void SetCodigo(int value)
        {
            if (value <= 0)
                throw new Exception("Please enter a valid code");
            cod = value;
        }
        public int GetCode() => cod;

        
        
        public void SetWage(double value)
        {
            if (value < 0)
                throw new Exception("Please enter a valid wage");
            wage = value; 
        }
        public double GetWage() => wage;
        public void SetName(string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new Exception("Please enter a valid name");
            name = value;
        }
        public string GetName() => name;
        public void SetRg(string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new Exception("Please enter a valid RG");
            rg = value;
        }
        public string GetRg() => rg;

        public double GetINSS() => wage * 0.11;

        public double GetLiquidWage() => wage - GetINSS();

       
            
        
    }
}
