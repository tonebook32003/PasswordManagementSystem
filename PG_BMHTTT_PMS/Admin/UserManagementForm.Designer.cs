namespace PG_BMHTTT_PMS.Admin
{
     partial class UserManagementForm
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
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementForm));
               this.dtgUsers = new Guna.UI2.WinForms.Guna2DataGridView();
               this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
               this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
               this.btnReload = new Guna.UI2.WinForms.Guna2Button();
               this.gunaBarDataset1 = new Guna.Charts.WinForms.GunaBarDataset();
               this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
               this.btnFixInfo = new Guna.UI2.WinForms.Guna2Button();
               this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
               ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
               this.SuspendLayout();
               // 
               // dtgUsers
               // 
               this.dtgUsers.AllowUserToAddRows = false;
               this.dtgUsers.AllowUserToDeleteRows = false;
               this.dtgUsers.AllowUserToOrderColumns = true;
               dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
               dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dtgUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
               this.dtgUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(95)))), ((int)(((byte)(139)))));
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(102)))));
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
               this.dtgUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
               this.dtgUsers.ColumnHeadersHeight = 40;
               this.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
               dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
               dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
               dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
               dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
               dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dtgUsers.DefaultCellStyle = dataGridViewCellStyle3;
               this.dtgUsers.GridColor = System.Drawing.Color.Black;
               this.dtgUsers.Location = new System.Drawing.Point(12, 96);
               this.dtgUsers.Name = "dtgUsers";
               this.dtgUsers.ReadOnly = true;
               this.dtgUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
               dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
               dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
               dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
               dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dtgUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
               this.dtgUsers.RowHeadersVisible = false;
               this.dtgUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
               dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
               dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dtgUsers.RowsDefaultCellStyle = dataGridViewCellStyle5;
               this.dtgUsers.RowTemplate.Height = 40;
               this.dtgUsers.RowTemplate.ReadOnly = true;
               this.dtgUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
               this.dtgUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
               this.dtgUsers.Size = new System.Drawing.Size(1205, 466);
               this.dtgUsers.TabIndex = 0;
               this.dtgUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
               this.dtgUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
               this.dtgUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
               this.dtgUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
               this.dtgUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
               this.dtgUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
               this.dtgUsers.ThemeStyle.GridColor = System.Drawing.Color.Black;
               this.dtgUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
               this.dtgUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
               this.dtgUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.dtgUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
               this.dtgUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
               this.dtgUsers.ThemeStyle.HeaderStyle.Height = 40;
               this.dtgUsers.ThemeStyle.ReadOnly = true;
               this.dtgUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
               this.dtgUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
               this.dtgUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
               this.dtgUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
               this.dtgUsers.ThemeStyle.RowsStyle.Height = 40;
               this.dtgUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
               this.dtgUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
               // 
               // searchTextBox
               // 
               this.searchTextBox.BorderRadius = 10;
               this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.searchTextBox.DefaultText = "";
               this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
               this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
               this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.searchTextBox.Location = new System.Drawing.Point(12, 54);
               this.searchTextBox.Name = "searchTextBox";
               this.searchTextBox.PasswordChar = '\0';
               this.searchTextBox.PlaceholderText = "";
               this.searchTextBox.SelectedText = "";
               this.searchTextBox.Size = new System.Drawing.Size(291, 36);
               this.searchTextBox.TabIndex = 0;
               this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
               // 
               // guna2Button1
               // 
               this.guna2Button1.BorderRadius = 10;
               this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.guna2Button1.FillColor = System.Drawing.Color.Gray;
               this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.guna2Button1.ForeColor = System.Drawing.Color.White;
               this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
               this.guna2Button1.Location = new System.Drawing.Point(309, 54);
               this.guna2Button1.Name = "guna2Button1";
               this.guna2Button1.Size = new System.Drawing.Size(56, 36);
               this.guna2Button1.TabIndex = 1;
               // 
               // btnReload
               // 
               this.btnReload.BorderRadius = 10;
               this.btnReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.btnReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.btnReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.btnReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.btnReload.FillColor = System.Drawing.Color.Gray;
               this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.btnReload.ForeColor = System.Drawing.Color.White;
               this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
               this.btnReload.Location = new System.Drawing.Point(975, 54);
               this.btnReload.Name = "btnReload";
               this.btnReload.Size = new System.Drawing.Size(56, 36);
               this.btnReload.TabIndex = 2;
               this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
               // 
               // gunaBarDataset1
               // 
               this.gunaBarDataset1.Label = "Bar1";
               // 
               // btnDelete
               // 
               this.btnDelete.BorderRadius = 10;
               this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.btnDelete.ForeColor = System.Drawing.Color.White;
               this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
               this.btnDelete.Location = new System.Drawing.Point(1099, 54);
               this.btnDelete.Name = "btnDelete";
               this.btnDelete.Size = new System.Drawing.Size(56, 36);
               this.btnDelete.TabIndex = 5;
               this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
               // 
               // btnFixInfo
               // 
               this.btnFixInfo.BorderRadius = 10;
               this.btnFixInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.btnFixInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.btnFixInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.btnFixInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.btnFixInfo.FillColor = System.Drawing.Color.Blue;
               this.btnFixInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.btnFixInfo.ForeColor = System.Drawing.Color.White;
               this.btnFixInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnFixInfo.Image")));
               this.btnFixInfo.Location = new System.Drawing.Point(1161, 54);
               this.btnFixInfo.Name = "btnFixInfo";
               this.btnFixInfo.Size = new System.Drawing.Size(56, 36);
               this.btnFixInfo.TabIndex = 4;
               // 
               // btnAdd
               // 
               this.btnAdd.BorderRadius = 10;
               this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.btnAdd.FillColor = System.Drawing.Color.MediumSeaGreen;
               this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.btnAdd.ForeColor = System.Drawing.Color.White;
               this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
               this.btnAdd.Location = new System.Drawing.Point(1037, 54);
               this.btnAdd.Name = "btnAdd";
               this.btnAdd.Size = new System.Drawing.Size(56, 36);
               this.btnAdd.TabIndex = 6;
               this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
               // 
               // UserManagementForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1229, 574);
               this.Controls.Add(this.btnAdd);
               this.Controls.Add(this.btnDelete);
               this.Controls.Add(this.btnFixInfo);
               this.Controls.Add(this.btnReload);
               this.Controls.Add(this.dtgUsers);
               this.Controls.Add(this.guna2Button1);
               this.Controls.Add(this.searchTextBox);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "UserManagementForm";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "UserManagementForm";
               this.Load += new System.EventHandler(this.UserManagementForm_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private Guna.UI2.WinForms.Guna2DataGridView dtgUsers;
          private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
          private Guna.UI2.WinForms.Guna2Button guna2Button1;
          private Guna.UI2.WinForms.Guna2Button btnReload;
          private Guna.Charts.WinForms.GunaBarDataset gunaBarDataset1;
          private Guna.UI2.WinForms.Guna2Button btnDelete;
          private Guna.UI2.WinForms.Guna2Button btnFixInfo;
          private Guna.UI2.WinForms.Guna2Button btnAdd;
     }
}