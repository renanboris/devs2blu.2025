using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto.Classes
{
    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            base.EmitirSom();
            Console.WriteLine("Miau!");
        }

    }
}
