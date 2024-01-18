using System.ComponentModel.DataAnnotations;
using WebApp_W1.Models;

namespace WebApp_W1.Services
{

    public class UserService(IUserRepository userRepository) : IUserService
    {
        private readonly IUserRepository _userRepository = userRepository;

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void Add(User user)
        {
            ValidateUser(user);
            _userRepository.Add(user);
        }
        public void Update(User user)
        {
            ValidateUser(user);
            _userRepository.Update(user);
        }
        private void ValidateUser(User user)
        {
            var validationContext = new ValidationContext(user, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(user, validationContext, validationResults, validateAllProperties: true))
            {
                var validationErrors = validationResults.Select(r => r.ErrorMessage);
                throw new ValidationException($"User validation failed: {string.Join(", ", validationErrors)}");
            }
        }
        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }
    }
}
