using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class CheckList : ObjetoValor
    {
        public CheckList(Ordenador ordenador, Descricao descricao, List<Topico> topicos)
        {
            Ordenador = ordenador;
            Descricao = descricao;
            Topicos = topicos;
        }

        public Ordenador Ordenador { get; private set; }
        public Descricao Descricao { get; private set; }
        public List<Topico> Topicos { get; private set; }
    }
}
