using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto.Classes
{
    public class Produto2
    {
        private string Nome { get; set; }
        private decimal Preco { get; set; }



        public Produto2(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarPreco(decimal preco)
        {
            if (preco >= 0)
            {
                Preco = preco;
            }
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome Produto: {Nome} | Preço: {Preco}");
        }
    }
}
