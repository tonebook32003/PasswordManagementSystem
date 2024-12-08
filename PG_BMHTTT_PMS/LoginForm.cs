using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

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

          private void loginBtn_Click(object sender, EventArgs e)
          {
               string username = txtUsername.Text.Trim();
               string password = txtPassword.Text.Trim();

               if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
               {
                    MessageBox.Show("Please enter username and password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
               }

               if (ConnectDatabase.Connect())
               {
                    try
                    {
                         OracleConnection conn = ConnectDatabase.Get_Connect();
                         string query = "SELECT * FROM USERS WHERE USERNAME = :username";
                         
                         using (OracleCommand cmd = new OracleCommand(query, conn))
                         {
                              cmd.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;

                              using (OracleDataReader reader = cmd.ExecuteReader())
                              {
                                   if (reader.Read())
                                   {
                                        string salt = reader["SALT"].ToString();
                                        string hashedPassword = HashPassword(password, salt);
                                        if (hashedPassword == reader["MASTER_PASSWORD"].ToString())
                                        {
                                             MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                             DashboardForm dashboard = new DashboardForm();
                                             dashboard.Show();
                                             this.Hide();
                                        }
                                        else
                                        {
                                             MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                             txtPassword.Clear();
                                             txtPassword.Focus();
                                        }
                                   }
                                   else
                                   {
                                        MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtPassword.Clear();
                                        txtPassword.Focus();
                                   }
                              }
                         }
                    }
                    catch (Exception ex)
                    {
                         //Console.WriteLine($"Error details: {ex.ToString()}");
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

          private void pictureBoxHidePass_Click(object sender, EventArgs e)
          {
               if(txtPassword.PasswordChar == '●')
               {
                    pictureBoxShowPass.BringToFront();
                    txtPassword.PasswordChar = '\0';
               }
          }

          private void pictureBoxShowPass_Click(object sender, EventArgs e)
          {
               if (txtPassword.PasswordChar == '\0')
               {
                    pictureBoxHidePass.BringToFront();
                    txtPassword.PasswordChar = '●';
               }
          }
     }
}