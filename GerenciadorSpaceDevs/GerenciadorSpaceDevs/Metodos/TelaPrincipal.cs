using GerenciadorSpaceDevs.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorSpaceDevs.Metodos
{
    public static class InterfaceUsuario
    {
        public static void TelaPrincipal(string msg1, string msg2, string msg3, List<Missao> missao)
        {
            Console.Clear();
            Console.WriteLine($"Bem vindo a Space Devs! | {Missao.NumeroLancamentos} Lançamentos já efetuados *-* \n");
            Console.WriteLine("*-------------------------------*");
            Console.WriteLine(msg1);
            Console.WriteLine(msg2);
            Console.WriteLine(msg3);
            Console.WriteLine("*X - Sair|Voltar \t\t*");
            Console.WriteLine("*-------------------------------*");
            Console.Write("Digite: ");
        }
    }
}