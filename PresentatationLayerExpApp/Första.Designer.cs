
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
            this.MedlemsNrTextBox = new System.Windows.Forms.TextBox();
            this.LabelMedlemNr = new System.Windows.Forms.Label();
            this.LabelRubrik = new System.Windows.Forms.Label();
            this.MedlemsNrError = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bookingErrorMessage = new System.Windows.Forms.Label();
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
            this.bokaButton.Location = new System.Drawing.Point(788, 594);
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
            this.dataGridViewBöcker.Location = new System.Drawing.Point(17, 136);
            this.dataGridViewBöcker.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBöcker.Name = "dataGridViewBöcker";
            this.dataGridViewBöcker.RowHeadersVisible = false;
            this.dataGridViewBöcker.RowHeadersWidth = 51;
            this.dataGridViewBöcker.Size = new System.Drawing.Size(560, 455);
            this.dataGridViewBöcker.TabIndex = 1;
            this.dataGridViewBöcker.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewBöcker_DataBindingComplete);
            // 
            // MedlemsNrTextBox
            // 
            this.MedlemsNrTextBox.Location = new System.Drawing.Point(179, 615);
            this.MedlemsNrTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MedlemsNrTextBox.Name = "MedlemsNrTextBox";
            this.MedlemsNrTextBox.Size = new System.Drawing.Size(127, 22);
            this.MedlemsNrTextBox.TabIndex = 3;
            // 
            // LabelMedlemNr
            // 
            this.LabelMedlemNr.AutoSize = true;
            this.LabelMedlemNr.Location = new System.Drawing.Point(14, 618);
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
            this.LabelRubrik.Location = new System.Drawing.Point(11, 9);
            this.LabelRubrik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelRubrik.Name = "LabelRubrik";
            this.LabelRubrik.Size = new System.Drawing.Size(242, 31);
            this.LabelRubrik.TabIndex = 6;
            this.LabelRubrik.Text = "Registrera bokning";
            // 
            // MedlemsNrError
            // 
            this.MedlemsNrError.AutoSize = true;
            this.MedlemsNrError.ForeColor = System.Drawing.Color.Red;
            this.MedlemsNrError.Location = new System.Drawing.Point(14, 635);
            this.MedlemsNrError.Name = "MedlemsNrError";
            this.MedlemsNrError.Size = new System.Drawing.Size(0, 17);
            this.MedlemsNrError.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(414, 95);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Visa utlånade böcker";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(17, 94);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(170, 22);
            this.dateTimePicker.TabIndex = 10;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // bookingErrorMessage
            // 
            this.bookingErrorMessage.AutoSize = true;
            this.bookingErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.bookingErrorMessage.Location = new System.Drawing.Point(14, 595);
            this.bookingErrorMessage.Name = "bookingErrorMessage";
            this.bookingErrorMessage.Size = new System.Drawing.Size(12, 17);
            this.bookingErrorMessage.TabIndex = 11;
            this.bookingErrorMessage.Text = " ";
            // 
            // Första
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1045, 661);
            this.Controls.Add(this.bookingErrorMessage);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.MedlemsNrError);
            this.Controls.Add(this.LabelRubrik);
            this.Controls.Add(this.LabelMedlemNr);
            this.Controls.Add(this.MedlemsNrTextBox);
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
        private System.Windows.Forms.TextBox MedlemsNrTextBox;
        private System.Windows.Forms.Label LabelMedlemNr;
        private System.Windows.Forms.Label LabelRubrik;
        private System.Windows.Forms.Label MedlemsNrError;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label bookingErrorMessage;
    }
}