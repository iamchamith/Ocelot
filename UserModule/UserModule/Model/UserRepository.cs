using System.Collections.Generic;
using System.Linq;
namespace UserModule.Model
{
    public class UserRepository
    {
        public static List<User> Users => new List<User>() {
            new User(1,"Chamith","iamchamith@gmail.com","Ganemulla"),
               new User(2,"Kasun","kasun@gmail.com","Ragama"),
                  new User(3,"Nuwan","nuwan@gmail.com","Colombo")
                     
        };

        public List<User> Get() {

            return Users;
        }
        public User Get(int id) {
            return Users.Single(p => p.Id == id);
        }
        public void AddUser(User user)
        {
            Users.Add(user);
        }
        public void UpdateUser(User user) {
            Get(user.Id).Update(user.Name, user.Address);
        }
        public void Deleteuser(int id) {
            Users.RemoveAll(p => p.Id == id);
        }
    }
}
