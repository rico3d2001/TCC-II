using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Area
    {
        public Area(string sigla, string nome, Area areaSuperior, OrdemServico ordemServico)
        {
            Sigla = sigla;
            Nome = nome;
            AreaSuperior = areaSuperior;
            OrdemServico = ordemServico;
        }

        public string Sigla { get; private set; }
        public string Nome { get; private set; }
        public Area AreaSuperior { get; private set; }
        public OrdemServico OrdemServico { get; private set; }
    }
}
