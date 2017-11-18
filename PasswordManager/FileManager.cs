using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    class FileManager
    {
        public FileManager()
        {
            //Empty Constructor
        }

        public void SaveToFile(string file, BindingList<Credential> list)
        {
            try
            {
                using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, list);
                }
            }
            catch (SerializationException)
            {
                MessageBox.Show("Error loading file");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("No file selected");
            }
        }

        public BindingList<Credential> LoadFromFile(string file)
        {
            BindingList<Credential> list = new BindingList<Credential>();

            try
            {
                using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    list = (BindingList<Credential>)bf.Deserialize(fs);
                }
            }
            catch (SerializationException)
            {
                MessageBox.Show("Error loading file");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("No file selected");
            }
            return list;
        }
    }
}
