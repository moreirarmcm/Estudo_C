using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static internal class CadastroUsuarios
    {
        private static Usuario[] usuarios =
        {
            new Usuario(){Nome = "Renan", Senha = "abc123"},
            new Usuario(){Nome = "Daniele", Senha = "123abc"},
            new Usuario(){Nome = "Rayane", Senha = "1a23bc"}
       };
        private static Usuario _usuarioLogado = null;

        public static Usuario usuarioLogado
        {
            get { return _usuarioLogado; }
            private set { _usuarioLogado = value; }
        }

        public static bool Login(string username, string password)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome == username && usuario.Senha == password)
                {
                    usuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
        