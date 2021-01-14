using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD
{
    class PGRepository : IRepository
    {
        private readonly string connectionString = "server=localhost;user=root;database=diary_for_pain;password=mixasoroko12369";

        public bool AddUser(User newUser)
        {
            try
            {
                using var connection = new MySqlConnection(connectionString);
                connection.Open();
                using var command = new MySqlCommand("INSERT INTO users (name, nickname, full_age, roleid) VALUES (@name, @nickname, @fullage, @roleid);", connection);
                command.Parameters.AddWithValue("@name", newUser.Name);
                command.Parameters.AddWithValue("@nickname", newUser.NickName);
                command.Parameters.AddWithValue("@fullage", newUser.Full_Age);
                command.Parameters.AddWithValue("@roleid", newUser.RoleId);

                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool AddDoc(doctors newDoc)
        {
                using var connection = new MySqlConnection(connectionString);
                connection.Open();
                using var command = new MySqlCommand("INSERT INTO doctors (name, rating, telephone_number) VALUES (@name, @rating, @telephone_number);", connection);
                command.Parameters.AddWithValue("@name", newDoc.Name);
                command.Parameters.AddWithValue("@rating", newDoc.Rating);
                command.Parameters.AddWithValue("@telephone_number", newDoc.Telephone_Number);

                command.ExecuteNonQuery();
                connection.Close();
                return true;
        }

        public bool AddPain(places_of_pain newPain)
        {
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("INSERT INTO places_of_pain (name) VALUES (@name);", connection);
            command.Parameters.AddWithValue("@name", newPain.Name);

            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        public bool EditUserByID(User newUser)
        {
            try
            {
                using var connection = new MySqlConnection(connectionString);
                connection.Open();
                using var command = new MySqlCommand("UPDATE users SET name=@name, nickname=@nickname, full_age=@fullage, roleid=@roleid WHERE id=@ID;", connection);
                command.Parameters.AddWithValue("@name", newUser.Name);
                command.Parameters.AddWithValue("@nickname", newUser.NickName);
                command.Parameters.AddWithValue("@fullage", newUser.Full_Age);
                command.Parameters.AddWithValue("@roleid", newUser.RoleId);
                command.Parameters.AddWithValue("@ID", newUser.Id);

                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool EditUserByName(User newUser, string Name)
        {
            try
            {
                using var connection = new MySqlConnection(connectionString);
                connection.Open();
                using var command = new MySqlCommand("UPDATE users SET name=@name, nickname=@nickname, full_age=@fullage, roleid=@roleid WHERE name=@Name_in;", connection);
                command.Parameters.AddWithValue("@name", newUser.Name);
                command.Parameters.AddWithValue("@nickname", newUser.NickName);
                command.Parameters.AddWithValue("@full_age", newUser.Full_Age);
                command.Parameters.AddWithValue("@roleid", newUser.RoleId);
                command.Parameters.AddWithValue("@Name_in", Name);

                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool EditUserByNickName(User newUser, string NickName)
        {
            try
            {
                using var connection = new MySqlConnection(connectionString);
                connection.Open();
                using var command = new MySqlCommand("UPDATE users SET name=@name, nickname=@nickname, full_age=@fullage, roleid=@roleid WHERE nickname=@Nickname_in;", connection);
                command.Parameters.AddWithValue("@name", newUser.Name);
                command.Parameters.AddWithValue("@nickname", newUser.NickName);
                command.Parameters.AddWithValue("@full_age", newUser.Full_Age);
                command.Parameters.AddWithValue("@roleid", newUser.RoleId);
                command.Parameters.AddWithValue("@Nickname_in", NickName);

                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool DelUserByID(int ID)
        {
            try
            {
                using var connection = new MySqlConnection(connectionString);
                connection.Open();
                using var command = new MySqlCommand("DELETE FROM users WHERE id=@ID;", connection);
                command.Parameters.AddWithValue("@ID", ID);

                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool DelUserByName(string Name)
        {
            try
            {
                using var connection = new MySqlConnection(connectionString);
                connection.Open();
                using var command = new MySqlCommand("DELETE FROM users WHERE name=@Name_in;", connection);
                command.Parameters.AddWithValue("@Name_in", Name);

                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool DelUserByNickName(string NickName)
        {
            try
            {
                using var connection = new MySqlConnection(connectionString);
                connection.Open();
                using var command = new MySqlCommand("DELETE FROM users WHERE name=@Name_in;", connection);
                command.Parameters.AddWithValue("@Name_in", NickName);

                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public IEnumerable<User> GetUsers()
        {
            var result = new List<User>();

            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("SELECT * FROM users", connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4)));
            }

            return result;
        }
       
      
       

        public bool AddMedicines(Medicines newMed)
        {
            try
            {
                using var connection = new MySqlConnection(connectionString);
                connection.Open();
                using var command = new MySqlCommand("INSERT INTO medicines (name, rating, price) VALUES (@name, @rating, @price);", connection);
                command.Parameters.AddWithValue("@name", newMed.Name);
                command.Parameters.AddWithValue("@rating", newMed.Rating);
                command.Parameters.AddWithValue("@price", newMed.Price);

                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool EditMedByID(Medicines newMed)
        {
            try
            {
                using var connection = new MySqlConnection(connectionString);
                connection.Open();
                using var command = new MySqlCommand("UPDATE medicines SET name=@name, rating=@rating, price=@price WHERE id=@ID;", connection);
                command.Parameters.AddWithValue("@name", newMed.Name);
                command.Parameters.AddWithValue("@rating", newMed.Rating);
                command.Parameters.AddWithValue("@price", newMed.Price);
                command.Parameters.AddWithValue("@ID", newMed.Id);

                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool EditMedByName(Medicines newMed, string Name)
        {
            try
            {
                using var connection = new MySqlConnection(connectionString);
                connection.Open();
                using var command = new MySqlCommand("UPDATE medicines SET name=@name, rating=@rating, price=@price WHERE name=@Name_in;", connection);
                command.Parameters.AddWithValue("@name", newMed.Name);
                command.Parameters.AddWithValue("@rating", newMed.Rating);
                command.Parameters.AddWithValue("@price", newMed.Price);
                command.Parameters.AddWithValue("@Name_in", Name);

                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool DelMedByID(int ID)
        {
            try
            {
                using var connection = new MySqlConnection(connectionString);
                connection.Open();
                using var command = new MySqlCommand("DELETE FROM medicines WHERE id=@ID;", connection);
                command.Parameters.AddWithValue("@ID", ID);

                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool DelMedByName(string Name)
        {
            try
            {
                using var connection = new MySqlConnection(connectionString);
                connection.Open();
                using var command = new MySqlCommand("DELETE FROM medicines WHERE name=@Name_in;", connection);
                command.Parameters.AddWithValue("@Name_in", Name);

                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public IEnumerable<Medicines> GetMedicines()
        {
            var result = new List<Medicines>();

            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("SELECT * FROM medicines", connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new Medicines(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetFloat(3)));
            }

            return result;
        }

        public IEnumerable<roles> GetRoles()
        {
            var result = new List<roles>();

            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("SELECT * FROM roles", connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new roles(reader.GetInt32(0), reader.GetString(1)));
            }

            return result;
        }
      

        public List<string> GetTables()
        {
            var result = new List<string>();

            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("SHOW TABLES", connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                result.Add(reader.GetString(0));
            }

            return result;
        }

       


        public IEnumerable<awards> GetAwards()
        {
            var result = new List<awards>();

            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("SELECT * FROM awards", connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new awards(reader.GetInt32(0), reader.GetString(1)));
            }

            return result;
        }

        public IEnumerable<places_of_pain> GetPOP()
        {
            var result = new List<places_of_pain>();

            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("SELECT * FROM places_of_pain", connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new places_of_pain(reader.GetInt32(0), reader.GetString(1)));
            }

            return result;
        }


        public IEnumerable<doctors> GetDoctors()
        {
            var result = new List<doctors>();

            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("SELECT * FROM doctors", connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new doctors(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3)));
            }

            return result;
        }

        public List<string> GetCM()
        {
            var result = new List<string>();

            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("SELECT conditions_meaning.Name, external_conditions_meaning.Numerical_Value, external_conditions_meaning.Character_Value "+
                "FROM conditions_meaning "+
                "JOIN external_conditions_meaning ON conditions_meaning.Ex_Con_MeanId = external_conditions_meaning.id; ", connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                result.Add(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2));
            }

            return result;
        }

        public List<string> GetUM()
        {
            var result = new List<string>();

            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("SELECT Name, COUNT(*) FROM medicines GROUP BY Name; ", connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                result.Add(reader.GetString(0) + " " + reader.GetString(1));
            }

            return result;
        }

        public List<string> GetBest()
        {
            var result = new List<string>();

            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("SELECT Name, COUNT(*),Price " + 
            "FROM medicines WHERE " + 
            " Price > 100 GROUP BY Name; ", connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                result.Add(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2));
            }

            return result;
        }

        public List<string> GetSpec()
        {
            var result = new List<string>();

            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("SELECT doctors.Name, specializations.Name "
                + "FROM doctors_to_specializations "
                + "JOIN doctors ON doctors.id = doctors_to_specializations.DoctorsId "
                + "JOIN specializations ON specializations.id = doctors_to_specializations.SpecializationsId; ", connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                result.Add(reader.GetString(0) + " " + reader.GetString(1));
            }

            return result;
        }
        /*public List<string> GetBD()
        {
            var result = new List<string>();

            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("SELECT * FROM doctors WHERE Rating = 10 ORDER BY Rating;", connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                result.Add(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3));
            }

            return result;
        }*/

        public IEnumerable<doctors> Getdoc()
        {
            var result = new List<doctors>();

            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("SELECT * FROM doctors WHERE Rating = 10 ORDER BY Rating;", connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new doctors(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3)));
            }

            return result;
        }


    }
}
