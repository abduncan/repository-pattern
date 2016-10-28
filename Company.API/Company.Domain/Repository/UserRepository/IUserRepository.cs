using Company.Domain.Repository.GenericRepository;

namespace Company.Domain.Repository.UserRepository
{
    public interface IUserRepository
    {
        User GetUserByEmail(string email);
    }
}