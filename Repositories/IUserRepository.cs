using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.Models;

namespace TechStore.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User?> GetById(int id);
        Task<User?> GetByEmail(string email);
        Task<IEnumerable<User>> GetByKeyword(string keyword);
        Task Add(User user);
        Task Update(User user);
        Task Delete(int id);
        Task<bool> CheckExistence(int id);
    }
}