using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class Verificador:Notifiable
    {
        public Verificador(string nome, string sigla, string email)
        {
            Nome = new Nome(nome,"Verificador",5,100);
            Sigla = new Sigla(sigla,"Verificador",5);
            Email = new Email(email);
        }

        public Nome Nome { get; private set; }
        public Sigla Sigla { get; private set; }
        public Email Email { get; set; }

        public override bool Equals(object verificador)
        {
            var v = verificador as Verificador;
           return Sigla.Equals(v.Sigla) ? true : false;
        }
    }
}
