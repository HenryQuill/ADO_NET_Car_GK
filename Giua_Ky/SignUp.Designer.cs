namespace Giua_Ky
{
	partial class SignUp
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
			txtUserName = new TextBox();
			txtPass = new TextBox();
			txtName = new TextBox();
			txtPhone = new TextBox();
			txtAddress = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			btnSignUp = new Button();
			btnBack = new Button();
			SuspendLayout();
			// 
			// txtUserName
			// 
			txtUserName.Location = new Point(326, 73);
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new Size(190, 27);
			txtUserName.TabIndex = 0;
			// 
			// txtPass
			// 
			txtPass.Location = new Point(326, 118);
			txtPass.Name = "txtPass";
			txtPass.Size = new Size(190, 27);
			txtPass.TabIndex = 1;
			// 
			// txtName
			// 
			txtName.Location = new Point(326, 162);
			txtName.Name = "txtName";
			txtName.Size = new Size(190, 27);
			txtName.TabIndex = 2;
			// 
			// txtPhone
			// 
			txtPhone.Location = new Point(326, 207);
			txtPhone.Name = "txtPhone";
			txtPhone.Size = new Size(190, 27);
			txtPhone.TabIndex = 3;
			// 
			// txtAddress
			// 
			txtAddress.Location = new Point(326, 249);
			txtAddress.Name = "txtAddress";
			txtAddress.Size = new Size(190, 27);
			txtAddress.TabIndex = 4;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(181, 73);
			label1.Name = "label1";
			label1.Size = new Size(82, 20);
			label1.TabIndex = 5;
			label1.Text = "User Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(181, 118);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 6;
			label2.Text = "Password";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(181, 162);
			label3.Name = "label3";
			label3.Size = new Size(49, 20);
			label3.TabIndex = 7;
			label3.Text = "Name";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(181, 207);
			label4.Name = "label4";
			label4.Size = new Size(50, 20);
			label4.TabIndex = 8;
			label4.Text = "Phone";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(181, 249);
			label5.Name = "label5";
			label5.Size = new Size(62, 20);
			label5.TabIndex = 9;
			label5.Text = "Address";
			label5.Click += label5_Click;
			// 
			// btnSignUp
			// 
			btnSignUp.Location = new Point(422, 292);
			btnSignUp.Name = "btnSignUp";
			btnSignUp.Size = new Size(94, 29);
			btnSignUp.TabIndex = 10;
			btnSignUp.Text = "Sign Up";
			btnSignUp.UseVisualStyleBackColor = true;
			btnSignUp.Click += btnSignUp_Click;
			// 
			// btnBack
			// 
			btnBack.Location = new Point(181, 292);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(94, 29);
			btnBack.TabIndex = 11;
			btnBack.Text = "Back";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// SignUp
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnBack);
			Controls.Add(btnSignUp);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtAddress);
			Controls.Add(txtPhone);
			Controls.Add(txtName);
			Controls.Add(txtPass);
			Controls.Add(txtUserName);
			Name = "SignUp";
			Text = "Sign Up";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtUserName;
		private TextBox txtPass;
		private TextBox txtName;
		private TextBox txtPhone;
		private TextBox txtAddress;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Button btnSignUp;
		private Button btnBack;
	}
}