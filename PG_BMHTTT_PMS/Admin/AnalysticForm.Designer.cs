﻿namespace PG_BMHTTT_PMS.Admin
{
     partial class AnalysticForm
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
               this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
               this.SuspendLayout();
               // 
               // guna2HtmlLabel1
               // 
               this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
               this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 12);
               this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
               this.guna2HtmlLabel1.Size = new System.Drawing.Size(97, 19);
               this.guna2HtmlLabel1.TabIndex = 1;
               this.guna2HtmlLabel1.Text = "Analystic Page";
               // 
               // AnalysticForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1245, 649);
               this.Controls.Add(this.guna2HtmlLabel1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "AnalysticForm";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "AnalysticForm";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
     }
}