using RicardoTCC.LV.Dominio.ObjetosValor;
using RicardoTCC.LV.Dominio.Servico;
using System.Collections.Generic;

namespace RicardoTCC.LV.Dominio.Entitades
{
    public class ListaVerificacao
    {

        List<Revisao> _revisoes;

        CopiaVerificacao _copiaVerificacao;

        public ListaVerificacao(CopiaVerificacao copiaVerificacao)
        {
            _copiaVerificacao = copiaVerificacao;
            _revisoes = new List<Revisao>();
        }

        public void AdiconarRevisao(Revisao revisao)
        {
            _revisoes.Add(revisao);
        }

       
        public CopiaVerificacao CopiaVerificacao { get => _copiaVerificacao;private set => _copiaVerificacao = value; }
    }
}
