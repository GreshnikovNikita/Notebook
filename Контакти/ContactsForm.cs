using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataBaseConnection;
using General_settings;

namespace Контакти
{
    public partial class TableForm : Form
    {
        DataBase database = new DataBase();
        Settings settings = new Settings();

        public TableForm()
        {
            InitializeComponent();
            
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Ідентифікатор", "Ідентифікатор");
            dataGridView1.Columns.Add("Ім_я", "Ім'я");
            dataGridView1.Columns.Add("Прізвище", "Прізвище");
            dataGridView1.Columns.Add("Телефон", "Телефон");
            dataGridView1.Columns.Add("Електронна_пошта", "Електронна пошта");
            dataGridView1.Columns.Add("Адреса", "Адреса");
            dataGridView1.Columns.Add("Дата_народження", "Дата народження");
            dataGridView1.Columns.Add("IsNew", String.Empty);

            dataGridView1.Columns[7].Visible = false;
        }

        private void ReadSingleRow(DataGridView data, IDataRecord record)
        {
            data.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6));
        }

        private void RefreshDataGrid(DataGridView data)
        {
            data.Rows.Clear();

            string queryString = $"SELECT * FROM Контакти_з_України";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(data, reader);
            }

            reader.Close();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void contactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactsBindingSource.EndEdit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                IdField.Text = row.Cells[0].Value.ToString();
                NameField.Text = row.Cells[1].Value.ToString();
                SurnameField.Text = row.Cells[2].Value.ToString();
                PhoneField.Text = row.Cells[3].Value.ToString();
                EmailField.Text = row.Cells[4].Value.ToString();
                AddressField.Text = row.Cells[5].Value.ToString();
                BirthDateField.Text = row.Cells[6].Value.ToString();
            }
        }

        private void IdSearchField_TextChanged(object sender, EventArgs e)
        {
            NameSearchField.Clear();
            SurnameSearchField.Clear();
            PhoneSearchField.Clear();
            EmailSearchField.Clear();
            AddressSearchField.Clear();
            BirthDateSearchField.Clear();

            dataGridView1.Rows.Clear();

            string searchString = $"SELECT * FROM Контакти_з_України WHERE Ідентифікатор like '" + IdSearchField.Text + "%'";

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
            SurnameSearchField.Clear();
            PhoneSearchField.Clear();
            EmailSearchField.Clear();
            AddressSearchField.Clear();
            BirthDateSearchField.Clear();

            dataGridView1.Rows.Clear();

            string searchString = $"SELECT * FROM Контакти_з_України WHERE Ім_я like '" + NameSearchField.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, database.GetConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
            }

            reader.Close();
        }

        private void SurnameSearchField_TextChanged(object sender, EventArgs e)
        {
            IdSearchField.Clear();
            NameSearchField.Clear();
            PhoneSearchField.Clear();
            EmailSearchField.Clear();
            AddressSearchField.Clear();
            BirthDateSearchField.Clear();

            dataGridView1.Rows.Clear();

            string searchString = $"SELECT * FROM Контакти_з_України WHERE Прізвище like '" + SurnameSearchField.Text + "%'";

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
            SurnameSearchField.Clear();
            EmailSearchField.Clear();
            AddressSearchField.Clear();
            BirthDateSearchField.Clear();

            dataGridView1.Rows.Clear();

            string searchString = $"SELECT * FROM Контакти_з_України WHERE Телефон like '" + PhoneSearchField.Text + "%'";

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
            SurnameSearchField.Clear();
            PhoneSearchField.Clear();
            AddressSearchField.Clear();
            BirthDateSearchField.Clear();

            dataGridView1.Rows.Clear();

            string searchString = $"SELECT * FROM Контакти_з_України WHERE Електронна_пошта like '" + EmailSearchField.Text + "%'";

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
            SurnameSearchField.Clear();
            PhoneSearchField.Clear();
            EmailSearchField.Clear();
            BirthDateSearchField.Clear();

            dataGridView1.Rows.Clear();

            string searchString = $"SELECT * FROM Контакти_з_України WHERE Адреса like '" + AddressSearchField.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, database.GetConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
            }

            reader.Close();
        }

        private void BirthDateSearchField_TextChanged(object sender, EventArgs e)
        {
            IdSearchField.Clear();
            NameSearchField.Clear();
            SurnameSearchField.Clear();
            PhoneSearchField.Clear();
            EmailSearchField.Clear();
            AddressSearchField.Clear();

            dataGridView1.Rows.Clear();

            string searchString = $"SELECT * FROM Контакти_з_України WHERE Дата_народження like '%" + BirthDateSearchField.Text + "%'";

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

        private void SurnameSearchField_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AddressSearchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            settings.ProhibitionSymbol(e);
        }

        private void BirthDateSearchField_KeyPress(object sender, KeyPressEventArgs e)
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
            AddNote note = new AddNote();
            note.ShowDialog();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            ChangeNote note = new ChangeNote();
            note.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteNote note = new DeleteNote();
            note.ShowDialog();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }
    }
}
