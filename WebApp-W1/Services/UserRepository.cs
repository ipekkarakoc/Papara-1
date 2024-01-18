using WebApp_W1.Models;

namespace WebApp_W1.Services
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> Users = new();

        public UserRepository()
        {
            if (Users.Count == 0)
            {
                Users.Add(new User { Id = 1, Name = "İpek", Surname = "Karakoç", Age = 24 });
                Users.Add(new User { Id = 2, Name = "Ali", Surname = "Korkmaz", Age = 48 });
                Users.Add(new User { Id = 3, Name = "Enver", Surname = "Yılmaz", Age = 30 });
                Users.Add(new User { Id = 4, Name = "İrem", Surname = "Aydın", Age = 18 });
            }
        }
        public User Add(User user)
        {
            Users.Add(user);
            return user;
        }

        public void Delete(int id)
        {
            var userToDeleteIndex = Users.FindIndex(u => u.Id == id);
            Users.RemoveAt(userToDeleteIndex);
        }

        public User GetById(int id)
        {
            return Users.FirstOrDefault(u => u.Id == id);
        }

        public List<User> GetAll()
        {
            return Users;
        }

        public void Update(User user)
        {
            var userToUpdateIndex = Users.FindIndex(u => u.Id == user.Id);
            
            if (userToUpdateIndex != null) 
            { 
                Users[userToUpdateIndex].Name = user.Name;
                Users[userToUpdateIndex].Surname = user.Surname;
                Users[userToUpdateIndex].Age = user.Age;
            }
        }
    }
}
