using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenListe_Forms.Klassen
{
    public class User
    {
        public Guid Id;
        public string Name;
        public string Benutzername;
        public string Passwort;

        public User(Guid id, string name, string benutzername, string passwort)
        {
            Id = id;
            Name = name;
            Benutzername = benutzername;
            Passwort = passwort;
        }
    }
}
