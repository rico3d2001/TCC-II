using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Topico
    {
        public Topico(Ordenador ordenador, string descricao)
        {
            Ordenador = ordenador;
            Descricao = descricao;
        }

        public Ordenador Ordenador { get; private set; }
        public string Descricao { get; private set; }
    }
}
