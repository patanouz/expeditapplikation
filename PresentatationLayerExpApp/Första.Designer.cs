﻿
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.bokaButton.Location = new System.Drawing.Point(266, 187);
            this.bokaButton.Name = "bokaButton";
            this.bokaButton.Size = new System.Drawing.Size(96, 33);
            this.bokaButton.TabIndex = 0;
            this.bokaButton.Text = "Boka";
            this.bokaButton.UseVisualStyleBackColor = false;
            this.bokaButton.Click += new System.EventHandler(this.bokaButton_Click);
            // 
            // dataGridViewBöcker
            // 
            this.dataGridViewBöcker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBöcker.Location = new System.Drawing.Point(387, 73);
            this.dataGridViewBöcker.Name = "dataGridViewBöcker";
            this.dataGridViewBöcker.RowHeadersVisible = false;
            this.dataGridViewBöcker.RowHeadersWidth = 51;
            this.dataGridViewBöcker.Size = new System.Drawing.Size(285, 345);
            this.dataGridViewBöcker.TabIndex = 1;
            this.dataGridViewBöcker.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBöcker_CellClick);
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(267, 76);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(96, 20);
            this.ISBNTextBox.TabIndex = 2;
            // 
            // MedlemsNrTextBox
            // 
            this.MedlemsNrTextBox.Location = new System.Drawing.Point(266, 127);
            this.MedlemsNrTextBox.Name = "MedlemsNrTextBox";
            this.MedlemsNrTextBox.Size = new System.Drawing.Size(96, 20);
            this.MedlemsNrTextBox.TabIndex = 3;
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Location = new System.Drawing.Point(168, 76);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(38, 13);
            this.ISBNLabel.TabIndex = 4;
            this.ISBNLabel.Text = "ISBN: ";
            // 
            // LabelMedlemNr
            // 
            this.LabelMedlemNr.AutoSize = true;
            this.LabelMedlemNr.Location = new System.Drawing.Point(168, 129);
            this.LabelMedlemNr.Name = "LabelMedlemNr";
            this.LabelMedlemNr.Size = new System.Drawing.Size(92, 13);
            this.LabelMedlemNr.TabIndex = 5;
            this.LabelMedlemNr.Text = "Medlemsnummer: ";
            // 
            // LabelRubrik
            // 
            this.LabelRubrik.AutoSize = true;
            this.LabelRubrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRubrik.Location = new System.Drawing.Point(12, 9);
            this.LabelRubrik.Name = "LabelRubrik";
            this.LabelRubrik.Size = new System.Drawing.Size(194, 26);
            this.LabelRubrik.TabIndex = 6;
            this.LabelRubrik.Text = "Registrera bokning";
            // 
            // MedlemsNrError
            // 
            this.MedlemsNrError.AutoSize = true;
            this.MedlemsNrError.ForeColor = System.Drawing.Color.Red;
            this.MedlemsNrError.Location = new System.Drawing.Point(170, 156);
            this.MedlemsNrError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MedlemsNrError.Name = "MedlemsNrError";
            this.MedlemsNrError.Size = new System.Drawing.Size(0, 13);
            this.MedlemsNrError.TabIndex = 7;
            // 
            // IsbnError
            // 
            this.IsbnError.AutoSize = true;
            this.IsbnError.ForeColor = System.Drawing.Color.Red;
            this.IsbnError.Location = new System.Drawing.Point(170, 103);
            this.IsbnError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IsbnError.Name = "IsbnError";
            this.IsbnError.Size = new System.Drawing.Size(0, 13);
            this.IsbnError.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(387, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Visa utlånade böcker";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Första
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(784, 537);
            this.Controls.Add(this.checkBox1);
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
        private System.Windows.Forms.CheckBox checkBox1;
    }
}