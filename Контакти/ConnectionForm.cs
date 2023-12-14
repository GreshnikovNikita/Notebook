using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataBaseConnection;
using General_settings;
using ContactsInteraction;
using OrganizationsInteraction;

namespace Контакти
{
    public partial class ConnectionForm : Form
    {
        DataBase database = new DataBase();
        Settings settings = new Settings();
        Contacts contacts = new Contacts();
        Organizations organizations = new Organizations();

        public ConnectionForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("idConnection", "Ідентифікатор зв'язку");
            dataGridView1.Columns.Add("idContact", "Ідентифікатор контакту");
            dataGridView1.Columns.Add("idOrganization", "Ідентифікатор організації");
            dataGridView1.Columns.Add("typeConnection", "Тип зв'язку");
            dataGridView1.Columns.Add("IsNew", String.Empty);

            dataGridView1.Columns[4].Visible = false;
        }

        private void ReadSingleRow(DataGridView data, IDataRecord record)
        {
            data.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetString(3));
        }

        private void RefreshDataGrid(DataGridView data)
        {
            data.Rows.Clear();

            string queryString = $"SELECT * FROM Conections";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(data, reader);
            }

            reader.Close();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                IdField.Text = row.Cells[1].Value.ToString();
                NameField.Text = contacts.GetName(IdField.Text);
                SurnameField.Text = contacts.GetSurname(IdField.Text);
                PhoneField.Text = contacts.GetPhone(IdField.Text);
                EmailField.Text = contacts.GetEmail(IdField.Text);
                AddressField.Text = contacts.GetAddress(IdField.Text);
                BirthDateField.Text = contacts.GetBirthDate(IdField.Text);

                IdOrganizationField.Text = row.Cells[2].Value.ToString();
                NameOrganizationField.Text = organizations.GetName(IdOrganizationField.Text);
                TypeOrganizationField.Text = organizations.GetType(IdOrganizationField.Text);
                AddressOrganizationField.Text = organizations.GetAddress(IdOrganizationField.Text);
                PhoneOrganizationField.Text = organizations.GetPhone(IdOrganizationField.Text);
                EmailOrganizationField.Text = organizations.GetEmail(IdOrganizationField.Text);

                IdConnectionField.Text = row.Cells[0].Value.ToString();
                IdContactConnectionField.Text = row.Cells[1].Value.ToString();
                IdOrganizationConnectionField.Text = row.Cells[2].Value.ToString();
                TypeConnectionField.Text = row.Cells[3].Value.ToString();
            }
        }

        private void IdConnectionSearchField_TextChanged(object sender, EventArgs e)
        {
            IdContactSearchField.Clear();
            IdOrganizationSearchField.Clear();
            TypeConnectionSearchField.Clear();

            dataGridView1.Rows.Clear();

            string searchString = $"SELECT * FROM Conections WHERE idConnection like '" + IdConnectionSearchField.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, database.GetConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
            }

            reader.Close();
        }

        private void IdContactSearchField_TextChanged(object sender, EventArgs e)
        {
            IdConnectionSearchField.Clear();
            IdOrganizationSearchField.Clear();
            TypeConnectionSearchField.Clear();

            dataGridView1.Rows.Clear();

            string searchString = $"SELECT * FROM Conections WHERE idContact like '" + IdContactSearchField.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, database.GetConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
            }

            reader.Close();
        }

        private void IdOrganizationSearchField_TextChanged(object sender, EventArgs e)
        {
            IdConnectionSearchField.Clear();
            IdContactSearchField.Clear();
            TypeConnectionSearchField.Clear();

            dataGridView1.Rows.Clear();

            string searchString = $"SELECT * FROM Conections WHERE idOrganization like '" + IdOrganizationSearchField.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, database.GetConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
            }

            reader.Close();
        }

        private void TypeConnectionSearchField_TextChanged(object sender, EventArgs e)
        {
            IdConnectionSearchField.Clear();
            IdContactSearchField.Clear();
            IdOrganizationSearchField.Clear();

            dataGridView1.Rows.Clear();

            string searchString = $"SELECT * FROM Conections WHERE typeConnection like '" + TypeConnectionSearchField.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, database.GetConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
            }

            reader.Close();
        }

        private void IdConnectionSearchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            settings.ProhibitionSymbol(e);
        }

        private void IdContactSearchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            settings.ProhibitionSymbol(e);
        }

        private void IdOrganizationSearchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            settings.ProhibitionSymbol(e);
        }

        private void TypeConnectionSearchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            settings.ProhibitionSymbol(e);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_SIZEBOX = 0x40000;

                var cp = base.CreateParams;
                cp.Style |= WS_SIZEBOX;

                return cp;
            }
        }

        private void ConnectionFormPanel_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void ConnectionFormPanel_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void ConnectionForm_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void ConnectionForm_MouseDown(object sender, MouseEventArgs e)
        {
            settings.MouseDown(e);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            settings.CloseWindow();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            settings.MaximizeWindow(this);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            settings.MinimizeWindow(this);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ConnectionAddForm form = new ConnectionAddForm();
            form.ShowDialog();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            ConnectionChangeForm form = new ConnectionChangeForm();
            form.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ConnectionDeleteForm form = new ConnectionDeleteForm();
            form.ShowDialog();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }
    }
}
