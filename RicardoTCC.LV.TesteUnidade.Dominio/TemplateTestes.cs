using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RicardoTCC.LV.Dominio.Entitades;
using RicardoTCC.LV.Dominio.ObjetosValor;
using RicardoTCC.LV.Dominio.ObjetosValor.Enumerados;
using RicardoTCC.LV.Dominio.Servico;

namespace RicardoTCC.LV.TesteUnidade.Dominio
{
    [TestClass]
    public class TemplateTestes
    {
        [TestMethod]
        public void MontagemOpcaoParaEscolha_Assertivo()
        {
            //MontaOpçãoEscolha
            List<Topico> topicosCheckList1 = new List<Topico>
            {
                new Topico(new IdTopico(Guid.NewGuid().ToString()),
                new Ordenador(1),"Formato no padrao do projeto"),

                 new Topico(new IdTopico(Guid.NewGuid().ToString()),
                 new Ordenador(2),"Layers do formato adequado"),

                 new Topico(new IdTopico(Guid.NewGuid().ToString()),
                 new Ordenador(3),"Escala do formato adequada")
            };

            List<Topico> topicosCheckList2 = new List<Topico>
            {
                 new Topico(new IdTopico(Guid.NewGuid().ToString()),
                 new Ordenador(1),"Título na legenda adequado"),

                 new Topico(new IdTopico(Guid.NewGuid().ToString()),
                 new Ordenador(2), "Numero na legenda adequado")
            };

            TipoDocumento tipoDocumento = new TipoDocumento("MC", "Formato de desenho");

            List<CheckList> checkLists = new List<CheckList>
            {
                new CheckList(new Ordenador(1), new Descricao("Formato"), topicosCheckList1),
                new CheckList(new Ordenador(2), new Descricao("Legenda"), topicosCheckList2)
            };

            ColunaTipicaRevisao colunaTipica = new ColunaTipicaRevisao(checkLists);



            List<TabelaRevisao> tabelas = new List<TabelaRevisao>
            {
                new TabelaRevisao(new Versao(0), new Ordenador(2),"Padrao Desenho 2", tipoDocumento, colunaTipica),
                new TabelaRevisao(new Versao(0), new Ordenador(2),"Padrao Desenho 2", tipoDocumento, colunaTipica)
            };

         


            //MontaItemVerficação

            var topicoVerificado = tabelas.First()
                .ColunaTipica
                .CheckLists.First()
                .Topicos.First();


            //Execução
            ItemVerificacao itemVerificar = new ItemVerificacao(topicoVerificado.IdTopico,
                new Verificador("Ricardo", "RRP55"), Status.X);



            string teste = itemVerificar.ToString();

            //Verificação

            Assert.AreEqual(itemVerificar.ToString(), $"{topicoVerificado.IdTopico.Id}: Errado");

            itemVerificar.ModificaStatusVerificacao(Status.V);

            Assert.AreEqual(itemVerificar.ToString(), $"{topicoVerificado.IdTopico.Id}: Verificado");

        }

        [TestMethod]
        public void InsercaoCopiaVerificacao_Acerto()
        {
            IdentidadeDocumento numeroFornecedor =
                new IdentidadeDocumento(new NumeracaoFornecedor(),
                    "1000",
                    new TipoDocumento("D04", "Detalhamento Mecanica"),
                    new Area("001", null, new OrdemServico("002", new Projeto("9999"))),
                    new Disciplina("Mecânica", "MEC"));

            IdentidadeDocumento numeroCliente =
                 new IdentidadeDocumento(new PlantaANumeracao(),
                    "1000",
                    new TipoDocumento("D04", "Detalhamento Mecanica"),
                    new Area("001", null, new OrdemServico("002", new Projeto("9999"))),
                    new Disciplina("Mecânica", "MEC"));

            string numForn = numeroFornecedor.Numero;
            string numCli = numeroCliente.Numero;

            CopiaVerificacao copiaVerificacao = new CopiaVerificacao(numForn, numCli);

            

            Assert.IsTrue(numeroFornecedor.Valid);
            Assert.IsTrue(numeroCliente.Valid);



            Assert.AreEqual("9999-002-001-D04MEC-1000", numForn);
            Assert.AreEqual("CLI-9999-002-001-D04MEC-1000", numCli);

        }

        [TestMethod]
        public void InsercaoCopiaVerificacao_Erros()
        {
            IdentidadeDocumento numeroFornecedor =
                new IdentidadeDocumento(new NumeracaoFornecedor(),
                    "10005",
                    new TipoDocumento("D04", "Detalhamento Mecanica"),
                    new Area("001", null, new OrdemServico("002", new Projeto("9999"))),
                    new Disciplina("Mecânica", "MEC"));

            IdentidadeDocumento numeroCliente =
                 new IdentidadeDocumento(new PlantaANumeracao(),
                    "10006",
                    new TipoDocumento("D04", "Detalhamento Mecanica"),
                    new Area("001", null, new OrdemServico("002", new Projeto("9999"))),
                    new Disciplina("Mecânica", "MEC"));

            string numForn = numeroFornecedor.Numero;
            string numCli = numeroCliente.Numero;

            CopiaVerificacao copiaVerificacao = new CopiaVerificacao(numForn, numCli);


            Assert.IsFalse(numeroFornecedor.Valid);
            Assert.IsFalse(numeroCliente.Valid);

            //"Sequencial de Numero do documento"
            //"Deve ter no mínimo 4 digitos"

            var notificacao = numeroFornecedor.Notifications.ToList()
                .FirstOrDefault(x => 
                x.Message == "Deve ter no máximo 4 digitos"
                && x.Property == "Sequencial de Numero do documento");

            Assert.IsNotNull(notificacao);

         



            Assert.AreEqual("9999-002-001-D04MEC-10005", numForn);
            Assert.AreEqual("CLI-9999-002-001-D04MEC-10006", numCli);

        }


        [TestMethod]
        public void InsercaoItemVerificacao_Erro()
        {
            Revisao revisao = new Revisao(new Ordenador(1), new IndiceRevisao("0"));

            revisao.AdicionarItem(
                new ItemVerificacao(new IdTopico("A123"), new Verificador("Ricardo", "RRP55"), Status.X));

            revisao.AdicionarItem(
                new ItemVerificacao(new IdTopico("A124"), new Verificador("Ricardo", "RRP55"), Status.X));

            revisao.AdicionarItem(
                new ItemVerificacao(new IdTopico("A125"), new Verificador("João", "JDD35"), Status.X));

            revisao.AdicionarItem(
                new ItemVerificacao(new IdTopico("A126"), new Verificador("João", "JDD35"), Status.X));

            //Erro aqui pois não pode mais inserir revisao
            revisao.AdicionarItem(
                new ItemVerificacao(new IdTopico("A127"), new Verificador("Ricardo", "RRP55"), Status.X));

            var testedebug = revisao.Notifications;

            var msg = revisao.Notifications.First().Property
                     + " - " + revisao.Notifications.First().Message;
            //teste
            Assert.AreEqual("Inserção de item de revisão - Outro verificador já iniciou.", msg);

        }
    }
}
