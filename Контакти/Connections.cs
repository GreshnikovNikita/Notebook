using System;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataBaseConnection;
using System.Text.RegularExpressions;

namespace ConnectionsInteraction
{
    internal class Connections
    {
        public void IdConnectionPrompt()
        {
            MessageBox.Show("Ідентифікатор повинен бути в числовому форматі");
        }

        public void IdContactPrompt()
        {
            MessageBox.Show("Ідентифікатор повинен бути в числовому форматі");
        }

        public void IdOrganizationPrompt()
        {
            MessageBox.Show("Ідентифікатор повинен бути в числовому форматі");
        }

        public void TypeConnectionPrompt()
        {
            MessageBox.Show("Тип зв'язку повинен бути:\n\nПрацевлаштування, Співпраця, Клієнт, Постачальник, Конкурент, Інший");
        }

        public void FillTable(Form form, string operation, string idContact, string idOrganization, string typeConnection, string idConnection)
        {
            string querystring = null;

            bool Connection_check = IsConnectionExists(idContact, idOrganization, typeConnection, idConnection);

            if (Connection_check == true)
            {
                DataBase db = new DataBase();

                if (operation == "insert")
                {
                    querystring = $"INSERT INTO Conections(idContact, idOrganization, typeConnection) VALUES('{idContact}', '{idOrganization}', '{typeConnection}')";
                }
                else if (operation == "update")
                {
                    querystring = $"UPDATE Conections SET idContact = '{idContact}', idOrganization = '{idOrganization}', typeConnection = '{typeConnection}' WHERE idConnection = '{idConnection}'";
                }
                else if (operation == "delete")
                {
                    querystring = $"DELETE FROM Conections WHERE idConnection = '{idConnection}'";
                }

                SqlCommand command = new SqlCommand(querystring, db.GetConnection());

                db.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    if (operation == "insert")
                    {
                        MessageBox.Show("Зв'язок додано");
                    }
                    else if (operation == "update")
                    {
                        MessageBox.Show("Зв'язок змінено");
                    }
                    else if (operation == "delete")
                    {
                        MessageBox.Show("Зв'язок видалено");
                    }

                    form.Hide();
                }

                db.CloseConnection();
            }
            else if (Connection_check == false)
            {
                MessageBox.Show("Такий зв'язок вже існує");
                return;
            }
        }

