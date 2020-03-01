using RicardoTCC.LV.Dominio.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.Servico
{
    public interface INumeracao
    {
        Sequencial Sequenciar(string sequencial); 
        string Numerar(TipoDocumento tipo, Area area, Disciplina disciplina, Sequencial sequencial);

    }
}
