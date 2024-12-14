using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG_BMHTTT_PMS.Admin
{
     public partial class AnalysticForm : Form
     {
          string username, password;
          public AnalysticForm(string username, string password)
          {
               InitializeComponent();
               this.username = username;
               this.password = password; 
          }

          private void AnalysticForm_Load(object sender, EventArgs e)
          {

          }

          private void guna2HtmlLabel9_Click(object sender, EventArgs e)
          {

          }
     }
}
