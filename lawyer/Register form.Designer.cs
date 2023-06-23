namespace lawyer
{
    partial class Register_form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.first_name = new System.Windows.Forms.TextBox();
            this.Secound_name = new System.Windows.Forms.TextBox();
            this.initialize_name = new System.Windows.Forms.TextBox();
            this.id_number = new System.Windows.Forms.TextBox();
            this.next_button = new System.Windows.Forms.Button();
            this.fist_name_error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lawyer.Properties.Resources.Artboard_14;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1329, 770);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(246, 352);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(346, 22);
            this.first_name.TabIndex = 1;
            this.first_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.first_name_KeyDown);
            // 
            // Secound_name
            // 
            this.Secound_name.CausesValidation = false;
            this.Secound_name.Location = new System.Drawing.Point(246, 444);
            this.Secound_name.Name = "Secound_name";
            this.Secound_name.Size = new System.Drawing.Size(346, 22);
            this.Secound_name.TabIndex = 1;
            // 
            // initialize_name
            // 
            this.initialize_name.CausesValidation = false;
            this.initialize_name.Location = new System.Drawing.Point(246, 536);
            this.initialize_name.Name = "initialize_name";
            this.initialize_name.Size = new System.Drawing.Size(346, 22);
            this.initialize_name.TabIndex = 1;
            this.initialize_name.TextChanged += new System.EventHandler(this.initialize_name_TextChanged);
            // 
            // id_number
            // 
            this.id_number.CausesValidation = false;
            this.id_number.Location = new System.Drawing.Point(709, 352);
            this.id_number.Name = "id_number";
            this.id_number.Size = new System.Drawing.Size(346, 22);
            this.id_number.TabIndex = 1;
            // 
            // next_button
            // 
            this.next_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.next_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.next_button.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_button.ForeColor = System.Drawing.Color.Snow;
            this.next_button.Location = new System.Drawing.Point(788, 547);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(267, 31);
            this.next_button.TabIndex = 2;
            this.next_button.Text = "N E X T";
            this.next_button.UseVisualStyleBackColor = false;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // fist_name_error
            // 
            this.fist_name_error.AutoSize = true;
            this.fist_name_error.BackColor = System.Drawing.Color.Transparent;
            this.fist_name_error.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fist_name_error.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fist_name_error.ForeColor = System.Drawing.Color.Red;
            this.fist_name_error.Location = new System.Drawing.Point(242, 385);
            this.fist_name_error.Name = "fist_name_error";
            this.fist_name_error.Size = new System.Drawing.Size(154, 19);
            this.fist_name_error.TabIndex = 3;
            this.fist_name_error.Text = "Enter First Name Please";
            this.fist_name_error.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(242, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter First Name Please";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(705, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter First Name Please";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(242, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter First Name Please";
            this.label3.Visible = false;
            // 
            // Register_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 784);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fist_name_error);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.id_number);
            this.Controls.Add(this.initialize_name);
            this.Controls.Add(this.Secound_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Register_form";
            this.Text = "Register_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.TextBox Secound_name;
        private System.Windows.Forms.TextBox initialize_name;
        private System.Windows.Forms.TextBox id_number;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Label fist_name_error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}