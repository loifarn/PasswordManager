using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class InvalidCredentialException : Exception
    {
        public InvalidCredentialException() : base("Error creating credential\nPlease make sure at least name is filled in!")
        {
            //Empty body
        }
    }
}
