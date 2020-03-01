using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class IdTopico:ObjetoValor
    {
        public IdTopico(string id)
        {
            Id = id;
        }

        public string Id { get; private set; }

        public override bool Equals(object obj)
        {
            var i = obj as IdTopico;
            return i.Id == Id ? true : false;
        }
    }
}
