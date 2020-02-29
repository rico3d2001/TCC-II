using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class TipoDocumento
    {
        public TipoDocumento(string sigla, string nome)
        {
            Sigla = sigla;
            Nome = nome;
        }

        public string Sigla { get; private set; }
        public string Nome { get; private set; }
    }
}
