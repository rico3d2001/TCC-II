using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Verificador
    {
        public Verificador(string nome, Ordenador ordenador)
        {
            Nome = nome;
            Ordenador = ordenador;
        }

        public string Nome { get; private set; }
        public Ordenador Ordenador { get; private set; }
    }
}
