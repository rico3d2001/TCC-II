using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Ordenador
    {
        public Ordenador(int numero)
        {
            Numero = numero;
        }


        public int Numero { get; private set; }
    }
}
