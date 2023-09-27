using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ex17
{
    internal class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public virtual double Salario { get; set; }

        public virtual double CalculoSalario()
        {
            return Salario;
        }
        public override string ToString()
        {
            return $"Código: {Codigo} Nome: {Nome} salario: {Salario:c} Salario líquido: {CalculoSalario():c}";
        }
    }
}
