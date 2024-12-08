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

namespace PG_BMHTTT_PMS.Admin
{
     public partial class UserManagementForm : Form
     {
          public UserManagementForm()
          {
               InitializeComponent();
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
                    using (OracleConnection conn = ConnectDatabase.Get_Connect())
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

          private void guna2TextBox1_TextChanged(object sender, EventArgs e)
          {

          }

          private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
          {

          }

          private void guna2HtmlLabel3_Click(object sender, EventArgs e)
          {

          }
     }
}
