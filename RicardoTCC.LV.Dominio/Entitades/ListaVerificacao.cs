using RicardoTCC.LV.Dominio.ObjetosValor;
using RicardoTCC.LV.Dominio.Servico;
using System.Collections.Generic;
using System.Linq;

namespace RicardoTCC.LV.Dominio.Entitades
{
    public class ListaVerificacao : Entidade
    {

        IList<Revisao> _revisoes;

        public ListaVerificacao(CopiaVerificacao copiaVerificacao)
        {
            CopiaVerificacao = copiaVerificacao;
            _revisoes = new List<Revisao>();

            AddNotifications(copiaVerificacao);
        }

        public void AdiconarRevisao(Revisao revisao)
        {
            _revisoes.Add(revisao);
        }

        public CopiaVerificacao CopiaVerificacao { get; private set; }

        public IReadOnlyCollection<Revisao> Itens { get { return _revisoes.ToList(); } }

    }
}
