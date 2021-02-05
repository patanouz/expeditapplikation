
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÅterlämningUI));
            this.LabelRubrikÅterlämna = new System.Windows.Forms.Label();
            this.dataGridViewÅterlämnade = new System.Windows.Forms.DataGridView();
            this.återlämnaButton = new System.Windows.Forms.Button();
            this.bokningsNummerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.medlemsNummerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewÅterlämnade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelRubrikÅterlämna
            // 
            this.LabelRubrikÅterlämna.AutoSize = true;
            this.LabelRubrikÅterlämna.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRubrikÅterlämna.Location = new System.Drawing.Point(67, 28);
            this.LabelRubrikÅterlämna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelRubrikÅterlämna.Name = "LabelRubrikÅterlämna";
            this.LabelRubrikÅterlämna.Size = new System.Drawing.Size(164, 24);
            this.LabelRubrikÅterlämna.TabIndex = 13;
            this.LabelRubrikÅterlämna.Text = "Återlämna bok";
            // 
            // dataGridViewÅterlämnade
            // 
            this.dataGridViewÅterlämnade.AllowUserToDeleteRows = false;
            this.dataGridViewÅterlämnade.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewÅterlämnade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewÅterlämnade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewÅterlämnade.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.dataGridViewÅterlämnade.Location = new System.Drawing.Point(71, 97);
            this.dataGridViewÅterlämnade.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewÅterlämnade.Name = "dataGridViewÅterlämnade";
            this.dataGridViewÅterlämnade.ReadOnly = true;
            this.dataGridViewÅterlämnade.RowHeadersVisible = false;
            this.dataGridViewÅterlämnade.RowHeadersWidth = 51;
            this.dataGridViewÅterlämnade.Size = new System.Drawing.Size(900, 500);
            this.dataGridViewÅterlämnade.TabIndex = 8;
            this.dataGridViewÅterlämnade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewÅterlämnade_CellClick);
            this.dataGridViewÅterlämnade.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewÅterlämnade_DataBindingComplete);
            // 
            // återlämnaButton
            // 
            this.återlämnaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.återlämnaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.återlämnaButton.FlatAppearance.BorderSize = 0;
            this.återlämnaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.återlämnaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.återlämnaButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.återlämnaButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.återlämnaButton.Location = new System.Drawing.Point(780, 625);
            this.återlämnaButton.Margin = new System.Windows.Forms.Padding(4);
            this.återlämnaButton.Name = "återlämnaButton";
            this.återlämnaButton.Size = new System.Drawing.Size(191, 43);
            this.återlämnaButton.TabIndex = 7;
            this.återlämnaButton.Text = "Bekräfta återlämning";
            this.återlämnaButton.UseVisualStyleBackColor = false;
            this.återlämnaButton.Click += new System.EventHandler(this.returnBookButton_Click);
            // 
            // bokningsNummerTextBox
            // 
            this.bokningsNummerTextBox.Location = new System.Drawing.Point(71, 645);
            this.bokningsNummerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bokningsNummerTextBox.Name = "bokningsNummerTextBox";
            this.bokningsNummerTextBox.Size = new System.Drawing.Size(120, 23);
            this.bokningsNummerTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(67, 618);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bokningsnummer";
            // 
            // medlemsNummerTextBox
            // 
            this.medlemsNummerTextBox.Location = new System.Drawing.Point(223, 645);
            this.medlemsNummerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.medlemsNummerTextBox.Name = "medlemsNummerTextBox";
            this.medlemsNummerTextBox.Size = new System.Drawing.Size(120, 23);
            this.medlemsNummerTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(220, 619);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Medlemsnummer";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(823, 68);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(151, 21);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Visa alla bokningar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkbox_StatusBookings);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(13, 604);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(12, 17);
            this.ErrorMessageLabel.TabIndex = 24;
            this.ErrorMessageLabel.Text = " ";
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = true;
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.Location = new System.Drawing.Point(364, 632);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(36, 36);
            this.SearchButton.TabIndex = 25;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(238, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // ÅterlämningUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1045, 702);
            this.Controls.Add(this.pictureBox2);
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
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ÅterlämningUI";
            this.Text = "Andra";
            this.Load += new System.EventHandler(this.Andra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewÅterlämnade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}