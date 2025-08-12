using GerenciadorSpaceDevs.Classes;
using GerenciadorSpaceDevs.Tratamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorSpaceDevs.Metodos
{
    public static class CadastroAstronauta
    {
        public static void Executar(List<Pessoa> cadAstronauta)
        {

            var funcao = "Astronauta";

            Console.WriteLine("Digite o nome do Astronauta");
            var nome = Console.ReadLine();

            if (!GerenciadorSpaceDevs.Tratamentos.StringVazia.Verifica(nome))
            {
                return;
            }

            Console.WriteLine("Digite a Data de Nascimento (ex: 16/07/2025): ");
            var dtNasc = Console.ReadLine();

            if (!GerenciadorSpaceDevs.Tratamentos.ValidarData.Verifica(dtNasc, out string dataFormatada) || string.IsNullOrEmpty(dataFormatada))
            {
                Console.WriteLine("Data Incorreta. Cadastro cancelado.");
                return;
            }
            else
            {
                dtNasc = dataFormatada;
            }

            Console.WriteLine("Digite o país de Origem do Astronauta");
            var paisOrigem = Console.ReadLine();

            if (!GerenciadorSpaceDevs.Tratamentos.StringVazia.Verifica(paisOrigem))
            {
                return;
            }

            cadAstronauta.Add(new Pessoa(nome, dtNasc, paisOrigem, funcao));
            Console.WriteLine("Cadastrado com sucesso!");
        }
    }
}
