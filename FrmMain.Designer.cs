﻿namespace chuong4._1
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chàoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhTổngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bàiTập1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chàoToolStripMenuItem,
            this.tínhTổngToolStripMenuItem,
            this.bàiTập1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chàoToolStripMenuItem
            // 
            this.chàoToolStripMenuItem.Name = "chàoToolStripMenuItem";
            this.chàoToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.chàoToolStripMenuItem.Text = "Chào Mừng";
            this.chàoToolStripMenuItem.Click += new System.EventHandler(this.chàoToolStripMenuItem_Click);
            // 
            // tínhTổngToolStripMenuItem
            // 
            this.tínhTổngToolStripMenuItem.Name = "tínhTổngToolStripMenuItem";
            this.tínhTổngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.tínhTổngToolStripMenuItem.Text = "Tính Tổng";
            this.tínhTổngToolStripMenuItem.Click += new System.EventHandler(this.tínhTổngToolStripMenuItem_Click);
            // 
            // bàiTập1ToolStripMenuItem
            // 
            this.bàiTập1ToolStripMenuItem.Name = "bàiTập1ToolStripMenuItem";
            this.bàiTập1ToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.bàiTập1ToolStripMenuItem.Text = "Bài Tập 1";
            this.bàiTập1ToolStripMenuItem.Click += new System.EventHandler(this.bàiTập1ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chàoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhTổngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bàiTập1ToolStripMenuItem;
    }
}