﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Projeto : ObjetoValor
    {
        public Projeto(string sigla)
        {
            Sigla = sigla;
        }

        public string Sigla { get; private set; }
       

    }
}