        private Boolean IsConnectionExists(string idContact, string idOrganization, string typeConnection, string idConnection)
        {
            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT idContact, idOrganization, typeConnection FROM Conections WHERE idContact = '{idContact}' AND idOrganization = '{idOrganization}' AND typeConnection = '{typeConnection}' AND idConnection != '{idConnection}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean IsIdConnectionExists(string idConnection)
        {
            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT idConnection FROM Conections WHERE idConnection = '{idConnection}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean IsIdContactsExists(string idContact)
        {
            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT Ідентифікатор FROM Контакти_з_України WHERE Ідентифікатор = '{idContact}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean IsIdOrganizationsExists(string idOrganization)
        {
            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT Id FROM Organizations WHERE Id = '{idOrganization}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean IsFieldFilled(string idContact, string idOrganization, string typeConnection)
        {
            if (idContact == "Введіть ідентифікатор контакту" || idContact == "")
            {
                MessageBox.Show("Введіть ідентифікатор контакту");
                return false;
            }
            else if (idOrganization == "Введіть ідентифікатор організації" || idOrganization == "")
            {
                MessageBox.Show("Введіть ідентифікатор організації");
                return false;
            }
            else if (typeConnection == "Введіть тип зв'язку" || typeConnection == "")
            {
                MessageBox.Show("Введіть тип зв'язку");
                return false;
            }
            else { return true; }
        }

        public void CheckIdConnectionField(TextBox IdConnectionField, TextBox IdContactField, TextBox IdOrganizationField, TextBox TypeConnectionField)
        {
            string pattern = @"[0-9]+$";
            Regex regex = new Regex(pattern);
            bool is_valid = regex.IsMatch(IdConnectionField.Text);

            if (is_valid == false)
            {
                MessageBox.Show("Ідентифікатор не відповідає встановленому формату");

                IdConnectionField.Text = "Введіть ідентифікатор зв'язку";
                IdConnectionField.ForeColor = Color.Gray;

                IdContactField.Clear();
                IdOrganizationField.Clear();
                TypeConnectionField.Clear();

                return;
            }

            bool id_check = IsIdConnectionExists(IdConnectionField.Text);

            if (id_check == true)
            {
                MessageBox.Show("Зв'язку с таким ідентифікатором не існує");

                IdConnectionField.Text = "Введіть ідентифікатор зв'язку";
                IdConnectionField.ForeColor = Color.Gray;
                
                IdContactField.Clear();
                IdOrganizationField.Clear();
                TypeConnectionField.Clear();

                return;
            }

            IdContactField.Text = GetIdContact(IdConnectionField.Text);
            IdContactField.ForeColor = Color.Black;

            IdOrganizationField.Text = GetIdOrganization(IdConnectionField.Text);
            IdOrganizationField.ForeColor = Color.Black;

            TypeConnectionField.Text = GetTypeConnection(IdConnectionField.Text);
            TypeConnectionField.ForeColor = Color.Black;
        }

        public void CheckIdContactField(TextBox IdContactField)
        {
            string pattern = @"[0-9]+$";
            Regex regex = new Regex(pattern);
            bool is_valid = regex.IsMatch(IdContactField.Text);

            if (is_valid == false)
            {
                MessageBox.Show("Ідентифікатор котнтакту не відповідає встановленому формату");
                IdContactField.Text = "Введіть ідентифікатор контакту";
                IdContactField.ForeColor = Color.Gray;
                return;
            }

            bool idContact_check = IsIdContactsExists(IdContactField.Text);

            if (idContact_check == true)
            {
                MessageBox.Show("Контакта с таким ідентифікатором не існує");

                IdContactField.Text = "Введіть ідентифікатор контакту";
                IdContactField.ForeColor = Color.Gray;
                return;
            }
        }

        public void CheckIdOrganizationField(TextBox IdOrganizationField)
        {
            string pattern = @"[0-9]+$";
            Regex regex = new Regex(pattern);
            bool is_valid = regex.IsMatch(IdOrganizationField.Text);

            if (is_valid == false)
            {
                MessageBox.Show("Ідентифікатор організації не відповідає встановленому формату");
                IdOrganizationField.Text = "Введіть ідентифікатор організації";
                IdOrganizationField.ForeColor = Color.Gray;
                return;
            }

            bool idContact_check = IsIdOrganizationsExists(IdOrganizationField.Text);

            if (idContact_check == true)
            {
                MessageBox.Show("Організації с таким ідентифікатором не існує");

                IdOrganizationField.Text = "Введіть ідентифікатор організації";
                IdOrganizationField.ForeColor = Color.Gray;
                return;
            }
        }

        public void CheckTypeConnectionField(TextBox TypeConnectionField)
        {
            string pattern = @"^(?:Працевлаштування|Співпраця|Клієнт|Постачальник|Конкурент|Інший)$";
            Regex regex = new Regex(pattern);
            bool is_valid = regex.IsMatch(TypeConnectionField.Text);

            if (is_valid == false)
            {
                MessageBox.Show("Тип зв'язку не відповідає встановленому формату");
                TypeConnectionField.Text = "Введіть тип зв'язку";
                TypeConnectionField.ForeColor = Color.Gray;
                return;
            }
        }

        public string GetIdContact(string idConnection)
        {
            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT idContact FROM Conections WHERE idConnection = '{idConnection}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                idConnection = reader["idContact"].ToString();
                db.CloseConnection();
                return idConnection;
            }
            else
            {
                db.CloseConnection();
                return null;
            }
        }

        public string GetIdOrganization(string idConnection)
        {
            string name;

            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT idOrganization FROM Conections WHERE idConnection = '{idConnection}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                name = reader["idOrganization"].ToString();
                db.CloseConnection();
                return name;
            }
            else
            {
                db.CloseConnection();
                return null;
            }
        }

        public string GetTypeConnection(string idConnection)
        {
            string surname;

            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT typeConnection FROM Conections WHERE idConnection = '{idConnection}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                surname = reader["typeConnection"].ToString();
                db.CloseConnection();
                return surname;
            }
            else
            {
                db.CloseConnection();
                return null;
            }
        }
    }
}
