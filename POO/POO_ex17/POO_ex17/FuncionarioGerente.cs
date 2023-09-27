using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ex17
{
    internal class FuncionarioGerente : Funcionario
    {
        public double Bonus { get; set; }
        public int DeptoGerenciado { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Bonus: {Bonus:c} Gerente do Depto: {DeptoGerenciado}";
        }

        private double salario;
        public override double Salario 
        { 
            get => salario; 
            
            set
            {
                if (value <= 5000)
                    throw new Exception("O valor não pode ser menos que 5 mil reais (Ta achando o que, que aqui é empresa de jogo indie?)");
                salario = value;
            }
        }

        public override double CalculoSalario()
        {
            return base.CalculoSalario() + Bonus;
        }
    }
}
