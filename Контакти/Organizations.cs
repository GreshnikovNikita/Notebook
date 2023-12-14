using DataBaseConnection;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml.Spreadsheet;

namespace OrganizationsInteraction
{
    internal class Organizations
    {
        public void IdPrompt()
        {
            MessageBox.Show("Ідентифікатор повинен бути в числовому форматі");
        }

        public void NamePrompt()
        {
            MessageBox.Show("Назва організації повинна бути в форматі:\n\nНазва організації (Українська залізниця), (Українська філія компанії Google)");
        }

        public void TypePrompt()
        {
            MessageBox.Show("Тип організації повинен бути в форматі:\n\nТип організації (Залізнична компанія), (IT компанія)");
        }

        public void PhonePrompt()
        {
            MessageBox.Show("Телефон організації повинен бути в форматі: +380(11)111-11-11");
        }

        public void EmailPrompt()
        {
            MessageBox.Show("Електронна пошта організації повинна бути в форматі: organization@example.com");
        }

        public void AddressPrompt()
        {
            MessageBox.Show("Адреса організації повинна бути в форматі:\n\nНазва_міста, вул. Назва_вулиці, номер (Київ, вул. Баумана, 9)\n\nПодвійна-Назва_міста, вул. Назва Вулиці, номер(Івано-Франківськ, вул. Володимира Великого, 12)\n\nНазва Міста, вул. Подвійна-Назва_вулиці, номер(Біла Церква, вул. Гулака-Артемовського, 134)");
        }

        public void FillTable(Form form, string operation, string name, string type, string address, string phone, string email, string id)
        {
            string querystring = null;

            bool phone_check = IsPhoneExists(phone, id);
            bool email_check = IsEmailExists(email, id);

            if (phone_check == true && email_check == true)
            {
                DataBase db = new DataBase();

                if (operation == "insert")
                {
                    querystring = $"INSERT INTO Organizations(Name, Type, Address, Phone, Email) VALUES('{name}', '{type}', '{address}', '{phone}', '{email}')";
                }
                else if (operation == "update")
                {
                    querystring = $"UPDATE Organizations SET Name = '{name}', Type = '{type}', Address = '{address}', Phone = '{phone}', Email = '{email}' WHERE Id = '{id}'";
                }
                else if (operation == "delete")
                {
                    querystring = $"DELETE FROM Organizations WHERE Id = '{id}'";
                }

                SqlCommand command = new SqlCommand(querystring, db.GetConnection());

                db.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    if (operation == "insert")
                    {
                        MessageBox.Show("Організацію додано");
                    }
                    else if (operation == "update")
                    {
                        MessageBox.Show("Організацію змінено");
                    }
                    else if (operation == "delete")
                    {
                        MessageBox.Show("Організацію видалено");
                    }

                    form.Hide();
                }

                db.CloseConnection();
            }
            else if (phone_check == false && email_check == true)
            {
                MessageBox.Show("Організація с таким номером телефону вже існує");
                return;
            }
            else if (phone_check == true && email_check == false)
            {
                MessageBox.Show("Організація с такою електронною поштою вже існує");
                return;
            }
            else if (phone_check == false && email_check == false)
            {
                MessageBox.Show("Організація с таким номером телефону та електронною поштою вже існує");
                return;
            }
        }

