using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Moto : Iveiculo
    {
        int velocidadeAtual;

        public int VelocidadeAtual
        {
            get => velocidadeAtual;
            set => velocidadeAtual = value;
        }
        public string Placa { get; set; }
        public void Acelerar()
        {
            velocidadeAtual++;
        }
        public void Frear()
        {
            velocidadeAtual--;
        }
        public void Buzinar()
        {
            Console.WriteLine("BIBI");
        }
        public void TrocarMarcha(int marcha)
        {
            Console.WriteLine($"Marcha: {marcha}");
        }
        public void IndicarDirecao(EnumDirecao direcao)
        {
            Console.WriteLine($"Direcao: {direcao}");
        }
    
    }
}
