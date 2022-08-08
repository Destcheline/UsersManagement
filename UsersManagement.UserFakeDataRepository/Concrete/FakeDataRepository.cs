using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UsersManagement.Domain.Abstract;
using UsersManagement.Domain.Models;
using UsersManagement.UserFakeDataRepository.Data;

namespace UsersManagement.UserFakeDataRepository
{
    public class FakeDataRepository : IUserRepository
    {
        private IMapper _mapper;
        List<User> _users = FakeData.GetUsers(5);
        public FakeDataRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public User Create(User input)
        {
            _users.Add(input);
            return input;
        }

        public void Delete(User input)
        {
            _users.Remove(input);
        }

        public User GetById(Guid id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);
            return user;
        }

        public List<User> GetAll()
        {
            return _users;
        }

        public User Update(User input)
        {
            _mapper.Map(input, GetById(input.Id));
            return input;
        }
    }
}
