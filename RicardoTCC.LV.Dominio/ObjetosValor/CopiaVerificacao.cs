using RicardoTCC.LV.Dominio.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class CopiaVerificacao
    {
        IdentidadeDocumento _numeroFornecedor;
        IdentidadeDocumento _numeroCliente;
        public CopiaVerificacao(INumeracao numeracaoFornecedor, INumeracao numeracaoCliente)
        {
            _numeroFornecedor = numeracaoFornecedor.Numerar();
            _numeroCliente = numeracaoCliente.Numerar();
        }

        public IdentidadeDocumento NumeroFornecedor { get => _numeroFornecedor; private set => _numeroFornecedor = value; }
        public IdentidadeDocumento NumeroCliente { get => _numeroCliente;private set => _numeroCliente = value; }
    }
}
