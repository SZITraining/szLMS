using System.Collections.Generic;
using sziServices.Models;

namespace sziServices.Repositories
{
    public interface IUsersRepository
    {
        List<User> GetAllUsers();
    }

    public class UsersRepository : IUsersRepository
    {
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>()
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

            return users;
        }
    }
}