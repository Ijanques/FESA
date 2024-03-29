﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class CarroDePasseio : Iveiculo, IVeiculoFechados, IComparable
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
        public int CompareTo(object obj)
        {
            Iveiculo veiculo = obj as Iveiculo;
             return this.VelocidadeAtual.CompareTo(veiculo.VelocidadeAtual);
        }
        public void TrocarMarcha(int marcha)
        {
            Console.WriteLine($"Marcha: {marcha}");
        }
        public void IndicarDirecao(EnumDirecao direcao)
        {
            Console.WriteLine($"Direcao: {direcao}");
        }
        public void AcionaLimpador()
        {
            Console.WriteLine("Limpador acionado");
        }
        public void AbrirPorta()
        {
            Console.WriteLine("Porta aberta");
        }
        public void FecharPorta()
        {
            Console.WriteLine("Porta fechada");
        }
    }
}
