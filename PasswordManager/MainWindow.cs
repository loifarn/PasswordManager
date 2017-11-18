using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class MainWindow : Form
    {
        private Storage storage;
        public MainWindow()
        {
            InitializeComponent();
            storage = new Storage();
            LB_Display.DataSource = storage.GetCredentialList;
        }

        //Menu Buttons
        private void Btn_Open_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Btn_Generator_Click(object sender, EventArgs e)
        {
            GenerateWindow gw = new GenerateWindow();
            gw.Show();
        }

        //Credential buttons
        private void Btn_Crd_Open_Click(object sender, EventArgs e)
        {
            Credential c = storage.GetCredential(LB_Display.SelectedItem.ToString());
            
            if(c != null)
            {
                TB_Crd_Name.Text = c.Name;
                TB_Crd_Username.Text = c.Username;
                TB_Crd_Password.Text = c.Password;
                TB_Crd_Email.Text = c.Email;
                RTB_Crd_Comment.Text = c.Comment;
            }
            else
            {
                MessageBox.Show($"Error opening credential");
            }
        }
        private void Btn_Crd_Add_Click(object sender, EventArgs e)
        {
            Credential credential = new Credential(
                TB_Crd_Name.Text,
                TB_Crd_Username.Text,
                TB_Crd_Password.Text,
                TB_Crd_Email.Text,
                RTB_Crd_Comment.Text);

            if(storage.AddCredential(credential))
            {
                MessageBox.Show("Credential Added");
            }
            else
            {
                MessageBox.Show("Error adding credential");
            }
        }
        private void Btn_Crd_Save_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
