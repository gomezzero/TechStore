using Microsoft.EntityFrameworkCore;
using TechStore.Data;
using TechStore.Models;
using TechStore.Repositories;

namespace TechStore.Services
{
    public class UserServices : IUserRepository
    {

        private readonly MyDbContext _context;

        public UserServices(MyDbContext context)
        {
            _context = context;
        }

        public async Task Add(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "El usuario no puede ser nulo");
            }

            try
            {
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbExi)
            {
                throw new Exception("Error al agregar el usuario a la base de datos", dbExi);
            }
            catch (Exception exi)
            {
                throw new Exception("ocurrio un error a la hora de agregar el usuario", exi);
            }
        }

        public async Task<bool> CheckExistence(int id)
        {
            try
            {
                return await _context.Users.AnyAsync(u => u.Id == id);
            }
            catch (Exception exi)
            {
                throw new Exception("ocurrio un error a la hora de busacar el usuario", exi);
            }
        }

        public async Task Delete(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException(nameof(user), "El usuario no puede ser nulo.");
            }
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetById(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User?> GetByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }


        public async Task Update(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "el usuario no puede ser nulo");
            }

            try
            {
                _context.Entry(user).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbExi)
            {

                throw new Exception("Error al actualizar el usuario en la base de datos", dbExi);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al actualizar el Usuario.", ex);
            }
        }

        public async Task<IEnumerable<User>> GetByKeyword(string keyword)
        {
            if(string.IsNullOrWhiteSpace(keyword))
            {
                return await GetAll();
            }

            return await _context.Users.Where(u => u.Username.Contains(keyword)).ToListAsync();
        }
    }
}