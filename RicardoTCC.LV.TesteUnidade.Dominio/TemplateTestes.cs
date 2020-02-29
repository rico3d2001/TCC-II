using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RicardoTCC.LV.Dominio.Entitades;
using RicardoTCC.LV.Dominio.ObjetosValor;
using RicardoTCC.LV.Dominio.ObjetosValor.Enumerados;

namespace RicardoTCC.LV.TesteUnidade.Dominio
{
    [TestClass]
    public class TemplateTestes
    {
        [TestMethod]
        public void MontagemOpcaoParaEscolha()
        {
            //MontaOpçãoEscolha
            List<Topico> topicosCheckList1 = new List<Topico>
            {
                new Topico(new Ordenador(1), "Formato no padrao do projeto"),
                 new Topico(new Ordenador(2), "Layers do formato adequado"),
                 new Topico(new Ordenador(3), "Escala do formato adequada")
            };
    
            List<Topico> topicosCheckList2 = new List<Topico>
            {
                 new Topico(new Ordenador(1), "Título na legenda adequado"),
                 new Topico(new Ordenador(2), "Numero na legenda adequado")
            };

            TipoDocumento tipoDocumento = new TipoDocumento("MC", "Formato de desenho");

            List<CheckList> checkLists = new List<CheckList>
            {
                new CheckList(new Ordenador(1), "Formato", topicosCheckList1),
                new CheckList(new Ordenador(2), "Legenda", topicosCheckList2)
            };

            ColunaTipicaRevisao colunaTipica = new ColunaTipicaRevisao(checkLists);

            

            List<TabelaRevisao> tabelas = new List<TabelaRevisao>
            {
                new TabelaRevisao(0, new Ordenador(2), "Padrao Desenho 2", tipoDocumento, colunaTipica),
                new TabelaRevisao(0, new Ordenador(2), "Padrao Desenho 2", tipoDocumento, colunaTipica)
            };

            List<Disciplina> disciplinas = new List<Disciplina>
            {
                new Disciplina("Mecânica1", "MC1", tabelas),
                new Disciplina("Mecânica2", "MC2", tabelas)
            };

          
            //MontaItemVerficação
            var topicoVerificado = disciplinas.First()
                .Tabelas.First()
                .ColunaTipica
                .CheckLists.First()
                .Topicos.First();

            

            ItemVerificado itemVerificar = new ItemVerificado(topicoVerificado);

            itemVerificar.StatusVerificacao = Status.X;

            string teste = itemVerificar.ToString();

            Assert.AreEqual(itemVerificar.ToString(), "Formato no padrao do projeto Errado");


        }
    }
}
