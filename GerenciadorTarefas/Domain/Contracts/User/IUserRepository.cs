using GerenciadorTarefas.Data.Models;

namespace GerenciadorTarefas.Domain.Contracts.User
{
    public interface IUserRepository
    {
        UserModel? GetUserById(long id);

        UserModel? GetUserByEmail(string email);

        bool SaveUser(UserModel user);
    }
}
