using ConnectionsInteraction;
using System;
using System.Drawing;
using System.Windows.Forms;
using General_settings;

namespace Контакти
{
    public partial class ConnectionDeleteForm : Form
    {
        Settings settings = new Settings();
        Connections connections = new Connections();

        public ConnectionDeleteForm()
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

        private void IdConnectionField_Leave(object sender, EventArgs e)
        {
            connections.CheckIdConnectionField(IdConnectionField, IdContactField, IdOrganizationField, TypeConnectionField);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string operation = "delete";

            if (IdConnectionField.Text == "Введіть ідентифікатор зв'язку")
            {
                MessageBox.Show("Введіть ідентифікатор зв'язку");
                return;
            }

            connections.FillTable(this, operation, IdContactField.Text, IdOrganizationField.Text, TypeConnectionField.Text, IdConnectionField.Text);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConnectionDeleteForm_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void ConnectionDeleteForm_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void ConnectionDeletePanel_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void ConnectionDeletePanel_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void IdConnectionLabel_Click(object sender, EventArgs e)
        {
            connections.IdConnectionPrompt();
        }
    }
}
