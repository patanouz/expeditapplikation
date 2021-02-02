
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
            this.dataGridViewÅterlämnade = new System.Windows.Forms.DataGridView();
            this.återlämnaButton = new System.Windows.Forms.Button();
            this.bokningsNummerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.medlemsNummerTextBox = new System.Windows.Forms.TextBox();
            this.bokTitelTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewÅterlämnade)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelRubrikÅterlämna
            // 
            this.LabelRubrikÅterlämna.AutoSize = true;
            this.LabelRubrikÅterlämna.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRubrikÅterlämna.Location = new System.Drawing.Point(12, 9);
            this.LabelRubrikÅterlämna.Name = "LabelRubrikÅterlämna";
            this.LabelRubrikÅterlämna.Size = new System.Drawing.Size(153, 26);
            this.LabelRubrikÅterlämna.TabIndex = 13;
            this.LabelRubrikÅterlämna.Text = "Återlämna bok";
            // 
            // dataGridViewÅterlämnade
            // 
            this.dataGridViewÅterlämnade.AllowUserToDeleteRows = false;
            this.dataGridViewÅterlämnade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewÅterlämnade.Location = new System.Drawing.Point(12, 73);
            this.dataGridViewÅterlämnade.Name = "dataGridViewÅterlämnade";
            this.dataGridViewÅterlämnade.ReadOnly = true;
            this.dataGridViewÅterlämnade.RowHeadersVisible = false;
            this.dataGridViewÅterlämnade.RowHeadersWidth = 51;
            this.dataGridViewÅterlämnade.Size = new System.Drawing.Size(760, 372);
            this.dataGridViewÅterlämnade.TabIndex = 8;
            this.dataGridViewÅterlämnade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewÅterlämnade_CellClick);
            // 
            // återlämnaButton
            // 
            this.återlämnaButton.BackColor = System.Drawing.Color.Lime;
            this.återlämnaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.återlämnaButton.FlatAppearance.BorderSize = 0;
            this.återlämnaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.återlämnaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.återlämnaButton.Location = new System.Drawing.Point(629, 492);
            this.återlämnaButton.Name = "återlämnaButton";
            this.återlämnaButton.Size = new System.Drawing.Size(143, 33);
            this.återlämnaButton.TabIndex = 7;
            this.återlämnaButton.Text = "Bekräfta återlämning";
            this.återlämnaButton.UseVisualStyleBackColor = false;
            this.återlämnaButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // bokningsNummerTextBox
            // 
            this.bokningsNummerTextBox.Location = new System.Drawing.Point(12, 505);
            this.bokningsNummerTextBox.Name = "bokningsNummerTextBox";
            this.bokningsNummerTextBox.Size = new System.Drawing.Size(100, 20);
            this.bokningsNummerTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bokningsnummer";
            // 
            // medlemsNummerTextBox
            // 
            this.medlemsNummerTextBox.Location = new System.Drawing.Point(130, 505);
            this.medlemsNummerTextBox.Name = "medlemsNummerTextBox";
            this.medlemsNummerTextBox.Size = new System.Drawing.Size(100, 20);
            this.medlemsNummerTextBox.TabIndex = 18;
            // 
            // bokTitelTextBox
            // 
            this.bokTitelTextBox.Location = new System.Drawing.Point(248, 505);
            this.bokTitelTextBox.Name = "bokTitelTextBox";
            this.bokTitelTextBox.Size = new System.Drawing.Size(188, 20);
            this.bokTitelTextBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Medlemsnummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Boktitel";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(657, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Visa alla bokningar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Andra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(784, 537);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bokTitelTextBox);
            this.Controls.Add(this.medlemsNummerTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bokningsNummerTextBox);
            this.Controls.Add(this.LabelRubrikÅterlämna);
            this.Controls.Add(this.dataGridViewÅterlämnade);
            this.Controls.Add(this.återlämnaButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.TextBox bokTitelTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}