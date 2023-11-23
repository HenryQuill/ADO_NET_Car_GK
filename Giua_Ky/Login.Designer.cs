namespace Giua_Ky
{
	partial class Login
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			label2 = new Label();
			txtUserName = new TextBox();
			txtPass = new TextBox();
			label1 = new Label();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			btnLogin = new Button();
			btnSignUp = new Button();
			label3 = new Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveCaption;
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(label2);
			panel1.Location = new Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(212, 426);
			panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(39, 49);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(137, 137);
			pictureBox1.TabIndex = 5;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(39, 218);
			label2.Name = "label2";
			label2.Size = new Size(137, 20);
			label2.TabIndex = 4;
			label2.Text = "Car Renting Service";
			// 
			// txtUserName
			// 
			txtUserName.Location = new Point(294, 108);
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new Size(494, 27);
			txtUserName.TabIndex = 1;
			// 
			// txtPass
			// 
			txtPass.Location = new Point(294, 159);
			txtPass.Name = "txtPass";
			txtPass.Size = new Size(494, 27);
			txtPass.TabIndex = 2;
			txtPass.TextChanged += txtPass_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(389, 61);
			label1.Name = "label1";
			label1.Size = new Size(221, 28);
			label1.TabIndex = 3;
			label1.Text = "Please login to continue";
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(252, 108);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(27, 27);
			pictureBox2.TabIndex = 4;
			pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(252, 159);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(27, 27);
			pictureBox3.TabIndex = 5;
			pictureBox3.TabStop = false;
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(351, 208);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(114, 29);
			btnLogin.TabIndex = 6;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// btnSignUp
			// 
			btnSignUp.Location = new Point(583, 208);
			btnSignUp.Name = "btnSignUp";
			btnSignUp.Size = new Size(110, 29);
			btnSignUp.TabIndex = 7;
			btnSignUp.Text = "Sign Up";
			btnSignUp.UseVisualStyleBackColor = true;
			btnSignUp.Click += btnSignUp_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("STCaiyun", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(243, 12);
			label3.Name = "label3";
			label3.Size = new Size(546, 38);
			label3.TabIndex = 8;
			label3.Text = "Welcome To Car Renting Service";
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label3);
			Controls.Add(btnSignUp);
			Controls.Add(btnLogin);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(label1);
			Controls.Add(txtPass);
			Controls.Add(txtUserName);
			Controls.Add(panel1);
			Name = "Login";
			Text = "Login";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		private Label label2;
		private TextBox txtUserName;
		private TextBox txtPass;
		private Label label1;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private Button btnLogin;
		private Button btnSignUp;
		private Label label3;
	}
}