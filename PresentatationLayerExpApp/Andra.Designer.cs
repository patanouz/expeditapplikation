
namespace PresentatationLayerExpApp
{
    partial class Andra
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
            this.LabelBokningsNr = new System.Windows.Forms.Label();
            this.ISBNLabelÅterlämna = new System.Windows.Forms.Label();
            this.BokningsNrTextBox = new System.Windows.Forms.TextBox();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewÅterlämnade = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.återlämnaButton = new System.Windows.Forms.Button();
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
            // LabelBokningsNr
            // 
            this.LabelBokningsNr.AutoSize = true;
            this.LabelBokningsNr.Location = new System.Drawing.Point(224, 158);
            this.LabelBokningsNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelBokningsNr.Name = "LabelBokningsNr";
            this.LabelBokningsNr.Size = new System.Drawing.Size(125, 17);
            this.LabelBokningsNr.TabIndex = 12;
            this.LabelBokningsNr.Text = "Bokningsnummer: ";
            // 
            // ISBNLabelÅterlämna
            // 
            this.ISBNLabelÅterlämna.AutoSize = true;
            this.ISBNLabelÅterlämna.Location = new System.Drawing.Point(224, 94);
            this.ISBNLabelÅterlämna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ISBNLabelÅterlämna.Name = "ISBNLabelÅterlämna";
            this.ISBNLabelÅterlämna.Size = new System.Drawing.Size(47, 17);
            this.ISBNLabelÅterlämna.TabIndex = 11;
            this.ISBNLabelÅterlämna.Text = "ISBN: ";
            // 
            // BokningsNrTextBox
            // 
            this.BokningsNrTextBox.Location = new System.Drawing.Point(355, 154);
            this.BokningsNrTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BokningsNrTextBox.Name = "BokningsNrTextBox";
            this.BokningsNrTextBox.Size = new System.Drawing.Size(127, 22);
            this.BokningsNrTextBox.TabIndex = 10;
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(355, 90);
            this.ISBNTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(127, 22);
            this.ISBNTextBox.TabIndex = 9;
            // 
            // dataGridViewÅterlämnade
            // 
            this.dataGridViewÅterlämnade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewÅterlämnade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Title});
            this.dataGridViewÅterlämnade.Location = new System.Drawing.Point(516, 90);
            this.dataGridViewÅterlämnade.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewÅterlämnade.Name = "dataGridViewÅterlämnade";
            this.dataGridViewÅterlämnade.RowHeadersWidth = 51;
            this.dataGridViewÅterlämnade.Size = new System.Drawing.Size(380, 425);
            this.dataGridViewÅterlämnade.TabIndex = 8;
            this.dataGridViewÅterlämnade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewÅterlämnade_CellContentClick);
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.Width = 125;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 205;
            // 
            // återlämnaButton
            // 
            this.återlämnaButton.BackColor = System.Drawing.Color.Lime;
            this.återlämnaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.återlämnaButton.FlatAppearance.BorderSize = 0;
            this.återlämnaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.återlämnaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.återlämnaButton.Location = new System.Drawing.Point(355, 230);
            this.återlämnaButton.Margin = new System.Windows.Forms.Padding(4);
            this.återlämnaButton.Name = "återlämnaButton";
            this.återlämnaButton.Size = new System.Drawing.Size(128, 41);
            this.återlämnaButton.TabIndex = 7;
            this.återlämnaButton.Text = "Bekräfta";
            this.återlämnaButton.UseVisualStyleBackColor = false;
            // 
            // Andra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1045, 661);
            this.Controls.Add(this.LabelRubrikÅterlämna);
            this.Controls.Add(this.LabelBokningsNr);
            this.Controls.Add(this.ISBNLabelÅterlämna);
            this.Controls.Add(this.BokningsNrTextBox);
            this.Controls.Add(this.ISBNTextBox);
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
        private System.Windows.Forms.Label LabelBokningsNr;
        private System.Windows.Forms.Label ISBNLabelÅterlämna;
        private System.Windows.Forms.TextBox BokningsNrTextBox;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.DataGridView dataGridViewÅterlämnade;
        private System.Windows.Forms.Button återlämnaButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
    }
}