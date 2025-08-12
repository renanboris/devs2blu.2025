using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto.MaoNaMassa
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Matricula { get; set; }

        public Aluno(string nome)
        {
            Nome = nome;
        }

        public Aluno(string nome, int idade, string matricula)
        {
            Nome = nome;
            Idade = idade;
            Matricula = matricula;
        }

        public void CalcularIdadeEmMeses()
        {
            var idadeEmMeses = Idade * 12;
            Console.WriteLine($"A idade de {Nome} em meses é {idadeEmMeses} meses");
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"*** Informações do Aluno ***");
            Console.WriteLine($"Aluno: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Matricula: {Matricula}");
        }

    }
}
