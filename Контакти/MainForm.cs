using System;
using System.Windows.Forms;
using General_settings;

namespace Контакти
{
    public partial class MainForm : Form
    {
        Settings settings = new Settings();

        public MainForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            settings.CloseWindow();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void MainFormPanel_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void MainFormPanel_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void OpenContactsForm_Click(object sender, EventArgs e)
        {
            TableForm form = new TableForm();
            form.Show();
            this.Hide();
        }

        private void OpenOrganizationsForm_Click(object sender, EventArgs e)
        {
            OrganizationsForm form = new OrganizationsForm();
            form.Show();
            this.Hide();
        }

        private void OpenConnectionsForm_Click(object sender, EventArgs e)
        {
            ConnectionForm form = new ConnectionForm();
            form.Show();
            this.Hide();
        }

        private void InformationBox_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm();
            form.ShowDialog();
        }
    }
}
