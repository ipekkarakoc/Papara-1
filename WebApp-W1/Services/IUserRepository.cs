using WebApp_W1.Models;

namespace WebApp_W1.Services
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User Add(User user);
        void Update(User user);
        void Delete(int id);
    }
}
