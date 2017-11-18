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
        private BindingList<Credential> _credentialList;
        public BindingList<Credential> GetCredentialList
        {
            get{ return _credentialList; }
        }

        //Constructor
        public Storage()
        {
            _credentialList = new BindingList<Credential>();
        }

        //Methods
        public Credential GetCredential(string name)
        {
            foreach(Credential c in _credentialList)
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
                GetCredentialList.Add(c);
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
                GetCredentialList.Remove(c);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
