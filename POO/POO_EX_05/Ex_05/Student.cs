using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05
{
    internal class Student
    {
        private string name;
        private double grade1;
        private double grade2;

        public string Name
        {
            get => name;
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("You should provide a valid name to the student");
                }
                name = value;
            }
        }
        public double Grade1
        {
            get=> grade1;
            set
            {
                if (double.IsNaN(value) || value < 0)
                {
                    throw new Exception("You should provide a valid number to the grades");
                }
                grade1 = value;
            }
        }
        public double Grade2
        {
            get => grade2;
            set
            {
                if (double.IsNaN(value) || value < 0)
                {
                    throw new Exception("You should provide a valid number to the grades");
                }
                grade2 = value;
            }
        }
        public double Avg
        {
            get => (grade1+ grade2) /2;
        }

    }
}
