using Flunt.Notifications;
using System;

namespace RicardoTCC.LV.Dominio.Entitades
{
    public class Entidade:Notifiable
    {
        
        public Entidade()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
