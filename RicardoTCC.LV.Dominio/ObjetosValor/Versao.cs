using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Versao : ObjetoValor
    {
        public Versao(int numero)
        {
            Texto = "V_" + numero;
        }

        public string Texto { get; private set; }
    }
}
