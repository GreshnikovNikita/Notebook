using System;
using System.Drawing;
using System.Windows.Forms;
using General_settings;
using OrganizationsInteraction;

namespace Контакти
{
    public partial class OrganisationsChangeForm : System.Windows.Forms.Form
    {
        Settings settings = new Settings();
        Organizations organizations = new Organizations();

        public OrganisationsChangeForm()
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
                if (NameField.Text == "Введіть назву організації")
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

        private void TypeField_Enter(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                if (TypeField.Text == "Введіть тип організації")
                {
                    TypeField.Text = "";
                }
                TypeField.ReadOnly = false;
                TypeField.ForeColor = Color.Black;
            }
            else
            {
                TypeField.ReadOnly = true;
            }
        }

        private void AddressField_Enter(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                if (AddressField.Text == "Введіть адресу організації")
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

        private void PhoneField_Enter(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                if (PhoneField.Text == "Введіть телефон організації")
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
                if (EmailField.Text == "Введіть електронну пошту організації")
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

        private void IdField_Leave(object sender, EventArgs e)
        {
            organizations.CheckIdField(IdField, NameField, TypeField, AddressField, PhoneField, EmailField);
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                organizations.CheckNameField(NameField);
            }
        }

        private void TypeField_Leave(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                organizations.CheckTypeField(TypeField);
            }
        }

        private void AddressField_Leave(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                organizations.CheckAddressField(AddressField);
            }
        }

        private void PhoneField_Leave(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                organizations.CheckPhoneField(PhoneField);
            }
        }

        private void EmailField_Leave(object sender, EventArgs e)
        {
            if (IdField.Text != "Введіть ідентифікатор")
            {
                organizations.CheckEmailField(EmailField);
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

            if (NameField.Text == organizations.GetName(id) && TypeField.Text == organizations.GetType(id) && AddressField.Text == organizations.GetAddress(id) && PhoneField.Text == organizations.GetPhone(id) && EmailField.Text == organizations.GetEmail(id))
            {
                MessageBox.Show("Введіть зміни");
                return;
            }

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

        private void OrganisationsChangeForm_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void OrganisationsChangeForm_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void OrganisationsChangePanel_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void OrganisationsChangePanel_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void IdLabel_Click(object sender, EventArgs e)
        {
            organizations.IdPrompt();
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
