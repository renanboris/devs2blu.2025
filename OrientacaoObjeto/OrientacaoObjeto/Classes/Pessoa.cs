using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto.Classes
{
    public class Pessoa
    {
        private static int _Contagem = 0;
        public static int Contagem { get => _Contagem; }

        public Pessoa()
        {
            _Contagem++;
        }

        public static void ResetarContagem()
        {
            _Contagem = 0;
        }
       
    }
}
