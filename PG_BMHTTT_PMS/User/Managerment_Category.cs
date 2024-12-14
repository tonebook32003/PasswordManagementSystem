using Oracle.ManagedDataAccess.Client;
using PG_BMHTTT_PMS.Model;
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
     public partial class Managerment_Category : Form
     {
          private int UserID;
          private AddPassword parentForm;
          string username, password;
          public Managerment_Category(int userID, AddPassword parent, string username, string password)
          {
               InitializeComponent();
               UserID = userID;
               parentForm = parent;
               CenterToScreen();
               LoadCategoriesIntoGridView(UserID);
               this.username = username;
               this.password = password;
          }
          public void LoadCategoriesIntoGridView(int userId, string categorySearch = null)
          {
               List<Category> categories = new List<Category>();

               using (OracleConnection conn = ConnectDatabase.Get_Connect(username, password))
               {
                    try
                    {
                         if (conn.State == ConnectionState.Closed)
                         {
                              conn.Open();
                              //MessageBox.Show("Đăng nhập thành công \nServerVersion: " + conn.ServerVersion);
                         }

                         using (OracleCommand cmd = new OracleCommand("SearchCategoriesByName", conn))
                         {
                              cmd.CommandType = CommandType.StoredProcedure;

                              cmd.Parameters.Add("p_user_id", OracleDbType.Int32).Value = userId;
                              cmd.Parameters.Add("p_category_name", OracleDbType.Varchar2).Value =
                                  string.IsNullOrEmpty(categorySearch) ? null : categorySearch;

                              cmd.Parameters.Add("p_result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                              using (OracleDataReader reader = cmd.ExecuteReader())
                              {
                                   while (reader.Read())
                                   {
                                        categories.Add(new Category
                                        {
                                             //CategoryId = reader.GetInt32(reader.GetOrdinal("category_id")),
                                             CategoryName = reader.GetString(reader.GetOrdinal("category_name")),
                                             Description = reader.IsDBNull(reader.GetOrdinal("description"))
                                                ? null
                                                : reader.GetString(reader.GetOrdinal("description"))
                                        });
                                   }
                              }
                         }

                         DataGridView_Category.Rows.Clear();
                         if (categories.Count > 0)
                         {
                              foreach (var category in categories)
                              {
                                   DataGridView_Category.Rows.Add(category.CategoryName, category.Description);
                              }
                         }
                         else
                         {
                              MessageBox.Show("No data found.");
                         }
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Error: " + ex.Message);
                    }
                    finally { if (conn.State == ConnectionState.Open) { conn.Close(); } }
               }
          }

          private void txt_category_TextChanged(object sender, EventArgs e)
          {
               string searchKeyword = txt_category_Search.Text;
               LoadCategoriesIntoGridView(UserID, searchKeyword);
          }

          private void btn_clear_Click(object sender, EventArgs e)
          {
               txt_categoryName.Text = string.Empty;
               txt_Description.Text = string.Empty;
               txt_category_Search.Text = string.Empty;
          }

          private void btn_save_Click(object sender, EventArgs e)
          {
               string categoryName = txt_categoryName.Text.Trim();
               string description = txt_Description.Text.Trim();

               if (string.IsNullOrEmpty(categoryName))
               {
                    MessageBox.Show("Category name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
               }

               if (categoryName.Length > 50)
               {
                    MessageBox.Show("Category name cannot exceed 50 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
               }

               try
               {
                    using (OracleConnection conn = ConnectDatabase.Get_Connect(username, password))
                    {
                         if (conn.State == ConnectionState.Closed)
                              conn.Open();

                         using (OracleCommand cmdCheck = new OracleCommand("CheckCategoryExists", conn))
                         {
                              cmdCheck.CommandType = CommandType.StoredProcedure;

                              cmdCheck.Parameters.Add("p_user_id", OracleDbType.Int32).Value = UserID; // UserID
                              cmdCheck.Parameters.Add("p_category_name", OracleDbType.Varchar2).Value = categoryName;
                              cmdCheck.Parameters.Add("p_exists", OracleDbType.Int32).Direction = ParameterDirection.Output;

                              cmdCheck.ExecuteNonQuery();

                              int exists = Convert.ToInt32(cmdCheck.Parameters["p_exists"].Value.ToString());

                              if (exists == 1)
                              {
                                   MessageBox.Show("Category already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                   return;
                              }
                         }

                         using (OracleCommand cmd = new OracleCommand("AddCategory", conn))
                         {
                              cmd.CommandType = CommandType.StoredProcedure;

                              cmd.Parameters.Add("p_user_id", OracleDbType.Int32).Value = UserID; // UserID 
                              cmd.Parameters.Add("p_category_name", OracleDbType.Varchar2).Value = categoryName;
                              cmd.Parameters.Add("p_description", OracleDbType.Varchar2).Value = description;

                              cmd.ExecuteNonQuery();

                              MessageBox.Show("Category saved successfully.");

                              LoadCategoriesIntoGridView(UserID);

                              parentForm.LoadCategoriesIntoComboBox(UserID);
                         }
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
          }

          private void DataGridView_Category_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               if (e.RowIndex >= 0)
               {
                    string categoryName = DataGridView_Category.Rows[e.RowIndex].Cells["HD_CategoryName"].Value?.ToString() ?? string.Empty;
                    string description = DataGridView_Category.Rows[e.RowIndex].Cells["HD_Description"].Value?.ToString() ?? string.Empty;

                    txt_categoryName.Text = categoryName;
                    txt_Description.Text = description;
               }
          }

          private void btn_delete_Click(object sender, EventArgs e)
          {
               if (DataGridView_Category.SelectedRows.Count > 0)
               {
                    int selectedIndex = DataGridView_Category.SelectedRows[0].Index;
                    //int categoryId = Convert.ToInt32(DataGridView_Category.Rows[selectedIndex].Cells["CategoryId"].Value);
                    string categoryName = DataGridView_Category.Rows[selectedIndex].Cells["HD_CategoryName"].Value.ToString();

                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete the category '{categoryName}'?",
                                                               "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                         try
                         {
                              using (OracleConnection conn = ConnectDatabase.Get_Connect(username, password))
                              {
                                   if (conn.State == ConnectionState.Closed)
                                        conn.Open();

                                   using (OracleCommand cmd = new OracleCommand("DeleteCategory", conn))
                                   {
                                        cmd.CommandType = CommandType.StoredProcedure;

                                        cmd.Parameters.Add("p_category_name", OracleDbType.NVarchar2).Value = categoryName;
                                        cmd.Parameters.Add("p_user_id", OracleDbType.Int32).Value = UserID;

                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        LoadCategoriesIntoGridView(UserID);
                                        parentForm.LoadCategoriesIntoComboBox(UserID);
                                   }
                              }
                         }
                         catch (Exception ex)
                         {
                              MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                    }
               }
               else
               {
                    MessageBox.Show("Please select a category to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
          }

          private void DataGridView_Category_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }

          private void btn_reload_Click(object sender, EventArgs e)
          {
               LoadCategoriesIntoGridView(UserID);
          }
     }
}
