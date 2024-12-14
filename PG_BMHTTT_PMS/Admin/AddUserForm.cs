using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Security.Cryptography;

namespace PG_BMHTTT_PMS.Admin
{
     public partial class AddUserForm : Form
     {
          private string adminUsername;
          private string adminPassword;

          public AddUserForm(string username, string password)
          {
               InitializeComponent();
               this.adminUsername = username;
               this.adminPassword = password;
          }

          // Hàm tạo salt ngẫu nhiên
          private string GenerateSalt()
          {
               byte[] saltBytes = new byte[32]; // 32 bytes = 256 bits
               using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
               {
                    rng.GetBytes(saltBytes);
               }
               return Convert.ToBase64String(saltBytes);
          }

          // Hàm mã hóa password với salt
          private string HashPassword(string password, string salt)
          {
               using (var sha256 = System.Security.Cryptography.SHA256.Create())
               {
                    // Kết hợp password và salt
                    byte[] combinedBytes = System.Text.Encoding.UTF8.GetBytes(password + salt);
                    byte[] hashBytes = sha256.ComputeHash(combinedBytes);
                    return Convert.ToBase64String(hashBytes);
               }
          }

          private void btnSave_Click(object sender, EventArgs e)
          {
               if (string.IsNullOrEmpty(txt_Username.Text) || 
                    string.IsNullOrEmpty(txt_Email.Text) || 
                    string.IsNullOrEmpty(txt_Password.Text))
               {
                    MessageBox.Show("Please fill in all required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
               }

               try
               {
                    using (OracleConnection conn = ConnectDatabase.Get_Connect(adminUsername, adminPassword))
                    {
                         // Tạo salt và hash password
                         string salt = GenerateSalt();
                         string hashedPassword = HashPassword(txt_Password.Text, salt);

                         // Query để lấy user_id tiếp theo
                         string sequenceQuery = "SELECT NVL(MAX(user_id), 0) + 1 FROM c##PG_BMHTTT_PMS.USERS";
                         int nextUserId;
                         using (OracleCommand seqCmd = new OracleCommand(sequenceQuery, conn))
                         {
                              nextUserId = Convert.ToInt32(seqCmd.ExecuteScalar());
                         }

                         // Query insert user mới
                         string insertQuery = @"INSERT INTO c##PG_BMHTTT_PMS.USERS  (user_id, username, email, master_password, salt, created_date) VALUES (:user_id, :username, :email, :password, :salt, CURRENT_TIMESTAMP)";

                         using (OracleCommand cmd = new OracleCommand(insertQuery, conn))
                         {
                              cmd.Parameters.Add(":user_id", OracleDbType.Int32).Value = nextUserId;
                              cmd.Parameters.Add(":username", OracleDbType.Varchar2).Value = txt_Username.Text.Trim();
                              cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = txt_Email.Text.Trim();
                              cmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = hashedPassword;
                              cmd.Parameters.Add(":salt", OracleDbType.Varchar2).Value = salt;

                              int rowsAffected = cmd.ExecuteNonQuery();

                              if (rowsAffected > 0)
                              {
                                   MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   this.DialogResult = DialogResult.OK;
                                   this.Close();
                              }
                              else
                              {
                                   MessageBox.Show("Failed to add user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                              }
                         }
                    }
               }
               catch (OracleException ex)
               {
                    if (ex.Number == 1 && ex.Message.Contains("USERS_USERNAME_UK"))
                    {
                         MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex.Number == 1 && ex.Message.Contains("USERS_EMAIL_UK"))
                    {
                         MessageBox.Show("Email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                         MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
          }

          private void btnCancel_Click(object sender, EventArgs e)
          {
               this.DialogResult = DialogResult.Cancel;
               this.Close();
          }

          private void pictureBoxHidePass_Click(object sender, EventArgs e)
          {
               if (txt_Password.PasswordChar == '●')
               {
                    pictureBoxShowPass.BringToFront();
                    txt_Password.PasswordChar = '\0';
               }
          }

          private void pictureBoxShowPass_Click(object sender, EventArgs e)
          {
               if (txt_Password.PasswordChar == '\0')
               {
                    pictureBoxHidePass.BringToFront();
                    txt_Password.PasswordChar = '●';
               }
          }
     }
}
