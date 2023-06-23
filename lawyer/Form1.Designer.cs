namespace lawyer
{
    partial class Form1
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
            this.login_butten = new System.Windows.Forms.Button();
            this.email_text = new System.Windows.Forms.TextBox();
            this.Password_text = new System.Windows.Forms.TextBox();
            this.Creat_account_label = new System.Windows.Forms.Label();
            this.forgot_password_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_butten
            // 
            this.login_butten.BackColor = System.Drawing.SystemColors.HotTrack;
            this.login_butten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_butten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_butten.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_butten.Location = new System.Drawing.Point(342, 633);
            this.login_butten.Name = "login_butten";
            this.login_butten.Size = new System.Drawing.Size(317, 40);
            this.login_butten.TabIndex = 1;
            this.login_butten.Text = "L O G I N";
            this.login_butten.UseVisualStyleBackColor = false;
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(293, 461);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(434, 22);
            this.email_text.TabIndex = 2;
            // 
            // Password_text
            // 
            this.Password_text.Location = new System.Drawing.Point(293, 531);
            this.Password_text.Name = "Password_text";
            this.Password_text.PasswordChar = '*';
            this.Password_text.Size = new System.Drawing.Size(434, 22);
            this.Password_text.TabIndex = 2;
            // 
            // Creat_account_label
            // 
            this.Creat_account_label.AutoSize = true;
            this.Creat_account_label.BackColor = System.Drawing.Color.Transparent;
            this.Creat_account_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Creat_account_label.Location = new System.Drawing.Point(456, 688);
            this.Creat_account_label.Name = "Creat_account_label";
            this.Creat_account_label.Size = new System.Drawing.Size(90, 16);
            this.Creat_account_label.TabIndex = 3;
            this.Creat_account_label.Text = "Creat Account";
            this.Creat_account_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // forgot_password_label
            // 
            this.forgot_password_label.AutoSize = true;
            this.forgot_password_label.BackColor = System.Drawing.Color.Transparent;
            this.forgot_password_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.forgot_password_label.Location = new System.Drawing.Point(637, 580);
            this.forgot_password_label.Name = "forgot_password_label";
            this.forgot_password_label.Size = new System.Drawing.Size(103, 16);
            this.forgot_password_label.TabIndex = 3;
            this.forgot_password_label.Text = "forgot password";
            this.forgot_password_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lawyer.Properties.Resources.Artboard_12;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1612, 832);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 831);
            this.Controls.Add(this.forgot_password_label);
            this.Controls.Add(this.Creat_account_label);
            this.Controls.Add(this.Password_text);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.login_butten);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button login_butten;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.TextBox Password_text;
        private System.Windows.Forms.Label Creat_account_label;
        private System.Windows.Forms.Label forgot_password_label;
    }
}

