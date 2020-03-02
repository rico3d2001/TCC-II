using RicardoTCC.LV.Dominio.Commands;
using RicardoTCC.LV.Shared.Commands;

namespace RicardoTCC.LV.Shared.Handerls
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
