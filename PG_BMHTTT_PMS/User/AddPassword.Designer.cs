namespace PG_BMHTTT_PMS.User
{
     partial class AddPassword
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPassword));
               this.btn_MCategory = new Guna.UI2.WinForms.Guna2Button();
               this.label6 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.btn_save = new Guna.UI2.WinForms.Guna2Button();
               this.txt_note = new Guna.UI2.WinForms.Guna2TextBox();
               this.cbb_category = new Guna.UI2.WinForms.Guna2ComboBox();
               this.txt_pass = new Guna.UI2.WinForms.Guna2TextBox();
               this.txt_user = new Guna.UI2.WinForms.Guna2TextBox();
               this.txt_urlWeb = new Guna.UI2.WinForms.Guna2TextBox();
               this.txt_webName = new Guna.UI2.WinForms.Guna2TextBox();
               this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
               this.closeBtn = new Guna.UI2.WinForms.Guna2Button();
               this.label7 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
               this.guna2Panel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // btn_MCategory
               // 
               this.btn_MCategory.BorderRadius = 5;
               this.btn_MCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.btn_MCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.btn_MCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.btn_MCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.btn_MCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btn_MCategory.ForeColor = System.Drawing.Color.White;
               this.btn_MCategory.Location = new System.Drawing.Point(414, 345);
               this.btn_MCategory.Margin = new System.Windows.Forms.Padding(2);
               this.btn_MCategory.Name = "btn_MCategory";
               this.btn_MCategory.Size = new System.Drawing.Size(156, 48);
               this.btn_MCategory.TabIndex = 33;
               this.btn_MCategory.Text = "Category";
               this.btn_MCategory.Click += new System.EventHandler(this.btn_MCategory_Click);
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.Location = new System.Drawing.Point(301, 175);
               this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(66, 17);
               this.label6.TabIndex = 32;
               this.label6.Text = "Password";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.Location = new System.Drawing.Point(301, 84);
               this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(78, 17);
               this.label5.TabIndex = 31;
               this.label5.Text = "Website Url";
               // 
               // btn_save
               // 
               this.btn_save.BorderRadius = 5;
               this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.btn_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
               this.btn_save.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btn_save.ForeColor = System.Drawing.Color.White;
               this.btn_save.Location = new System.Drawing.Point(20, 345);
               this.btn_save.Margin = new System.Windows.Forms.Padding(2);
               this.btn_save.Name = "btn_save";
               this.btn_save.Size = new System.Drawing.Size(172, 48);
               this.btn_save.TabIndex = 29;
               this.btn_save.Text = "Save";
               this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
               // 
               // txt_note
               // 
               this.txt_note.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.txt_note.DefaultText = "";
               this.txt_note.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
               this.txt_note.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
               this.txt_note.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_note.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_note.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_note.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txt_note.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_note.Location = new System.Drawing.Point(20, 280);
               this.txt_note.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.txt_note.Name = "txt_note";
               this.txt_note.PasswordChar = '\0';
               this.txt_note.PlaceholderText = "";
               this.txt_note.SelectedText = "";
               this.txt_note.Size = new System.Drawing.Size(375, 36);
               this.txt_note.TabIndex = 28;
               // 
               // cbb_category
               // 
               this.cbb_category.BackColor = System.Drawing.Color.Transparent;
               this.cbb_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
               this.cbb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.cbb_category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.cbb_category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.cbb_category.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.cbb_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
               this.cbb_category.ItemHeight = 30;
               this.cbb_category.Location = new System.Drawing.Point(414, 280);
               this.cbb_category.Margin = new System.Windows.Forms.Padding(2);
               this.cbb_category.Name = "cbb_category";
               this.cbb_category.Size = new System.Drawing.Size(156, 36);
               this.cbb_category.TabIndex = 27;
               // 
               // txt_pass
               // 
               this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.txt_pass.DefaultText = "";
               this.txt_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
               this.txt_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
               this.txt_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_pass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txt_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_pass.Location = new System.Drawing.Point(304, 195);
               this.txt_pass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.txt_pass.Name = "txt_pass";
               this.txt_pass.PasswordChar = '\0';
               this.txt_pass.PlaceholderText = "";
               this.txt_pass.SelectedText = "";
               this.txt_pass.Size = new System.Drawing.Size(266, 39);
               this.txt_pass.TabIndex = 26;
               // 
               // txt_user
               // 
               this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.txt_user.DefaultText = "";
               this.txt_user.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
               this.txt_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
               this.txt_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_user.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_user.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txt_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_user.Location = new System.Drawing.Point(20, 195);
               this.txt_user.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.txt_user.Name = "txt_user";
               this.txt_user.PasswordChar = '\0';
               this.txt_user.PlaceholderText = "";
               this.txt_user.SelectedText = "";
               this.txt_user.Size = new System.Drawing.Size(250, 39);
               this.txt_user.TabIndex = 25;
               // 
               // txt_urlWeb
               // 
               this.txt_urlWeb.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.txt_urlWeb.DefaultText = "";
               this.txt_urlWeb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
               this.txt_urlWeb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
               this.txt_urlWeb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_urlWeb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_urlWeb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_urlWeb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txt_urlWeb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_urlWeb.Location = new System.Drawing.Point(304, 104);
               this.txt_urlWeb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.txt_urlWeb.Name = "txt_urlWeb";
               this.txt_urlWeb.PasswordChar = '\0';
               this.txt_urlWeb.PlaceholderText = "";
               this.txt_urlWeb.SelectedText = "";
               this.txt_urlWeb.Size = new System.Drawing.Size(266, 39);
               this.txt_urlWeb.TabIndex = 24;
               // 
               // txt_webName
               // 
               this.txt_webName.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.txt_webName.DefaultText = "";
               this.txt_webName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
               this.txt_webName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
               this.txt_webName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_webName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_webName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_webName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txt_webName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_webName.Location = new System.Drawing.Point(20, 104);
               this.txt_webName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.txt_webName.Name = "txt_webName";
               this.txt_webName.PasswordChar = '\0';
               this.txt_webName.PlaceholderText = "";
               this.txt_webName.SelectedText = "";
               this.txt_webName.Size = new System.Drawing.Size(250, 39);
               this.txt_webName.TabIndex = 23;
               // 
               // guna2Panel1
               // 
               this.guna2Panel1.Controls.Add(this.closeBtn);
               this.guna2Panel1.Controls.Add(this.label7);
               this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
               this.guna2Panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
               this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
               this.guna2Panel1.Name = "guna2Panel1";
               this.guna2Panel1.Size = new System.Drawing.Size(603, 54);
               this.guna2Panel1.TabIndex = 22;
               // 
               // closeBtn
               // 
               this.closeBtn.BackColor = System.Drawing.Color.Transparent;
               this.closeBtn.BorderColor = System.Drawing.Color.Transparent;
               this.closeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.closeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.closeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.closeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.closeBtn.FillColor = System.Drawing.Color.Transparent;
               this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.closeBtn.ForeColor = System.Drawing.Color.White;
               this.closeBtn.HoverState.BorderColor = System.Drawing.Color.Transparent;
               this.closeBtn.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
               this.closeBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
               this.closeBtn.HoverState.ForeColor = System.Drawing.Color.Transparent;
               this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
               this.closeBtn.Location = new System.Drawing.Point(552, 0);
               this.closeBtn.Name = "closeBtn";
               this.closeBtn.Size = new System.Drawing.Size(51, 48);
               this.closeBtn.TabIndex = 55;
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label7.Location = new System.Drawing.Point(219, 11);
               this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(132, 32);
               this.label7.TabIndex = 1;
               this.label7.Text = "ADD ITEM";
               this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.Location = new System.Drawing.Point(18, 260);
               this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(38, 17);
               this.label4.TabIndex = 37;
               this.label4.Text = "Note";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(411, 260);
               this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(64, 17);
               this.label3.TabIndex = 36;
               this.label3.Text = "Category";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(18, 175);
               this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(35, 17);
               this.label2.TabIndex = 35;
               this.label2.Text = "User";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(17, 84);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(97, 17);
               this.label1.TabIndex = 34;
               this.label1.Text = "Website Name";
               // 
               // btn_cancel
               // 
               this.btn_cancel.BorderRadius = 5;
               this.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.btn_cancel.FillColor = System.Drawing.Color.Red;
               this.btn_cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
               this.btn_cancel.ForeColor = System.Drawing.Color.White;
               this.btn_cancel.Location = new System.Drawing.Point(209, 345);
               this.btn_cancel.Name = "btn_cancel";
               this.btn_cancel.Size = new System.Drawing.Size(186, 48);
               this.btn_cancel.TabIndex = 38;
               this.btn_cancel.Text = "Cancel";
               this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
               // 
               // AddPassword
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(603, 416);
               this.Controls.Add(this.btn_cancel);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.btn_MCategory);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.btn_save);
               this.Controls.Add(this.txt_note);
               this.Controls.Add(this.cbb_category);
               this.Controls.Add(this.txt_pass);
               this.Controls.Add(this.txt_user);
               this.Controls.Add(this.txt_urlWeb);
               this.Controls.Add(this.txt_webName);
               this.Controls.Add(this.guna2Panel1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "AddPassword";
               this.Text = "AddPassword";
               this.guna2Panel1.ResumeLayout(false);
               this.guna2Panel1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private Guna.UI2.WinForms.Guna2Button btn_MCategory;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.Label label5;
          private Guna.UI2.WinForms.Guna2Button btn_save;
          private Guna.UI2.WinForms.Guna2TextBox txt_note;
          private Guna.UI2.WinForms.Guna2ComboBox cbb_category;
          private Guna.UI2.WinForms.Guna2TextBox txt_pass;
          private Guna.UI2.WinForms.Guna2TextBox txt_user;
          private Guna.UI2.WinForms.Guna2TextBox txt_urlWeb;
          private Guna.UI2.WinForms.Guna2TextBox txt_webName;
          private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label1;
          private Guna.UI2.WinForms.Guna2Button btn_cancel;
          private Guna.UI2.WinForms.Guna2Button closeBtn;
     }
}