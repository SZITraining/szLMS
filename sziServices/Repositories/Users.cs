using System.Collections.Generic;
using System.Threading.Tasks;
using sziServices.Models;

namespace sziServices.Repositories
{
    public interface IUsersRepository
    {
        Task<List<User>> GetAllUsers();

        Task<User> GetOneUser(int id);
    }

    public class UsersRepository : IUsersRepository
    {
        private readonly List<User> Users = new List<User>()
                    {
                        new User()
                        {
                            id = 1,
                            Email = "Keith@webizly.com"
                        },
                        new User()
                        {
                           id = 2,
                           Email = "steve@steve.com"
                        }
                    };

        public async Task<List<User>> GetAllUsers()
        {
            List<User> users = await Task.FromResult<List<User>>(Users);

            return users;
        }

        public async Task<User> GetOneUser(int id)
        {
            User user = await Task.FromResult<User>(Users[id]);

            return user;
        }
    }
}