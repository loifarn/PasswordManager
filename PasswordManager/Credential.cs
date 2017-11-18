using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    [Serializable]
    class Credential
    {
        //Fields and properties
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }

        //Constructor(s)
        public Credential(string name, string username, string password, string email)
        {
            this.Name = name;
            this.Username = username;
            this.Password = password;
            this.Email = email;
        }
        public Credential(string name, string username, string password, string email, string comment)
        {
            this.Name = name;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Comment = comment;
        }

        //Methods
        public string GetCredential()
        {
            return $"{Name}|{Username}|{Password}|{Email}|{Comment}";
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
