using Flunt.Validations;
using RicardoTCC.LV.Dominio.Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Disciplina : ObjetoValor
    {
        public Disciplina(string nome, string sigla)//, List<TabelaRevisao> tabelas)
        {
            Nome = new Nome(nome, "Disciplina", 5, 50);
            Sigla = sigla;
            //Tabelas = tabelas;
            AddNotifications(new Contract().Requires());
        }

        public Nome Nome { get; private set; }
        public string Sigla { get; private set; }

        

        //public List<TabelaRevisao> Tabelas { get; private set; }
    }
}
