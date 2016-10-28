using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Domain.Repository.GenericRepository;

namespace Company.Domain.Repository.UserRepository
{
    public class UserRepository : IUserRepository
    {
        // Variable to hold our injected db context.
        private readonly RepositoryModel _dbContext;

        public UserRepository(RepositoryModel dbContext)
        {
            // Store our injected db context.
            _dbContext = dbContext;
        }

        public User GetUserByEmail(string email)
        {
            // Use the injected entity framework db context
            // to query the database.
            return _dbContext.Users.SingleOrDefault(u => u.Email == email);
        }
    }
}
