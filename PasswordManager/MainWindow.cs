﻿using System;
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
            LB_Display.DataSource = storage.Credentials;
        }

        //Menu Buttons
        private void Btn_Open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileManager fm = new FileManager();
                    storage.Credentials = fm.LoadFromFile(ofd.FileName);
                    LB_Display.DataSource = storage.Credentials;
                }
            }

        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ofd = new SaveFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileManager fm = new FileManager();
                    fm.SaveToFile(ofd.FileName, storage.Credentials);
                }
            }
        }
        private void Btn_Generator_Click(object sender, EventArgs e)
        {
            GenerateWindow gw = new GenerateWindow();
            gw.Show();
        }

        //Credential buttons
        private void Btn_Crd_Open_Click(object sender, EventArgs e)
        {
            Credential c;
            try
            {
                c = storage.GetCredential(LB_Display.SelectedItem.ToString());
                if (c != null)
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
            catch(NullReferenceException)
            {
                MessageBox.Show("No credential selected");
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

            try
            {
                if (storage.AddCredential(credential))
                {
                    MessageBox.Show("Credential Added");
                }
                else
                {
                    MessageBox.Show("Error adding credential");
                }
            }
            catch(InvalidCredentialException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Btn_Crd_Save_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
