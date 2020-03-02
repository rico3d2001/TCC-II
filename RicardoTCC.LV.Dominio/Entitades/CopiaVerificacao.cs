using RicardoTCC.LV.Dominio.ObjetosValor;

namespace RicardoTCC.LV.Dominio.Entitades
{
    public class CopiaVerificacao : Entidade
    {
        IdentidadeDocumento _numeroFornecedor;
        IdentidadeDocumento _numeroCliente;

        public CopiaVerificacao(IdentidadeDocumento numeroFornecedor, IdentidadeDocumento numeroCliente)
        {
            _numeroFornecedor = numeroFornecedor;
            _numeroCliente = numeroCliente;
        }

        public string NumeroFornecedor { get => _numeroFornecedor.Numero; }
        public string NumeroCliente { get => _numeroCliente.Numero; }
    }
}
