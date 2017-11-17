using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class InvalidPasswordException : Exception
    {
        public InvalidPasswordException() : base("Password can not be generated with those paramteres!")
        {
            //Empty body
        }
    }
}
