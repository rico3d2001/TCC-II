using RicardoTCC.LV.Dominio.ObjetosValor;
using System.Collections.Generic;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class ColunaTipicaRevisao : ObjetoValor
    {
        public ColunaTipicaRevisao(List<CheckList> checkLists)
        {
            CheckLists = checkLists;
        }

        public List<CheckList> CheckLists { get; private set; }
    }
}
