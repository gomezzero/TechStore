using TechStore.DTOs;
using TechStore.Models;

namespace TechStore.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetCustomerById(int id);
        Task AddCustomer(ClientDTO customerDto);
        Task UpdateCustomer(int id, ClientDTO customerDto);
    }
}