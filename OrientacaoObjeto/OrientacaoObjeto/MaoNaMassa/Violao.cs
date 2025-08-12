using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto.MaoNaMassa
{
    internal class Violao : InstrumentoMusical
    {
        private const string SOM_VIOLAO = "SOM VIOLAO";
        public string SomViolao => SOM_VIOLAO;

        public override void Tocar()
        {
            Console.WriteLine($"Som do Instrumento: {SomViolao}");
        }
    }
}
