
namespace PresentatationLayerExpApp
{
    partial class ControllerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControllerUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.förstaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.andraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(240)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.förstaToolStripMenuItem,
            this.andraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1044, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // förstaToolStripMenuItem
            // 
            this.förstaToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.förstaToolStripMenuItem.Name = "förstaToolStripMenuItem";
            this.förstaToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.förstaToolStripMenuItem.Text = "Bokning";
            this.förstaToolStripMenuItem.Click += new System.EventHandler(this.förstaToolStripMenuItem_Click);
            // 
            // andraToolStripMenuItem
            // 
            this.andraToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.andraToolStripMenuItem.Name = "andraToolStripMenuItem";
            this.andraToolStripMenuItem.Size = new System.Drawing.Size(104, 23);
            this.andraToolStripMenuItem.Text = "Återlämning";
            this.andraToolStripMenuItem.Click += new System.EventHandler(this.andraToolStripMenuItem_Click);
            // 
            // ControllerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1044, 746);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1060, 785);
            this.MinimumSize = new System.Drawing.Size(1060, 785);
            this.Name = "ControllerUI";
            this.Text = "Expeditapplikation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem förstaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem andraToolStripMenuItem;
    }
}

