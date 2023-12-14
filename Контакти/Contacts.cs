using System;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataBaseConnection;
using System.Text.RegularExpressions;

namespace ContactsInteraction
{
    internal class Contacts
    {
        public void IdPrompt()
        {
            MessageBox.Show("Ідентифікатор повинен бути в числовому форматі");
        }

        public void NamePrompt()
        {
            MessageBox.Show("Ім'я повинно бути в форматі:\n\nІм'я (Андрій)\n\nПодвійне-Ім'я (Либідь-Тетяна)");
        }

        public void SurnamePrompt()
        {
            MessageBox.Show("Прізвище повинно бути в форматі:\n\nПрізвище (Шевченко)\n\nПодвійне-Прізвище (Антонов-Овсієнко)");
        }

        public void PhonePrompt()
        {
            MessageBox.Show("Телефон повинен бути в форматі: +380(11)111-11-11");
        }

        public void EmailPrompt()
        {
            MessageBox.Show("Електронна пошта повинна бути в форматі: user@example.com");
        }

        public void AddressPrompt()
        {
            MessageBox.Show("Адреса повинна бути в форматі:\n\nНазва_міста, вул. Назва_вулиці, номер (Київ, вул. Баумана, 9)\n\nПодвійна-Назва_міста, вул. Назва Вулиці, номер(Івано-Франківськ, вул. Володимира Великого, 12)\n\nНазва Міста, вул. Подвійна-Назва_вулиці, номер(Біла Церква, вул. Гулака-Артемовського, 134)");
        }

        public void BirthDatePrompt()
        {
            MessageBox.Show("Дата народження повинна бути в форматі: 11-11-1111");
        }

        public void FillTable(Form form, string operation, string name, string surname, string phone, string email, string address, string birthDate, string id)
        {
            string querystring = null;

            bool phone_check = IsPhoneExists(phone, id);
            bool email_check = IsEmailExists(email, id);

            if (phone_check == true && email_check == true)
            {
                DataBase db = new DataBase();

                if (operation == "insert")
                {
                    querystring = $"INSERT INTO Контакти_з_України(Ім_я, Прізвище, Телефон, Електронна_пошта, Адреса, Дата_народження) VALUES('{name}', '{surname}', '{phone}', '{email}', '{address}', '{birthDate}')";
                }
                else if (operation == "update")
                {
                    querystring = $"UPDATE Контакти_з_України SET Ім_я = '{name}', Прізвище = '{surname}', Телефон = '{phone}', Електронна_пошта = '{email}', Адреса = '{address}', Дата_народження = '{birthDate}' WHERE Ідентифікатор = '{id}'";
                }
                else if (operation == "delete")
                {
                    querystring = $"DELETE FROM Контакти_з_України WHERE Ідентифікатор = '{id}'";
                }
                
                SqlCommand command = new SqlCommand(querystring, db.GetConnection());
                
                db.OpenConnection();
                
                if (command.ExecuteNonQuery() == 1)
                {
                    if (operation == "insert")
                    {
                        MessageBox.Show("Контакт додано");
                    }
                    else if (operation == "update")
                    {
                        MessageBox.Show("Контакт змінено");
                    }
                    else if (operation == "delete")
                    {
                        MessageBox.Show("Контакт видалено");
                    }

                    form.Hide();
                }
                
                db.CloseConnection();
            }
            else if (phone_check == false && email_check == true)
            {
                MessageBox.Show("Контакт с таким номером телефону вже існує");
                return;
            }
            else if (phone_check == true && email_check == false)
            {
                MessageBox.Show("Контакт с такою електронною поштою вже існує");
                return;
            }
            else if (phone_check == false && email_check == false)
            {
                MessageBox.Show("Контакт с таким номером телефону та електронною поштою вже існує");
                return;
            }
        }

