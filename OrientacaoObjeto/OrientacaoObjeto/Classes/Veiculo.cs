using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto.Classes
{
    internal class Veiculo
    {
        public TipoVelocidade TipoVelocidade { get; set; }
        public int Velocidade { get; set; }

        public Veiculo(TipoVelocidade tipoVelocidade, int velocidade)
        {
            TipoVelocidade = tipoVelocidade;
            Velocidade = velocidade;
        }

        public void Mover()
        {
            Console.WriteLine($"O veículo está se movendo a {Velocidade} {TipoVelocidade.ToString()}");
        }
    }
}
