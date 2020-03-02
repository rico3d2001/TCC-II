using Flunt.Validations;
using RicardoTCC.LV.Dominio.Numeracao;

namespace RicardoTCC.LV.Dominio.ObjetosValor
{
    public class IdentidadeDocumento : ObjetoValor
    {
        INumeracao _numeracao;
        Sequencial _sequencial;
        TipoDocumento _tipoDocumento;
        Disciplina _disciplina;
        string _numeroDocumento;
        Area _area;


        public IdentidadeDocumento(INumeracao numeracao, string sequencial,
            TipoDocumento tipoDocumento, Area area, Disciplina disciplina)
        {
            _numeracao = numeracao;
            _tipoDocumento = tipoDocumento;
            _sequencial = numeracao.Sequenciar(sequencial);
            _area = area;
            _disciplina = disciplina;

            _numeroDocumento = _numeracao.Numerar(_tipoDocumento, _area, _disciplina, _sequencial);

            AddNotifications(new Contract().Requires());

            AddNotifications(_sequencial, _tipoDocumento, _area, _disciplina);

          
        }

        public string Numero { get => _numeroDocumento; }
        //public int Sequencial { get; private set; }

        //public Area Area { get; private set; }

    }
}
