using RicardoTCC.LV.Dominio.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.Servico
{
    public class NumeracaoFornecedor : INumeracao
    {
        TipoDocumento _tipo;
        Area _area;
        OrdemServico _ordemServico;

        public NumeracaoFornecedor(TipoDocumento tipo, Area area, OrdemServico ordemServico)
        {
            _tipo = tipo;
            _area = area;
            _ordemServico = ordemServico;
        }
        public IdentidadeDocumento Numerar()
        {
            throw new NotImplementedException();
        }
    }
}
