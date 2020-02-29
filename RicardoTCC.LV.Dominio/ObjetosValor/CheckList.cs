using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class CheckList
    {
        public CheckList(Ordenador ordenador, string descricao, List<Topico> topicos)
        {
            Ordenador = ordenador;
            Descricao = descricao;
            Topicos = topicos;
        }

        public Ordenador Ordenador { get; private set; }
        public string Descricao { get; private set; }
        public List<Topico> Topicos { get; private set; }
    }
}
