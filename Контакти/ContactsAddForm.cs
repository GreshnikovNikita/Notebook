using System;
using System.Drawing;
using System.Windows.Forms;
using General_settings;
using ContactsInteraction;

namespace Контакти
{
    public partial class AddNote : System.Windows.Forms.Form
    {
        Settings settings = new Settings();
        Contacts contacts = new Contacts();

        public AddNote()
        {
            InitializeComponent();
            
            StartPosition = FormStartPosition.CenterScreen;

            NameField.Text = "Введіть ім'я";
            SurnameField.Text = "Введіть прізвище";
            PhoneField.Text = "Введіть телефон";
            EmailField.Text = "Введіть електронну пошту";
            AddressField.Text = "Введіть адресу";
            BirthDateField.Text = "Введіть дату народження";
        }

        private void NameField_Enter(object sender, EventArgs e)
        {
            if (NameField.Text == "Введіть ім'я")
            {
                NameField.Text = "";
                NameField.ForeColor = Color.Black;
            }
        }

        private void SurnameField_Enter(object sender, EventArgs e)
        {
            if (SurnameField.Text == "Введіть прізвище")
            {
                SurnameField.Text = "";
                SurnameField.ForeColor = Color.Black;
            }
        }

        private void PhoneField_Enter(object sender, EventArgs e)
        {
            if (PhoneField.Text == "Введіть телефон")
            {
                PhoneField.Text = "+380()";
                PhoneField.ForeColor = Color.Black;
                PhoneField.SelectionStart = PhoneField.Text.Length;
            }
        }

        private void EmailField_Enter(object sender, EventArgs e)
        {
            if (EmailField.Text == "Введіть електронну пошту")
            {
                EmailField.Text = "";
                EmailField.ForeColor = Color.Black;
            }
        }

        private void AddressField_Enter(object sender, EventArgs e)
        {
            if (AddressField.Text == "Введіть адресу")
            {
                AddressField.Text = "";
                AddressField.ForeColor = Color.Black;
            }
        }

        private void BirthDateField_Enter(object sender, EventArgs e)
        {
            if (BirthDateField.Text == "Введіть дату народження")
            {
                BirthDateField.Text = "";
                BirthDateField.ForeColor = Color.Black;
            }
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            contacts.CheckNameField(NameField);
        }

        private void SurnameField_Leave(object sender, EventArgs e)
        {
            contacts.CheckSurnameField(SurnameField);
        }

        private void PhoneField_Leave(object sender, EventArgs e)
        {
            contacts.CheckPhoneField(PhoneField);
        }

        private void EmailField_Leave(object sender, EventArgs e)
        {
            contacts.CheckEmailField(EmailField);
        }

        private void AddressField_Leave(object sender, EventArgs e)
        {
            contacts.CheckAddressField(AddressField);
        }

        private void BirthDateField_Leave(object sender, EventArgs e)
        {
            contacts.CheckBirthDateField(BirthDateField);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string id = null;
            string operation = "insert";

            bool fieldFilled = contacts.IsFieldFilled(NameField.Text, SurnameField.Text, PhoneField.Text, EmailField.Text, AddressField.Text, BirthDateField.Text);

            if (fieldFilled == true)
            {
                contacts.FillTable(this, operation, NameField.Text, SurnameField.Text, PhoneField.Text, EmailField.Text, AddressField.Text, BirthDateField.Text, id);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNote_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void AddNote_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void AddNotePanel_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void AddNotePanel_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {
            contacts.NamePrompt();
        }

        private void SurnameLabel_Click(object sender, EventArgs e)
        {
            contacts.SurnamePrompt();
        }

        private void PhoneLabel_Click(object sender, EventArgs e)
        {
            contacts.PhonePrompt();
        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {
            contacts.EmailPrompt();
        }

        private void AddressLabel_Click(object sender, EventArgs e)
        {
            contacts.AddressPrompt();
        }

        private void BirthDateLabel_Click(object sender, EventArgs e)
        {
            contacts.BirthDatePrompt();
        }
    }
}
