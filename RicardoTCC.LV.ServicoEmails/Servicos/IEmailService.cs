using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.ServicoEmails.Servicos
{
    public interface IEmailService
    {
        void Envia(string para, string email, string remetente, string corpo);
    }
}
