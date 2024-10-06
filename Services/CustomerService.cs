using Microsoft.EntityFrameworkCore;
using TechStore.Data;
using TechStore.DTOs;
using TechStore.Models;
using TechStore.Repositories;

namespace TechStore.Services
{
    public class CustomerService : ICustomerRepository
    {

        private readonly MyDbContext _context;

        public CustomerService(MyDbContext context)
        {
            _context = context;
        }

        // Consultar clientes
        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _context.Set<Customer>().ToListAsync();
        }

        // Consultar un cliente por id
        public async Task<Customer> GetCustomerById(int id)
        {
            return await _context.Set<Customer>().FindAsync(id);
        }

        // Registrar cliente
        public async Task AddCustomer(ClientDTO customerDto)
        {
            var customer = new Customer(
                customerDto.Name,
                customerDto.Address,
                customerDto.Phone,
                customerDto.Email);

            await _context.Set<Customer>().AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        // Actualizar cliente
        public async Task UpdateCustomer(int id, ClientDTO customerDto)
        {
            var customer = await GetCustomerById(id);

            if (customer != null)
            {
                customer.Name = customerDto.Name;
                customer.Address = customerDto.Address;
                customer.Phone = customerDto.Phone;
                customer.Email = customerDto.Email;

                _context.Set<Customer>().Update(customer);
                await _context.SaveChangesAsync();
            }
        }
    }
}