using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsInteraction;
using General_settings;
using OrganizationsInteraction;

namespace Контакти
{
    public partial class OrganizationsAddForm : System.Windows.Forms.Form
    {
        Settings settings = new Settings();
        Organizations organizations = new Organizations();

        public OrganizationsAddForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            NameField.Text = "Введіть назву організації";
            TypeField.Text = "Введіть тип організації";
            AddressField.Text = "Введіть адресу організації";
            PhoneField.Text = "Введіть телефон організації";
            EmailField.Text = "Введіть електронну пошту організації";
        }

        private void NameField_Enter(object sender, EventArgs e)
        {
            if (NameField.Text == "Введіть назву організації")
            {
                NameField.Text = "";
                NameField.ForeColor = Color.Black;
            }
        }

        private void TypeField_Enter(object sender, EventArgs e)
        {
            if (TypeField.Text == "Введіть тип організації")
            {
                TypeField.Text = "";
                TypeField.ForeColor = Color.Black;
            }
        }

        private void AddressField_Enter(object sender, EventArgs e)
        {
            if (AddressField.Text == "Введіть адресу організації")
            {
                AddressField.Text = "";
                AddressField.ForeColor = Color.Black;
            }
        }

        private void PhoneField_Enter(object sender, EventArgs e)
        {
            if (PhoneField.Text == "Введіть телефон організації")
            {
                PhoneField.Text = "+380()";
                PhoneField.ForeColor = Color.Black;
                PhoneField.SelectionStart = PhoneField.Text.Length;
            }
        }

        private void EmailField_Enter(object sender, EventArgs e)
        {
            if (EmailField.Text == "Введіть електронну пошту організації")
            {
                EmailField.Text = "";
                EmailField.ForeColor = Color.Black;
            }
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            organizations.CheckNameField(NameField);
        }

        private void TypeField_Leave(object sender, EventArgs e)
        {
            organizations.CheckTypeField(TypeField);
        }

        private void AddressField_Leave(object sender, EventArgs e)
        {
            organizations.CheckAddressField(AddressField);
        }

        private void PhoneField_Leave(object sender, EventArgs e)
        {
            organizations.CheckPhoneField(PhoneField);
        }

        private void EmailField_Leave(object sender, EventArgs e)
        {
            organizations.CheckEmailField(EmailField);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string id = null;
            string operation = "insert";

            bool fieldFilled = organizations.IsFieldFilled(NameField.Text, TypeField.Text, AddressField.Text, PhoneField.Text, EmailField.Text);

            if (fieldFilled == true)
            {
                organizations.FillTable(this, operation, NameField.Text, TypeField.Text, AddressField.Text, PhoneField.Text, EmailField.Text, id);
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

        private void OrganizationsAddForm_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void OrganizationsAddForm_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {
            organizations.NamePrompt();
        }

        private void TypeLabel_Click(object sender, EventArgs e)
        {
            organizations.TypePrompt();
        }

        private void AddressLabel_Click(object sender, EventArgs e)
        {
            organizations.AddressPrompt();
        }

        private void PhoneLabel_Click(object sender, EventArgs e)
        {
            organizations.PhonePrompt();
        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {
            organizations.EmailPrompt();
        }
    }
}
