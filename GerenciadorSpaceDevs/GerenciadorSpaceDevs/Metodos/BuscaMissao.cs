using GerenciadorSpaceDevs.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorSpaceDevs.Metodos
{
    public class BuscaMissao
    {
        public static void Executar(List<Missao> missoes)
        {
            bool continuar = true;
            do
            {
                if (missoes.Count == 0)
                {
                    Console.WriteLine("Nenhuma Missão Cadastrada.");
                    Thread.Sleep(1200);
                    return;
                }

                Console.Clear();
                Console.WriteLine("*-------------------------------*");
                Console.WriteLine("Todas as Missões \t\t*");
                Console.WriteLine("*-------------------------------*");

                var contador = 1;
                foreach (var missao in missoes)
                {
                    Console.WriteLine($"{contador} - Nome: {missao.Nome} | Destino: {missao.Destino} | Status Atual: {missao.Situacao} | Detalhes: {missao.Descricao}");
                    contador++;
                }
                Console.WriteLine("*-------------------------------*");
                Console.WriteLine("\nO que deseja fazer?");
                Console.Write("Atualizar Status(1) | Atualizar Descrição(2) | Sair(X):");
                var resposta = Console.ReadLine().ToUpper();

                switch (resposta)
                {
                    case "1":
                        Console.Write("Digite o cód da Missão que deseja atualizar: ");
                        if (int.TryParse(Console.ReadLine(), out int indiceB) &&
                            indiceB > 0 && indiceB <= missoes.Count)
                        {
                            var statusString = "";

                            Console.WriteLine("Escolha a opção: 1 - Sucesso | 2 - Problemas | 3 - Aguardando");

                            if (int.TryParse(Console.ReadLine(), out int status))
                            {
                                if (Enum.IsDefined(typeof(Missao.Status), status))
                                {
                                    Missao.Status statusEnum = (Missao.Status)status;
                                    statusString = statusEnum.ToString();
                                }
                                else
                                {
                                    Console.WriteLine("Valor inválido.");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Opção incorreta!");
                                break;
                            }
                            missoes[indiceB - 1].AtualizarStatus(statusString);

                        }
                        else
                        {
                            Console.Write("Código Inexistente.");
                            Thread.Sleep(2000);
                        }
                        break;
                    case "2":
                        Console.Write("Digite o cód da Missão que deseja atualizar: ");
                        if (int.TryParse(Console.ReadLine(), out int indiceA) &&
                            indiceA > 0 && indiceA <= missoes.Count)
                        {
                            Console.Write("Insira a Descrição: ");
                            var descricao = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(descricao))
                            {
                                Console.WriteLine("A Descrição não pode ser vazia!");
                                break;
                            }

                            missoes[indiceA - 1].AtualizaDescricao(descricao);
                        }
                        else
                        {
                            Console.Write("Código Inexistente.");
                            Thread.Sleep(2000);
                        }
                        break;
                    case "X":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (continuar);
        }
    }
}
