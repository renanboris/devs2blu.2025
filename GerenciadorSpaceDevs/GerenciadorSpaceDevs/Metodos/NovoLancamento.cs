using GerenciadorSpaceDevs.Classes;
using GerenciadorSpaceDevs.Tratamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorSpaceDevs.Metodos
{
    public static class NovoLancamento
    {
        public static void Executar(List<Pessoa> cadAstronauta, List<Missao> listaMissoes)
        {
            if (cadAstronauta.Count == 0)
            {
                Console.WriteLine("Não é possível efetuar um novo lançamento. Nenhum Astronauta cadastrado.");
                Thread.Sleep(800);
                return;
            }


            Console.WriteLine("*-------------------------------*");
            Console.WriteLine("Digite o nome da Missão:");
            var nomeMissao = Console.ReadLine();

            if (!GerenciadorSpaceDevs.Tratamentos.StringVazia.Verifica(nomeMissao))
            {
                return;
            }

            Console.WriteLine("Digite o Destino da Viagem:");
            var destinoMissao = Console.ReadLine();

            if (!GerenciadorSpaceDevs.Tratamentos.StringVazia.Verifica(destinoMissao))
            {
                return;
            }

            Console.WriteLine("Digite o Tempo (em dias) da Missão:");

            if (!int.TryParse(Console.ReadLine(), out int tempoMissao))
            {
                Console.WriteLine("Dias não preenchidos. Lançamento cancelado");
                Thread.Sleep(1200);
                return;
            }

            bool continuar = true;
            List<Astronauta> astronautasMissao = new List<Astronauta>();
            bool naoAchou = false;

            do
            {
                Console.WriteLine("Adicione Astronauta responsável:");
                var nomeAstronauta = Console.ReadLine();
                bool astronautaEncontrado = false;

                foreach (var astronauta in cadAstronauta)
                {
                    var localizaAstronauta = astronauta.Nome;

                    if (nomeAstronauta == astronauta.Nome && astronauta.Funcao == "Astronauta")
                    {
                        astronautaEncontrado = true;
                        var novoAstronauta = new Astronauta(nomeAstronauta);
                        astronautasMissao.Add(novoAstronauta);

                        Console.WriteLine("Astronauta responsável Cadastrado. Deseja incluir outro? (S/N)");
                        var opcaoNovoAstronauta = Console.ReadLine().ToUpper();
                        if (opcaoNovoAstronauta != "S")
                        {
                            continuar = false;
                        }
                        break;
                    }
                }
                if (!astronautaEncontrado)
                {
                    if (naoAchou)
                    {
                        Console.WriteLine("Operação cancelada!");
                        Thread.Sleep(800);
                        return;
                    }
                    {
                        Console.WriteLine("Astronauta não encontrado!");
                        Thread.Sleep(800);
                        naoAchou = true;
                    }
                }
            } while (continuar);

            var novaMissao = new Missao(nomeMissao, destinoMissao, tempoMissao);
            listaMissoes.Add(novaMissao);

            foreach (var astronauta in astronautasMissao)
            {
                astronauta.AdicionarMissao(novaMissao);
                novaMissao.AdicionarAstronauta(astronauta);
            }
            Console.Clear();
            Console.WriteLine("*-------------------------------*");
            Console.WriteLine("* Missão Cadastrada com sucesso!*");
            novaMissao.ExibirDetalhes();
            Console.Write("\n* Pressione ENTER para voltar *");
            Console.ReadKey();
        }
    }
}
