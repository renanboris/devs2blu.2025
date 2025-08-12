using GerenciadorSpaceDevs.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorSpaceDevs.Metodos
{
    public static class ListarAstronautas
    {
        public static void Executar(List<Pessoa> cadAstronauta)
        {
            Console.Clear();
            Console.WriteLine("* Astronautas Cadastrados \t*");
            Console.WriteLine("*-------------------------------*");


            foreach (var astronauta in cadAstronauta)
            {
                var funcao = astronauta.Funcao.ToUpper();

                if (funcao == "ASTRONAUTA")
                {
                    var nome = astronauta.Nome;
                    var dtNasc = astronauta.DtNasc;
                    var paisOrigem = astronauta.PaisOrigem;

                    Console.WriteLine($"Nome: {nome} | Dt Nasc: {dtNasc} | País de Origem: {paisOrigem}");
                }
            }
            Console.Write("\n* Pressione ENTER para voltar *");
            Console.ReadKey();
        }
    }
}
