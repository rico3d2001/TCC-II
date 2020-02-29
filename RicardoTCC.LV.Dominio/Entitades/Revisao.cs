using RicardoTCC.LV.Dominio.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.Entitades
{
    public class Revisao
    {
        
        List<ItemVerificado> _itens;
        public Revisao(Ordenador ordenador, IndiceRevisao indice)
        {
            Ordenador = ordenador;
            Indice = indice;
        }

        public Ordenador Ordenador { get; private set; }
        public IndiceRevisao Indice { get; private set; }

        


        //public List<ItemVerificado> Itens { get; set; }

       
        
    }
}
