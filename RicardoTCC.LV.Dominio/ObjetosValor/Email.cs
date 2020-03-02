using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Email:ObjetoValor
    {
        public Email(string destinatario)
        {
            Destinatario = destinatario;
            AddNotifications(new Contract()
                 .Requires()
                 .Contains(Destinatario, "@", "Email", "Digite um email válido")
                 .Contains(Destinatario, ".", "Email", "Digite um email válido")
                 .HasMinLen(Destinatario, 9, "Email", "Digite um email válido"));
                
        }

        public string Destinatario { get; private set; }
    }
}
