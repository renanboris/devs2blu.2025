using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto.MaoNaMassa
{
    internal class Piano : InstrumentoMusical
    {
        private const string SOM_PIANO = "SOM PIANO";
        public string SomPiano => SOM_PIANO;


        public override void Tocar()
        {
            Console.WriteLine($"Som do Instrumento: {SomPiano}");
        }
    }
   
}
