using Microsoft.VisualStudio.TestTools.UnitTesting;
using RicardoTCC.LV.Dominio.Commands;
using RicardoTCC.LV.Shared.Handerls;
using RicardoTCC.LV.TesteUnidade.Dominio.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.TesteUnidade.Dominio
{
    [TestClass]
    public class HandlerTestes
    {

        [TestMethod]
        public void RevisaoHandlerTeste_Acerta()
        {
            FakeRevisaoRepo revisaoRepo = new FakeRevisaoRepo();
            FakeEmailsService emailsService = new FakeEmailsService();

            RevisaoHandler handler = new RevisaoHandler(revisaoRepo, emailsService);

            var  command = new CriaRevisaoComando();


            command.OrdenadorRevisao = 1;
            command.IndiceRevisao = "0";

            command.EmailPrimeiroVerificador = "rico3d@live.com";
            command.NomePrimeiroVerificador = "Ricardo";
            command.SiglaPrimeiroVerificador = "RRP55";

            command.EmailSegundoVerificador = "joao@live.com";
            command.NomeSegundoVerificador = "João";
            command.SiglaSegundoVerificador = "JDD35";

            handler.Handle(command);

            Assert.AreEqual(true, command.Valid);



        }
    }
}
