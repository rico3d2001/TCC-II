using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class OrdemServico
    {
        public OrdemServico(string sigla, string nome, Projeto projeto)
        {
            Sigla = sigla;
            Nome = nome;
            Projeto = projeto;
        }

        public string Sigla { get; private set; }
        public string Nome { get; private set; }

        public Projeto Projeto { get; private set; }
    }
}
