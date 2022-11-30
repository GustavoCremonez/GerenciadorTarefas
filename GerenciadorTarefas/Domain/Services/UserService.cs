using GerenciadorTarefas.Data.Models;
using GerenciadorTarefas.Domain.Contracts.Task;

namespace GerenciadorTarefas.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserModel? GetUserById(long id)
        {
            var hasUser = _userRepository.GetUserById(id);

            if (hasUser != null)
            {
                return hasUser;
            }
            return null;
        }

        public UserModel? GetUserByEmail(string email)
        {
            var hasUser = _userRepository.GetUserByEmail(email);

            if (hasUser != null)
            {
                return hasUser;
            }
            return null;
        }

        public bool SaveUser(UserModel user)
        {
            var hasUser = GetUserByEmail(user.Email);

            if (hasUser != null)
            {
                return false;
            }

            return _userRepository.SaveUser(user);
        }
    }
}
