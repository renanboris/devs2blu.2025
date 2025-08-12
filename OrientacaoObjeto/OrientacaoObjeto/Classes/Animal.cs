using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto.Classes
{
    public class Animal
    {
        private const int TAMANHO_BARRIGA = 5;

        private int _Saciedade = 0;


        public string Nome { get; set; }
        public string NomeCientifico { get; set; }
        public int Idade { get; set; }

        public void Andar()
        {
            Console.WriteLine($"O {Nome} está andando");
        }

        public void Comer()
        {
            if (_Saciedade == TAMANHO_BARRIGA)
            {
                Console.WriteLine($"O {Nome} não está mais com fome");
            }
            else
            {
                Console.WriteLine($"O {Nome} está comendo");
                _Saciedade++;
            }

        }

        public virtual void EmitirSom()
        {
            Console.WriteLine("O som do Animal");
        }

    }
}
