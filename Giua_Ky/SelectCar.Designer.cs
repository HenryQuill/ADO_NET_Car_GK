namespace Giua_Ky
{
	partial class SelectCar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCar));
			btnBack = new Button();
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
			button2 = new Button();
			label1 = new Label();
			txbSearch = new TextBox();
			btnSearch = new Button();
			((System.ComponentModel.ISupportInitialize)gridCar).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// btnBack
			// 
			btnBack.Location = new Point(1052, 327);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(94, 29);
			btnBack.TabIndex = 3;
			btnBack.Text = "Back";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// gridCar
			// 
			gridCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridCar.Columns.AddRange(new DataGridViewColumn[] { Car_ID, Car_Type, Manufacturer, Car_Name, Rented_Status, Seats, Price });
			gridCar.Location = new Point(218, 85);
			gridCar.Name = "gridCar";
			gridCar.RowHeadersWidth = 51;
			gridCar.RowTemplate.Height = 29;
			gridCar.Size = new Size(928, 222);
			gridCar.TabIndex = 4;
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
			panel1.Controls.Add(button2);
			panel1.Location = new Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(196, 426);
			panel1.TabIndex = 9;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(33, 38);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(137, 137);
			pictureBox1.TabIndex = 12;
			pictureBox1.TabStop = false;
			// 
			// button2
			// 
			button2.Location = new Point(33, 233);
			button2.Name = "button2";
			button2.Size = new Size(137, 62);
			button2.TabIndex = 7;
			button2.Text = "Customer Management";
			button2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Lucida Fax", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(214, 9);
			label1.Name = "label1";
			label1.Size = new Size(573, 40);
			label1.TabIndex = 10;
			label1.Text = "Select the car you want to rent ";
			// 
			// txbSearch
			// 
			txbSearch.Location = new Point(218, 52);
			txbSearch.Name = "txbSearch";
			txbSearch.Size = new Size(828, 27);
			txbSearch.TabIndex = 10;
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(1052, 50);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(94, 29);
			btnSearch.TabIndex = 11;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click;
			// 
			// SelectCar
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1158, 450);
			Controls.Add(btnSearch);
			Controls.Add(txbSearch);
			Controls.Add(label1);
			Controls.Add(panel1);
			Controls.Add(gridCar);
			Controls.Add(btnBack);
			Name = "SelectCar";
			Text = "Select Car ";
			((System.ComponentModel.ISupportInitialize)gridCar).EndInit();
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnBack;
		private DataGridView gridCar;
		private DataGridViewTextBoxColumn Car_ID;
		private DataGridViewTextBoxColumn Car_Type;
		private DataGridViewTextBoxColumn Manufacturer;
		private DataGridViewTextBoxColumn Car_Name;
		private DataGridViewCheckBoxColumn Rented_Status;
		private DataGridViewTextBoxColumn Seats;
		private DataGridViewTextBoxColumn Price;
		private Panel panel1;
		private Button button2;
		private Label label1;
		private TextBox txbSearch;
		private Button btnSearch;
		private PictureBox pictureBox1;
	}
}