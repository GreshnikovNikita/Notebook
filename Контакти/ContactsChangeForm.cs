using System;
using System.Drawing;
using System.Windows.Forms;
using ContactsInteraction;
using General_settings;

namespace Контакти
{
    public partial class ChangeNote : System.Windows.Forms.Form
    {
        Settings settings = new Settings();
        Contacts contacts = new Contacts();

        public ChangeNote()
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

        private void NameField_Enter(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                if (NameField.Text == "Введіть ім'я")
                {
                    NameField.Text = "";
                }
                NameField.ReadOnly = false;
                NameField.ForeColor = Color.Black;
            }
            else
            {
                NameField.ReadOnly = true;
            }
        }

        private void SurnameField_Enter(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                if (SurnameField.Text == "Введіть прізвище")
                {
                    SurnameField.Text = "";
                }
                SurnameField.ReadOnly = false;
                SurnameField.ForeColor = Color.Black;
            }
            else
            {
                SurnameField.ReadOnly = true;
            }
        }

        private void PhoneField_Enter(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                if (PhoneField.Text == "Введіть телефон")
                {
                    PhoneField.Text = "+380()";
                }
                PhoneField.ReadOnly = false;
                PhoneField.ForeColor = Color.Black;
            }
            else
            {
                PhoneField.ReadOnly = true;
            }
        }

        private void EmailField_Enter(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                if (EmailField.Text == "Введіть електронну пошту")
                {
                    EmailField.Text = "";
                }
                EmailField.ReadOnly = false;
                EmailField.ForeColor = Color.Black;
            }
            else
            {
                EmailField.ReadOnly = true;
            }
        }

        private void AddressField_Enter(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                if (AddressField.Text == "Введіть адресу")
                {
                    AddressField.Text = "";
                }
                AddressField.ReadOnly = false;
                AddressField.ForeColor = Color.Black;
            }
            else
            {
                AddressField.ReadOnly = true;
            }
        }

        private void BirthDateField_Enter(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                if (BirthDateField.Text == "Введіть дату народження")
                {
                    BirthDateField.Text = "";
                }
                BirthDateField.ReadOnly = false;
                BirthDateField.ForeColor = Color.Black;
            }
            else
            {
                BirthDateField.ReadOnly = true;
            }
        }

        private void IdField_Leave(object sender, EventArgs e)
        {
            contacts.CheckIdField(IdField, NameField, SurnameField, PhoneField, EmailField, AddressField, BirthDateField);
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                contacts.CheckNameField(NameField);
            }
        }

        private void SurnameField_Leave(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                contacts.CheckSurnameField(SurnameField);
            }
        }

        private void PhoneField_Leave(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                contacts.CheckPhoneField(PhoneField);
            }
        }

        private void EmailField_Leave(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                contacts.CheckEmailField(EmailField);
            }
        }

        private void AddressField_Leave(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                contacts.CheckAddressField(AddressField);
            }
        }

        private void BirthDateField_Leave(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                contacts.CheckBirthDateField(BirthDateField);
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string id = IdField.Text;
            string operation = "update";

            if (IdField.Text == "Введіть ідентифікатор")
            {
                MessageBox.Show("Введіть ідентифікатор");
                return;
            }
            if (NameField.Text == contacts.GetName(id) && SurnameField.Text == contacts.GetSurname(id) && PhoneField.Text == contacts.GetPhone(id) && EmailField.Text == contacts.GetEmail(id) && AddressField.Text == contacts.GetAddress(id) && BirthDateField.Text == contacts.GetBirthDate(id))
            {
                MessageBox.Show("Введіть зміни");
                return;
            }
            
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

        private void AddNotePanel_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void AddNotePanel_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void ChangeNote_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void ChangeNote_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void IdLabel_Click(object sender, EventArgs e)
        {
            contacts.IdPrompt();
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
