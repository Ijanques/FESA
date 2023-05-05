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
            CarroDePasseio carro2= new CarroDePasseio();
            carro2.Placa = "HIF-1434";
            carro2.Acelerar();
            carro2.Acelerar();
            carro2.Acelerar();
            carro2.IndicarDirecao(EnumDirecao.Esquerda);
            Console.WriteLine(carro2.VelocidadeAtual);


            //foreach para mostrar a placa dos veiculos

            List<Iveiculo> veiculos = new List<Iveiculo>();
            veiculos.Add(moto);
            veiculos.Add(carro);
            foreach(Iveiculo i in veiculos) 
            {
                Console.WriteLine(i.Placa);
            }
            if (carro.CompareTo(carro2) == 0)
            {
                Console.WriteLine("A velocidade dos carros era a mesma");
            }
            else if (carro.CompareTo(carro2) == 1)
            {
                Console.WriteLine("A velocidade do carro 1 era maior que a do carro 2");
            }
            else
            {
                Console.WriteLine("A velocidade do carro 1 era menor que a do carro 2");
            }
            Console.ReadKey();
        }
    }
}
