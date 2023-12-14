using System;
using System.Drawing;
using System.Windows.Forms;
using General_settings;
using ConnectionsInteraction;

namespace Контакти
{
    public partial class ConnectionAddForm : Form
    {
        Settings settings = new Settings();
        Connections connections = new Connections();

        public ConnectionAddForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            IdContactField.Text = "Введіть ідентифікатор контакту";
            IdOrganizationField.Text = "Введіть ідентифікатор організації";
            TypeConnectionField.Text = "Введіть тип зв'язку";
        }

        private void IdContactField_Enter(object sender, EventArgs e)
        {
            if (IdContactField.Text == "Введіть ідентифікатор контакту")
            {
                IdContactField.Text = "";
                IdContactField.ForeColor = Color.Black;
            }
        }

        private void IdOrganizationField_Enter(object sender, EventArgs e)
        {
            if (IdOrganizationField.Text == "Введіть ідентифікатор організації")
            {
                IdOrganizationField.Text = "";
                IdOrganizationField.ForeColor = Color.Black;
            }
        }

        private void TypeConnectionField_Enter(object sender, EventArgs e)
        {
            if (TypeConnectionField.Text == "Введіть тип зв'язку")
            {
                TypeConnectionField.Text = "";
                TypeConnectionField.ForeColor = Color.Black;
            }
        }

        private void IdContactField_Leave(object sender, EventArgs e)
        {
            connections.CheckIdContactField(IdContactField);
        }

        private void IdOrganizationField_Leave(object sender, EventArgs e)
        {
            connections.CheckIdOrganizationField(IdOrganizationField);
        }

        private void TypeConnectionField_Leave(object sender, EventArgs e)
        {
            connections.CheckTypeConnectionField(TypeConnectionField);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string id = null;
            string operation = "insert";

            bool fieldFilled = connections.IsFieldFilled(IdContactField.Text, IdOrganizationField.Text, TypeConnectionField.Text);

            if (fieldFilled == true)
            {
                connections.FillTable(this, operation, IdContactField.Text, IdOrganizationField.Text, TypeConnectionField.Text, id);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConnectionPanel_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void ConnectionPanel_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void ConnectionAddForm_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void ConnectionAddForm_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void IdContactLabel_Click(object sender, EventArgs e)
        {
            connections.IdContactPrompt();
        }

        private void IdOrganizationLabel_Click(object sender, EventArgs e)
        {
            connections.IdOrganizationPrompt();
        }

        private void TypeConnectionLabel_Click(object sender, EventArgs e)
        {
            connections.TypeConnectionPrompt();
        }
    }
}
