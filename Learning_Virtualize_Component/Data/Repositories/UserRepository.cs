using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.Repositories
{
    public class UserRepository : Base.Repository<Models.User>, IUserRepository
    {
        internal UserRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public Models.User GetByUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return null;
            }

            var result =
                DbSet
                .Where(current => current.Username.ToLower() == username.ToLower())
                .FirstOrDefault();

            return result;
        }

        public async System.Threading.Tasks.Task<Models.User> GetByUsernameAsync(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return null;
            }

            var result =
                await DbSet
                .Where(current => current.Username.ToLower() == username.ToLower())
                .FirstOrDefaultAsync();

            return result;
        }

        public override async System.Threading.Tasks.Task<Models.User>
            GetByIdAsync(System.Guid id)
        {
            var user =
                await DbSet
                .Where(current => current.Id == id)
                .FirstOrDefaultAsync();

            return user;
        }
    }
}
