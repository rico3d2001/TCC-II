using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Senha
    {
        public Senha(string nome)
        {
            Nome = new Nome(nome,"Senha",6,10);
        }

        public Nome Nome { get; set; }
    }
}
