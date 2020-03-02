using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Login
    {
        public Login(string nome)
        {
            Nome = new Nome(nome, "Login", 5, 10);
        }

        public Nome Nome { get; set; }
    }
}
