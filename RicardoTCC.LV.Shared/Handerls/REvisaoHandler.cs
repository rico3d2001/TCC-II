using Flunt.Notifications;
using RicardoTCC.LV.Command.Relacional.Interfaces;
using RicardoTCC.LV.Dominio.Commands;
using RicardoTCC.LV.Dominio.Entitades;
using RicardoTCC.LV.Dominio.ObjetosValor;
using RicardoTCC.LV.ServicoEmails.Servicos;
using RicardoTCC.LV.Shared.Commands;
using System.Collections.Generic;

namespace RicardoTCC.LV.Shared.Handerls
{
    public class RevisaoHandler : Notifiable, IHandler<CriaRevisaoComando>
    {

        IRevisaoRepoArmazem _repositorio;
        IEmailService _emails;

        public RevisaoHandler(IRevisaoRepoArmazem repositorio, IEmailService emails)
        {
            _repositorio = repositorio;
            _emails = emails;
        }

        public ICommandResult Handle(CriaRevisaoComando command)
        {
            //Validação rápida para velocidade
            command.Validate();
            if (command.Invalid)
            {
                AddNotifications(command);
                return new CommandResult(false, "Não foi possível criar a revisão.");
                //if (command.Invalid)
                //return new CommandResult(false, Notifications.ToList().First().Message);
            }

            //Gerar VOs --- Usar Repository
            var ordenadorRevisao = new Ordenador(command.OrdenadorRevisao);
            var indiceRevisao = new IndiceRevisao(command.IndiceRevisao);

            //Verificadores
            var primeiroVerificador = new Verificador(command.NomePrimeiroVerificador,
                command.SiglaPrimeiroVerificador, command.EmailPrimeiroVerificador);
            var segundoVerificador = new Verificador(command.NomeSegundoVerificador,
               command.SiglaSegundoVerificador, command.EmailSegundoVerificador);

            //Gerar  Entidades
            var revisao = new Revisao(primeiroVerificador, segundoVerificador, indiceRevisao);

            //Agrupar Validações
            AddNotifications(ordenadorRevisao, indiceRevisao, revisao);

            //Checar Notificações
            if (Invalid)
            {
                return new CommandResult(false, "Não foi possível criar sua revisão");
            }

            //Salvar Informações
            var salvo = _repositorio.SalvaRevisao(revisao);

            //Retornar Informações
            if (salvo)
            {
                _emails.Envia(primeiroVerificador.Nome.Texto, primeiroVerificador.Email.Destinatario,
                 primeiroVerificador.Nome.Texto, "Liberado para verificação");
            }

            return new CommandResult(true, "Revisão criada com sucesso");
        }
    }
}
