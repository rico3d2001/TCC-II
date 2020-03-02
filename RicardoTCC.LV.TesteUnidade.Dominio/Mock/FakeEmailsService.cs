using RicardoTCC.LV.ServicoEmails.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.TesteUnidade.Dominio.Mock
{
    public class FakeEmailsService : IEmailService
    {
        public void Envia(string para, string email, string remetente, string corpo)
        {
            throw new NotImplementedException();
        }
    }
}
