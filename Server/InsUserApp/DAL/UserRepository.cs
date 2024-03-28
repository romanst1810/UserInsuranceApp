using InsUserApp.Core.Interfaces;
using InsUserApp.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace InsUserApp.DAL
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUser(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
