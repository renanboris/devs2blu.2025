using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto.Classes
{
    public class Livro
    {
        private const int QUANTIDADE_PAGINAS = 384;

        private int _PaginaAtual = 0;

        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int QtdPaginas { get; private set; }

        
        //Atalho para fazer o construtor: ctor
    
        public Livro(string titulo, string autor, int qtdPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            QtdPaginas = qtdPaginas;
        }


        public void Identificar()
        {
            Console.WriteLine($"O {Titulo} foi escrito pelo Autor {Autor}");
        }

        public int Ler()
        {
            _PaginaAtual++;
            Console.WriteLine($"Leu página {_PaginaAtual}");
            return _PaginaAtual;
        }

    }
}
