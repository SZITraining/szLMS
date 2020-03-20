using sziServices.Repositories;

namespace sziServices.Services
{
    public interface IUsersService : IUsersRepository { }

    public class UsersService : UsersRepository, IUsersService { }
}