using RicardoTCC.LV.Dominio.ObjetosValor;
using RicardoTCC.LV.Dominio.ObjetosValor.Enumerados;

namespace RicardoTCC.LV.Dominio.Entitades
{
    public class ItemVerificacao : Entidade
    {
        public ItemVerificacao(IdTopico idTopico, Verificador verificador, Status status)
        {
            IdTopico = idTopico;
            Verificador = verificador;
            Hora = new Hora();
            Status = status;

            AddNotifications(idTopico, verificador, status);
        }

        public Hora Hora { get; private set; }
        public IdTopico IdTopico { get; private set; }

        public Verificador Verificador { get; private set; }
        public Status Status { get; private set; }

        public void ModificaStatusVerificacao(Status status)
        {
            Status = status;
        }

        public override bool Equals(object obj)
        {
            var i = obj as IdTopico;
            return IdTopico.Equals(i);
        }

        public override string ToString()
        {
            return IdTopico.GUID + ": " + Status.Name;
        }

    }
}
