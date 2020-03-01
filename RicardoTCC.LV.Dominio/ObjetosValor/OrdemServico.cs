using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class OrdemServico : ObjetoValor
    {
        public OrdemServico(string sigla, Projeto projeto)
        {
            Sigla = sigla;
           

            Projeto = projeto;

            AddNotifications(new Contract().Requires());

            AddNotifications(Projeto);
        }

        public string Sigla { get; private set; }
      

        public Projeto Projeto { get; private set; }
    }
}
