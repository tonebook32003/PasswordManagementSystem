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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PG_BMHTTT_PMS.Admin
{
     public partial class UserManagementForm : Form
     {
          string username, password;
          public UserManagementForm(string username, string password)
          {
               InitializeComponent();
               this.username = username;
               this.password = password;
          }
          private void LoadDataToDataGridview(){
               //try
               //{
               //     using (OracleConnection conn = ConnectDatabase.Get_Connect()){
               //          string query = "SELECT * FROM c##PG_BMHTTT_PMS.USERS";
               //          using (OracleCommand cmd = new OracleCommand(query, conn)) {
               //               //cmd.Connection = conn;
               //               OracleDataAdapter adapter = new OracleDataAdapter(cmd);
               //               DataTable dt = new DataTable();
               //               adapter.Fill(dt);
               //               dtgUsers.DataSource = dt;
               //               dtgUsers.AutoResizeColumns();
               //          }
               //     }
               //} 
               //catch(Exception ex)
               //{
               //     MessageBox.Show("Error loading data: ", ex.Message);
               //}

               try
               {
                    using (OracleConnection conn = ConnectDatabase.Get_Connect(username, password))
                    {
                         string query = "SELECT * FROM c##PG_BMHTTT_PMS.USERS";
                         using (OracleCommand cmd = new OracleCommand(query, conn))
                         {
                              //cmd.Connection = conn;
                              OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                              DataTable dt = new DataTable();
                              adapter.Fill(dt);
                              dtgUsers.DataSource = dt;
                              dtgUsers.Columns["user_id"].HeaderText = "ID";
                              dtgUsers.Columns["username"].HeaderText = "Username";
                              dtgUsers.Columns["email"].HeaderText = "Email";
                              dtgUsers.Columns["master_password"].HeaderText = "Master Password";
                              dtgUsers.Columns["salt"].HeaderText = "Salt";
                              dtgUsers.Columns["created_date"].HeaderText = "Created date";
                              dtgUsers.Columns["last_login"].HeaderText = "Last Login";
                              dtgUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                              dtgUsers.RowTemplate.Height = 40;
                         }
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Error loading data: ", ex.Message);
               }
          }

          private void UserManagementForm_Load(object sender, EventArgs e)
          {
               LoadDataToDataGridview();
          }

          private void btnDelete_Click(object sender, EventArgs e)
          {
               // Kiểm tra xem có dòng nào được chọn không
               if (dtgUsers.SelectedRows.Count == 0)
               {
                    MessageBox.Show("Please select a user to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
               }

               // Lấy thông tin user được chọn
               DataGridViewRow selectedRow = dtgUsers.SelectedRows[0];
               string username = selectedRow.Cells["username"].Value.ToString();

               DialogResult result = MessageBox.Show($"Are you sure you want to delete user '{username}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

               if (result == DialogResult.Yes)
               {
                    try
                    {
                         using (OracleConnection conn = ConnectDatabase.Get_Connect(this.username, this.password))
                         {
                              string deleteQuery = "DELETE FROM c##PG_BMHTTT_PMS.USERS WHERE username = :username";
                              using (OracleCommand cmd = new OracleCommand(deleteQuery, conn))
                              {
                                   cmd.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;
                                   int rowsAffected = cmd.ExecuteNonQuery();

                                   if (rowsAffected > 0)
                                   {
                                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        
                                        // Reload lại data
                                        LoadDataToDataGridview();
                                   }
                                   else
                                   {
                                        MessageBox.Show("Failed to delete user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                   }
                              }
                         }
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               }
          }

          private void searchTextBox_TextChanged(object sender, EventArgs e)
          {
               string searchText = searchTextBox.Text.Trim().ToLower();
               
               if (dtgUsers.DataSource is DataTable dataTable)
               {
                    DataView dv = dataTable.DefaultView;
                    if (string.IsNullOrEmpty(searchText))
                    {
                         dv.RowFilter = string.Empty; // Hiển thị tất cả dữ liệu
                    }
                    else
                    {
                         // Tìm kiếm trên các cột cụ thể
                         dv.RowFilter = string.Format("username LIKE '%{0}%' OR email LIKE '%{0}%'", searchText.Replace("'", "''"));
                    }
               }
          }

          private void btnReload_Click(object sender, EventArgs e)
          {
               searchTextBox.Clear();
               
               LoadDataToDataGridview();
               
               MessageBox.Show("Data has been reloaded successfully!", "Reload Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }

          private void btnAdd_Click(object sender, EventArgs e)
          {
               AddUserForm addUserForm = new AddUserForm(username, password);
               if (addUserForm.ShowDialog() == DialogResult.OK)
               {
                    // Nếu thêm thành công, reload lại data
                    LoadDataToDataGridview();
               }
          }

     }
}
