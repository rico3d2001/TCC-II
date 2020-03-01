using Flunt.Validations;
using RicardoTCC.LV.Dominio.ObjetosValor;
using RicardoTCC.LV.Dominio.ObjetosValor.Enumerados;
using System.Collections.Generic;
using System.Linq;

namespace RicardoTCC.LV.Dominio.Entitades
{
    public class Revisao : Entidade
    {
        
        IList<ItemVerificacao> _itens;
        public Revisao(Ordenador ordenador, IndiceRevisao indice)
        {
            Ordenador = ordenador;
            Indice = indice;
            _itens = new List<ItemVerificacao>();

            AddNotifications(indice);

        }

        public Ordenador Ordenador { get; private set; }
        public IndiceRevisao Indice { get; private set; }

        public IReadOnlyCollection<ItemVerificacao> Itens { get { return _itens.ToList(); } }


        


        public void AdicionarItem(ItemVerificacao item)
        {
          
            if (naoHaOutroNaLista(item))
            {
                _itens.Add(item);
            }
            else if (nenhumOutroInseriuItemDepoisDesteVerificador(item))
            {
                _itens.Add(item);
            }
            else
            {
                AddNotification("Inserção de item de revisão", "Outro verificador já iniciou.");
            }
         
        }

        public ItemVerificacao PegaItem(Topico topico)
        {
           return _itens.FirstOrDefault(x => x.IdTopico.Equals(topico));
        }

        public void ModificaStatusItem(ItemVerificacao item, Status status)
        {
            var i = _itens.FirstOrDefault(x => x.IdTopico.Equals(item.IdTopico));
            i.ModificaStatusVerificacao(status);
        }

        #region Metodos privados

       

        private bool naoHaOutroNaLista(ItemVerificacao item)
        {
            var outros = _itens.Where(x => !x.Verificador.Equals(item.Verificador)).ToList();
            return (outros.Count() > 0) ? false : true;
        }

        private bool nenhumOutroInseriuItemDepoisDesteVerificador(ItemVerificacao item)
        {
            var seus = _itens.Where(x => x.Verificador.Equals(item.Verificador)).ToList();
            if(seus.Count > 0)
            {
                var outros = _itens.Where(x => !x.Verificador.Equals(item.Verificador)).ToList();
                var suaHora = seus.Max(x => x.Hora.HoraAcao);
                var horaOutro = outros.Max(x => x.Hora.HoraAcao);
                return (suaHora > horaOutro) ? true : false;
            }

            return true;
           

        }

        private bool naoEstaNaLista(ItemVerificacao item)
        {
            var teste = _itens.FirstOrDefault(x => x.Verificador.Equals(item.Verificador));
            return _itens.FirstOrDefault(x => x.Verificador.Equals(item.Verificador)) == null;
        }

        #endregion
    }
}
