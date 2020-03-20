using System;
using UserRepository.Models;

namespace UserRepository
{
     public class Repository
    {
         public User CreateUser(string FirstName, string LastName, string Email, string Password)
        {
            User User = new User();

            User.Fname = FirstName;
            User.Lname = LastName;
            User.Email = Email;
            User.Password = Password;

            return User;
        }
    }
}
