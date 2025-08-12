// See https://aka.ms/new-console-template for more information

using GerenciadorSpaceDevs.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main()
    {
        bool continuar = true;
        var cadAstronauta = new List<Pessoa>();
        var listaMissoes = new List<Missao>();

        do
        {
            var msg1 = "*1 - Cadastro de Astronautas\t*";
            var msg2 = "*2 - Realizar Novo Lançamento\t*";
            var msg3 = "*3 - Buscar Missões \t\t*";

            GerenciadorSpaceDevs.Metodos.InterfaceUsuario.TelaPrincipal(msg1, msg2, msg3, listaMissoes);

            var opcaoMenu = Console.ReadLine().ToUpper();

            switch (opcaoMenu)
            {
                case "1":
                    GerenciadorSpaceDevs.Metodos.MenuAstronauta.Executar(cadAstronauta, listaMissoes);
                    break;
                case "2":
                    GerenciadorSpaceDevs.Metodos.NovoLancamento.Executar(cadAstronauta, listaMissoes);
                    break;
                case "3":
                    GerenciadorSpaceDevs.Metodos.BuscaMissao.Executar(listaMissoes);
                    break;
                case "X":
                    continuar = false;
                    Console.Write("LOGOFF");
                    Thread.Sleep(700);
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    Thread.Sleep(1200);
                    break;
            }

        } while (continuar);
    }
}
      
