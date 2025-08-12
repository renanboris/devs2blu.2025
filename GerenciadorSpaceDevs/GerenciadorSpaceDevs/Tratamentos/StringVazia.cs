using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorSpaceDevs.Tratamentos
{
    public static class StringVazia
    {
        public static bool Verifica(string validar)
        {
            if (string.IsNullOrWhiteSpace(validar))
            {
                Console.WriteLine("Cadatro cancelado. Campos obrigatórios não preenchidos!");
                Thread.Sleep(2000);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
