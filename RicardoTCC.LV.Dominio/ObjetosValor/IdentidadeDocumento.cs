using RicardoTCC.LV.Dominio.Servico;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class IdentidadeDocumento
    {
        public IdentidadeDocumento(int sequencial, Area area)
        {
            Sequencial = sequencial;
            Area = area;
        }

        public int Sequencial { get; private set; }

        public Area Area { get; private set; }



    }
}
