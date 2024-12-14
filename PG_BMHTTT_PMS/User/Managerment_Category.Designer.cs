namespace PG_BMHTTT_PMS.User
{
     partial class Managerment_Category
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Managerment_Category));
               this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
               this.label4 = new System.Windows.Forms.Label();
               this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
               this.label3 = new System.Windows.Forms.Label();
               this.txt_categoryName = new Guna.UI2.WinForms.Guna2TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.txt_Description = new Guna.UI2.WinForms.Guna2TextBox();
               this.btn_reload = new Guna.UI2.WinForms.Guna2Button();
               this.label1 = new System.Windows.Forms.Label();
               this.txt_category_Search = new Guna.UI2.WinForms.Guna2TextBox();
               this.DataGridView_Category = new Guna.UI2.WinForms.Guna2DataGridView();
               this.HD_CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.HD_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.btn_save = new Guna.UI2.WinForms.Guna2Button();
               this.closeBtn = new Guna.UI2.WinForms.Guna2Button();
               ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Category)).BeginInit();
               this.SuspendLayout();
               // 
               // btn_clear
               // 
               this.btn_clear.BorderRadius = 5;
               this.btn_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.btn_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.btn_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.btn_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btn_clear.ForeColor = System.Drawing.Color.White;
               this.btn_clear.Location = new System.Drawing.Point(325, 210);
               this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
               this.btn_clear.Name = "btn_clear";
               this.btn_clear.Size = new System.Drawing.Size(135, 37);
               this.btn_clear.TabIndex = 33;
               this.btn_clear.Text = "Clear";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.Location = new System.Drawing.Point(112, 21);
               this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(286, 32);
               this.label4.TabIndex = 32;
               this.label4.Text = "Managerment Category";
               // 
               // btn_delete
               // 
               this.btn_delete.BorderRadius = 5;
               this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.btn_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btn_delete.ForeColor = System.Drawing.Color.White;
               this.btn_delete.Location = new System.Drawing.Point(325, 537);
               this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
               this.btn_delete.Name = "btn_delete";
               this.btn_delete.Size = new System.Drawing.Size(135, 37);
               this.btn_delete.TabIndex = 31;
               this.btn_delete.Text = "Delete";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(55, 73);
               this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(104, 17);
               this.label3.TabIndex = 30;
               this.label3.Text = "Category Name";
               // 
               // txt_categoryName
               // 
               this.txt_categoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.txt_categoryName.DefaultText = "";
               this.txt_categoryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
               this.txt_categoryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
               this.txt_categoryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_categoryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_categoryName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_categoryName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txt_categoryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_categoryName.Location = new System.Drawing.Point(58, 93);
               this.txt_categoryName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.txt_categoryName.Name = "txt_categoryName";
               this.txt_categoryName.PasswordChar = '\0';
               this.txt_categoryName.PlaceholderForeColor = System.Drawing.Color.Black;
               this.txt_categoryName.PlaceholderText = "";
               this.txt_categoryName.SelectedText = "";
               this.txt_categoryName.Size = new System.Drawing.Size(402, 39);
               this.txt_categoryName.TabIndex = 29;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(55, 146);
               this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(76, 17);
               this.label2.TabIndex = 28;
               this.label2.Text = "Description";
               // 
               // txt_Description
               // 
               this.txt_Description.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.txt_Description.DefaultText = "";
               this.txt_Description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
               this.txt_Description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
               this.txt_Description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_Description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_Description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_Description.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txt_Description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_Description.Location = new System.Drawing.Point(58, 166);
               this.txt_Description.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.txt_Description.Name = "txt_Description";
               this.txt_Description.PasswordChar = '\0';
               this.txt_Description.PlaceholderForeColor = System.Drawing.Color.Black;
               this.txt_Description.PlaceholderText = "";
               this.txt_Description.SelectedText = "";
               this.txt_Description.Size = new System.Drawing.Size(402, 39);
               this.txt_Description.TabIndex = 27;
               // 
               // btn_reload
               // 
               this.btn_reload.BorderRadius = 5;
               this.btn_reload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.btn_reload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.btn_reload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.btn_reload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.btn_reload.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btn_reload.ForeColor = System.Drawing.Color.White;
               this.btn_reload.Location = new System.Drawing.Point(58, 537);
               this.btn_reload.Margin = new System.Windows.Forms.Padding(2);
               this.btn_reload.Name = "btn_reload";
               this.btn_reload.Size = new System.Drawing.Size(135, 37);
               this.btn_reload.TabIndex = 26;
               this.btn_reload.Text = "Reload";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(55, 269);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(148, 17);
               this.label1.TabIndex = 25;
               this.label1.Text = "Category Name Search";
               // 
               // txt_category_Search
               // 
               this.txt_category_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.txt_category_Search.DefaultText = "";
               this.txt_category_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
               this.txt_category_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
               this.txt_category_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_category_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
               this.txt_category_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_category_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txt_category_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.txt_category_Search.Location = new System.Drawing.Point(58, 289);
               this.txt_category_Search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.txt_category_Search.Name = "txt_category_Search";
               this.txt_category_Search.PasswordChar = '\0';
               this.txt_category_Search.PlaceholderForeColor = System.Drawing.Color.Black;
               this.txt_category_Search.PlaceholderText = "";
               this.txt_category_Search.SelectedText = "";
               this.txt_category_Search.Size = new System.Drawing.Size(402, 39);
               this.txt_category_Search.TabIndex = 24;
               // 
               // DataGridView_Category
               // 
               dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
               this.DataGridView_Category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
               this.DataGridView_Category.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.DataGridView_Category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
               this.DataGridView_Category.ColumnHeadersHeight = 25;
               this.DataGridView_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
               this.DataGridView_Category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HD_CategoryName,
            this.HD_Description});
               dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
               dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
               dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
               dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
               dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
               this.DataGridView_Category.DefaultCellStyle = dataGridViewCellStyle3;
               this.DataGridView_Category.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
               this.DataGridView_Category.Location = new System.Drawing.Point(58, 351);
               this.DataGridView_Category.Margin = new System.Windows.Forms.Padding(2);
               this.DataGridView_Category.Name = "DataGridView_Category";
               this.DataGridView_Category.RowHeadersVisible = false;
               this.DataGridView_Category.RowHeadersWidth = 51;
               this.DataGridView_Category.RowTemplate.Height = 24;
               this.DataGridView_Category.Size = new System.Drawing.Size(402, 160);
               this.DataGridView_Category.TabIndex = 23;
               this.DataGridView_Category.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
               this.DataGridView_Category.ThemeStyle.AlternatingRowsStyle.Font = null;
               this.DataGridView_Category.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
               this.DataGridView_Category.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
               this.DataGridView_Category.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
               this.DataGridView_Category.ThemeStyle.BackColor = System.Drawing.Color.White;
               this.DataGridView_Category.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
               this.DataGridView_Category.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
               this.DataGridView_Category.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
               this.DataGridView_Category.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.DataGridView_Category.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
               this.DataGridView_Category.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
               this.DataGridView_Category.ThemeStyle.HeaderStyle.Height = 25;
               this.DataGridView_Category.ThemeStyle.ReadOnly = false;
               this.DataGridView_Category.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
               this.DataGridView_Category.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
               this.DataGridView_Category.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.DataGridView_Category.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
               this.DataGridView_Category.ThemeStyle.RowsStyle.Height = 24;
               this.DataGridView_Category.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
               this.DataGridView_Category.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
               this.DataGridView_Category.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Category_CellContentClick);
               // 
               // HD_CategoryName
               // 
               this.HD_CategoryName.HeaderText = "Category Name";
               this.HD_CategoryName.MinimumWidth = 6;
               this.HD_CategoryName.Name = "HD_CategoryName";
               this.HD_CategoryName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
               this.HD_CategoryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
               // 
               // HD_Description
               // 
               this.HD_Description.HeaderText = "Description";
               this.HD_Description.MinimumWidth = 6;
               this.HD_Description.Name = "HD_Description";
               // 
               // btn_save
               // 
               this.btn_save.BorderRadius = 5;
               this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
               this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
               this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
               this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
               this.btn_save.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btn_save.ForeColor = System.Drawing.Color.White;
               this.btn_save.Location = new System.Drawing.Point(58, 210);
               this.btn_save.Margin = new System.Windows.Forms.Padding(2);
               this.btn_save.Name = "btn_save";
               this.btn_save.Size = new System.Drawing.Size(135, 37);
               this.btn_save.TabIndex = 22;
               this.btn_save.Text = "Save";
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
               this.closeBtn.Location = new System.Drawing.Point(478, 0);
               this.closeBtn.Name = "closeBtn";
               this.closeBtn.Size = new System.Drawing.Size(51, 48);
               this.closeBtn.TabIndex = 55;
               // 
               // Managerment_Category
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(528, 620);
               this.Controls.Add(this.closeBtn);
               this.Controls.Add(this.btn_clear);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.btn_delete);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.txt_categoryName);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.txt_Description);
               this.Controls.Add(this.btn_reload);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.txt_category_Search);
               this.Controls.Add(this.DataGridView_Category);
               this.Controls.Add(this.btn_save);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "Managerment_Category";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Category";
               ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Category)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private Guna.UI2.WinForms.Guna2Button btn_clear;
          private System.Windows.Forms.Label label4;
          private Guna.UI2.WinForms.Guna2Button btn_delete;
          private System.Windows.Forms.Label label3;
          private Guna.UI2.WinForms.Guna2TextBox txt_categoryName;
          private System.Windows.Forms.Label label2;
          private Guna.UI2.WinForms.Guna2TextBox txt_Description;
          private Guna.UI2.WinForms.Guna2Button btn_reload;
          private System.Windows.Forms.Label label1;
          private Guna.UI2.WinForms.Guna2TextBox txt_category_Search;
          private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Category;
          private System.Windows.Forms.DataGridViewTextBoxColumn HD_CategoryName;
          private System.Windows.Forms.DataGridViewTextBoxColumn HD_Description;
          private Guna.UI2.WinForms.Guna2Button btn_save;
          private Guna.UI2.WinForms.Guna2Button closeBtn;
     }
}