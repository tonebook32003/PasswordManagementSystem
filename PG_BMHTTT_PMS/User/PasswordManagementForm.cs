using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using PG_BMHTTT_PMS.Encrypt;
using PG_BMHTTT_PMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG_BMHTTT_PMS.User
{
     public partial class PasswordManagementForm : Form
     {
          public int userId = 1; //Gán UserID
          //private DesEncrypter desEncrypter;
          string username, password;
          public PasswordManagementForm(string username, string password)
          {
               InitializeComponent();
               //desEncrypter = new DesEncrypter();
               this.username = username;
               this.password = password;
          }
         

          //public Managerment_Password(int userId)
          //{
          //    this.userId = userId;
          //}

          private void Managerment_Password_Load(object sender, EventArgs e)
          {
               LoadPasswordEntries(userId);
          }

          public void LoadPasswordEntries(int userId, string websiteSearch = null, string usernameSearch = null)
          {
               List<PasswordEntry> passwordEntries = new List<PasswordEntry>();
               HashSet<string> uniqueWebsites = new HashSet<string>();

               using (OracleConnection conn = ConnectDatabase.Get_Connect(username, password))
               {
                    try
                    {
                         if (conn.State == ConnectionState.Closed)
                              conn.Open();

                         using (OracleCommand cmd = new OracleCommand("SearchEntries", conn))
                         {
                              cmd.CommandType = CommandType.StoredProcedure;

                              cmd.Parameters.Add("p_user_id", OracleDbType.Int32).Value = userId;
                              cmd.Parameters.Add("p_website_name", OracleDbType.Varchar2).Value = 
                                   string.IsNullOrEmpty(websiteSearch) ? DBNull.Value : (object)websiteSearch;
                              cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = 
                                   string.IsNullOrEmpty(usernameSearch) ? DBNull.Value : (object)usernameSearch;
                              cmd.Parameters.Add("p_result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                              using (OracleDataReader reader = cmd.ExecuteReader())
                              {
                                   while (reader.Read())
                                   {
                                        passwordEntries.Add(new PasswordEntry
                                        {
                                             WebsiteName = reader.GetString(reader.GetOrdinal("website_name")),
                                             UsernameForSite = reader.GetString(reader.GetOrdinal("username_for_site")),
                                             EncryptedPassword = reader.GetString(reader.GetOrdinal("encrypted_password")),
                                             Category = reader.GetString(reader.GetOrdinal("category"))
                                        });
                                   }
                              }
                         }

                         DataGridView_PasswordEntry.Rows.Clear();
                         if (passwordEntries.Count > 0)
                         {
                              foreach (var entry in passwordEntries)
                              {
                                   DataGridView_PasswordEntry.Rows.Add(entry.WebsiteName, entry.UsernameForSite, entry.EncryptedPassword, entry.Category);
                                   uniqueWebsites.Add(entry.WebsiteName);
                              }
                              labelNumberOfPassword.Text = $"{passwordEntries.Count}";
                              labelNumberOfWebsite.Text = $"{uniqueWebsites.Count}";
                         }
                         else
                         {
                              MessageBox.Show("No data found.");
                              labelNumberOfPassword.Text = "0";
                              labelNumberOfWebsite.Text = "0";
                         }
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Error: " + ex.Message);
                         labelNumberOfPassword.Text = "0";
                         labelNumberOfWebsite.Text = "0";
                    }
               }
          }


          private void btn_new_Click(object sender, EventArgs e)
          {
               AddPassword addPasswordForm = new AddPassword(userId, this, username, password);
               addPasswordForm.Show();
          }

          private void btn_reload_Click(object sender, EventArgs e)
          {
               LoadPasswordEntries(userId);
          }

          private void txt_website_TextChanged(object sender, EventArgs e)
          {
               string websiteSearch = txt_website.Text.Trim();
               string usernameSearch = txt_user.Text.Trim();
               LoadPasswordEntries(userId, websiteSearch, usernameSearch);
          }

          private void txt_user_TextChanged(object sender, EventArgs e)
          {
               string websiteSearch = txt_website.Text.Trim();
               string usernameSearch = txt_user.Text.Trim();
               LoadPasswordEntries(userId, websiteSearch, usernameSearch);
          }

          private void btn_delete_Click(object sender, EventArgs e)
          {
               if (DataGridView_PasswordEntry.SelectedRows.Count > 0)
               {
                    int selectedIndex = DataGridView_PasswordEntry.SelectedRows[0].Index;
                    string websiteName = DataGridView_PasswordEntry.Rows[selectedIndex].Cells["HD_Website"].Value?.ToString();

                    if (string.IsNullOrEmpty(websiteName))
                    {
                         MessageBox.Show("Website name is missing. Cannot delete entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         return;
                    }

                    DialogResult dialogResult = MessageBox.Show(
                        $"Are you sure you want to delete the password entry for '{websiteName}'?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                    if (dialogResult == DialogResult.Yes)
                    {
                         try
                         {
                              using (OracleConnection conn = ConnectDatabase.Get_Connect(username, password))
                              {
                                   if (conn.State == ConnectionState.Closed)
                                        conn.Open();

                                   using (OracleCommand cmd = new OracleCommand("DeletePasswordEntry", conn))
                                   {
                                        cmd.CommandType = CommandType.StoredProcedure;

                                        cmd.Parameters.Add("p_user_id", OracleDbType.Int32).Value = userId; // Assuming UserID is a global variable
                                        cmd.Parameters.Add("p_website_name", OracleDbType.Varchar2).Value = websiteName;

                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Password entry deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        LoadPasswordEntries(userId); // Refresh the GridView
                                   }
                              }
                         }
                         catch (OracleException ex)
                         {
                              MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                         catch (Exception ex)
                         {
                              MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                    }
               }
               else
               {
                    MessageBox.Show("Please select a password entry to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
          }

          private void btn_update_Click(object sender, EventArgs e)
          {
               //if (DataGridView_PasswordEntry.SelectedRows.Count > 0)
               //{
               //     var selectedRow = DataGridView_PasswordEntry.SelectedRows[0];
               //     string websiteName = selectedRow.Cells["HD_Website"].Value?.ToString();

               //     if (string.IsNullOrEmpty(websiteName))
               //     {
               //          MessageBox.Show("Website name is empty or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               //          return;
               //     }

               //     try
               //     {
               //          using (OracleConnection conn = ConnectDatabase.Get_Connect(username, password))
               //          {
               //               if (conn.State == ConnectionState.Closed)
               //                    conn.Open();

               //               using (OracleCommand cmd = new OracleCommand("GetPasswordEntryUpdate", conn))
               //               {
               //                    cmd.CommandType = CommandType.StoredProcedure;

               //                    // Thêm các tham số đầu vào
               //                    cmd.Parameters.Add("p_user_id", OracleDbType.Int32).Value = userId;
               //                    cmd.Parameters.Add("p_website_name", OracleDbType.Varchar2).Value = websiteName;

               //                    // Các tham số đầu ra
               //                    cmd.Parameters.Add("p_entry_id", OracleDbType.Int32).Direction = ParameterDirection.Output;
               //                    cmd.Parameters.Add("p_website_url", OracleDbType.Varchar2, 255).Direction = ParameterDirection.Output;
               //                    cmd.Parameters.Add("p_username_for_site", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
               //                    cmd.Parameters.Add("p_encrypted_password", OracleDbType.Varchar2, 512).Direction = ParameterDirection.Output;
               //                    cmd.Parameters.Add("p_notes", OracleDbType.Clob).Direction = ParameterDirection.Output;
               //                    cmd.Parameters.Add("p_category", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
               //                    cmd.Parameters.Add("p_created_date", OracleDbType.TimeStamp).Direction = ParameterDirection.Output;
               //                    cmd.Parameters.Add("p_last_modified", OracleDbType.TimeStamp).Direction = ParameterDirection.Output;

               //                    cmd.ExecuteNonQuery();

               //                    // Lấy dữ liệu từ các tham số đầu ra
               //                    int? entryId = cmd.Parameters["p_entry_id"].Value as int?;
               //                    string websiteUrl = cmd.Parameters["p_website_url"].Value?.ToString();
               //                    string usernameForSite = cmd.Parameters["p_username_for_site"].Value?.ToString();
               //                    string encryptedPassword = cmd.Parameters["p_encrypted_password"].Value?.ToString();

               //                    string notes = "";
               //                    using (OracleClob clob = cmd.Parameters["p_notes"].Value as OracleClob)
               //                    {
               //                         if (clob != null)
               //                         {
               //                              // Sử dụng StreamReader để đọc dữ liệu
               //                              using (var reader = new StreamReader(clob, Encoding.UTF8))
               //                              {
               //                                   notes = reader.ReadToEnd();
               //                                   Console.WriteLine("Notes: " + notes);
               //                              }
               //                         }
               //                         else
               //                         {
               //                              notes = string.Empty;
               //                              Console.WriteLine("No notes available.");
               //                         }
               //                    }

               //                    string category = cmd.Parameters["p_category"].Value?.ToString();

               //                    object createdDateObj = cmd.Parameters["p_created_date"].Value;
               //                    object lastModifiedObj = cmd.Parameters["p_last_modified"].Value;

               //                    DateTime createdDate = createdDateObj is OracleTimeStamp oracleCreated
               //                        ? oracleCreated.Value
               //                        : DateTime.Now;

               //                    DateTime lastModified = lastModifiedObj is OracleTimeStamp oracleModified
               //                        ? oracleModified.Value
               //                        : DateTime.Now;

               //                    // Giải mã mật khẩu
               //                    string decryptedPassword = string.Empty;

               //                    if (!string.IsNullOrEmpty(encryptedPassword))
               //                    {
               //                         using (OracleCommand decryptCmd = new OracleCommand("BEGIN :decryptedPassword := DES.decrypt(:encryptedText, :key); END;", conn))
               //                         {
               //                              decryptCmd.Parameters.Add("decryptedPassword", OracleDbType.Varchar2, 2000).Direction = ParameterDirection.Output;
               //                              decryptCmd.Parameters.Add("encryptedText", OracleDbType.Raw).Value = Convert.FromBase64String(encryptedPassword);
               //                              decryptCmd.Parameters.Add("key", OracleDbType.Varchar2).Value = "PRIVATEKEY";

               //                              decryptCmd.ExecuteNonQuery();
               //                              decryptedPassword = decryptCmd.Parameters["decryptedPassword"].Value?.ToString();
               //                         }
               //                    }

               //                    // Hiển thị form chỉnh sửa với dữ liệu đã lấy
               //                    EditInfo editForm = new EditInfo(
               //                        userId,
               //                        entryId ?? 0,
               //                        websiteName,
               //                        websiteUrl,
               //                        usernameForSite,
               //                        decryptedPassword, // Gửi mật khẩu đã giải mã
               //                        notes,
               //                        category,
               //                        createdDate,
               //                        lastModified,
               //                        username,
               //                        password
               //                    );
               //                    editForm.ShowDialog();

               //                    // Refresh lại DataGridView sau khi chỉnh sửa
               //                    LoadPasswordEntries(userId);
               //               }
               //          }
               //     }
               //     catch (Exception ex)
               //     {
               //          MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               //     }
               //}
               //else
               //{
               //     MessageBox.Show("Please select a row to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               //}
          }

     }
}
