using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Nome : ObjetoValor
    {
        public Nome(string texto, string origem, int tamanhoMin, int tamanhoMax)
        {
            Texto = texto;
            AddNotifications(new Contract()
                  .HasMinLen(Texto, tamanhoMin, 
                  $"O texto de {origem}", $"Deve ter no mínimo {tamanhoMin} caracteres")
                  .HasMaxLen(Texto, tamanhoMax, 
                  $"O texto de {origem}", $"Deve ter no máximo {tamanhoMax} caracteres"));
        }

        public string Texto { get; private set; }

        public override bool Equals(object nome)
        {
            var n = nome as Nome;
            return n.Texto == Texto ? true : false;
        }
    }
}
