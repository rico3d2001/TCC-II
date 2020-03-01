using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class TabelaRevisao : ObjetoValor
    {
        public TabelaRevisao(Versao versao, Ordenador ordenador, string nome, TipoDocumento tipoDocumento, ColunaTipicaRevisao coluna)
        {
            Versao = versao;
            Ordenador = ordenador;
            Nome = new Nome(nome,"Tabela de Revisão",5,50);
            TipoDocumento = tipoDocumento;
            ColunaTipica = coluna;
        }

        public Versao Versao { get; private set; }
        public Ordenador Ordenador { get; private set; }
        public Nome Nome { get; private set; }
        public TipoDocumento TipoDocumento { get; private set; }

        public ColunaTipicaRevisao ColunaTipica { get; set; }

    }
}
