using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto.Classes
{
    public class Calculadora
    {
       //public decimal Numero1 { get; set; }
       //public decimal Numero2 { get; set; }
                     
       public decimal Somar(decimal n1, decimal n2)
        {
            return n1 + n2;
        }

        public decimal Subtrair(decimal n1, decimal n2)
        {
            return n1 - n2;
        }

        public decimal Multiplicar(decimal n1, decimal n2)
        {
            return n1 * n2;
        }

        public decimal Dividir(decimal n1, decimal n2)
        {
            return n1 / n2;
        }

    }
}
