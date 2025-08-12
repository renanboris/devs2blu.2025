using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto.MaoNaMassa
{
    internal class Tambor : InstrumentoMusical
    {
        private const string SOM_TAMBOR = "SOM TAMBOR";
        public string SomTambor => SOM_TAMBOR;

        public override void Tocar()
        {
            Console.WriteLine($"Som do Instrumento: {SomTambor}");
        }
    }
}
