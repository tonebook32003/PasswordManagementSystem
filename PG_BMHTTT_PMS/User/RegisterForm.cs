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
     public partial class RegisterForm : Form
     {
          public RegisterForm()
          {
               InitializeComponent();
          }
          private class RegisterUser
          {
               public string Email { get; set; }
               public string Username { get; set; }
               public string Password { get; set; }

               public RegisterUser(string email,string username, string password)
               {
                    Username = username;
                    Password = password;
                    Email = email;
               }
          }
          private void loginButton_Click(object sender, EventArgs e)
          {
               LoginForm loginForm = new LoginForm();
               loginForm.ShowDialog();
               this.Close();
          }

          private void closeBtn_Click(object sender, EventArgs e)
          {
               DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (result == DialogResult.Yes) 
               {
                    this.Close();
               }
          }

          private void registerBtn_Click(object sender, EventArgs e)
          {
               MessageBox.Show("Register successfully!", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
     }
}
