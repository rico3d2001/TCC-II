using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor.Enumerados
{
    public class Status: Enumeracao
    {
        public static Status X = new Status(1, "Errado");
        public static Status V = new Status(1, "Verificado");
        public static Status NA = new Status(1, "Não Aplicável");
        public static Status ND = new Status(1, "Não Disponível");
        public static Status I = new Status(1, "Indefinido");
        public Status(int id, string name) : base(id, name)
        {
            
        }

        
    }

}
