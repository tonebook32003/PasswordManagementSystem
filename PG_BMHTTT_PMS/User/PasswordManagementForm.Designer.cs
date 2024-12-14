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
               this.components = new System.ComponentModel.Container();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordManagementForm));
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
               this.Password = new Guna.UI2.WinForms.Guna2Panel();
               this.labelNumberOfPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
               this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
               this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
               this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
               this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
               this.Website = new Guna.UI2.WinForms.Guna2Panel();
               this.labelNumberOfWebsite = new Guna.UI2.WinForms.Guna2HtmlLabel();
               this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
               this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
               this.Expired = new Guna.UI2.WinForms.Guna2Panel();
               this.labelNumberOfPasswordExpired = new Guna.UI2.WinForms.Guna2HtmlLabel();
               this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
               this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
               this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
               this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
               this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
               this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
               ((System.ComponentModel.ISupportInitialize)(this.DataGridView_PasswordEntry)).BeginInit();
               this.Password.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
               this.Website.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
               this.Expired.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
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
               this.btn_update.Location = new System.Drawing.Point(1069, 508);
               this.btn_update.Margin = new System.Windows.Forms.Padding(2);
               this.btn_update.Name = "btn_update";
               this.btn_update.Size = new System.Drawing.Size(135, 87);
               this.btn_update.TabIndex = 17;
               this.btn_update.Text = "Update";
               this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
               // 
               // btn_delete
               // 
               this.btn_delete.BorderRadius = 5;
               this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.btn_delete.FillColor = System.Drawing.Color.Red;
               this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
               this.btn_delete.ForeColor = System.Drawing.Color.White;
               this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
               this.btn_delete.Location = new System.Drawing.Point(1069, 400);
               this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
               this.btn_delete.Name = "btn_delete";
               this.btn_delete.Size = new System.Drawing.Size(135, 87);
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
               this.btn_reload.Location = new System.Drawing.Point(1069, 182);
               this.btn_reload.Margin = new System.Windows.Forms.Padding(2);
               this.btn_reload.Name = "btn_reload";
               this.btn_reload.Size = new System.Drawing.Size(135, 87);
               this.btn_reload.TabIndex = 15;
               this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(554, 154);
               this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(116, 25);
               this.label2.TabIndex = 14;
               this.label2.Text = "User Search";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(11, 154);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(146, 25);
               this.label1.TabIndex = 13;
               this.label1.Text = "Website Search";
               // 
               // txt_user
               // 
               this.txt_user.BorderRadius = 5;
               this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.txt_user.DefaultText = "";
               this.txt_user.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
               this.txt_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
               this.txt_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_user.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_user.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txt_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_user.Location = new System.Drawing.Point(550, 182);
               this.txt_user.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.txt_user.Name = "txt_user";
               this.txt_user.PasswordChar = '\0';
               this.txt_user.PlaceholderForeColor = System.Drawing.Color.Black;
               this.txt_user.PlaceholderText = "";
               this.txt_user.SelectedText = "";
               this.txt_user.Size = new System.Drawing.Size(504, 42);
               this.txt_user.TabIndex = 12;
               this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
               // 
               // txt_website
               // 
               this.txt_website.BorderRadius = 5;
               this.txt_website.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.txt_website.DefaultText = "";
               this.txt_website.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
               this.txt_website.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
               this.txt_website.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_website.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_website.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_website.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txt_website.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_website.Location = new System.Drawing.Point(11, 182);
               this.txt_website.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.txt_website.Name = "txt_website";
               this.txt_website.PasswordChar = '\0';
               this.txt_website.PlaceholderForeColor = System.Drawing.Color.Black;
               this.txt_website.PlaceholderText = "";
               this.txt_website.SelectedText = "";
               this.txt_website.Size = new System.Drawing.Size(504, 42);
               this.txt_website.TabIndex = 11;
               this.txt_website.TextChanged += new System.EventHandler(this.txt_website_TextChanged);
               // 
               // DataGridView_PasswordEntry
               // 
               dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
               this.DataGridView_PasswordEntry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
               this.DataGridView_PasswordEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(102)))));
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.DataGridView_PasswordEntry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
               this.DataGridView_PasswordEntry.ColumnHeadersHeight = 25;
               this.DataGridView_PasswordEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HD_Website,
            this.HD_User,
            this.HD_Password,
            this.HD_Category});
               dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
               dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
               dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
               dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
               dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
               this.DataGridView_PasswordEntry.DefaultCellStyle = dataGridViewCellStyle3;
               this.DataGridView_PasswordEntry.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
               this.DataGridView_PasswordEntry.Location = new System.Drawing.Point(11, 235);
               this.DataGridView_PasswordEntry.Margin = new System.Windows.Forms.Padding(2);
               this.DataGridView_PasswordEntry.Name = "DataGridView_PasswordEntry";
               this.DataGridView_PasswordEntry.RowHeadersVisible = false;
               this.DataGridView_PasswordEntry.RowHeadersWidth = 51;
               this.DataGridView_PasswordEntry.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
               dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               this.DataGridView_PasswordEntry.RowsDefaultCellStyle = dataGridViewCellStyle4;
               this.DataGridView_PasswordEntry.RowTemplate.Height = 35;
               this.DataGridView_PasswordEntry.Size = new System.Drawing.Size(1043, 360);
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
               this.DataGridView_PasswordEntry.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
               this.DataGridView_PasswordEntry.ThemeStyle.HeaderStyle.Height = 25;
               this.DataGridView_PasswordEntry.ThemeStyle.ReadOnly = false;
               this.DataGridView_PasswordEntry.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
               this.DataGridView_PasswordEntry.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
               this.DataGridView_PasswordEntry.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.DataGridView_PasswordEntry.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
               this.DataGridView_PasswordEntry.ThemeStyle.RowsStyle.Height = 35;
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
               this.btn_new.Location = new System.Drawing.Point(1069, 291);
               this.btn_new.Margin = new System.Windows.Forms.Padding(2);
               this.btn_new.Name = "btn_new";
               this.btn_new.Size = new System.Drawing.Size(135, 87);
               this.btn_new.TabIndex = 9;
               this.btn_new.Text = "New";
               this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
               // 
               // Password
               // 
               this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(102)))));
               this.Password.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
               this.Password.Controls.Add(this.labelNumberOfPassword);
               this.Password.Controls.Add(this.guna2HtmlLabel2);
               this.Password.Controls.Add(this.guna2PictureBox1);
               this.Password.Location = new System.Drawing.Point(11, 25);
               this.Password.Name = "Password";
               this.Password.Size = new System.Drawing.Size(369, 114);
               this.Password.TabIndex = 18;
               // 
               // labelNumberOfPassword
               // 
               this.labelNumberOfPassword.BackColor = System.Drawing.Color.Transparent;
               this.labelNumberOfPassword.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelNumberOfPassword.ForeColor = System.Drawing.Color.White;
               this.labelNumberOfPassword.Location = new System.Drawing.Point(267, 30);
               this.labelNumberOfPassword.Name = "labelNumberOfPassword";
               this.labelNumberOfPassword.Size = new System.Drawing.Size(29, 47);
               this.labelNumberOfPassword.TabIndex = 2;
               this.labelNumberOfPassword.Text = "--";
               // 
               // guna2HtmlLabel2
               // 
               this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
               this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
               this.guna2HtmlLabel2.Location = new System.Drawing.Point(75, 45);
               this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
               this.guna2HtmlLabel2.Size = new System.Drawing.Size(158, 22);
               this.guna2HtmlLabel2.TabIndex = 1;
               this.guna2HtmlLabel2.Text = "Numbers of Password";
               // 
               // guna2PictureBox1
               // 
               this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
               this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
               this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
               this.guna2PictureBox1.ImageRotate = 0F;
               this.guna2PictureBox1.Location = new System.Drawing.Point(19, 30);
               this.guna2PictureBox1.Name = "guna2PictureBox1";
               this.guna2PictureBox1.Size = new System.Drawing.Size(50, 49);
               this.guna2PictureBox1.TabIndex = 0;
               this.guna2PictureBox1.TabStop = false;
               // 
               // guna2HtmlLabel1
               // 
               this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
               this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
               this.guna2HtmlLabel1.Location = new System.Drawing.Point(267, 30);
               this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
               this.guna2HtmlLabel1.Size = new System.Drawing.Size(29, 47);
               this.guna2HtmlLabel1.TabIndex = 2;
               this.guna2HtmlLabel1.Text = "--";
               // 
               // guna2HtmlLabel4
               // 
               this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
               this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
               this.guna2HtmlLabel4.Location = new System.Drawing.Point(75, 45);
               this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
               this.guna2HtmlLabel4.Size = new System.Drawing.Size(158, 22);
               this.guna2HtmlLabel4.TabIndex = 1;
               this.guna2HtmlLabel4.Text = "Numbers of Password";
               // 
               // Website
               // 
               this.Website.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(102)))));
               this.Website.Controls.Add(this.labelNumberOfWebsite);
               this.Website.Controls.Add(this.guna2HtmlLabel6);
               this.Website.Controls.Add(this.guna2PictureBox2);
               this.Website.Location = new System.Drawing.Point(432, 25);
               this.Website.Name = "Website";
               this.Website.Size = new System.Drawing.Size(369, 114);
               this.Website.TabIndex = 19;
               // 
               // labelNumberOfWebsite
               // 
               this.labelNumberOfWebsite.BackColor = System.Drawing.Color.Transparent;
               this.labelNumberOfWebsite.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelNumberOfWebsite.ForeColor = System.Drawing.Color.White;
               this.labelNumberOfWebsite.Location = new System.Drawing.Point(267, 30);
               this.labelNumberOfWebsite.Name = "labelNumberOfWebsite";
               this.labelNumberOfWebsite.Size = new System.Drawing.Size(29, 47);
               this.labelNumberOfWebsite.TabIndex = 2;
               this.labelNumberOfWebsite.Text = "--";
               // 
               // guna2HtmlLabel6
               // 
               this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
               this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
               this.guna2HtmlLabel6.Location = new System.Drawing.Point(75, 45);
               this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
               this.guna2HtmlLabel6.Size = new System.Drawing.Size(141, 22);
               this.guna2HtmlLabel6.TabIndex = 1;
               this.guna2HtmlLabel6.Text = "Number of Website";
               // 
               // guna2PictureBox2
               // 
               this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
               this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
               this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
               this.guna2PictureBox2.ImageRotate = 0F;
               this.guna2PictureBox2.Location = new System.Drawing.Point(19, 30);
               this.guna2PictureBox2.Name = "guna2PictureBox2";
               this.guna2PictureBox2.Size = new System.Drawing.Size(50, 49);
               this.guna2PictureBox2.TabIndex = 0;
               this.guna2PictureBox2.TabStop = false;
               // 
               // Expired
               // 
               this.Expired.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(102)))));
               this.Expired.Controls.Add(this.labelNumberOfPasswordExpired);
               this.Expired.Controls.Add(this.guna2HtmlLabel8);
               this.Expired.Controls.Add(this.guna2PictureBox3);
               this.Expired.Location = new System.Drawing.Point(832, 25);
               this.Expired.Name = "Expired";
               this.Expired.Size = new System.Drawing.Size(369, 114);
               this.Expired.TabIndex = 20;
               // 
               // labelNumberOfPasswordExpired
               // 
               this.labelNumberOfPasswordExpired.BackColor = System.Drawing.Color.Transparent;
               this.labelNumberOfPasswordExpired.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelNumberOfPasswordExpired.ForeColor = System.Drawing.Color.White;
               this.labelNumberOfPasswordExpired.Location = new System.Drawing.Point(267, 30);
               this.labelNumberOfPasswordExpired.Name = "labelNumberOfPasswordExpired";
               this.labelNumberOfPasswordExpired.Size = new System.Drawing.Size(29, 47);
               this.labelNumberOfPasswordExpired.TabIndex = 2;
               this.labelNumberOfPasswordExpired.Text = "--";
               // 
               // guna2HtmlLabel8
               // 
               this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
               this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.White;
               this.guna2HtmlLabel8.Location = new System.Drawing.Point(75, 45);
               this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
               this.guna2HtmlLabel8.Size = new System.Drawing.Size(126, 22);
               this.guna2HtmlLabel8.TabIndex = 1;
               this.guna2HtmlLabel8.Text = "Password expired";
               // 
               // guna2PictureBox3
               // 
               this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
               this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
               this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
               this.guna2PictureBox3.ImageRotate = 0F;
               this.guna2PictureBox3.Location = new System.Drawing.Point(19, 30);
               this.guna2PictureBox3.Name = "guna2PictureBox3";
               this.guna2PictureBox3.Size = new System.Drawing.Size(50, 49);
               this.guna2PictureBox3.TabIndex = 0;
               this.guna2PictureBox3.TabStop = false;
               // 
               // guna2Elipse1
               // 
               this.guna2Elipse1.BorderRadius = 20;
               this.guna2Elipse1.TargetControl = this.Password;
               // 
               // guna2Elipse2
               // 
               this.guna2Elipse2.BorderRadius = 20;
               this.guna2Elipse2.TargetControl = this.Website;
               // 
               // guna2Elipse3
               // 
               this.guna2Elipse3.BorderRadius = 20;
               this.guna2Elipse3.TargetControl = this.Expired;
               // 
               // guna2Elipse4
               // 
               this.guna2Elipse4.BorderRadius = 10;
               this.guna2Elipse4.TargetControl = this.DataGridView_PasswordEntry;
               // 
               // PasswordManagementForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1245, 606);
               this.Controls.Add(this.Expired);
               this.Controls.Add(this.Website);
               this.Controls.Add(this.Password);
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
               this.Password.ResumeLayout(false);
               this.Password.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
               this.Website.ResumeLayout(false);
               this.Website.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
               this.Expired.ResumeLayout(false);
               this.Expired.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
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
          private Guna.UI2.WinForms.Guna2Panel Password;
          private Guna.UI2.WinForms.Guna2HtmlLabel labelNumberOfPassword;
          private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
          private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
          private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
          private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
          private Guna.UI2.WinForms.Guna2Panel Website;
          private Guna.UI2.WinForms.Guna2HtmlLabel labelNumberOfWebsite;
          private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
          private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
          private Guna.UI2.WinForms.Guna2Panel Expired;
          private Guna.UI2.WinForms.Guna2HtmlLabel labelNumberOfPasswordExpired;
          private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
          private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
          private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
          private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
          private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
          private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
     }
}