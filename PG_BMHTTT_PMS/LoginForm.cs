using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace PG_BMHTTT_PMS
{
     public partial class LoginForm : Form
     {
          public LoginForm()
          {
               InitializeComponent();
          }
          
          private void LoginForm_Load(object sender, EventArgs e)
          {
               // Thử kết nối database khi form load
               if (!ConnectDatabase.Connect())
               {
                    MessageBox.Show("Unable to connect to database on startup!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
          }

          private class User
          {
               public string Username { get; set; }
               public string Password { get; set; }
               public string LoaiTaiKhoan { get; set; }

               public User(string username, string password, string loaiTaiKhoan)
               {
                    Username = username;
                    Password = password;
                    LoaiTaiKhoan = loaiTaiKhoan;
               }
          }
          private void loginBtn_Click(object sender, EventArgs e)
          {
               string username = txtUsername.Text.Trim();
               string password = txtPassword.Text.Trim();

               if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
               {
                    MessageBox.Show("Please enter complete login information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
               }

               if (ConnectDatabase.Connect())
               {
                    try
                    {
                         User user = null;
                         OracleConnection conn = ConnectDatabase.Get_Connect();
                         string query = "SELECT * FROM USERS WHERE USERNAME = :username AND PASSWORD = :password";
                         using (OracleCommand cmd = new OracleCommand(query, conn))
                         {
                              cmd.Parameters.Add(":username", OracleDbType.Varchar2, 10).Value = username;
                              cmd.Parameters.Add(":password", OracleDbType.Varchar2, 30).Value = password;

                              using (OracleDataReader reader = cmd.ExecuteReader())
                              {
                                   if (reader.Read())
                                   {
                                        user = new User(
                                            reader["USERNAME"].ToString(),
                                            reader["PASSWORD"].ToString(),
                                            reader["LOAITAIKHOAN"].ToString()
                                        );
                                   }
                              }
                         }

                         if (user != null)
                         {
                              MessageBox.Show($"Log in successfully!\nAccount type: {user.LoaiTaiKhoan}\nServer version: " + conn.ServerVersion, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                              DashboardForm main = new DashboardForm();
                              main.Show();
                              this.Hide();
                         }
                         else
                         {
                              MessageBox.Show("Account or password is incorrect!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                              txtPassword.Clear();
                              txtPassword.Focus();
                         }
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               }
               else
               {
                    MessageBox.Show("Unable to connect to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
          }
          private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
          {
               if (e.KeyChar == (char)Keys.Enter)
               {
                    loginBtn_Click(sender, e);
               }
          }

          private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
          {
               if (e.KeyChar == (char)Keys.Enter)
               {
                    loginBtn_Click(sender, e);
               }
          }

          private void forgotpasswordBtn_Click(object sender, EventArgs e)
          {
               ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
               forgotPasswordForm.Show();
               this.Hide();
          }

          private void closeBtn_Click_1(object sender, EventArgs e)
          {
               DialogResult result = MessageBox.Show("Are you sure you want to exit??", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (result == DialogResult.Yes)
               {
                    this.Close();
               }
          }

          private void registerBtn_Click(object sender, EventArgs e)
          {
               RegisterForm registerform = new RegisterForm();
               registerform.Show();
               this.Hide();
          }

          private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
          {

          }

          // Optional: Add method to toggle password visibility
          //private void togglePassword_Click(object sender, EventArgs e)
          //{
          //     if (txtPassword.PasswordChar == '*')
          //     {
          //          txtPassword.PasswordChar = '\0'; // Show password
          //     }
          //     else
          //     {
          //          txtPassword.PasswordChar = '*'; // Hide password
          //     }
          //}
     }
}