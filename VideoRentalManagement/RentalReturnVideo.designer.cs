namespace VideoRentalManagement
{
    partial class RentalReturnVideo
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
            this.gridViewrental = new System.Windows.Forms.DataGridView();
            this.RMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRentalVideo = new System.Windows.Forms.Button();
            this.RentedDate = new System.Windows.Forms.DateTimePicker();
            this.combobox_Video = new System.Windows.Forms.ComboBox();
            this.combobox_Customer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.radioAllrental = new System.Windows.Forms.RadioButton();
            this.radioRentOut = new System.Windows.Forms.RadioButton();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.rentalMovieId = new System.Windows.Forms.Label();
            this.VideoId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewrental)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewrental
            // 
            this.gridViewrental.AllowUserToAddRows = false;
            this.gridViewrental.AllowUserToDeleteRows = false;
            this.gridViewrental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewrental.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RMID,
            this.CustId,
            this.FirstName,
            this.LastName,
            this.Address,
            this.Phone,
            this.MovieId,
            this.Title,
            this.ReleaseDate,
            this.RentalCost,
            this.Genre,
            this.Plot,
            this.DateRented,
            this.DateReturned});
            this.gridViewrental.Location = new System.Drawing.Point(12, 332);
            this.gridViewrental.Name = "gridViewrental";
            this.gridViewrental.ReadOnly = true;
            this.gridViewrental.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewrental.Size = new System.Drawing.Size(994, 224);
            this.gridViewrental.TabIndex = 59;
            // 
            // RMID
            // 
            this.RMID.DataPropertyName = "RentedMovieId";
            this.RMID.HeaderText = "RMID";
            this.RMID.Name = "RMID";
            this.RMID.ReadOnly = true;
            this.RMID.Width = 50;
            // 
            // CustId
            // 
            this.CustId.DataPropertyName = "CustId";
            this.CustId.HeaderText = "CustId";
            this.CustId.Name = "CustId";
            this.CustId.ReadOnly = true;
            this.CustId.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 200;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Visible = false;
            // 
            // MovieId
            // 
            this.MovieId.DataPropertyName = "MovieId";
            this.MovieId.HeaderText = "MovieId";
            this.MovieId.Name = "MovieId";
            this.MovieId.ReadOnly = true;
            this.MovieId.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Movie Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 150;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.DataPropertyName = "ReleaseDate";
            this.ReleaseDate.HeaderText = "ReleaseDate";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            this.ReleaseDate.Visible = false;
            // 
            // RentalCost
            // 
            this.RentalCost.DataPropertyName = "RentalCost";
            this.RentalCost.HeaderText = "Rental Cost";
            this.RentalCost.Name = "RentalCost";
            this.RentalCost.ReadOnly = true;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Visible = false;
            // 
            // Plot
            // 
            this.Plot.DataPropertyName = "Plot";
            this.Plot.HeaderText = "Plot";
            this.Plot.Name = "Plot";
            this.Plot.ReadOnly = true;
            this.Plot.Visible = false;
            // 
            // DateRented
            // 
            this.DateRented.DataPropertyName = "DateRented";
            this.DateRented.HeaderText = "Date Rented";
            this.DateRented.Name = "DateRented";
            this.DateRented.ReadOnly = true;
            this.DateRented.Width = 150;
            // 
            // DateReturned
            // 
            this.DateReturned.DataPropertyName = "DateReturned";
            this.DateReturned.HeaderText = "Date Returned";
            this.DateReturned.Name = "DateReturned";
            this.DateReturned.ReadOnly = true;
            this.DateReturned.Width = 150;
            // 
            // btnRentalVideo
            // 
            this.btnRentalVideo.BackColor = System.Drawing.Color.White;
            this.btnRentalVideo.BackgroundImage = global::VideoRentalManagement.Properties.Resources.images;
            this.btnRentalVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRentalVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentalVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalVideo.ForeColor = System.Drawing.Color.White;
            this.btnRentalVideo.Location = new System.Drawing.Point(190, 226);
            this.btnRentalVideo.Name = "btnRentalVideo";
            this.btnRentalVideo.Size = new System.Drawing.Size(153, 37);
            this.btnRentalVideo.TabIndex = 58;
            this.btnRentalVideo.Text = "Issue Video";
            this.btnRentalVideo.UseVisualStyleBackColor = false;
            this.btnRentalVideo.Click += new System.EventHandler(this.btnRentalVideo_Click);
            // 
            // RentedDate
            // 
            this.RentedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.RentedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RentedDate.Location = new System.Drawing.Point(190, 185);
            this.RentedDate.Name = "RentedDate";
            this.RentedDate.Size = new System.Drawing.Size(230, 20);
            this.RentedDate.TabIndex = 56;
            // 
            // combobox_Video
            // 
            this.combobox_Video.FormattingEnabled = true;
            this.combobox_Video.Location = new System.Drawing.Point(190, 143);
            this.combobox_Video.Name = "combobox_Video";
            this.combobox_Video.Size = new System.Drawing.Size(230, 21);
            this.combobox_Video.TabIndex = 54;
            // 
            // combobox_Customer
            // 
            this.combobox_Customer.FormattingEnabled = true;
            this.combobox_Customer.Location = new System.Drawing.Point(190, 95);
            this.combobox_Customer.Name = "combobox_Customer";
            this.combobox_Customer.Size = new System.Drawing.Size(230, 21);
            this.combobox_Customer.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(293, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 46);
            this.label3.TabIndex = 63;
            this.label3.Text = "Rental/Return Video\'s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(42, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Select Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(42, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Select Movie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(42, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "Rental Date";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.BackgroundImage = global::VideoRentalManagement.Properties.Resources.images;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_close.Location = new System.Drawing.Point(349, 224);
            this.btn_close.Name = "btn_close";
            this.btn_close.Padding = new System.Windows.Forms.Padding(12, 0, 9, 0);
            this.btn_close.Size = new System.Drawing.Size(116, 39);
            this.btn_close.TabIndex = 68;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // radioAllrental
            // 
            this.radioAllrental.AutoSize = true;
            this.radioAllrental.BackColor = System.Drawing.Color.Transparent;
            this.radioAllrental.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAllrental.ForeColor = System.Drawing.Color.White;
            this.radioAllrental.Location = new System.Drawing.Point(12, 298);
            this.radioAllrental.Name = "radioAllrental";
            this.radioAllrental.Size = new System.Drawing.Size(120, 17);
            this.radioAllrental.TabIndex = 69;
            this.radioAllrental.TabStop = true;
            this.radioAllrental.Text = "All Rented Video";
            this.radioAllrental.UseVisualStyleBackColor = false;
            this.radioAllrental.CheckedChanged += new System.EventHandler(this.radioAllrental_CheckedChanged);
            // 
            // radioRentOut
            // 
            this.radioRentOut.AutoSize = true;
            this.radioRentOut.BackColor = System.Drawing.Color.Transparent;
            this.radioRentOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRentOut.ForeColor = System.Drawing.Color.White;
            this.radioRentOut.Location = new System.Drawing.Point(161, 298);
            this.radioRentOut.Name = "radioRentOut";
            this.radioRentOut.Size = new System.Drawing.Size(126, 17);
            this.radioRentOut.TabIndex = 70;
            this.radioRentOut.TabStop = true;
            this.radioRentOut.Text = "Rented Out Video";
            this.radioRentOut.UseVisualStyleBackColor = false;
            this.radioRentOut.CheckedChanged += new System.EventHandler(this.radioRentOut_CheckedChanged);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.White;
            this.buttonReturn.BackgroundImage = global::VideoRentalManagement.Properties.Resources.images;
            this.buttonReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(12, 576);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(153, 37);
            this.buttonReturn.TabIndex = 71;
            this.buttonReturn.Text = "Return Video";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // rentalMovieId
            // 
            this.rentalMovieId.AutoSize = true;
            this.rentalMovieId.Location = new System.Drawing.Point(664, 215);
            this.rentalMovieId.Name = "rentalMovieId";
            this.rentalMovieId.Size = new System.Drawing.Size(0, 13);
            this.rentalMovieId.TabIndex = 72;
            this.rentalMovieId.Visible = false;
            // 
            // VideoId
            // 
            this.VideoId.AutoSize = true;
            this.VideoId.Location = new System.Drawing.Point(789, 215);
            this.VideoId.Name = "VideoId";
            this.VideoId.Size = new System.Drawing.Size(0, 13);
            this.VideoId.TabIndex = 73;
            this.VideoId.Visible = false;
            // 
            // RentalReturnVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VideoRentalManagement.Properties.Resources.images__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1144, 747);
            this.Controls.Add(this.VideoId);
            this.Controls.Add(this.rentalMovieId);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.radioRentOut);
            this.Controls.Add(this.radioAllrental);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridViewrental);
            this.Controls.Add(this.btnRentalVideo);
            this.Controls.Add(this.RentedDate);
            this.Controls.Add(this.combobox_Video);
            this.Controls.Add(this.combobox_Customer);
            this.Name = "RentalReturnVideo";
            this.Text = "Issue_ReturnVideo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Issue_ReturnVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewrental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridViewrental;
        private System.Windows.Forms.Button btnRentalVideo;
        private System.Windows.Forms.DateTimePicker RentedDate;
        private System.Windows.Forms.ComboBox combobox_Video;
        private System.Windows.Forms.ComboBox combobox_Customer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.RadioButton radioAllrental;
        private System.Windows.Forms.RadioButton radioRentOut;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label rentalMovieId;
        private System.Windows.Forms.Label VideoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plot;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRented;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReturned;
    }
}