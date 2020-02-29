using RicardoTCC.LV.Dominio.Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Disciplina
    {
        public Disciplina(string nome, string sigla, List<TabelaRevisao> tabelas)
        {
            Nome = nome;
            Sigla = sigla;
            Tabelas = tabelas;
        }

        public string Nome { get; private set; }
        public string Sigla { get; private set; }

        public List<TabelaRevisao> Tabelas { get; private set; }
    }
}
