using System.Windows.Forms;

namespace Giua_Ky
{
	partial class Customer_Management
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Management));
			btnBack = new Button();
			gridCustomer = new DataGridView();
			UserName = new DataGridViewTextBoxColumn();
			Password = new DataGridViewTextBoxColumn();
			CustomerName = new DataGridViewTextBoxColumn();
			Phone = new DataGridViewTextBoxColumn();
			Address = new DataGridViewTextBoxColumn();
			btnAdd = new Button();
			btnRemove = new Button();
			btnSearch = new Button();
			btnEdit = new Button();
			btnCar = new Button();
			btnExport = new Button();
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			txbSearch = new TextBox();
			((System.ComponentModel.ISupportInitialize)gridCustomer).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// btnBack
			// 
			btnBack.Location = new Point(816, 301);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(94, 29);
			btnBack.TabIndex = 0;
			btnBack.Text = "Back";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// gridCustomer
			// 
			gridCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridCustomer.Columns.AddRange(new DataGridViewColumn[] { UserName, Password, CustomerName, Phone, Address });
			gridCustomer.Location = new Point(235, 47);
			gridCustomer.Name = "gridCustomer";
			gridCustomer.RowHeadersWidth = 51;
			gridCustomer.RowTemplate.Height = 29;
			gridCustomer.Size = new Size(672, 234);
			gridCustomer.TabIndex = 1;
			gridCustomer.CellContentClick += gridCustomer_CellContentClick;
			gridCustomer.CellEndEdit += gridCustomer_CellEndEdit;
			// 
			// UserName
			// 
			UserName.HeaderText = "UserName";
			UserName.MinimumWidth = 6;
			UserName.Name = "UserName";
			UserName.Width = 125;
			// 
			// Password
			// 
			Password.HeaderText = "Password";
			Password.MinimumWidth = 6;
			Password.Name = "Password";
			Password.Width = 125;
			// 
			// CustomerName
			// 
			CustomerName.HeaderText = "Name";
			CustomerName.MinimumWidth = 6;
			CustomerName.Name = "CustomerName";
			CustomerName.Width = 125;
			// 
			// Phone
			// 
			Phone.HeaderText = "Phone";
			Phone.MinimumWidth = 6;
			Phone.Name = "Phone";
			Phone.Width = 125;
			// 
			// Address
			// 
			Address.HeaderText = "Address";
			Address.MinimumWidth = 6;
			Address.Name = "Address";
			Address.Width = 125;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(235, 301);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(94, 29);
			btnAdd.TabIndex = 2;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnRemove
			// 
			btnRemove.Location = new Point(380, 301);
			btnRemove.Name = "btnRemove";
			btnRemove.Size = new Size(94, 29);
			btnRemove.TabIndex = 3;
			btnRemove.Text = "Remove";
			btnRemove.UseVisualStyleBackColor = true;
			btnRemove.Click += btnRemove_Click;
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(840, 12);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(70, 29);
			btnSearch.TabIndex = 4;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(525, 301);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(94, 29);
			btnEdit.TabIndex = 5;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnCar
			// 
			btnCar.Location = new Point(31, 368);
			btnCar.Name = "btnCar";
			btnCar.Size = new Size(137, 70);
			btnCar.TabIndex = 6;
			btnCar.Text = "Car Management";
			btnCar.UseVisualStyleBackColor = true;
			btnCar.Click += btnCar_Click;
			// 
			// btnExport
			// 
			btnExport.Location = new Point(31, 235);
			btnExport.Name = "btnExport";
			btnExport.Size = new Size(133, 67);
			btnExport.TabIndex = 7;
			btnExport.Text = "Export Customer List (Excel File)";
			btnExport.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveCaption;
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(btnCar);
			panel1.Controls.Add(btnExport);
			panel1.Location = new Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(196, 489);
			panel1.TabIndex = 8;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(31, 35);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(137, 137);
			pictureBox1.TabIndex = 10;
			pictureBox1.TabStop = false;
			// 
			// txbSearch
			// 
			txbSearch.Location = new Point(235, 12);
			txbSearch.Name = "txbSearch";
			txbSearch.Size = new Size(599, 27);
			txbSearch.TabIndex = 9;
			// 
			// Customer_Management
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(919, 513);
			Controls.Add(txbSearch);
			Controls.Add(panel1);
			Controls.Add(btnEdit);
			Controls.Add(btnSearch);
			Controls.Add(btnRemove);
			Controls.Add(btnAdd);
			Controls.Add(gridCustomer);
			Controls.Add(btnBack);
			Name = "Customer_Management";
			Text = "Customer Management";
			((System.ComponentModel.ISupportInitialize)gridCustomer).EndInit();
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnBack;
		private DataGridView gridCustomer;
		private Button btnAdd;
		private Button btnRemove;
		private Button btnSearch;
		private Button btnEdit;
		private Button btnCar;
		private Button btnExport;
		private Panel panel1;
		private TextBox txbSearch;
		private DataGridViewTextBoxColumn UserName;
		private DataGridViewTextBoxColumn Password;
		private DataGridViewTextBoxColumn CustomerName;
		private DataGridViewTextBoxColumn Phone;
		private DataGridViewTextBoxColumn Address;
		private PictureBox pictureBox1;
	}
}