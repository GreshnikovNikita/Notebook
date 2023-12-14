using System;
using System.Drawing;
using System.Windows.Forms;
using ContactsInteraction;
using General_settings;
using OrganizationsInteraction;

namespace Контакти
{
    public partial class OrganisationsDeleteForm : System.Windows.Forms.Form
    {
        Settings settings = new Settings();
        Organizations organizations = new Organizations();

        public OrganisationsDeleteForm()
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
            organizations.CheckIdField(IdField, NameField, TypeField, AddressField, PhoneField, EmailField);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string operation = "delete";

            if (IdField.Text == "Введіть ідентифікатор")
            {
                MessageBox.Show("Введіть ідентифікатор");
                return;
            }

            organizations.FillTable(this, operation, NameField.Text, TypeField.Text, AddressField.Text, PhoneField.Text, EmailField.Text, IdField.Text);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IdLabel_Click(object sender, EventArgs e)
        {
            organizations.IdPrompt();
        }

        private void OrganisationsDeleteForm_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void OrganisationsDeleteForm_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void OrganisationsDeletePanel_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void OrganisationsDeletePanel_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }
    }
}
