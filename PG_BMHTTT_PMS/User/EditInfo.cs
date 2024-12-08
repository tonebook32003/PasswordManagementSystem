using Oracle.ManagedDataAccess.Client;
using PG_BMHTTT_PMS.Encrypt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG_BMHTTT_PMS.User
{
     public partial class EditInfo : Form
     {
          private DesEncrypter desEncrypter;
          private int UserID;
          private string WebsiteName;
          public EditInfo(int userId, int entryId, string websiteName, string websiteUrl,
                           string usernameForSite, string decryptedPassword, string notes,
                           string category, DateTime? createdDate, DateTime? lastModified)
          {
               txt_webName.Text = websiteName;
               txt_urlWeb.Text = websiteUrl;
               txt_user.Text = usernameForSite;
               txt_pass.Text = decryptedPassword;
               txt_note.Text = notes;
               cbb_category.SelectedItem = category;

               UserID = userId;
               WebsiteName = websiteName;

               InitializeComponent();
               LoadCategoriesIntoComboBox(userId);
               desEncrypter = new DesEncrypter();
          }

          private void guna2HtmlLabel1_Click(object sender, EventArgs e)
          {

          }

          private void btn_update_Click(object sender, EventArgs e)
          {
               string websiteUrl = txt_urlWeb.Text.Trim();
               string usernameForSite = txt_user.Text.Trim();
               string password = txt_pass.Text.Trim();
               string notes = txt_note.Text.Trim();
               string category = cbb_category.SelectedItem?.ToString();

               if (string.IsNullOrEmpty(password))
               {
                    MessageBox.Show("Mật khẩu không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
               }

               // Mã hóa mật khẩu
               byte[] key = desEncrypter.GenerateKey();
               byte[] encryptedPassword = desEncrypter.Encrypt(password, key);

               using (OracleConnection conn = ConnectDatabase.Get_Connect())
               {
                    try
                    {
                         if (conn.State == ConnectionState.Closed)
                              conn.Open();

                         using (OracleCommand cmd = new OracleCommand("UpdatePasswordEntry", conn))
                         {
                              cmd.CommandType = CommandType.StoredProcedure;

                              cmd.Parameters.Add("p_user_id", OracleDbType.Int32).Value = UserID;
                              cmd.Parameters.Add("p_website_name", OracleDbType.Varchar2).Value = WebsiteName;
                              cmd.Parameters.Add("p_website_url", OracleDbType.Varchar2).Value = websiteUrl;
                              cmd.Parameters.Add("p_username_for_site", OracleDbType.Varchar2).Value = usernameForSite;
                              cmd.Parameters.Add("p_encrypted_password", OracleDbType.Varchar2).Value = Convert.ToBase64String(encryptedPassword);
                              cmd.Parameters.Add("p_notes", OracleDbType.Clob).Value = notes;
                              cmd.Parameters.Add("p_category", OracleDbType.Varchar2).Value = category;

                              cmd.ExecuteNonQuery();

                              MessageBox.Show("Cập nhật mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                              this.Close();
                         }
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               }
          }
          public void LoadCategoriesIntoComboBox(int userId)
          {
               List<string> categories = new List<string>();

               using (OracleConnection conn = ConnectDatabase.Get_Connect())
               {
                    try
                    {
                         if (conn.State == ConnectionState.Closed)
                         {
                              conn.Open();
                              //MessageBox.Show("Đăng nhập thành công \nServerVersion: " + conn.ServerVersion);
                         }

                         using (OracleCommand cmd = new OracleCommand("GetCategoriesByUser", conn))
                         {
                              cmd.CommandType = CommandType.StoredProcedure;

                              cmd.Parameters.Add("p_user_id", OracleDbType.Int32).Value = userId;

                              cmd.Parameters.Add("p_result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                              using (OracleDataReader reader = cmd.ExecuteReader())
                              {
                                   while (reader.Read())
                                   {
                                        string category = reader.GetString(reader.GetOrdinal("category_name"));
                                        categories.Add(category);
                                   }
                              }
                         }

                         if (categories.Count > 0)
                         {
                              cbb_category.Items.Clear();
                              cbb_category.Items.AddRange(categories.ToArray());
                         }
                         else
                         {
                              MessageBox.Show("Không có danh mục nào.");
                         }
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Lỗi: " + ex.Message);
                    }
                    finally { if (conn.State == ConnectionState.Open) { conn.Close(); } }
               }
          }
     }
}
