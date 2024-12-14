namespace PG_BMHTTT_PMS.Admin
{
     partial class AddUserForm
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
               this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
               this.label1 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.btnSave = new Guna.UI2.WinForms.Guna2Button();
               this.txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
               this.txt_Email = new Guna.UI2.WinForms.Guna2TextBox();
               this.txt_Username = new Guna.UI2.WinForms.Guna2TextBox();
               this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
               this.pictureBoxHidePass = new System.Windows.Forms.PictureBox();
               this.pictureBoxShowPass = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHidePass)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPass)).BeginInit();
               this.SuspendLayout();
               // 
               // btnCancel
               // 
               this.btnCancel.BorderRadius = 5;
               this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.btnCancel.FillColor = System.Drawing.Color.Red;
               this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
               this.btnCancel.ForeColor = System.Drawing.Color.White;
               this.btnCancel.Location = new System.Drawing.Point(184, 355);
               this.btnCancel.Name = "btnCancel";
               this.btnCancel.Size = new System.Drawing.Size(133, 36);
               this.btnCancel.TabIndex = 53;
               this.btnCancel.Text = "Cancel";
               this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(48, 106);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(69, 17);
               this.label1.TabIndex = 49;
               this.label1.Text = "Username";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.Location = new System.Drawing.Point(48, 271);
               this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(66, 17);
               this.label6.TabIndex = 47;
               this.label6.Text = "Password";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.Location = new System.Drawing.Point(48, 184);
               this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(40, 17);
               this.label5.TabIndex = 46;
               this.label5.Text = "Email";
               // 
               // btnSave
               // 
               this.btnSave.BorderRadius = 5;
               this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
               this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnSave.ForeColor = System.Drawing.Color.White;
               this.btnSave.Location = new System.Drawing.Point(51, 355);
               this.btnSave.Margin = new System.Windows.Forms.Padding(2);
               this.btnSave.Name = "btnSave";
               this.btnSave.Size = new System.Drawing.Size(128, 36);
               this.btnSave.TabIndex = 45;
               this.btnSave.Text = "Save";
               this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
               // 
               // txt_Password
               // 
               this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.txt_Password.DefaultText = "";
               this.txt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
               this.txt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
               this.txt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txt_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_Password.Location = new System.Drawing.Point(51, 291);
               this.txt_Password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.txt_Password.Name = "txt_Password";
               this.txt_Password.PasswordChar = '●';
               this.txt_Password.PlaceholderText = "";
               this.txt_Password.SelectedText = "";
               this.txt_Password.Size = new System.Drawing.Size(266, 39);
               this.txt_Password.TabIndex = 42;
               // 
               // txt_Email
               // 
               this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.txt_Email.DefaultText = "";
               this.txt_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
               this.txt_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
               this.txt_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txt_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_Email.Location = new System.Drawing.Point(51, 204);
               this.txt_Email.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.txt_Email.Name = "txt_Email";
               this.txt_Email.PasswordChar = '\0';
               this.txt_Email.PlaceholderText = "";
               this.txt_Email.SelectedText = "";
               this.txt_Email.Size = new System.Drawing.Size(266, 39);
               this.txt_Email.TabIndex = 40;
               // 
               // txt_Username
               // 
               this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.txt_Username.DefaultText = "";
               this.txt_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
               this.txt_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
               this.txt_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_Username.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txt_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_Username.Location = new System.Drawing.Point(51, 126);
               this.txt_Username.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.txt_Username.Name = "txt_Username";
               this.txt_Username.PasswordChar = '\0';
               this.txt_Username.PlaceholderText = "";
               this.txt_Username.SelectedText = "";
               this.txt_Username.Size = new System.Drawing.Size(266, 39);
               this.txt_Username.TabIndex = 39;
               // 
               // guna2CirclePictureBox1
               // 
               this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
               this.guna2CirclePictureBox1.ImageRotate = 0F;
               this.guna2CirclePictureBox1.Location = new System.Drawing.Point(156, 24);
               this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
               this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
               this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
               this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
               this.guna2CirclePictureBox1.TabIndex = 54;
               this.guna2CirclePictureBox1.TabStop = false;
               // 
               // pictureBoxHidePass
               // 
               this.pictureBoxHidePass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
               this.pictureBoxHidePass.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHidePass.Image")));
               this.pictureBoxHidePass.Location = new System.Drawing.Point(263, 299);
               this.pictureBoxHidePass.Name = "pictureBoxHidePass";
               this.pictureBoxHidePass.Size = new System.Drawing.Size(47, 24);
               this.pictureBoxHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBoxHidePass.TabIndex = 59;
               this.pictureBoxHidePass.TabStop = false;
               this.pictureBoxHidePass.Click += new System.EventHandler(this.pictureBoxHidePass_Click);
               // 
               // pictureBoxShowPass
               // 
               this.pictureBoxShowPass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
               this.pictureBoxShowPass.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShowPass.Image")));
               this.pictureBoxShowPass.Location = new System.Drawing.Point(263, 299);
               this.pictureBoxShowPass.Name = "pictureBoxShowPass";
               this.pictureBoxShowPass.Size = new System.Drawing.Size(47, 24);
               this.pictureBoxShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBoxShowPass.TabIndex = 58;
               this.pictureBoxShowPass.TabStop = false;
               this.pictureBoxShowPass.Click += new System.EventHandler(this.pictureBoxShowPass_Click);
               // 
               // AddUserForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(375, 421);
               this.Controls.Add(this.pictureBoxHidePass);
               this.Controls.Add(this.pictureBoxShowPass);
               this.Controls.Add(this.guna2CirclePictureBox1);
               this.Controls.Add(this.btnCancel);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.btnSave);
               this.Controls.Add(this.txt_Password);
               this.Controls.Add(this.txt_Email);
               this.Controls.Add(this.txt_Username);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.Name = "AddUserForm";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "AddUser";
               ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHidePass)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPass)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private Guna.UI2.WinForms.Guna2Button btnCancel;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.Label label5;
          private Guna.UI2.WinForms.Guna2Button btnSave;
          private Guna.UI2.WinForms.Guna2TextBox txt_Password;
          private Guna.UI2.WinForms.Guna2TextBox txt_Email;
          private Guna.UI2.WinForms.Guna2TextBox txt_Username;
          private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
          private System.Windows.Forms.PictureBox pictureBoxHidePass;
          private System.Windows.Forms.PictureBox pictureBoxShowPass;
     }
}