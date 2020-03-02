using Flunt.Notifications;

namespace RicardoTCC.LV.Dominio.Commands
{
    public class CriaRevisaoComando: Notifiable, ICommand
    {
       
       
        public int OrdenadorRevisao { get; set; }
        public string IndiceRevisao { get; set; }

        //Dois Verificadores
        public string NomePrimeiroVerificador { get; set; }
        public string EmailPrimeiroVerificador { get; set; }
        public string SiglaPrimeiroVerificador { get; set; }

        public string NomeSegundoVerificador { get; set; }
        public string EmailSegundoVerificador { get; set; }
        public string SiglaSegundoVerificador { get; set; }

        public void Validate()
        {
            //AddNotifications(new Contract())
        }
    }
}
