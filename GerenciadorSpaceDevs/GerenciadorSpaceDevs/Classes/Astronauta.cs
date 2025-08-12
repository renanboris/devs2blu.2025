using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorSpaceDevs.Classes
{
    public class Astronauta
    {

        public string Nome { get; set; }
        public List<Missao> Missoes { get; set; } = new List<Missao>();

        public Astronauta(string nome)
        {
            Nome = nome;
        }

        public void AdicionarMissao(Missao missao)
        {
            Missoes.Add(missao);
        }
    }
}

