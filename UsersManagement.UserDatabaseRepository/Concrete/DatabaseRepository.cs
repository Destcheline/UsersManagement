using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UsersManagement.Domain.Abstract;
using UsersManagement.Domain.Models;

namespace UsersManagement.UserDatabaseRepository.Concrete
{
    public class DatabaseRepository : IUserRepository
    {
        public User Create(User input)
        {
            using (var userDbContext = new UserDbContext())
            {
                userDbContext.Users.Add(input);
                userDbContext.SaveChanges();
                return input;
            }
        }

        public void Delete(User input)
        {
            using (var userDbContext = new UserDbContext())
            {
                userDbContext.Users.Remove(input);
                userDbContext.SaveChanges();
            }
        }

        public List<User> GetAll()
        {
            using (var userDbContext = new UserDbContext())
            {
                return userDbContext.Users.ToList();
            }
        }

        public User GetById(Guid id)
        {
            using (var userDbContext = new UserDbContext())
            {
                return userDbContext.Users.Find(id);
            }
        }

        public User Update(User input)
        {
            using (var userDbContext = new UserDbContext())
            {
                userDbContext.Users.Update(input);
                userDbContext.SaveChanges();
                return input;
            }
        }
    }
}
