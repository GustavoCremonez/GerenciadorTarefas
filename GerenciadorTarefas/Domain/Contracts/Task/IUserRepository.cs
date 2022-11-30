using GerenciadorTarefas.Data.Models;

namespace GerenciadorTarefas.Domain.Contracts.Task
{
    public interface IUserRepository
    {
        UserModel? GetUserById(long id);

        UserModel? GetUserByEmail(string email);

        bool SaveUser(UserModel user);
    }
}
