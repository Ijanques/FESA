using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarroDePasseio carro = new CarroDePasseio();
            carro.Placa = "KPC-1234";
            carro.Acelerar();
            carro.Acelerar();
            carro.IndicarDirecao(EnumDirecao.Esquerda);
            Console.WriteLine(carro.VelocidadeAtual);
            Moto moto= new Moto();
            moto.Placa = "YIM-2101";
            moto.Acelerar();
            moto.Acelerar();
            moto.Acelerar();
            moto.Buzinar();
            moto.IndicarDirecao(EnumDirecao.Direita);
            Console.WriteLine(moto.VelocidadeAtual);
            

            //foreach para mostrar a placa dos veiculos

           List<Iveiculo> veiculos = new List<Iveiculo>();
            veiculos.Add(moto);
            veiculos.Add(carro);
            foreach(Iveiculo i in veiculos) 
            {
                Console.WriteLine(i.Placa);
            }
            Console.ReadKey();

        }
    }
}
