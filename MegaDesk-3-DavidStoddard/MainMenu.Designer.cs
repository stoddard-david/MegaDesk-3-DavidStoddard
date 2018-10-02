﻿namespace MegaDesk_3_DavidStoddard
{
  partial class MainMenu
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
      this.AddQuotesBtn = new System.Windows.Forms.Button();
      this.ViewQuotesBtn = new System.Windows.Forms.Button();
      this.SearchQuotesBtn = new System.Windows.Forms.Button();
      this.ExitBtn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // AddQuotesBtn
      // 
      this.AddQuotesBtn.FlatAppearance.BorderSize = 2;
      this.AddQuotesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
      this.AddQuotesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.AddQuotesBtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.AddQuotesBtn.Location = new System.Drawing.Point(24, 31);
      this.AddQuotesBtn.Margin = new System.Windows.Forms.Padding(6);
      this.AddQuotesBtn.Name = "AddQuotesBtn";
      this.AddQuotesBtn.Size = new System.Drawing.Size(200, 50);
      this.AddQuotesBtn.TabIndex = 0;
      this.AddQuotesBtn.Text = "&Add New Quote";
      this.AddQuotesBtn.UseVisualStyleBackColor = true;
      // 
      // ViewQuotesBtn
      // 
      this.ViewQuotesBtn.FlatAppearance.BorderSize = 2;
      this.ViewQuotesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
      this.ViewQuotesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ViewQuotesBtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ViewQuotesBtn.Location = new System.Drawing.Point(24, 93);
      this.ViewQuotesBtn.Margin = new System.Windows.Forms.Padding(6);
      this.ViewQuotesBtn.Name = "ViewQuotesBtn";
      this.ViewQuotesBtn.Size = new System.Drawing.Size(200, 50);
      this.ViewQuotesBtn.TabIndex = 1;
      this.ViewQuotesBtn.Text = "&View Quotes";
      this.ViewQuotesBtn.UseVisualStyleBackColor = true;
      // 
      // SearchQuotesBtn
      // 
      this.SearchQuotesBtn.FlatAppearance.BorderSize = 2;
      this.SearchQuotesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
      this.SearchQuotesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.SearchQuotesBtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SearchQuotesBtn.Location = new System.Drawing.Point(24, 155);
      this.SearchQuotesBtn.Margin = new System.Windows.Forms.Padding(6);
      this.SearchQuotesBtn.Name = "SearchQuotesBtn";
      this.SearchQuotesBtn.Size = new System.Drawing.Size(200, 50);
      this.SearchQuotesBtn.TabIndex = 2;
      this.SearchQuotesBtn.Text = "&SearchQuotes";
      this.SearchQuotesBtn.UseVisualStyleBackColor = true;
      // 
      // ExitBtn
      // 
      this.ExitBtn.FlatAppearance.BorderSize = 2;
      this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
      this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ExitBtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ExitBtn.Location = new System.Drawing.Point(24, 217);
      this.ExitBtn.Margin = new System.Windows.Forms.Padding(6);
      this.ExitBtn.Name = "ExitBtn";
      this.ExitBtn.Size = new System.Drawing.Size(200, 50);
      this.ExitBtn.TabIndex = 3;
      this.ExitBtn.Text = "E&xit";
      this.ExitBtn.UseVisualStyleBackColor = true;
      // 
      // MainMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(584, 361);
      this.Controls.Add(this.ExitBtn);
      this.Controls.Add(this.SearchQuotesBtn);
      this.Controls.Add(this.ViewQuotesBtn);
      this.Controls.Add(this.AddQuotesBtn);
      this.ForeColor = System.Drawing.Color.MediumSeaGreen;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainMenu";
      this.Text = "MegaDesk";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button AddQuotesBtn;
    private System.Windows.Forms.Button ViewQuotesBtn;
    private System.Windows.Forms.Button SearchQuotesBtn;
    private System.Windows.Forms.Button ExitBtn;
  }
}
