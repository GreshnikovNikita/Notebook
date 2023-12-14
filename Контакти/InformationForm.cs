using System;
using System.Windows.Forms;
using General_settings;

namespace Контакти
{
    public partial class InformationForm : Form
    {
        Settings settings = new Settings();

        public InformationForm()
        {
            InitializeComponent();
            
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void InformationFormPanel_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void InformationFormPanel_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void InformationForm_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void InformationForm_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }
    }
}
