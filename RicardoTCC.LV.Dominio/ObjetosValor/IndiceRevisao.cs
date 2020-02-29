using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class IndiceRevisao
    {
        public IndiceRevisao(string indice)
        {
            Indice = indice;
        }

        public string Indice { get; private set; }
    }
}