        private Boolean IsPhoneExists(string phone, string id)
        {
            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT Phone FROM Organizations WHERE Phone = '{phone}' AND Id != '{id}'";
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

            string querystring = $"SELECT Email FROM Organizations WHERE Email = '{email}' AND Id != '{id}'";
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

            string querystring = $"SELECT Id FROM Organizations WHERE Id = '{id}'";
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

        public Boolean IsFieldFilled(string name, string type, string address, string phone, string email)
        {
            if (name == "Введіть назву організації" || name == "")
            {
                MessageBox.Show("Введіть назву організації");
                return false;
            }
            else if (type == "Введіть тип організації" || type == "")
            {
                MessageBox.Show("Введіть тип організації");
                return false;
            }
            else if (address == "Введіть адресу організації" || address == "")
            {
                MessageBox.Show("Введіть адресу організації");
                return false;
            }
            else if (phone == "Введіть телефон організації" || phone == "")
            {
                MessageBox.Show("Введіть телефон організації");
                return false;
            }
            else if (email == "Введіть електронну пошту організації" || email == "")
            {
                MessageBox.Show("Введіть електронну пошту організації");
                return false;
            }
            else { return true; }
        }

        public void CheckIdField(TextBox IdField, TextBox NameField, TextBox TypeField, TextBox AddressField, TextBox PhoneField, TextBox EmailField)
        {
            string pattern = @"[0-9]+$";
            Regex regex = new Regex(pattern);
            bool is_valid = regex.IsMatch(IdField.Text);

            if (is_valid == false)
            {
                MessageBox.Show("Ідентифікатор не відповідає встановленому формату");

                IdField.Text = "Введіть ідентифікатор";
                IdField.ForeColor = System.Drawing.Color.Gray;

                NameField.Clear();
                TypeField.Clear();
                AddressField.Clear();
                PhoneField.Clear();
                EmailField.Clear();

                return;
            }

            bool id_check = IsIdExists(IdField.Text);

            if (id_check == true)
            {
                MessageBox.Show("Організації с таким ідентифікатором не існує");

                IdField.Text = "Введіть ідентифікатор";
                IdField.ForeColor = System.Drawing.Color.Gray;

                NameField.Clear();
                TypeField.Clear();
                AddressField.Clear();
                PhoneField.Clear();
                EmailField.Clear();

                return;
            }

            NameField.Text = GetName(IdField.Text);
            NameField.ForeColor = System.Drawing.Color.Black;

            TypeField.Text = GetType(IdField.Text);
            TypeField.ForeColor = System.Drawing.Color.Black;

            AddressField.Text = GetAddress(IdField.Text);
            AddressField.ForeColor = System.Drawing.Color.Black;

            PhoneField.Text = GetPhone(IdField.Text);
            PhoneField.ForeColor = System.Drawing.Color.Black;

            EmailField.Text = GetEmail(IdField.Text);
            EmailField.ForeColor = System.Drawing.Color.Black;
        }

        public void CheckNameField(TextBox NameField)
        {
            if (NameField.Text == "")
            {
                MessageBox.Show("Назва організації не відповідає встановленому формату");
                NameField.Text = "Введіть назву організації";
                NameField.ForeColor = System.Drawing.Color.Gray;
                return;
            }
            else
            {
                string pattern = @"'";
                string target = "_";
                Regex regex1 = new Regex(pattern);
                NameField.Text = regex1.Replace(NameField.Text, target);
                return;
            }
        }

        public void CheckTypeField(TextBox TypeField)
        {
            if (TypeField.Text == "")
            {
                MessageBox.Show("Тип організації не відповідає встановленому формату");
                TypeField.Text = "Введіть тип організації";
                TypeField.ForeColor = System.Drawing.Color.Gray;
                return;
            }
            else
            {
                string pattern = @"'";
                string target = "_";
                Regex regex1 = new Regex(pattern);
                TypeField.Text = regex1.Replace(TypeField.Text, target);
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
                MessageBox.Show("Адреса організації не відповідає встановленому формату");
                AddressField.Text = "Введіть адресу організації";
                AddressField.ForeColor = System.Drawing.Color.Gray;
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

        public void CheckPhoneField(TextBox PhoneField)
        {
            string pattern = @"\+380\([0-9]{2}\)[0-9]{3}-[0-9]{2}-[0-9]{2}$";
            Regex regex = new Regex(pattern);
            bool is_valid = regex.IsMatch(PhoneField.Text);

            if (is_valid == false)
            {
                MessageBox.Show("Номер телефону організації не відповідає встановленому формату");
                PhoneField.Text = "Введіть телефон організації";
                PhoneField.ForeColor = System.Drawing.Color.Gray;
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
                MessageBox.Show("Електронна пошта організації не відповідає встановленому формату");
                EmailField.Text = "Введіть електронну пошту організації";
                EmailField.ForeColor = System.Drawing.Color.Gray;
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

        public string GetId(string id)
        {
            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT Id FROM Organizations WHERE Id = '{id}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                id = reader["Id"].ToString();
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

            string querystring = $"SELECT Name FROM Organizations WHERE Id = '{id}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                name = reader["Name"].ToString();
                db.CloseConnection();
                return name;
            }
            else
            {
                db.CloseConnection();
                return null;
            }
        }

        public string GetType(string id)
        {
            string surname;

            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT Type FROM Organizations WHERE Id = '{id}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                surname = reader["Type"].ToString();
                db.CloseConnection();
                return surname;
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

            string querystring = $"SELECT Address FROM Organizations WHERE Id = '{id}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                address = reader["Address"].ToString();
                db.CloseConnection();
                return address;
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

            string querystring = $"SELECT Phone FROM Organizations WHERE Id = '{id}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                phone = reader["Phone"].ToString();
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

            string querystring = $"SELECT Email FROM Organizations WHERE Id = '{id}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                email = reader["Email"].ToString();
                db.CloseConnection();
                return email;
            }
            else
            {
                db.CloseConnection();
                return null;
            }
        }
    }
}
