using RicardoTCC.LV.Dominio.ObjetosValor;
using RicardoTCC.LV.Dominio.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.Entitades
{
    public class CopiaVerificacao : Entidade
    {
        public CopiaVerificacao(string numeroFornecedor, string numeroCliente)
        {
            NumeroFornecedor = numeroFornecedor;
            NumeroCliente = numeroCliente;
        }

        public string NumeroFornecedor { get; set; }
        public string NumeroCliente { get; set; }
    }
}
