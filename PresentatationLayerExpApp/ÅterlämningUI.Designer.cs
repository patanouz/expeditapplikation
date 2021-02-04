
namespace PresentatationLayerExpApp
{
    partial class ÅterlämningUI
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
            this.LabelRubrikÅterlämna = new System.Windows.Forms.Label();
            this.dataGridViewÅterlämnade = new System.Windows.Forms.DataGridView();
            this.återlämnaButton = new System.Windows.Forms.Button();
            this.bokningsNummerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.medlemsNummerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher3 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher4 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher5 = new System.DirectoryServices.DirectorySearcher();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewÅterlämnade)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelRubrikÅterlämna
            // 
            this.LabelRubrikÅterlämna.AutoSize = true;
            this.LabelRubrikÅterlämna.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRubrikÅterlämna.Location = new System.Drawing.Point(16, 11);
            this.LabelRubrikÅterlämna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelRubrikÅterlämna.Name = "LabelRubrikÅterlämna";
            this.LabelRubrikÅterlämna.Size = new System.Drawing.Size(188, 31);
            this.LabelRubrikÅterlämna.TabIndex = 13;
            this.LabelRubrikÅterlämna.Text = "Återlämna bok";
            // 
            // dataGridViewÅterlämnade
            // 
            this.dataGridViewÅterlämnade.AllowUserToDeleteRows = false;
            this.dataGridViewÅterlämnade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewÅterlämnade.Location = new System.Drawing.Point(16, 90);
            this.dataGridViewÅterlämnade.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewÅterlämnade.Name = "dataGridViewÅterlämnade";
            this.dataGridViewÅterlämnade.ReadOnly = true;
            this.dataGridViewÅterlämnade.RowHeadersVisible = false;
            this.dataGridViewÅterlämnade.RowHeadersWidth = 51;
            this.dataGridViewÅterlämnade.Size = new System.Drawing.Size(1013, 458);
            this.dataGridViewÅterlämnade.TabIndex = 8;
            this.dataGridViewÅterlämnade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewÅterlämnade_CellClick);
            this.dataGridViewÅterlämnade.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewÅterlämnade_DataBindingComplete);
            // 
            // återlämnaButton
            // 
            this.återlämnaButton.BackColor = System.Drawing.Color.Lime;
            this.återlämnaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.återlämnaButton.FlatAppearance.BorderSize = 0;
            this.återlämnaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.återlämnaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.återlämnaButton.Location = new System.Drawing.Point(838, 587);
            this.återlämnaButton.Margin = new System.Windows.Forms.Padding(4);
            this.återlämnaButton.Name = "återlämnaButton";
            this.återlämnaButton.Size = new System.Drawing.Size(191, 41);
            this.återlämnaButton.TabIndex = 7;
            this.återlämnaButton.Text = "Bekräfta återlämning";
            this.återlämnaButton.UseVisualStyleBackColor = false;
            this.återlämnaButton.Click += new System.EventHandler(this.returnBookButton_Click);
            // 
            // bokningsNummerTextBox
            // 
            this.bokningsNummerTextBox.Location = new System.Drawing.Point(14, 606);
            this.bokningsNummerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bokningsNummerTextBox.Name = "bokningsNummerTextBox";
            this.bokningsNummerTextBox.Size = new System.Drawing.Size(132, 22);
            this.bokningsNummerTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 585);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bokningsnummer";
            // 
            // medlemsNummerTextBox
            // 
            this.medlemsNummerTextBox.Location = new System.Drawing.Point(166, 606);
            this.medlemsNummerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.medlemsNummerTextBox.Name = "medlemsNummerTextBox";
            this.medlemsNummerTextBox.Size = new System.Drawing.Size(132, 22);
            this.medlemsNummerTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 585);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Medlemsnummer";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(879, 58);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 21);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Visa alla bokningar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkbox_StatusBookings);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(13, 568);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(12, 17);
            this.ErrorMessageLabel.TabIndex = 24;
            this.ErrorMessageLabel.Text = " ";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher3
            // 
            this.directorySearcher3.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher3.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher3.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher4
            // 
            this.directorySearcher4.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher4.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher4.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher5
            // 
            this.directorySearcher5.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher5.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher5.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(325, 602);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(105, 30);
            this.SearchButton.TabIndex = 25;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Andra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1045, 661);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.medlemsNummerTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bokningsNummerTextBox);
            this.Controls.Add(this.LabelRubrikÅterlämna);
            this.Controls.Add(this.dataGridViewÅterlämnade);
            this.Controls.Add(this.återlämnaButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Andra";
            this.Text = "Andra";
            this.Load += new System.EventHandler(this.Andra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewÅterlämnade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelRubrikÅterlämna;
        private System.Windows.Forms.DataGridView dataGridViewÅterlämnade;
        private System.Windows.Forms.Button återlämnaButton;
        private System.Windows.Forms.TextBox bokningsNummerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox medlemsNummerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.DirectoryServices.DirectorySearcher directorySearcher3;
        private System.DirectoryServices.DirectorySearcher directorySearcher4;
        private System.DirectoryServices.DirectorySearcher directorySearcher5;
        private System.Windows.Forms.Button SearchButton;
    }
}