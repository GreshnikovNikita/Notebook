using System;
using System.Drawing;
using System.Windows.Forms;
using ConnectionsInteraction;
using General_settings;

namespace Контакти
{
    public partial class ConnectionChangeForm : Form
    {
        Settings settings = new Settings();
        Connections connections = new Connections();

        public ConnectionChangeForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            IdConnectionField.Text = "Введіть ідентифікатор зв'язку";
        }

        private void IdConnectionField_Enter(object sender, EventArgs e)
        {
            if (IdConnectionField.Text == "Введіть ідентифікатор зв'язку")
            {
                IdConnectionField.Text = "";
                IdConnectionField.ForeColor = Color.Black;
            }
        }

        private void IdContactField_Enter(object sender, EventArgs e)
        {
            if (IdConnectionField.Text != "Введіть ідентифікатор зв'язку")
            {
                if (IdContactField.Text == "Введіть ідентифікатор контакту")
                {
                    IdContactField.Text = "";
                }
                IdContactField.ReadOnly = false;
                IdContactField.ForeColor = Color.Black;
            }
            else
            {
                IdContactField.ReadOnly = true;
            }
        }

        private void IdOrganizationField_Enter(object sender, EventArgs e)
        {
            if (IdConnectionField.Text != "Введіть ідентифікатор зв'язку")
            {
                if (IdOrganizationField.Text == "Введіть ідентифікатор організації")
                {
                    IdOrganizationField.Text = "";
                }
                IdOrganizationField.ReadOnly = false;
                IdOrganizationField.ForeColor = Color.Black;
            }
            else
            {
                IdOrganizationField.ReadOnly = true;
            }
        }

        private void TypeConnectionField_Enter(object sender, EventArgs e)
        {
            if (IdConnectionField.Text != "Введіть ідентифікатор зв'язку")
            {
                if (TypeConnectionField.Text == "Введіть тип зв'язку")
                {
                    TypeConnectionField.Text = "";
                }
                TypeConnectionField.ReadOnly = false;
                TypeConnectionField.ForeColor = Color.Black;
            }
            else
            {
                TypeConnectionField.ReadOnly = true;
            }
        }

        private void IdConnectionField_Leave(object sender, EventArgs e)
        {
            connections.CheckIdConnectionField(IdConnectionField, IdContactField, IdOrganizationField, TypeConnectionField);
        }

        private void IdContactField_Leave(object sender, EventArgs e)
        {
            if (IdConnectionField.Text != "Введіть ідентифікатор зв'язку")
            {
                connections.CheckIdContactField(IdContactField);
            }
        }

        private void IdOrganizationField_Leave(object sender, EventArgs e)
        {
            if (IdConnectionField.Text != "Введіть ідентифікатор зв'язку")
            {
                connections.CheckIdOrganizationField(IdOrganizationField);
            }
        }

        private void TypeConnectionField_Leave(object sender, EventArgs e)
        {
            if (IdConnectionField.Text != "Введіть ідентифікатор зв'язку")
            {
                connections.CheckTypeConnectionField(TypeConnectionField);
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string idConnection = IdConnectionField.Text;
            string operation = "update";

            if (IdConnectionField.Text == "Введіть ідентифікатор зв'язку")
            {
                MessageBox.Show("Введіть ідентифікатор зв'язку");
                return;
            }
            if (IdContactField.Text == connections.GetIdContact(idConnection) && IdOrganizationField.Text == connections.GetIdOrganization(idConnection) && TypeConnectionField.Text == connections.GetTypeConnection(idConnection))
            {
                MessageBox.Show("Введіть зміни");
                return;
            }
            
            bool fieldFilled = connections.IsFieldFilled(IdContactField.Text, IdOrganizationField.Text, TypeConnectionField.Text);
            
            if (fieldFilled == true)
            {
                connections.FillTable(this, operation, IdContactField.Text, IdOrganizationField.Text, TypeConnectionField.Text, idConnection);
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConnectionChangePanel_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }
        private void ConnectionChangePanel_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }
        private void ConnectionChangeForm_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }
        private void ConnectionChangeForm_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }
        private void IdConnectionLabel_Click(object sender, EventArgs e)
        {
            connections.IdConnectionPrompt();
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
