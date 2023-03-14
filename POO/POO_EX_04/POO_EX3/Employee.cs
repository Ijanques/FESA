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

        public int Code
        {
            get => cod;
            set
            {
                if (value <= 0)
                    throw new Exception("Please enter a valid code");
                cod = value;
            }

        }
        /*public void SetCode(int value)
        {
            if (value <= 0)
                throw new Exception("Please enter a valid code");
            cod = value;
        }
        public int GetCode() => cod;
        */

        public double Wage
        {
            get => wage;
            set
            {
                if(value < 0)
                    throw new Exception("Please enter a valid wage");
                wage = value;
            }
        }
        /* 
         public void SetWage(double value)
         {
             if (value < 0)
                 throw new Exception("Please enter a valid wage");
             wage = value; 
         }
         public double GetWage() => wage;
        */
        public string Name
        {
            get=> name;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Please enter a valid name");
                name = value;
            }
        }
        //public void SetName(string value)
        //{
        //    if (String.IsNullOrEmpty(value))
        //        throw new Exception("Please enter a valid name");
        //    name = value;
        //}
        //public string GetName() => name;
        public string Rg
        {
            get=> rg;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Please enter a valid RG");
                rg = value;
            }
        }
        //public void SetRg(string value)
        //{
        //    if (String.IsNullOrEmpty(value))
        //        throw new Exception("Please enter a valid RG");
        //    rg = value;
        //}
        //public string GetRg() => rg;

        public double Inss
        {
            get => wage * 0.11;
        }
        //public double GetINSS() => wage * 0.11;

        public double LiquidWage
        {
            get => wage - Inss;
        }
        //public double GetLiquidWage() => wage - GetINSS();

       
            
        
    }
}
