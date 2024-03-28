﻿using UserInsuranceApp.Server.Core.Models;

namespace UserInsuranceApp.Server.Core.Interfaces
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetUsers();
        public Task<User> GetUser(int id);
        public Task AddUser(User user);
        public Task UpdateUser(User user);
        public Task DeleteUser(int id);
    }

}
