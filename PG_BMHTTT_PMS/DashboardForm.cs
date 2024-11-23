using PG_BMHTTT_PMS.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


          private void closeBtn_Click(object sender, EventArgs e)
          {
               DialogResult result = MessageBox.Show("Are you sure you want to exit??", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (result == DialogResult.Yes)
               {
                    this.Close();
               }
          }
          private void btnHomePage_Click(object sender, EventArgs e)
          {
               HomePageForm homePageForm = new HomePageForm() { TopLevel = false, TopMost = true };
               DisplayFormPanel.Controls.Add(homePageForm);
               homePageForm.Show();
          }

          private void btnAnalystic_Click(object sender, EventArgs e)
          {
               AnalysticForm analysticForm = new AnalysticForm() { TopLevel = false, TopMost = true };
               DisplayFormPanel.Controls.Add(analysticForm);
               analysticForm.Show();
          }
     }
}
