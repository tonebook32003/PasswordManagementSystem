namespace PG_BMHTTT_PMS.User
{
     partial class PasswordManagementForm
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordManagementForm));
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
               this.btn_update = new Guna.UI2.WinForms.Guna2Button();
               this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
               this.btn_reload = new Guna.UI2.WinForms.Guna2Button();
               this.label2 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.txt_user = new Guna.UI2.WinForms.Guna2TextBox();
               this.txt_website = new Guna.UI2.WinForms.Guna2TextBox();
               this.DataGridView_PasswordEntry = new Guna.UI2.WinForms.Guna2DataGridView();
               this.HD_Website = new System.Windows.Forms.DataGridViewLinkColumn();
               this.HD_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.HD_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.HD_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.btn_new = new Guna.UI2.WinForms.Guna2Button();
               ((System.ComponentModel.ISupportInitialize)(this.DataGridView_PasswordEntry)).BeginInit();
               this.SuspendLayout();
               // 
               // btn_update
               // 
               this.btn_update.BorderRadius = 5;
               this.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.btn_update.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btn_update.ForeColor = System.Drawing.Color.White;
               this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
               this.btn_update.Location = new System.Drawing.Point(211, 479);
               this.btn_update.Margin = new System.Windows.Forms.Padding(2);
               this.btn_update.Name = "btn_update";
               this.btn_update.Size = new System.Drawing.Size(134, 45);
               this.btn_update.TabIndex = 17;
               this.btn_update.Text = "Update";
               // 
               // btn_delete
               // 
               this.btn_delete.BorderRadius = 5;
               this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.btn_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
               this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
               this.btn_delete.ForeColor = System.Drawing.Color.White;
               this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
               this.btn_delete.Location = new System.Drawing.Point(26, 479);
               this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
               this.btn_delete.Name = "btn_delete";
               this.btn_delete.Size = new System.Drawing.Size(134, 45);
               this.btn_delete.TabIndex = 16;
               this.btn_delete.Text = "Delete";
               this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
               // 
               // btn_reload
               // 
               this.btn_reload.BorderRadius = 5;
               this.btn_reload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.btn_reload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.btn_reload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.btn_reload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.btn_reload.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btn_reload.ForeColor = System.Drawing.Color.White;
               this.btn_reload.Image = ((System.Drawing.Image)(resources.GetObject("btn_reload.Image")));
               this.btn_reload.ImageSize = new System.Drawing.Size(30, 30);
               this.btn_reload.Location = new System.Drawing.Point(1136, 11);
               this.btn_reload.Margin = new System.Windows.Forms.Padding(2);
               this.btn_reload.Name = "btn_reload";
               this.btn_reload.Size = new System.Drawing.Size(66, 54);
               this.btn_reload.TabIndex = 15;
               this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(21, 163);
               this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(147, 32);
               this.label2.TabIndex = 14;
               this.label2.Text = "User Search";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(20, 69);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(187, 32);
               this.label1.TabIndex = 13;
               this.label1.Text = "Website Search";
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
               this.txt_user.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txt_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_user.Location = new System.Drawing.Point(26, 198);
               this.txt_user.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.txt_user.Name = "txt_user";
               this.txt_user.PasswordChar = '\0';
               this.txt_user.PlaceholderForeColor = System.Drawing.Color.Black;
               this.txt_user.PlaceholderText = "";
               this.txt_user.SelectedText = "";
               this.txt_user.Size = new System.Drawing.Size(504, 39);
               this.txt_user.TabIndex = 12;
               this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
               // 
               // txt_website
               // 
               this.txt_website.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.txt_website.DefaultText = "";
               this.txt_website.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
               this.txt_website.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
               this.txt_website.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_website.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_website.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_website.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txt_website.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_website.Location = new System.Drawing.Point(26, 104);
               this.txt_website.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.txt_website.Name = "txt_website";
               this.txt_website.PasswordChar = '\0';
               this.txt_website.PlaceholderForeColor = System.Drawing.Color.Black;
               this.txt_website.PlaceholderText = "";
               this.txt_website.SelectedText = "";
               this.txt_website.Size = new System.Drawing.Size(504, 39);
               this.txt_website.TabIndex = 11;
               this.txt_website.TextChanged += new System.EventHandler(this.txt_website_TextChanged);
               // 
               // DataGridView_PasswordEntry
               // 
               dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
               this.DataGridView_PasswordEntry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
               dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
               dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
               dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.DataGridView_PasswordEntry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
               this.DataGridView_PasswordEntry.ColumnHeadersHeight = 25;
               this.DataGridView_PasswordEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
               this.DataGridView_PasswordEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HD_Website,
            this.HD_User,
            this.HD_Password,
            this.HD_Category});
               dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
               dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
               dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
               dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
               dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
               this.DataGridView_PasswordEntry.DefaultCellStyle = dataGridViewCellStyle15;
               this.DataGridView_PasswordEntry.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
               this.DataGridView_PasswordEntry.Location = new System.Drawing.Point(562, 69);
               this.DataGridView_PasswordEntry.Margin = new System.Windows.Forms.Padding(2);
               this.DataGridView_PasswordEntry.Name = "DataGridView_PasswordEntry";
               this.DataGridView_PasswordEntry.RowHeadersVisible = false;
               this.DataGridView_PasswordEntry.RowHeadersWidth = 51;
               this.DataGridView_PasswordEntry.RowTemplate.Height = 24;
               this.DataGridView_PasswordEntry.Size = new System.Drawing.Size(640, 455);
               this.DataGridView_PasswordEntry.TabIndex = 10;
               this.DataGridView_PasswordEntry.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
               this.DataGridView_PasswordEntry.ThemeStyle.AlternatingRowsStyle.Font = null;
               this.DataGridView_PasswordEntry.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
               this.DataGridView_PasswordEntry.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
               this.DataGridView_PasswordEntry.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
               this.DataGridView_PasswordEntry.ThemeStyle.BackColor = System.Drawing.Color.White;
               this.DataGridView_PasswordEntry.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
               this.DataGridView_PasswordEntry.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
               this.DataGridView_PasswordEntry.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
               this.DataGridView_PasswordEntry.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.DataGridView_PasswordEntry.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
               this.DataGridView_PasswordEntry.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
               this.DataGridView_PasswordEntry.ThemeStyle.HeaderStyle.Height = 25;
               this.DataGridView_PasswordEntry.ThemeStyle.ReadOnly = false;
               this.DataGridView_PasswordEntry.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
               this.DataGridView_PasswordEntry.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
               this.DataGridView_PasswordEntry.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.DataGridView_PasswordEntry.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
               this.DataGridView_PasswordEntry.ThemeStyle.RowsStyle.Height = 24;
               this.DataGridView_PasswordEntry.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
               this.DataGridView_PasswordEntry.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
               // 
               // HD_Website
               // 
               this.HD_Website.HeaderText = "Website";
               this.HD_Website.MinimumWidth = 6;
               this.HD_Website.Name = "HD_Website";
               this.HD_Website.Resizable = System.Windows.Forms.DataGridViewTriState.True;
               this.HD_Website.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
               // 
               // HD_User
               // 
               this.HD_User.HeaderText = "User";
               this.HD_User.MinimumWidth = 6;
               this.HD_User.Name = "HD_User";
               this.HD_User.Resizable = System.Windows.Forms.DataGridViewTriState.True;
               this.HD_User.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
               // 
               // HD_Password
               // 
               this.HD_Password.HeaderText = "Password";
               this.HD_Password.MinimumWidth = 6;
               this.HD_Password.Name = "HD_Password";
               this.HD_Password.Resizable = System.Windows.Forms.DataGridViewTriState.True;
               this.HD_Password.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
               // 
               // HD_Category
               // 
               this.HD_Category.HeaderText = "Category";
               this.HD_Category.MinimumWidth = 6;
               this.HD_Category.Name = "HD_Category";
               // 
               // btn_new
               // 
               this.btn_new.BorderRadius = 5;
               this.btn_new.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.btn_new.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.btn_new.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.btn_new.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.btn_new.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
               this.btn_new.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btn_new.ForeColor = System.Drawing.Color.White;
               this.btn_new.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.Image")));
               this.btn_new.Location = new System.Drawing.Point(395, 479);
               this.btn_new.Margin = new System.Windows.Forms.Padding(2);
               this.btn_new.Name = "btn_new";
               this.btn_new.Size = new System.Drawing.Size(135, 45);
               this.btn_new.TabIndex = 9;
               this.btn_new.Text = "New";
               this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
               // 
               // PasswordManagementForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1213, 535);
               this.Controls.Add(this.btn_update);
               this.Controls.Add(this.btn_delete);
               this.Controls.Add(this.btn_reload);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.txt_user);
               this.Controls.Add(this.txt_website);
               this.Controls.Add(this.DataGridView_PasswordEntry);
               this.Controls.Add(this.btn_new);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "PasswordManagementForm";
               this.Text = "PasswordManagementForm";
               this.Load += new System.EventHandler(this.Managerment_Password_Load);
               ((System.ComponentModel.ISupportInitialize)(this.DataGridView_PasswordEntry)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private Guna.UI2.WinForms.Guna2Button btn_update;
          private Guna.UI2.WinForms.Guna2Button btn_delete;
          private Guna.UI2.WinForms.Guna2Button btn_reload;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label1;
          private Guna.UI2.WinForms.Guna2TextBox txt_user;
          private Guna.UI2.WinForms.Guna2TextBox txt_website;
          private Guna.UI2.WinForms.Guna2DataGridView DataGridView_PasswordEntry;
          private System.Windows.Forms.DataGridViewLinkColumn HD_Website;
          private System.Windows.Forms.DataGridViewTextBoxColumn HD_User;
          private System.Windows.Forms.DataGridViewTextBoxColumn HD_Password;
          private System.Windows.Forms.DataGridViewTextBoxColumn HD_Category;
          private Guna.UI2.WinForms.Guna2Button btn_new;
     }
}