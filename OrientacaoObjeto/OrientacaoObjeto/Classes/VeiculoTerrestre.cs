using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto.Classes
{
    internal class VeiculoTerrestre : Veiculo
    {
        public VeiculoTerrestre(TipoVelocidade tipoVelocidade, int velocidade, int numeroRodas) : base(tipoVelocidade, velocidade)
        {
            NumeroRodas = numeroRodas;
        }

        public int NumeroRodas { get; set; }

        public void Buzinar() 
        {
            Console.WriteLine("Biii");
        }
    }
}
