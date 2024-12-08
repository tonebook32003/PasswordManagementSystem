using PG_BMHTTT_PMS.Admin;
using PG_BMHTTT_PMS.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace PG_BMHTTT_PMS
{
     public partial class DashboardForm : Form
     {
          public DashboardForm()
          {
               InitializeComponent();
          }


          private void DashboardForm_Load(object sender, EventArgs e)
          {
          }

          private void logoutBtn_Click(object sender, EventArgs e)
          {
               DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?","Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

               if (result == DialogResult.Yes)
               {
                    this.Close();
                    LoginForm loginForm = new LoginForm();
                    loginForm.ShowDialog();
               }
          }

          public void ViewChildForm(object Form){
               if (this.DisplayFormPanel.Controls.Count > 0){
                    this.DisplayFormPanel.Controls.RemoveAt(0);
               }
               Form f = Form as Form;
               f.TopLevel = false;
               f.Dock = DockStyle.Fill;

               this.DisplayFormPanel.Controls.Add(f);
               this.DisplayFormPanel.Tag = f;
               f.Show();
          }
          
          private void btnHomePage_Click(object sender, EventArgs e)
          {
               ViewChildForm(new HomePageForm());
          }

          private void btnAnalystic_Click(object sender, EventArgs e)
          {
               ViewChildForm(new AnalysticForm());
          }

          private void btnUserManagement_Click(object sender, EventArgs e)
          {
               ViewChildForm(new UserManagementForm());
          }

          private void btnSettings_Click(object sender, EventArgs e)
          {
               ViewChildForm(new UserManagementForm());
          }

          private void btnPassManagement_Click(object sender, EventArgs e)
          {
               ViewChildForm(new PasswordManagementForm());
          }
          private void closeBtn_Click(object sender, EventArgs e)
          {
               DialogResult result = MessageBox.Show("Are you sure you want to exit??", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (result == DialogResult.Yes)
               {
                    this.Close();
               }
          }
     }
}
