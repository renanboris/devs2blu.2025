using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorSpaceDevs.Tratamentos
{
    public static class ValidarData
    {
        public static bool Verifica(string validarDtNasc, out string dtNasc)
        {
            if (DateTime.TryParse(validarDtNasc, out DateTime dataNasc))
            {
                dtNasc = dataNasc.ToString("dd/MM/yyyy");
                return true;
            }
            else
            {
                dtNasc = string.Empty;
                return false;
            }
        }
    }
}
