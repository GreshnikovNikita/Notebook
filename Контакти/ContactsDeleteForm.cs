using ContactsInteraction;
using System;
using System.Drawing;
using System.Windows.Forms;
using General_settings;

namespace Контакти
{
    public partial class DeleteNote : System.Windows.Forms.Form
    {
        Settings settings = new Settings();
        Contacts contacts = new Contacts();

        public DeleteNote()
        {
            InitializeComponent();
            
            StartPosition = FormStartPosition.CenterScreen;

            IdField.Text = "Введіть ідентифікатор";
        }

        private void IdField_Enter(object sender, EventArgs e)
        {
            if (IdField.Text == "Введіть ідентифікатор")
            {
                IdField.Text = "";
                IdField.ForeColor = Color.Black;
            }
        }

        private void IdField_Leave(object sender, EventArgs e)
        {
            contacts.CheckIdField(IdField, NameField, SurnameField, PhoneField, EmailField, AddressField, BirthDateField);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string operation = "delete";
            
            if (IdField.Text == "Введіть ідентифікатор")
            {
                MessageBox.Show("Введіть ідентифікатор");
                return;
            }

            contacts.FillTable(this, operation, NameField.Text, SurnameField.Text, PhoneField.Text, EmailField.Text, AddressField.Text, BirthDateField.Text, IdField.Text);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteNotePanel_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void DeleteNotePanel_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void DeleteNote_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void DeleteNote_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void IdLabel_Click(object sender, EventArgs e)
        {
            contacts.IdPrompt();
        }
    }
}
