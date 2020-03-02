using RicardoTCC.LV.Dominio.Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Topico : ObjetoValor
    {
        public Topico(IdTopico idTopico, Ordenador ordenador, string descricao)
        {
            IdTopico = idTopico;
            Ordenador = ordenador;
            Descricao = new Descricao(descricao);
        }

        public IdTopico IdTopico { get; set; }
        public Ordenador Ordenador { get; private set; }
        public Descricao Descricao { get; private set; }

        public override bool Equals(object obj)
        {
            var t = obj as Topico;
            return Descricao == t.Descricao ? true : false;
        }
    }
}
