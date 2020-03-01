using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Sequencial : ObjetoValor
    {
        public Sequencial(string numero, string origem, int tamanhoMin, int tamanhoMax)
        {
        Numero = numero;
        AddNotifications(new Contract()
                  .Requires()
                  .HasMinLen(Numero, tamanhoMin, $"Sequencial de {origem}", $"Deve ter no mínimo {tamanhoMin} digitos")
                  .HasMaxLen(Numero, tamanhoMax, $"Sequencial de {origem}", $"Deve ter no máximo {tamanhoMax} digitos")
                  );
        }

        public string Numero { get; private set; }
    }
}
