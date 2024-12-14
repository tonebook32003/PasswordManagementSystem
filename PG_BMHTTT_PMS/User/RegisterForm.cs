using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG_BMHTTT_PMS
{
     public partial class RegisterForm : Form
     {
          string username, password;
          public RegisterForm(string username, string password)
          {
               InitializeComponent();
               this.username = username;
               this.password = password;
          }
          private class RegisterUser
          {
               public string Email { get; set; }
               public string Username { get; set; }
               public string Password { get; set; }

               public RegisterUser(string email,string username, string password)
               {
                    Username = username;
                    Password = password;
                    Email = email;
               }
          }
          private string GenerateSalt()
          {
               byte[] saltBytes = new byte[32];
               using (var rng = new RNGCryptoServiceProvider())
               {
                    rng.GetBytes(saltBytes);
               }
               return BitConverter.ToString(saltBytes).Replace("-", "").ToLower();
          }
          private string HashPassword(string password, string salt)
          {
               using (var sha256 = SHA256.Create())
               {
                    var combinedPassword = string.Concat(password, salt);
                    byte[] bytes = Encoding.UTF8.GetBytes(combinedPassword);
                    byte[] hash = sha256.ComputeHash(bytes);
                    return BitConverter.ToString(hash).Replace("-", "").ToLower();
               }
          }
          private bool ValidateInput(RegisterUser user)
          {
               if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
               {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
               }

               if (!System.Text.RegularExpressions.Regex.IsMatch(user.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
               {
                    MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
               }

               return true;
          }
          private bool IsUserExists(string email, string username)
          {
               try
               {
                    using (OracleConnection conn = ConnectDatabase.Get_Connect(username, password))
                    {
                         string sql = "SELECT COUNT(*) FROM Users WHERE email = :email OR username = :username";
                         using (OracleCommand cmd = new OracleCommand(sql, conn))
                         {
                              cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;
                              cmd.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;

                              int count = Convert.ToInt32(cmd.ExecuteScalar());
                              return count > 0;
                         }
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show($"Lỗi kiểm tra user: {ex.Message}", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
               }
          }

          private bool SaveUserToDatabase(RegisterUser user, string hashedPassword, string salt)
          {
               try
               {
                    using (OracleConnection conn = ConnectDatabase.Get_Connect(username, password))
                    {
                         string sql = @"INSERT INTO Users (user_id, username, email, master_password, salt, created_date) 
                                      VALUES  (users_seq.NEXTVAL, :username, :email, :password, :salt, CURRENT_TIMESTAMP)";

                         using (OracleCommand cmd = new OracleCommand(sql, conn))
                         {
                              cmd.Parameters.Add(":username", OracleDbType.Varchar2).Value = user.Username;
                              cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = user.Email;
                              cmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = hashedPassword;
                              cmd.Parameters.Add(":salt", OracleDbType.Varchar2).Value = salt;

                              cmd.ExecuteNonQuery();
                         }
                         return true;
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
               }
          }

          

          private void registerBtn_Click(object sender, EventArgs e)
          {
               RegisterUser newUser = new RegisterUser(
                    txtEmail.Text.Trim(),
                    txtUsername.Text.Trim(),
                    txtPassword.Text
               );

               if (!ValidateInput(newUser))
                    return;

               if (IsUserExists(newUser.Email, newUser.Username))
               {
                    MessageBox.Show("Email hoặc tên đăng nhập đã tồn tại!", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
               }

               string salt = GenerateSalt();
               string hashedPassword = HashPassword(newUser.Password, salt);

               if (SaveUserToDatabase(newUser, hashedPassword, salt))
               {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Close();
               }
          }

          private void loginButton_Click(object sender, EventArgs e)
          {
               LoginForm loginForm = new LoginForm();
               loginForm.ShowDialog();
               this.Close();
          }

          private void closeBtn_Click(object sender, EventArgs e)
          {
               DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (result == DialogResult.Yes)
               {
                    this.Close();
               }
          }

          private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
          {

          }

          private void pictureBoxHidePass_Click(object sender, EventArgs e)
          {
               //txtPassword.UseSystemPasswordChar = false;
               //pictureBoxShowPass.Show();
               //pictureBoxHidePass.Hide();
               if (txtPassword.PasswordChar == '●')
               {
                    pictureBoxShowPass.BringToFront();
                    txtPassword.PasswordChar = '\0';
               }
          }

          private void txtPassword_TextChanged(object sender, EventArgs e)
          {

          }

          private void pictureBoxShowPass_Click(object sender, EventArgs e)
          {
               //txtPassword.UseSystemPasswordChar = true;
               //pictureBoxShowPass.Hide();
               //pictureBoxHidePass.Show();
               if (txtPassword.PasswordChar == '\0')
               {
                    pictureBoxHidePass.BringToFront();
                    txtPassword.PasswordChar = '●';
               }
          }
     }
}
