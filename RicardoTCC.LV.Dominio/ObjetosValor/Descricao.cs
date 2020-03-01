using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Descricao
    {
        public Descricao(string texto)
        {
            Texto = texto;
        }

        public string Texto { get; private set; }
    }
}
