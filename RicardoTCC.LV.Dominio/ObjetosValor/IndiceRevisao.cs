using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class IndiceRevisao : ObjetoValor
    {
        public IndiceRevisao(string indice)
        {
            Indice = new Nome(indice,"Indice de Revisão",1,2);
        }

        private string defineIndice(string indice)
        {
            if (contemNumeros(indice))
            {
                AddNotification("Indice de Revisão", "Não pode conter números");
            }

            return indice;
        }

        public bool contemNumeros(string texto)
        {
            if (texto.Where(c => char.IsNumber(c)).Count() > 0)
                return true;
            else
                return false;
        }

        public Nome Indice { get; private set; }
    }
}
