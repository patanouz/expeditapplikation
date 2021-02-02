
namespace PresentatationLayerExpApp
{
    partial class Första
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
            this.bokaButton = new System.Windows.Forms.Button();
            this.dataGridViewBöcker = new System.Windows.Forms.DataGridView();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.MedlemsNrTextBox = new System.Windows.Forms.TextBox();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.LabelMedlemNr = new System.Windows.Forms.Label();
            this.LabelRubrik = new System.Windows.Forms.Label();
            this.MedlemsNrError = new System.Windows.Forms.Label();
            this.IsbnError = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBöcker)).BeginInit();
            this.SuspendLayout();
            // 
            // bokaButton
            // 
            this.bokaButton.BackColor = System.Drawing.Color.Lime;
            this.bokaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bokaButton.FlatAppearance.BorderSize = 0;
            this.bokaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bokaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bokaButton.Location = new System.Drawing.Point(355, 230);
            this.bokaButton.Margin = new System.Windows.Forms.Padding(4);
            this.bokaButton.Name = "bokaButton";
            this.bokaButton.Size = new System.Drawing.Size(128, 41);
            this.bokaButton.TabIndex = 0;
            this.bokaButton.Text = "Boka";
            this.bokaButton.UseVisualStyleBackColor = false;
            this.bokaButton.Click += new System.EventHandler(this.bokaButton_Click);
            // 
            // dataGridViewBöcker
            // 
            this.dataGridViewBöcker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBöcker.Location = new System.Drawing.Point(516, 90);
            this.dataGridViewBöcker.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBöcker.Name = "dataGridViewBöcker";
            this.dataGridViewBöcker.RowHeadersVisible = false;
            this.dataGridViewBöcker.RowHeadersWidth = 51;
            this.dataGridViewBöcker.Size = new System.Drawing.Size(380, 425);
            this.dataGridViewBöcker.TabIndex = 1;
            this.dataGridViewBöcker.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBöcker_CellContentClick);
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(356, 94);
            this.ISBNTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(127, 22);
            this.ISBNTextBox.TabIndex = 2;
            // 
            // MedlemsNrTextBox
            // 
            this.MedlemsNrTextBox.Location = new System.Drawing.Point(355, 156);
            this.MedlemsNrTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MedlemsNrTextBox.Name = "MedlemsNrTextBox";
            this.MedlemsNrTextBox.Size = new System.Drawing.Size(127, 22);
            this.MedlemsNrTextBox.TabIndex = 3;
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Location = new System.Drawing.Point(224, 94);
            this.ISBNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(47, 17);
            this.ISBNLabel.TabIndex = 4;
            this.ISBNLabel.Text = "ISBN: ";
            // 
            // LabelMedlemNr
            // 
            this.LabelMedlemNr.AutoSize = true;
            this.LabelMedlemNr.Location = new System.Drawing.Point(224, 159);
            this.LabelMedlemNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMedlemNr.Name = "LabelMedlemNr";
            this.LabelMedlemNr.Size = new System.Drawing.Size(123, 17);
            this.LabelMedlemNr.TabIndex = 5;
            this.LabelMedlemNr.Text = "Medlemsnummer: ";
            // 
            // LabelRubrik
            // 
            this.LabelRubrik.AutoSize = true;
            this.LabelRubrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRubrik.Location = new System.Drawing.Point(16, 11);
            this.LabelRubrik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelRubrik.Name = "LabelRubrik";
            this.LabelRubrik.Size = new System.Drawing.Size(242, 31);
            this.LabelRubrik.TabIndex = 6;
            this.LabelRubrik.Text = "Registrera bokning";
            // 
            // MedlemsNrError
            // 
            this.MedlemsNrError.AutoSize = true;
            this.MedlemsNrError.Location = new System.Drawing.Point(227, 192);
            this.MedlemsNrError.Name = "MedlemsNrError";
            this.MedlemsNrError.Size = new System.Drawing.Size(12, 17);
            this.MedlemsNrError.TabIndex = 7;
            this.MedlemsNrError.Text = " ";
            // 
            // IsbnError
            // 
            this.IsbnError.AutoSize = true;
            this.IsbnError.Location = new System.Drawing.Point(227, 127);
            this.IsbnError.Name = "IsbnError";
            this.IsbnError.Size = new System.Drawing.Size(12, 17);
            this.IsbnError.TabIndex = 8;
            this.IsbnError.Text = " ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(743, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 22);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Datum";
            // 
            // Första
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1045, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IsbnError);
            this.Controls.Add(this.MedlemsNrError);
            this.Controls.Add(this.LabelRubrik);
            this.Controls.Add(this.LabelMedlemNr);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.MedlemsNrTextBox);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.dataGridViewBöcker);
            this.Controls.Add(this.bokaButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Första";
            this.Text = "       ";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBöcker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bokaButton;
        private System.Windows.Forms.DataGridView dataGridViewBöcker;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.TextBox MedlemsNrTextBox;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.Label LabelMedlemNr;
        private System.Windows.Forms.Label LabelRubrik;
        private System.Windows.Forms.Label MedlemsNrError;
        private System.Windows.Forms.Label IsbnError;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}