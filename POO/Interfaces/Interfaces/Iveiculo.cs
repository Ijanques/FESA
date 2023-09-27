using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface Iveiculo
    {
        int VelocidadeAtual { get; set; }
        string Placa { get; set; }
        void Acelerar();
        void Frear();
        void Buzinar();
        void TrocarMarcha(int marcha);
        void IndicarDirecao(EnumDirecao direcao);
    }
}
