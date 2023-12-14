using DataBaseConnection;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using General_settings;

namespace Контакти
{
    public partial class OrganizationsForm : System.Windows.Forms.Form
    {
        DataBase database = new DataBase();
        Settings settings = new Settings();

        public OrganizationsForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Id", "Ідентифікатор");
            dataGridView1.Columns.Add("Name", "Назва організації");
            dataGridView1.Columns.Add("Type", "Тип організації");
            dataGridView1.Columns.Add("Address", "Адреса організації");
            dataGridView1.Columns.Add("Phone", "Телефон організації");
            dataGridView1.Columns.Add("Email", "Електронна пошта організації");
            dataGridView1.Columns.Add("IsNew", String.Empty);

            dataGridView1.Columns[6].Visible = false;
        }

        private void ReadSingleRow(DataGridView data, IDataRecord record)
        {
            data.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5));
        }

        private void RefreshDataGrid(DataGridView data)
        {
            data.Rows.Clear();

            string queryString = $"SELECT * FROM Organizations";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(data, reader);
            }

            reader.Close();
        }

        private void OrganizationsForm_Load(object sender, EventArgs e)
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

                IdField.Text = row.Cells[0].Value.ToString();
                NameField.Text = row.Cells[1].Value.ToString();
                TypeField.Text = row.Cells[2].Value.ToString();
                AddressField.Text = row.Cells[3].Value.ToString();
                PhoneField.Text = row.Cells[4].Value.ToString();
                EmailField.Text = row.Cells[5].Value.ToString();
            }
        }

        private void IdSearchField_TextChanged(object sender, EventArgs e)
        {
            NameSearchField.Clear();
            TypeSearchField.Clear();
            PhoneSearchField.Clear();
            EmailSearchField.Clear();
            AddressSearchField.Clear();

            dataGridView1.Rows.Clear();

            string searchString = $"SELECT * FROM Organizations WHERE Id like '" + IdSearchField.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, database.GetConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
            }

            reader.Close();
        }

        private void NameSearchField_TextChanged(object sender, EventArgs e)
        {
            IdSearchField.Clear();
            TypeSearchField.Clear();
            PhoneSearchField.Clear();
            EmailSearchField.Clear();
            AddressSearchField.Clear();

            dataGridView1.Rows.Clear();

            string searchString = $"SELECT * FROM Organizations WHERE Name like '" + NameSearchField.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, database.GetConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
            }

            reader.Close();
        }

        private void TypeSearchField_TextChanged(object sender, EventArgs e)
        {
            IdSearchField.Clear();
            NameSearchField.Clear();
            PhoneSearchField.Clear();
            EmailSearchField.Clear();
            AddressSearchField.Clear();

            dataGridView1.Rows.Clear();

            string searchString = $"SELECT * FROM Organizations WHERE Type like '" + TypeSearchField.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, database.GetConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
            }

            reader.Close();
        }

        private void AddressSearchField_TextChanged(object sender, EventArgs e)
        {
            IdSearchField.Clear();
            NameSearchField.Clear();
            TypeSearchField.Clear();
            PhoneSearchField.Clear();
            EmailSearchField.Clear();

            dataGridView1.Rows.Clear();

            string searchString = $"SELECT * FROM Organizations WHERE Address like '" + AddressSearchField.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, database.GetConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
            }

            reader.Close();
        }

        private void PhoneSearchField_TextChanged(object sender, EventArgs e)
        {
            IdSearchField.Clear();
            NameSearchField.Clear();
            TypeSearchField.Clear();
            EmailSearchField.Clear();
            AddressSearchField.Clear();

            dataGridView1.Rows.Clear();

            string searchString = $"SELECT * FROM Organizations WHERE Phone like '" + PhoneSearchField.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, database.GetConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
            }

            reader.Close();
        }

        private void EmailSearchField_TextChanged(object sender, EventArgs e)
        {
            IdSearchField.Clear();
            NameSearchField.Clear();
            TypeSearchField.Clear();
            PhoneSearchField.Clear();
            AddressSearchField.Clear();

            dataGridView1.Rows.Clear();

            string searchString = $"SELECT * FROM Organizations WHERE Email like '" + EmailSearchField.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, database.GetConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
            }

            reader.Close();
        }

        private void IdSearchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            settings.ProhibitionSymbol(e);
        }

        private void NameSearchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            settings.ProhibitionSymbol(e);
        }

        private void TypeSearchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            settings.ProhibitionSymbol(e);
        }

        private void AddressSearchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            settings.ProhibitionSymbol(e);
        }

        private void PhoneSearchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            settings.ProhibitionSymbol(e);
        }

        private void EmailSearchField_KeyPress(object sender, KeyPressEventArgs e)
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

        private void OrganizationsForm_MouseMove(object sender, MouseEventArgs e)
        {
            settings.MouseMove(this, e);
        }

        private void OrganizationsForm_MouseDown(object sender, MouseEventArgs e)
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
            OrganizationsAddForm addForm = new OrganizationsAddForm();
            addForm.ShowDialog();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            OrganisationsChangeForm changeForm = new OrganisationsChangeForm();
            changeForm.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            OrganisationsDeleteForm deleteForm = new OrganisationsDeleteForm();
            deleteForm.ShowDialog();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }
    }
}
