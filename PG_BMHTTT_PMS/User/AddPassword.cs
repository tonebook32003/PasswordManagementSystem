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
     public partial class AddPassword : Form
     {
          private int UserID;
          private DesEncrypter desEncrypter;
          private PasswordManagementForm parentForm;

          public AddPassword(int userID, PasswordManagementForm parent)
          {
               InitializeComponent();
               UserID = userID;
               parentForm = parent;
               CenterToScreen();
               LoadCategoriesIntoComboBox(userID);
               desEncrypter = new DesEncrypter();
          }

          private void btn_cancel_Click(object sender, EventArgs e)
          {
               this.Close();
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

          private void btn_save_Click(object sender, EventArgs e)
          {
               string websiteName = txt_webName.Text;
               string websiteUrl = txt_urlWeb.Text;
               string usernameForSite = txt_user.Text;
               string password = txt_pass.Text;
               string notes = txt_pass.Text;
               string category = cbb_category.SelectedItem.ToString();

               // Tạo key và mã hóa mật khẩu
               byte[] key = desEncrypter.GenerateKey();
               byte[] encryptedPassword = desEncrypter.Encrypt(password, key);

               // Thêm dữ liệu vào cơ sở dữ liệu
               using (OracleConnection conn = ConnectDatabase.Get_Connect())
               {
                    try
                    {
                         if (conn.State == ConnectionState.Closed)
                         {
                              conn.Open();
                         }
                         using (OracleCommand cmd = new OracleCommand("AddPasswordEntry", conn))
                         {
                              cmd.CommandType = CommandType.StoredProcedure;
                              cmd.Parameters.Add("p_user_id", OracleDbType.Int32).Value = UserID;
                              cmd.Parameters.Add("p_website_name", OracleDbType.Varchar2).Value = websiteName;
                              cmd.Parameters.Add("p_website_url", OracleDbType.Varchar2).Value = websiteUrl;
                              cmd.Parameters.Add("p_username_for_site", OracleDbType.Varchar2).Value = usernameForSite;
                              cmd.Parameters.Add("p_encrypted_password", OracleDbType.Varchar2).Value = Convert.ToBase64String(encryptedPassword);
                              cmd.Parameters.Add("p_notes", OracleDbType.Clob).Value = notes;
                              cmd.Parameters.Add("p_category", OracleDbType.Varchar2).Value = category;
                              cmd.ExecuteNonQuery();
                         }
                         MessageBox.Show("Đã lưu mật khẩu thành công!");

                         parentForm.LoadPasswordEntries(UserID);
                         this.Close();
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Lỗi: " + ex.Message);
                    }
               }
          }

          private void btn_MCategory_Click(object sender, EventArgs e)
          {
               try
               {
                    if (ConnectDatabase.Get_Connect().State == ConnectionState.Open)
                    {
                         ConnectDatabase.Get_Connect().Close();
                    }

                    Managerment_Category managermentCategoryForm = new Managerment_Category(UserID, this);
                    managermentCategoryForm.Show();
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Error: " + ex.Message);
               }
          }
     }
}
