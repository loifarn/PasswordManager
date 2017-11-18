using System;
using System.Collections.Generic;
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

        public void SaveToFile(string file, Storage storage)
        {
            try
            {
                using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, storage);
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

        public Storage LoadFromFile(string file)
        {
            Storage storage;
            //TODO Adjust return so it's safer.
            try
            {
                using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    storage = (Storage)bf.Deserialize(fs);

                    return storage;
                }
            }
            catch (SerializationException)
            {
                MessageBox.Show("Error loading file");
                return null;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("No file selected");
                return null;
            }
        }
    }
}
