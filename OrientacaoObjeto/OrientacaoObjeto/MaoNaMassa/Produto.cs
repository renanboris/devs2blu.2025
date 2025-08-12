using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto.MaoNaMassa
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }        
        public int Moeda { get; set; }

        public enum TipoMoeda
        {
            Real = 1,
            Dolar = 2
        }

        public static List<Produto> Comprar(List<Produto> produtos, double valorPagamento, out double troco)
        {
            double somaCarrinho = 0;
            var i = 0;

            Console.WriteLine("\n--- Carrinho de Compras ---");
            
            foreach (var produto in produtos)
            {                  
                Console.WriteLine($"{i + 1} - {produto.Nome}\tPreço: {produto.Preco:F2}");
                somaCarrinho += produto.Preco;
            }

            if (somaCarrinho > valorPagamento)
            {
                Console.WriteLine("Você não deu dinheiro o suficiente!");
                troco = valorPagamento;
            }
            else
            {
                Console.WriteLine("Produto comprado!");
                troco = valorPagamento - somaCarrinho;
            }
            return produtos;
        }

        public static string FormatarValor(double valorProduto, int moeda)
        {
            TipoMoeda VerificaMoeda = (TipoMoeda)moeda;

            switch (VerificaMoeda)
            {
                case TipoMoeda.Dolar:
                    return valorProduto.ToString("C", new System.Globalization.CultureInfo("en-US"));
                case TipoMoeda.Real:
                    return valorProduto.ToString("C", new System.Globalization.CultureInfo("pt-BR"));
                default:
                    return "ERRO MOEDA";
            }
        }

        public Produto(string nome)
        {
            Nome = nome;
        }

        public Produto(string nome, double preco, int qtdeEstoque, int moeda)
        {
            Nome = nome;
            Preco = preco;  
            QuantidadeEstoque = qtdeEstoque;
            Moeda = moeda;            
        }

        public int AtualizarEstoque(int quantidade)
        {
            return QuantidadeEstoque = quantidade;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Produto:\t{Nome}");
            Console.WriteLine($"Preço:\t{Preco}");
            Console.WriteLine($"Estoque:\t{QuantidadeEstoque}");
        }
    }
}
