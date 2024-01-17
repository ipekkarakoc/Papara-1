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
                Users.Add(new User { Id = 2, Name = "", Surname = "", Age = 100 });
                Users.Add(new User { Id = 3, Name = "", Surname = "", Age = 100 });
                Users.Add(new User { Id = 4, Name = "", Surname = "", Age = 100 });
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

        public List<User> GetAll()
        {
            return Users;
        }

        public void Update(User user)
        {
            var userToUpdateIndex = Users.FindIndex(u => u.Id == user.Id);
            //search
            Users[userToUpdateIndex].Name = user.Name;
            Users[userToUpdateIndex].Surname = user.Surname;
            Users[userToUpdateIndex].Age = user.Age;

        }
    }
}
