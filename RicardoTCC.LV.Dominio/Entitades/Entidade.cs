using Flunt.Notifications;
using System;

namespace RicardoTCC.LV.Dominio.Entitades
{
    public class Entidade:Notifiable
    {
        
        public Entidade()
        {
            GUID = Guid.NewGuid().ToString();
        }

        public string GUID { get; set; }
    }
}
