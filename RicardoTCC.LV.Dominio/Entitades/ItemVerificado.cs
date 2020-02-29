using RicardoTCC.LV.Dominio.ObjetosValor;
using RicardoTCC.LV.Dominio.ObjetosValor.Enumerados;

namespace RicardoTCC.LV.Dominio.Entitades
{
    public class ItemVerificado
    {
        public ItemVerificado(Topico topicoVerificacao)
        {
            TopicoVerificacao = topicoVerificacao;
        }

        public Topico TopicoVerificacao { get; private set; }

        public Verificador Verificador { get; set; }
        public Status StatusVerificacao { get; set; }

        public override string ToString()
        {
            return TopicoVerificacao.Descricao + " " + StatusVerificacao.Name;
        }

    }
}
