using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorSpaceDevs.Classes
{
    public class Pessoa
    {
        
        public string Nome { get; set; }    
        public string DtNasc { get; set; }
        public string PaisOrigem { get; set;}
        public string Funcao { get; set; }


        public Pessoa(string nome, string dtNasc, string paisOrigem, string funcao) 
        {
            Nome = nome;
            DtNasc = dtNasc;
            PaisOrigem = paisOrigem;
            Funcao = funcao;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"*** Informações do Cadastro ***");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Dt Nasc: {DtNasc}");
            Console.WriteLine($"País de Origem: {PaisOrigem}");
            Console.WriteLine($"Função: {Funcao}");
        }
    }
}
