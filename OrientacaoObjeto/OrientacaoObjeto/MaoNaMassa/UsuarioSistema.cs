using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto.MaoNaMassa
{
    
    public class UsuarioSistema
    {
        private static List<UsuarioSistema> cadUsuarios = new List<UsuarioSistema>();        

        public string Nome {  get; set; }  
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public UsuarioSistema(string nome, string usuario, string senha)
        {
            Nome = nome;
            Usuario = usuario;
            Senha = senha;
        }

        public static void Cadastrar(UsuarioSistema novoUsuario)
        {
            cadUsuarios.Add(novoUsuario);
            Console.WriteLine("Usuário cadastrado com sucesso!");
        }

        public static UsuarioSistema Autenticar(string usuario, string senha)
        {
            foreach (var user in cadUsuarios)
            {
                if (user.Usuario == usuario && user.Senha == senha)
                {
                    return user;
                }
            }
            Console.WriteLine("Usuário ou senha incorretos.");
            return null;
        }

        public bool Deslogar()
        {
            Console.Write($"Usuário: {Usuario} | DESLOGADO");
            return true;
        }

        public void AtulizarSenha(UsuarioSistema usuario)
        {

        }
    }
}
