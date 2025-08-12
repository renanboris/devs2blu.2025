using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorSpaceDevs.Classes
{
    public class Missao
    {
        public static int NumeroLancamentos { get; private set; } = 0;
        public string Nome { get; set; }
        public string Destino { get; set; }
        public List<Astronauta> Astronautas { get; set; } = new List<Astronauta>();

        public string Descricao { get; set; }

        public int DuracaoDias { get; set; }
        public string Situacao { get; set; }  

        
        public enum Status
        {
            Sucesso = 1,
            Problemas = 2,
            Aguardando = 3,            
        }

        public Missao(string nomeMissao, string destinoMissao, int tempoMissao)
        {
            Nome = nomeMissao;
            Destino = destinoMissao;
            DuracaoDias = tempoMissao;
            Descricao = "Sem atualizações no momento";
            Situacao = Status.Aguardando.ToString();
            NumeroLancamentos++;
        }


        public void AdicionarAstronauta(Astronauta astronauta)
        {
            Astronautas.Add(astronauta);
        }

        public void AtualizaDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public void AtualizarStatus(string status)
        {
            Situacao = status;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("*-------------------------------*");
            Console.WriteLine($"* Missão: {Nome}");
            Console.WriteLine($"* Destino: {Destino}");
            Console.WriteLine($"* Duração: {DuracaoDias} dias");
            Console.WriteLine("* Astronautas responsáveis:");

            foreach (var astronauta in Astronautas)
            {
                Console.WriteLine($"*\t{astronauta.Nome}");
            }

            if (!string.IsNullOrEmpty(Descricao))
            {
                Console.WriteLine($"Status atual da Missão: {Situacao}");
                Console.WriteLine($"Atualizações da Missão: {Descricao}");                
                //Console.WriteLine($"Status atual da Missão: {(Sucesso ? "Sucesso" : "Problemas")}");
            }
            Console.WriteLine("*-------------------------------*");

        }
    }
}


