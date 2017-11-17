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
    public partial class GenerateWindow : Form
    {
        private BindingList<string> _generatedPasswords;

        public GenerateWindow()
        {
            InitializeComponent();

            //Create new list and connect to display
            _generatedPasswords = new BindingList<string>();
            LB_Passwords.DataSource = _generatedPasswords;
        }

        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            PasswordGenerator pg = new PasswordGenerator();

            //Generate and add new password to list
            try
            {
                _generatedPasswords.Add(pg.GenPassword(
                    Convert.ToInt32(NUD_PasswordLength.Value),
                    CB_Numbers.Checked,
                    CB_SpecialCharacters.Checked));
            }
            catch (InvalidPasswordException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            _generatedPasswords.Clear();
        }

        private void Btn_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LB_Passwords.SelectedItem.ToString());
            LB_CopyConfirmed.Text = $"Password copied!";
        }
    }
}
