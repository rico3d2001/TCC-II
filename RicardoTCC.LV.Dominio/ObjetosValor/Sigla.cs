using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Sigla:ObjetoValor
    {
        public Sigla(string texto, string origem, int tamanho)
        {
            Texto = texto;
            AddNotifications(new Contract()
                  .Requires()
                  .HasLen(Texto, tamanho, $"Sigla de {origem}", $"Deve ter {tamanho} caracteres"));
        }

        public string Texto { get; private set; }

        public override bool Equals(object sigla)
        {
            var s = sigla as Sigla;
            return s.Texto == Texto ? true : false;
        }
    }
}
