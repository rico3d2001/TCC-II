using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class TipoDocumento : ObjetoValor
    {
        public TipoDocumento(string sigla, string nome)
        {
            Sigla = sigla;
            Nome = new Nome(nome, "Tipo de Documento",5,50);
        }

        public string Sigla { get; private set; }
        public Nome Nome { get; private set; }
    }
}
