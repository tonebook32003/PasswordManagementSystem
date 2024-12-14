namespace PG_BMHTTT_PMS
{
     partial class HomePageForm
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
               this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
               this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
               ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // guna2PictureBox1
               // 
               this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
               this.guna2PictureBox1.ImageRotate = 0F;
               this.guna2PictureBox1.Location = new System.Drawing.Point(444, 131);
               this.guna2PictureBox1.Name = "guna2PictureBox1";
               this.guna2PictureBox1.Size = new System.Drawing.Size(300, 200);
               this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.guna2PictureBox1.TabIndex = 0;
               this.guna2PictureBox1.TabStop = false;
               // 
               // guna2HtmlLabel1
               // 
               this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
               this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.guna2HtmlLabel1.Location = new System.Drawing.Point(297, 337);
               this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
               this.guna2HtmlLabel1.Size = new System.Drawing.Size(608, 46);
               this.guna2HtmlLabel1.TabIndex = 26;
               this.guna2HtmlLabel1.Text = "PASSWORD MANAGEMENT SYSTEM";
               // 
               // HomePageForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1245, 606);
               this.Controls.Add(this.guna2HtmlLabel1);
               this.Controls.Add(this.guna2PictureBox1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "HomePageForm";
               this.Text = "HomePageForm";
               ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
          private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
     }
}