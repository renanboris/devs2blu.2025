using GerenciadorSpaceDevs.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorSpaceDevs.Metodos
{
    public static class MenuAstronauta
    {
        public static void Executar(List<Pessoa> cadAstronauta, List<Missao>? listaMissoes)
        {
            bool continuar = true;

            do
            {
                var msg1 = "1 - Astronautas Cadastrados\t*";
                var msg2 = "2 - Cadastro de Astronautas\t*";
                var msg3 = "*\t\t\t\t*";

                GerenciadorSpaceDevs.Metodos.InterfaceUsuario.TelaPrincipal(msg1, msg2, msg3, listaMissoes);
                                
                var opcaoMenu = Console.ReadLine().ToUpper();

                switch (opcaoMenu)
                {
                    case "1":
                        if (cadAstronauta.Count == 0)
                        {
                            Console.WriteLine("Nenhum Astronauta cadastrado.");
                            Thread.Sleep(800);
                            break;
                        }
                        GerenciadorSpaceDevs.Metodos.ListarAstronautas.Executar(cadAstronauta);
                        break;
                    case "2":
                        GerenciadorSpaceDevs.Metodos.CadastroAstronauta.Executar(cadAstronauta);
                        Thread.Sleep(1200);
                        break;
                    case "X":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        Thread.Sleep(1200);
                        break;
                }

            } while (continuar);
        }
    }
}
