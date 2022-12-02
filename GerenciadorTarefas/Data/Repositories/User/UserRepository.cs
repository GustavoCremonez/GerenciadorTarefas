using GerenciadorTarefas.Data.Models;
using GerenciadorTarefas.Domain.Contracts.User;

namespace GerenciadorTarefas.Data.Repositories.User
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public UserModel? GetUserById(long id)
        {
            var hasUser = _context.Users.Where(x => x.Id == id).FirstOrDefault();

            if (hasUser != null)
            {
                return hasUser;
            }
            return null;
        }

        public UserModel? GetUserByEmail(string email)
        {
            var hasUser = _context.Users.Where(x => x.Email == email).FirstOrDefault();

            if (hasUser != null)
            {
                return hasUser;
            }
            return null;
        }

        public bool SaveUser(UserModel user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return true;
        }
    }
}
