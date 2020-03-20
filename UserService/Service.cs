using System;
using UserRepository.Models;
using UserRepository;

namespace UserService
{
    static public class Service
    {
        private UserRepository.Repository Repository;

        static public User CreateUser(string FirstName, string LastName, string Email, string Password)
        {
            var User = Repository.CreateUser(FirstName, LastName, Email, Password);

            return User;
        }
    }
}
