
namespace PresentatationLayerExpApp
{
    partial class LoginUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.loggaInButton = new System.Windows.Forms.Button();
            this.labelAnställning = new System.Windows.Forms.Label();
            this.labenLösenord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 111);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FelhanteringInlogg_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 156);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(116, 21);
            this.textBox2.TabIndex = 1;
            // 
            // loggaInButton
            // 
            this.loggaInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(140)))));
            this.loggaInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loggaInButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(140)))));
            this.loggaInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loggaInButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.loggaInButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loggaInButton.Location = new System.Drawing.Point(172, 219);
            this.loggaInButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loggaInButton.Name = "loggaInButton";
            this.loggaInButton.Size = new System.Drawing.Size(117, 33);
            this.loggaInButton.TabIndex = 2;
            this.loggaInButton.Text = "Logga in";
            this.loggaInButton.UseVisualStyleBackColor = false;
            this.loggaInButton.Click += new System.EventHandler(this.LogginButton_Click);
            // 
            // labelAnställning
            // 
            this.labelAnställning.AutoSize = true;
            this.labelAnställning.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnställning.Location = new System.Drawing.Point(59, 111);
            this.labelAnställning.Name = "labelAnställning";
            this.labelAnställning.Size = new System.Drawing.Size(105, 17);
            this.labelAnställning.TabIndex = 3;
            this.labelAnställning.Text = "AnställningsNr: ";
            // 
            // labenLösenord
            // 
            this.labenLösenord.AutoSize = true;
            this.labenLösenord.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labenLösenord.Location = new System.Drawing.Point(59, 156);
            this.labenLösenord.Name = "labenLösenord";
            this.labenLösenord.Size = new System.Drawing.Size(74, 17);
            this.labenLösenord.TabIndex = 4;
            this.labenLösenord.Text = "Lösenord: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = " ";
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.Font = new System.Drawing.Font("Century Gothic", 16.25F);
            this.loginTitle.Location = new System.Drawing.Point(57, 33);
            this.loginTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(126, 25);
            this.loginTitle.TabIndex = 7;
            this.loginTitle.Text = "Inloggning";
            // 
            // LoginUI
            // 
            this.AcceptButton = this.loggaInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(218)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(384, 325);
            this.Controls.Add(this.loginTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labenLösenord);
            this.Controls.Add(this.labelAnställning);
            this.Controls.Add(this.loggaInButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginUI";
            this.Text = "Expeditapplikation";
            this.Load += new System.EventHandler(this.Login_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loginTitle;
    }
}