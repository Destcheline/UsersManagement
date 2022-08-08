using System;
using System.Collections.Generic;
using System.Text;
using UsersManagement.Domain.Models;

namespace UsersManagement.Domain.Abstract
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User GetById(Guid id);
        User Create(User input);
        User Update(User input);
        void Delete(User input);

    }
}
