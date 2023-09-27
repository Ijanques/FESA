using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ex17
{
    internal class FuncionarioVendedor : Funcionario
    {
        public double MetaDeVendaMesEmReais { get; set; }
        public double VendasMesEmReais { get; set; }
        public double PorcentagemSobreVendas { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Meta de vendas: {MetaDeVendaMesEmReais:c} Vendas do mes: {VendasMesEmReais} % sobre as vendas {PorcentagemSobreVendas}";
        }
        public override double CalculoSalario()
        {
            if(VendasMesEmReais < MetaDeVendaMesEmReais)
                return base.CalculoSalario() ;
            else
                return base.CalculoSalario() + ((PorcentagemSobreVendas /100) * VendasMesEmReais);
        }
        private double salario;
        public override double Salario
        { 
            get => salario; 
            set 
            {
                if (value < 3000)
                    throw new Exception("O salario do vendedor não pode ser menor que 3 mil reais");
                salario = value;
            } 
        }


    }
}