        private Boolean IsPhoneExists(string phone, string id)
        {
            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT Телефон FROM Контакти_з_України WHERE Телефон = '{phone}' AND Ідентифікатор != '{id}'";
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

        private Boolean IsEmailExists(string email, string id)
        {
            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT Електронна_пошта FROM Контакти_з_України WHERE Електронна_пошта = '{email}' AND Ідентифікатор != '{id}'";
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

        public Boolean IsIdExists(string id)
        {
            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT Ідентифікатор FROM Контакти_з_України WHERE Ідентифікатор = '{id}'";
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

        public Boolean IsFieldFilled(string name, string surname, string phone, string email, string address, string birthDate)
        {
            if (name == "Введіть ім'я" || name == "")
            {
                MessageBox.Show("Введіть ім'я");
                return false;
            }
            else if (surname == "Введіть прізвище" || surname == "")
            {
                MessageBox.Show("Введіть прізвище");
                return false;
            }
            else if (phone == "Введіть телефон" || phone == "")
            {
                MessageBox.Show("Введіть телефон");
                return false;
            }
            else if (email == "Введіть електронну пошту" || email == "")
            {
                MessageBox.Show("Введіть електронну пошту");
                return false;
            }
            else if (address == "Введіть адресу" || address == "")
            {
                MessageBox.Show("Введіть адресу");
                return false;
            }
            else if (birthDate == "Введіть дату народження" || birthDate == "")
            {
                MessageBox.Show("Введіть дату народження");
                return false;
            }
            else { return true; }
        }

        public void CheckIdField(TextBox IdField, TextBox NameField, TextBox SurnameField, TextBox PhoneField, TextBox EmailField, TextBox AddressField, TextBox BirthDateField)
        {
            string pattern = @"[0-9]+$";
            Regex regex = new Regex(pattern);
            bool is_valid = regex.IsMatch(IdField.Text);

            if (is_valid == false)
            {
                MessageBox.Show("Ідентифікатор не відповідає встановленому формату");

                IdField.Text = "Введіть ідентифікатор";
                IdField.ForeColor = Color.Gray;

                NameField.Clear();
                SurnameField.Clear();
                PhoneField.Clear();
                EmailField.Clear();
                AddressField.Clear();
                BirthDateField.Clear();

                return;
            }

            bool id_check = IsIdExists(IdField.Text);

            if (id_check == true)
            {
                MessageBox.Show("Контакта с таким ідентифікатором не існує");

                IdField.Text = "Введіть ідентифікатор";
                IdField.ForeColor = Color.Gray;

                NameField.Clear();
                SurnameField.Clear();
                PhoneField.Clear();
                EmailField.Clear();
                AddressField.Clear();
                BirthDateField.Clear();

                return;
            }

            NameField.Text = GetName(IdField.Text);
            NameField.ForeColor = Color.Black;

            SurnameField.Text = GetSurname(IdField.Text);
            SurnameField.ForeColor = Color.Black;

            PhoneField.Text = GetPhone(IdField.Text);
            PhoneField.ForeColor = Color.Black;

            EmailField.Text = GetEmail(IdField.Text);
            EmailField.ForeColor = Color.Black;

            AddressField.Text = GetAddress(IdField.Text);
            AddressField.ForeColor = Color.Black;

            BirthDateField.Text = GetBirthDate(IdField.Text);
            BirthDateField.ForeColor = Color.Black;
        }

        public void CheckNameField(TextBox NameField)
        {
            string pattern = @"^[А-ЯЁЇІЄҐ'_][а-яёїієґ'_]+(-[А-ЯЁЇІЄҐ'_][а-яёїієґ'_]+)?$";
            Regex regex = new Regex(pattern);
            bool is_valid = regex.IsMatch(NameField.Text);

            if (is_valid == false)
            {
                MessageBox.Show("Ім'я не відповідає встановленому формату");
                NameField.Text = "Введіть ім'я";
                NameField.ForeColor = Color.Gray;
                return;
            }
            else
            {
                pattern = @"'";
                string target = "_";
                Regex regex1 = new Regex(pattern);
                NameField.Text = regex1.Replace(NameField.Text, target);
                return;
            }
        }

        public void CheckSurnameField(TextBox SurnameField)
        {
            string pattern = @"^[А-ЯЁЇІЄҐ'_][а-яёїієґ'_]+(-[А-ЯЁЇІЄҐ'_][а-яёїієґ'_]+)?$";
            Regex regex = new Regex(pattern);
            bool is_valid = regex.IsMatch(SurnameField.Text);

            if (is_valid == false)
            {
                MessageBox.Show("Прізвище не відповідає встановленому формату");
                SurnameField.Text = "Введіть прізвище";
                SurnameField.ForeColor = Color.Gray;
                return;
            }
            else
            {
                pattern = @"'";
                string target = "_";
                Regex regex1 = new Regex(pattern);
                SurnameField.Text = regex1.Replace(SurnameField.Text, target);
                return;
            }
        }

        public void CheckPhoneField(TextBox PhoneField)
        {
            string pattern = @"\+380\([0-9]{2}\)[0-9]{3}-[0-9]{2}-[0-9]{2}$";
            Regex regex = new Regex(pattern);
            bool is_valid = regex.IsMatch(PhoneField.Text);

            if (is_valid == false)
            {
                MessageBox.Show("Номер телефону не відповідає встановленому формату");
                PhoneField.Text = "Введіть телефон";
                PhoneField.ForeColor = Color.Gray;
                return;
            }
        }

        public void CheckEmailField(TextBox EmailField)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            Regex regex = new Regex(pattern);
            bool is_valid = regex.IsMatch(EmailField.Text);

            if (is_valid == false)
            {
                MessageBox.Show("Електронна пошта не відповідає встановленому формату");
                EmailField.Text = "Введіть електронну пошту";
                EmailField.ForeColor = Color.Gray;
                return;
            }
            else
            {
                pattern = @"'";
                string target = "_";
                Regex regex1 = new Regex(pattern);
                EmailField.Text = regex1.Replace(EmailField.Text, target);
                return;
            }
        }

        public void CheckAddressField(TextBox AddressField)
        {
            string pattern = @"^[А-ЯЁЇІЄҐ'_][а-яёїієґ'_]+(-[А-ЯЁЇІЄҐ'_][а-яёїієґ'_]+)?(\s[А-ЯЁЇІЄҐ'_][а-яёїієґ'_]+)?,\s[а-яёїієґ]{3}.\s[А-ЯЁЇІЄҐ'_][а-яёїієґ'_]+(-[А-ЯЁЇІЄҐ'_][а-яёїієґ'_]+)?(\s[А-яёїієґ'_]+)?,\s[0-9]+$";
            Regex regex = new Regex(pattern);
            bool is_valid = regex.IsMatch(AddressField.Text);

            if (is_valid == false)
            {
                MessageBox.Show("Адреса не відповідає встановленому формату");
                AddressField.Text = "Введіть адресу";
                AddressField.ForeColor = Color.Gray;
                return;
            }
            else
            {
                pattern = @"'";
                string target = "_";
                Regex regex1 = new Regex(pattern);
                AddressField.Text = regex1.Replace(AddressField.Text, target);
                return;
            }
        }

        public void CheckBirthDateField(TextBox BirthDateField)
        {
            string pattern = @"\d{2}-\d{2}-\d{4}$";
            Regex regex = new Regex(pattern);
            bool is_valid = regex.IsMatch(BirthDateField.Text);

            if (is_valid == false)
            {
                MessageBox.Show("Дата народження не відповідає встановленому формату");
                BirthDateField.Text = "Введіть дату народження";
                BirthDateField.ForeColor = Color.Gray;
                return;
            }
        }

        public string GetId(string id)
        {
            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT Ідентифікатор FROM Контакти_з_України WHERE Ідентифікатор = '{id}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                id = reader["Ідентифікатор"].ToString();
                db.CloseConnection();
                return id;
            }
            else
            {
                db.CloseConnection();
                return null;
            }
        }

        public string GetName(string id)
        {
            string name;

            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT Ім_я FROM Контакти_з_України WHERE Ідентифікатор = '{id}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                name = reader["Ім_я"].ToString();
                db.CloseConnection();
                return name;
            }
            else
            {
                db.CloseConnection();
                return null;
            }
        }

