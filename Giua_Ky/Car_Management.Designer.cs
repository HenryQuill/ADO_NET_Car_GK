namespace Giua_Ky
{
	partial class Car_Management
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car_Management));
			gridCar = new DataGridView();
			Car_ID = new DataGridViewTextBoxColumn();
			Car_Type = new DataGridViewTextBoxColumn();
			Manufacturer = new DataGridViewTextBoxColumn();
			Car_Name = new DataGridViewTextBoxColumn();
			Rented_Status = new DataGridViewCheckBoxColumn();
			Seats = new DataGridViewTextBoxColumn();
			Price = new DataGridViewTextBoxColumn();
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			btnImport = new Button();
			button2 = new Button();
			btnAdd = new Button();
			btnRemove = new Button();
			btnEdit = new Button();
			txbSearch = new TextBox();
			btnSearch = new Button();
			btnBack = new Button();
			((System.ComponentModel.ISupportInitialize)gridCar).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// gridCar
			// 
			gridCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridCar.Columns.AddRange(new DataGridViewColumn[] { Car_ID, Car_Type, Manufacturer, Car_Name, Rented_Status, Seats, Price });
			gridCar.Location = new Point(233, 45);
			gridCar.Name = "gridCar";
			gridCar.RowHeadersWidth = 51;
			gridCar.RowTemplate.Height = 29;
			gridCar.Size = new Size(912, 222);
			gridCar.TabIndex = 5;
			gridCar.CellContentClick += gridCar_CellContentClick;
			gridCar.CellEndEdit += gridCar_CellEndEdit;
			// 
			// Car_ID
			// 
			Car_ID.HeaderText = "Car_ID";
			Car_ID.MinimumWidth = 6;
			Car_ID.Name = "Car_ID";
			Car_ID.Width = 125;
			// 
			// Car_Type
			// 
			Car_Type.HeaderText = "Car_Type";
			Car_Type.MinimumWidth = 6;
			Car_Type.Name = "Car_Type";
			Car_Type.Width = 125;
			// 
			// Manufacturer
			// 
			Manufacturer.HeaderText = "Manufacturer";
			Manufacturer.MinimumWidth = 6;
			Manufacturer.Name = "Manufacturer";
			Manufacturer.Width = 125;
			// 
			// Car_Name
			// 
			Car_Name.HeaderText = "Car_Name";
			Car_Name.MinimumWidth = 6;
			Car_Name.Name = "Car_Name";
			Car_Name.Width = 125;
			// 
			// Rented_Status
			// 
			Rented_Status.HeaderText = "Rented_Status";
			Rented_Status.MinimumWidth = 6;
			Rented_Status.Name = "Rented_Status";
			Rented_Status.Width = 125;
			// 
			// Seats
			// 
			Seats.HeaderText = "Seats";
			Seats.MinimumWidth = 6;
			Seats.Name = "Seats";
			Seats.Resizable = DataGridViewTriState.True;
			Seats.SortMode = DataGridViewColumnSortMode.NotSortable;
			Seats.Width = 125;
			// 
			// Price
			// 
			Price.HeaderText = "Price";
			Price.MinimumWidth = 6;
			Price.Name = "Price";
			Price.Resizable = DataGridViewTriState.True;
			Price.SortMode = DataGridViewColumnSortMode.NotSortable;
			Price.Width = 125;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveCaption;
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(btnImport);
			panel1.Controls.Add(button2);
			panel1.Location = new Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(215, 426);
			panel1.TabIndex = 10;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(41, 33);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(137, 137);
			pictureBox1.TabIndex = 8;
			pictureBox1.TabStop = false;
			// 
			// btnImport
			// 
			btnImport.Location = new Point(41, 221);
			btnImport.Name = "btnImport";
			btnImport.Size = new Size(137, 54);
			btnImport.TabIndex = 6;
			btnImport.Text = "Import Car List (Excel File) ";
			btnImport.UseVisualStyleBackColor = true;
			btnImport.Click += btnImport_Click;
			// 
			// button2
			// 
			button2.Location = new Point(41, 325);
			button2.Name = "button2";
			button2.Size = new Size(137, 54);
			button2.TabIndex = 7;
			button2.Text = "Customer Management";
			button2.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(233, 285);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(108, 29);
			btnAdd.TabIndex = 8;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnRemove
			// 
			btnRemove.Location = new Point(378, 285);
			btnRemove.Name = "btnRemove";
			btnRemove.Size = new Size(111, 29);
			btnRemove.TabIndex = 8;
			btnRemove.Text = "Remove";
			btnRemove.UseVisualStyleBackColor = true;
			btnRemove.Click += btnRemove_Click;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(515, 285);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(111, 29);
			btnEdit.TabIndex = 11;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// txbSearch
			// 
			txbSearch.Location = new Point(233, 12);
			txbSearch.Name = "txbSearch";
			txbSearch.Size = new Size(803, 27);
			txbSearch.TabIndex = 12;
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(1042, 10);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(103, 29);
			btnSearch.TabIndex = 13;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click;
			// 
			// btnBack
			// 
			btnBack.Location = new Point(1042, 285);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(103, 29);
			btnBack.TabIndex = 14;
			btnBack.Text = "Back";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// Car_Management
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1157, 450);
			Controls.Add(btnBack);
			Controls.Add(btnSearch);
			Controls.Add(txbSearch);
			Controls.Add(btnEdit);
			Controls.Add(btnRemove);
			Controls.Add(btnAdd);
			Controls.Add(panel1);
			Controls.Add(gridCar);
			Name = "Car_Management";
			Text = "Car_Management";
			((System.ComponentModel.ISupportInitialize)gridCar).EndInit();
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView gridCar;
		private DataGridViewTextBoxColumn Car_ID;
		private DataGridViewTextBoxColumn Car_Type;
		private DataGridViewTextBoxColumn Manufacturer;
		private DataGridViewTextBoxColumn Car_Name;
		private DataGridViewCheckBoxColumn Rented_Status;
		private DataGridViewTextBoxColumn Seats;
		private DataGridViewTextBoxColumn Price;
		private Panel panel1;
		private Button btnImport;
		private Button button2;
		private Button btnAdd;
		private Button btnRemove;
		private Button btnEdit;
		private TextBox txbSearch;
		private Button btnSearch;
		private Button btnBack;
		private PictureBox pictureBox1;
	}
}