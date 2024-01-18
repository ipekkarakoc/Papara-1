using WebApp_W1.Models;

namespace WebApp_W1.Services
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(int id);
        void Update(User user);
        void Delete(int id);
    }
}
