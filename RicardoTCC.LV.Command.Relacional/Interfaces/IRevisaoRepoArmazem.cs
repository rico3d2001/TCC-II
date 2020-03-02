using RicardoTCC.LV.Dominio.Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Command.Relacional.Interfaces
{
    public interface IRevisaoRepoArmazem
    {
        bool SalvaRevisao(Revisao revisao);

        Revisao ObtemRevisao(string indice, string idCopiaRevisao);
    }


}
