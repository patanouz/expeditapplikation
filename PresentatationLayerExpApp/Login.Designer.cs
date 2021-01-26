
namespace PresentatationLayerExpApp
{
    partial class Login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.loggaInButton = new System.Windows.Forms.Button();
            this.labelAnställning = new System.Windows.Forms.Label();
            this.labenLösenord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // loggaInButton
            // 
            this.loggaInButton.BackColor = System.Drawing.Color.Lime;
            this.loggaInButton.FlatAppearance.BorderSize = 0;
            this.loggaInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loggaInButton.Location = new System.Drawing.Point(109, 164);
            this.loggaInButton.Name = "loggaInButton";
            this.loggaInButton.Size = new System.Drawing.Size(100, 27);
            this.loggaInButton.TabIndex = 2;
            this.loggaInButton.Text = "Logga in";
            this.loggaInButton.UseVisualStyleBackColor = false;
            this.loggaInButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAnställning
            // 
            this.labelAnställning.AutoSize = true;
            this.labelAnställning.Location = new System.Drawing.Point(12, 76);
            this.labelAnställning.Name = "labelAnställning";
            this.labelAnställning.Size = new System.Drawing.Size(80, 13);
            this.labelAnställning.TabIndex = 3;
            this.labelAnställning.Text = "AnställningsNr: ";
            // 
            // labenLösenord
            // 
            this.labenLösenord.AutoSize = true;
            this.labenLösenord.Location = new System.Drawing.Point(12, 131);
            this.labenLösenord.Name = "labenLösenord";
            this.labenLösenord.Size = new System.Drawing.Size(57, 13);
            this.labenLösenord.TabIndex = 4;
            this.labenLösenord.Text = "Lösenord: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 5;
            // 
            // Login
            // 
            this.AcceptButton = this.loggaInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labenLösenord);
            this.Controls.Add(this.labelAnställning);
            this.Controls.Add(this.loggaInButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button loggaInButton;
        private System.Windows.Forms.Label labelAnställning;
        private System.Windows.Forms.Label labenLösenord;
        private System.Windows.Forms.Label label1;
    }
}