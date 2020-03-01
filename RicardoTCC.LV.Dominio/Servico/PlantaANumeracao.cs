using RicardoTCC.LV.Dominio.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.Servico
{
    public class PlantaANumeracao : INumeracao
    {
        public string Numerar(TipoDocumento tipo, Area area, Disciplina disciplina, Sequencial sequencial)
        {
            Sigla siglaProjeto = new Sigla(area.OrdemServico.Projeto.Sigla, "Projeto", 4);
            Sigla siglaArea = new Sigla(area.Sigla, "Area", 3);
            Sigla siglaOS = new Sigla(area.OrdemServico.Sigla, "Ordem de Serviço", 3);
            Sigla siglaTipo = new Sigla(tipo.Sigla, "Tipo de Documento", 3);
            Sequencial sequFornecedor = sequencial;
            Sigla siglaDisciplina = new Sigla(disciplina.Sigla, "Disciplina", 2);

            return $"CLI-{siglaProjeto.Texto}-{siglaOS.Texto}-{siglaArea.Texto}"
            + $"-{siglaTipo.Texto}{siglaDisciplina.Texto}-{sequFornecedor.Numero}";
        }

        public Sequencial Sequenciar(string sequencial)
        {
           
            return new Sequencial(sequencial, "Numero do documento", 4, 4);
        }
    }
}
