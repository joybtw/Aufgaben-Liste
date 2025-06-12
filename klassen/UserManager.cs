using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenListe_Forms.Klassen
{
    public class UserManager
    {
        private List<User> _users;
        public UserManager()
        {
            _users = new List<User>();
            // Temp benutzer
            _users.Add(new User(Guid.NewGuid(), "test", "test", "test"));
        }

        public User FindUser(string username, string password)
        {
            foreach (User user in _users)
            {
                if (user.Benutzername.ToLower() == username.ToLower() && user.Passwort == password)
                {
                    return user;
                }
            }
            return null;
        }

        public bool BenutzernameFrei(string username) {
            foreach (User user in _users)
            {
                if (user.Benutzername.ToLower() == username.ToLower())
                {
                    return false;
                }
            }
            return true;
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }
    }
}
