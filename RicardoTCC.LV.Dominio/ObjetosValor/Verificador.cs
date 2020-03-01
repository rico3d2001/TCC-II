using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Verificador : ObjetoValor
    {
        public Verificador(string nome, string sigla)
        {
            Nome = new Nome(nome,"Nome do Verficador",5,100);
            Sigla = new Sigla(sigla, "Nome do Verficador", 5);
        }

        public Nome Nome { get; private set; }
        public Sigla Sigla { get; private set; }

        public override bool Equals(object verificador)
        {
            var v = verificador as Verificador;
           return Sigla.Equals(v.Sigla) ? true : false;
        }
    }
}