        public string GetSurname(string id)
        {
            string surname;

            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT Прізвище FROM Контакти_з_України WHERE Ідентифікатор = '{id}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                surname = reader["Прізвище"].ToString();
                db.CloseConnection();
                return surname;
            }
            else
            {
                db.CloseConnection();
                return null;
            }
        }

        public string GetPhone(string id)
        {
            string phone;

            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT Телефон FROM Контакти_з_України WHERE Ідентифікатор = '{id}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                phone = reader["Телефон"].ToString();
                db.CloseConnection();
                return phone;
            }
            else
            {
                db.CloseConnection();
                return null;
            }
        }

        public string GetEmail(string id)
        {
            string email;

            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT Електронна_пошта FROM Контакти_з_України WHERE Ідентифікатор = '{id}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                email = reader["Електронна_пошта"].ToString();
                db.CloseConnection();
                return email;
            }
            else
            {
                db.CloseConnection();
                return null;
            }
        }

        public string GetAddress(string id)
        {
            string address;

            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT Адреса FROM Контакти_з_України WHERE Ідентифікатор = '{id}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                address = reader["Адреса"].ToString();
                db.CloseConnection();
                return address;
            }
            else
            {
                db.CloseConnection();
                return null;
            }
        }

        public string GetBirthDate(string id)
        {
            string birthDate;

            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT Дата_народження FROM Контакти_з_України WHERE Ідентифікатор = '{id}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                birthDate = reader["Дата_народження"].ToString();
                db.CloseConnection();
                return birthDate;
            }
            else
            {
                db.CloseConnection();
                return null;
            }
        }
    }
}
