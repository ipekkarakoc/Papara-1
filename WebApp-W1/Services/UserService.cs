using WebApp_W1.Models;

namespace WebApp_W1.Services
{
    //ddi ?
    public class UserService(IUserRepository userRepository) : IUserService
    {
        private readonly IUserRepository _userRepository = userRepository;
    
        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }
    }
}
