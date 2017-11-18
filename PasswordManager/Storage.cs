using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    [Serializable]
    class Storage
    {
        //Fields and properties
        public BindingList<Credential> Credentials { get; set; }

        //Constructor
        public Storage()
        {
            Credentials = new BindingList<Credential>();
        }

        //Methods
        public Credential GetCredential(string name)
        {
            foreach(Credential c in Credentials)
            {
                if (c.Name == name) { return c; }
            }
            return null;
        }
        public bool AddCredential(Credential c)
        {
            if (c.Name is null || c.Name.Equals(""))
            {
                throw new InvalidCredentialException();
            }

            if (this.GetCredential(c.Name) == null)
            {
                Credentials.Add(c);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveCredential(Credential c)
        {
            if (this.GetCredential(c.Name) == null)
            {
                Credentials.Remove(c);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
