namespace loginsystem
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.login_image = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.register_button_on_login_page = new System.Windows.Forms.Button();
			this.register_label = new System.Windows.Forms.Label();
			this.close_login_button = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.username_label = new System.Windows.Forms.Label();
			this.username_textbox = new System.Windows.Forms.TextBox();
			this.password_textbox = new System.Windows.Forms.TextBox();
			this.password_label = new System.Windows.Forms.Label();
			this.password_checkbox = new System.Windows.Forms.CheckBox();
			this.login_button = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.login_image)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SlateBlue;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.login_image);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.register_button_on_login_page);
			this.panel1.Controls.Add(this.register_label);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.ForeColor = System.Drawing.SystemColors.Control;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(232, 400);
			this.panel1.TabIndex = 0;
			// 
			// login_image
			// 
			this.login_image.BackColor = System.Drawing.Color.Transparent;
			this.login_image.BackgroundImage = global::loginsystem.Properties.Resources.health_hands;
			this.login_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.login_image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.login_image.Location = new System.Drawing.Point(62, 20);
			this.login_image.Name = "login_image";
			this.login_image.Size = new System.Drawing.Size(100, 100);
			this.login_image.TabIndex = 11;
			this.login_image.TabStop = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(224, 64);
			this.label4.TabIndex = 10;
			this.label4.Text = "Welcome to my Login Test";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// register_button_on_login_page
			// 
			this.register_button_on_login_page.BackColor = System.Drawing.Color.White;
			this.register_button_on_login_page.Cursor = System.Windows.Forms.Cursors.Hand;
			this.register_button_on_login_page.FlatAppearance.BorderSize = 0;
			this.register_button_on_login_page.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.register_button_on_login_page.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.register_button_on_login_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.register_button_on_login_page.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_button_on_login_page.ForeColor = System.Drawing.Color.SlateBlue;
			this.register_button_on_login_page.Location = new System.Drawing.Point(11, 334);
			this.register_button_on_login_page.Name = "register_button_on_login_page";
			this.register_button_on_login_page.Size = new System.Drawing.Size(204, 42);
			this.register_button_on_login_page.TabIndex = 10;
			this.register_button_on_login_page.Text = "Register";
			this.register_button_on_login_page.UseVisualStyleBackColor = false;
			this.register_button_on_login_page.Click += new System.EventHandler(this.register_button_on_login_page_Click);
			// 
			// register_label
			// 
			this.register_label.AutoSize = true;
			this.register_label.BackColor = System.Drawing.Color.Transparent;
			this.register_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_label.ForeColor = System.Drawing.Color.Black;
			this.register_label.Location = new System.Drawing.Point(23, 293);
			this.register_label.Name = "register_label";
			this.register_label.Size = new System.Drawing.Size(180, 21);
			this.register_label.TabIndex = 10;
			this.register_label.Text = "Register Account Here";
			this.register_label.Click += new System.EventHandler(this.label1_Click);
			// 
			// close_login_button
			// 
			this.close_login_button.AutoSize = true;
			this.close_login_button.BackColor = System.Drawing.Color.SlateBlue;
			this.close_login_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.close_login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.close_login_button.Location = new System.Drawing.Point(574, 9);
			this.close_login_button.Name = "close_login_button";
			this.close_login_button.Size = new System.Drawing.Size(16, 16);
			this.close_login_button.TabIndex = 1;
			this.close_login_button.Text = "X";
			this.close_login_button.Click += new System.EventHandler(this.close_login_button_Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(238, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(158, 37);
			this.label2.TabIndex = 2;
			this.label2.Text = "Login Here";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// username_label
			// 
			this.username_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username_label.Location = new System.Drawing.Point(240, 103);
			this.username_label.Name = "username_label";
			this.username_label.Size = new System.Drawing.Size(102, 32);
			this.username_label.TabIndex = 3;
			this.username_label.Text = "Username:";
			this.username_label.Click += new System.EventHandler(this.label3_Click);
			// 
			// username_textbox
			// 
			this.username_textbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.username_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.username_textbox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username_textbox.Location = new System.Drawing.Point(244, 129);
			this.username_textbox.Multiline = true;
			this.username_textbox.Name = "username_textbox";
			this.username_textbox.Size = new System.Drawing.Size(344, 30);
			this.username_textbox.TabIndex = 5;
			// 
			// password_textbox
			// 
			this.password_textbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.password_textbox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password_textbox.Location = new System.Drawing.Point(244, 206);
			this.password_textbox.Multiline = true;
			this.password_textbox.Name = "password_textbox";
			this.password_textbox.PasswordChar = '*';
			this.password_textbox.Size = new System.Drawing.Size(344, 30);
			this.password_textbox.TabIndex = 7;
			this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
			// 
			// password_label
			// 
			this.password_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password_label.Location = new System.Drawing.Point(240, 180);
			this.password_label.Name = "password_label";
			this.password_label.Size = new System.Drawing.Size(102, 32);
			this.password_label.TabIndex = 6;
			this.password_label.Text = "Password:";
			// 
			// password_checkbox
			// 
			this.password_checkbox.AutoSize = true;
			this.password_checkbox.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password_checkbox.Location = new System.Drawing.Point(488, 242);
			this.password_checkbox.Name = "password_checkbox";
			this.password_checkbox.Size = new System.Drawing.Size(108, 20);
			this.password_checkbox.TabIndex = 8;
			this.password_checkbox.Text = "Show Password";
			this.password_checkbox.UseVisualStyleBackColor = true;
			this.password_checkbox.CheckedChanged += new System.EventHandler(this.password_checkbox_CheckedChanged);
			// 
			// login_button
			// 
			this.login_button.BackColor = System.Drawing.Color.SlateBlue;
			this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.login_button.FlatAppearance.BorderSize = 0;
			this.login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
			this.login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
			this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.login_button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_button.Location = new System.Drawing.Point(244, 284);
			this.login_button.Name = "login_button";
			this.login_button.Size = new System.Drawing.Size(98, 42);
			this.login_button.TabIndex = 9;
			this.login_button.Text = "Login";
			this.login_button.UseVisualStyleBackColor = false;
			this.login_button.Click += new System.EventHandler(this.login_button_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.Add(this.login_button);
			this.Controls.Add(this.password_checkbox);
			this.Controls.Add(this.password_textbox);
			this.Controls.Add(this.password_label);
			this.Controls.Add(this.username_textbox);
			this.Controls.Add(this.username_label);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.close_login_button);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.login_image)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label close_login_button;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label username_label;
		private System.Windows.Forms.TextBox username_textbox;
		private System.Windows.Forms.TextBox password_textbox;
		private System.Windows.Forms.Label password_label;
		private System.Windows.Forms.CheckBox password_checkbox;
		private System.Windows.Forms.Button login_button;
		private System.Windows.Forms.Button register_button_on_login_page;
		private System.Windows.Forms.Label register_label;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox login_image;
	}
}

