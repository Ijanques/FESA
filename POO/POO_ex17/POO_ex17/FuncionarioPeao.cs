using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ex17
{
    internal class FuncionarioPeao : Funcionario
    {
        public double HoraExtra { get; set; }
        public override double CalculoSalario()
        {
            return base.CalculoSalario() + HoraExtra;
        }
        private double salario;
        public override double Salario 
        { 
            get => salario; 
            set
            {
                if (value < 1302)
                    throw new Exception("o valor não pode ser inferior ao salario minimo");
                salario = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"Hora extra: {HoraExtra:c}";
        }
    }
}
