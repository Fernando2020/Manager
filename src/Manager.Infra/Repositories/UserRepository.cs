using Manager.Domain.Entities;
using Manager.Infra.Context;
using Manager.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manager.Infra.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly ManagerContext _context;

        public UserRepository(ManagerContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetByEmail(string email)
        {
            var obj = await _context.Users
                            .AsNoTracking()
                            .Where(x => x.Email.ToLower() == email.ToLower())
                            .FirstOrDefaultAsync();

            return obj;
        }

        public async Task<List<User>> SearchByEmail(string email)
        {
            var users = await _context.Users
                            .AsNoTracking()
                            .Where(x => x.Email.ToLower().Contains(email.ToLower()))
                            .ToListAsync();

            return users;
        }

        public async Task<List<User>> SearchByName(string name)
        {
            var users = await _context.Users
                            .AsNoTracking()
                            .Where(x => x.Name.ToLower().Contains(name.ToLower()))
                            .ToListAsync();

            return users;
        }
    }
}
