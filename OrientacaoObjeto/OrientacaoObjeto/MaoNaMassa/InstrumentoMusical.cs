using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrientacaoObjeto.MaoNaMassa
{
    internal class InstrumentoMusical
    {
        private const string SOM_PADRAO = "SOM PADRAO";
        private string SomInstrumento { get; set; }

        public InstrumentoMusical(string som = SOM_PADRAO)
        {
            SomInstrumento = som;
        }

        public virtual void Tocar()
        {
            Console.WriteLine($"Som do Instrumento: {SomInstrumento}");
        }
    }
}
