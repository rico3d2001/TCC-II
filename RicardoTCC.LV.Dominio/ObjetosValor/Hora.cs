using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Hora : ObjetoValor
    {
        public Hora()
        {
            HoraAcao = DateTime.Now;
        }

        public DateTime HoraAcao { get; private set; }
    }
}
