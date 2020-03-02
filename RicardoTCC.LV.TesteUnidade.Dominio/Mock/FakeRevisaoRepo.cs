using RicardoTCC.LV.Command.Relacional.Interfaces;
using RicardoTCC.LV.Dominio.Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.TesteUnidade.Dominio.Mock
{
    public class FakeRevisaoRepo : IRevisaoRepoArmazem
    {
        public Revisao ObtemRevisao(string indice, string idCopiaRevisao)
        {
            throw new NotImplementedException();
        }

        public bool SalvaRevisao(Revisao revisao)
        {
            return revisao == null ? false : true;
        }
    }
}
