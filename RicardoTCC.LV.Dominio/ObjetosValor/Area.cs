using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Area: ObjetoValor
    {
        public Area(string sigla, Area areaSuperior, OrdemServico ordemServico)
        {
            
            if(areaSuperior != null)
            AreaSuperior = areaSuperior;

            Sigla = sigla;

            OrdemServico = ordemServico;

            AddNotifications(new Contract().Requires());

            if (areaSuperior != null)
                AddNotifications(areaSuperior);

            AddNotifications(OrdemServico);

        }

        public string Sigla { get; private set; }
        public Nome Nome { get; private set; }
        public Area AreaSuperior { get; private set; }
        public OrdemServico OrdemServico { get; private set; }
    }
}
