using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.Entitades
{
    public class IdTopico:Entidade
    {
        
        public override bool Equals(object obj)
        {
            var i = obj as IdTopico;
            return i.GUID == GUID ? true : false;
        }
    }
}
