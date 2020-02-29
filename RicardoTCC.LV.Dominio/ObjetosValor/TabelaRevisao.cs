using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class TabelaRevisao
    {
        public TabelaRevisao(int versao, Ordenador ordenador, string nome, TipoDocumento tipoDocumento, ColunaTipicaRevisao coluna)
        {
            Versao = versao;
            Ordenador = ordenador;
            Nome = nome;
            TipoDocumento = tipoDocumento;
            ColunaTipica = coluna;
        }

        public int Versao { get; private set; }
        public Ordenador Ordenador { get; private set; }
        public string Nome { get; private set; }
        public TipoDocumento TipoDocumento { get; private set; }

        public ColunaTipicaRevisao ColunaTipica { get; set; }

    }
}
