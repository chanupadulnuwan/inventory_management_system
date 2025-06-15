using inventryUI;
using inventryUI.Models;
using inventryUI.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace inventryUI.Controllers
{
    public class UserController
    {
        private readonly UserForm? _view;
        private readonly SignupForm? _viewSign;
        private readonly List<User> userlist = new();

        // Constructor for UserForm (Edit/Delete Profile)
        public UserController(UserForm view)
        {
            _view = view;
        }

        // Constructor for SignupForm (Signup)
        public UserController(SignupForm viewSign)
        {
            _viewSign = viewSign;
        }

        // Load profile for current user
        public void LoadUserProfile()
        {
            if (Session.CurrentUserId == 0)
            {
                _view?.ShowMessage("No user logged in. Cannot load profile.", "Authentication Error", MessageBoxIcon.Warning);
                return;
            }

            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT Username, FullName, Password FROM users WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", Session.CurrentUserId);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read() && _view != null)
                    {
                        _view.txtUsername.Text = reader["Username"].ToString();
                        _view.txtFullName.Text = reader["FullName"].ToString();
                        _view.txtPassword.Text = reader["Password"].ToString();
                    }
                    else
                    {
                        _view?.ShowMessage("User not found.", "Error", MessageBoxIcon.Warning);
                    }
                }
            }
        }

        // Add a new user to the database
        public bool AddUser(User user)
        {
            string username = user.Username?.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(user.FullName) ||
                string.IsNullOrWhiteSpace(user.Password))
            {
                _viewSign?.ShowMessage("All fields (Username, Full Name, Password) are required.", "Error", MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    var checkCmd = new MySqlCommand("SELECT COUNT(*) FROM users WHERE LOWER(TRIM(Username)) = @username", conn);
                    checkCmd.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        _viewSign?.ShowMessage("This username is already taken.", "Duplicate Username", MessageBoxIcon.Warning);
                        return false;
                    }

                    var cmd = new MySqlCommand("INSERT INTO users (Username, FullName, Password, Role) VALUES (@username, @fullName, @password, @role)", conn);
                    cmd.Parameters.AddWithValue("@username", user.Username.Trim());
                    cmd.Parameters.AddWithValue("@fullName", user.FullName.Trim());
                    cmd.Parameters.AddWithValue("@password", user.Password.Trim());
                    cmd.Parameters.AddWithValue("@role", user.Role?.Trim());
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                _viewSign?.ShowMessage($"Database error: {ex.Message}", "Database Error", MessageBoxIcon.Error);
                return false;
            }
        }

        // Validate user login and set session
        public bool LoginValid(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                _view?.ShowMessage("Username and Password are required.", "Error", MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand("SELECT * FROM users WHERE Username = @username AND Password = @password", conn);
                    cmd.Parameters.AddWithValue("@username", username.Trim());
                    cmd.Parameters.AddWithValue("@password", password.Trim());
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Session.CurrentUserId = Convert.ToInt32(reader["Id"]);
                            return true;
                        }
                        else
                        {
                            _view?.ShowMessage("Invalid username or password.", "Login Failed", MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _view?.ShowMessage($"Error: {ex.Message}", "Error", MessageBoxIcon.Error);
                return false;
            }
        }

        // Update user's profile
        public bool UpdateUser(int userId, string username, string fullName, string password)
        {
            if (userId != Session.CurrentUserId)
            {
                _view?.ShowMessage("Unauthorized update attempt.", "Security Warning", MessageBoxIcon.Stop);
                return false;
            }

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(password))
            {
                _view?.ShowMessage("All fields are required.", "Error", MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand("UPDATE users SET Username=@username, FullName=@fullName, Password=@password WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@username", username.Trim());
                    cmd.Parameters.AddWithValue("@fullName", fullName.Trim());
                    cmd.Parameters.AddWithValue("@password", password.Trim());
                    cmd.Parameters.AddWithValue("@id", userId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                _view?.ShowMessage($"Error: {ex.Message}", "Error", MessageBoxIcon.Error);
                return false;
            }
        }

        // Delete user's account
        public bool DeleteUser(int userId)
        {
            if (userId != Session.CurrentUserId)
            {
                _view?.ShowMessage("Unauthorized deletion attempt.", "Security Warning", MessageBoxIcon.Stop);
                return false;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand("DELETE FROM users WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", userId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                _view?.ShowMessage($"Error: {ex.Message}", "Error", MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
