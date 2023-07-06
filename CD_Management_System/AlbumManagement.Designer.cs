﻿namespace CD_Management_System
{
    partial class AlbumManagement
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
            TitleAlbum = new Label();
            dgvAlbum = new DataGridView();
            txtAlbumName = new TextBox();
            AlbumName = new Label();
            ReleaseYear = new Label();
            txtReleaseYear = new TextBox();
            txtAuthor = new TextBox();
            Author = new Label();
            txtGenre = new TextBox();
            Genre = new Label();
            Quantity = new Label();
            txtQuantity = new TextBox();
            Description = new Label();
            txtDescription = new RichTextBox();
            txtPrice = new TextBox();
            Price = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            AlbumID = new Label();
            txtAlbumId = new TextBox();
            txtSearchBox = new TextBox();
            label1 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlbum).BeginInit();
            SuspendLayout();
            // 
            // TitleAlbum
            // 
            TitleAlbum.AutoSize = true;
            TitleAlbum.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            TitleAlbum.ForeColor = Color.Red;
            TitleAlbum.Location = new Point(441, 9);
            TitleAlbum.Name = "TitleAlbum";
            TitleAlbum.Size = new Size(113, 28);
            TitleAlbum.TabIndex = 0;
            TitleAlbum.Text = "Album List";
            // 
            // dgvAlbum
            // 
            dgvAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbum.Location = new Point(41, 70);
            dgvAlbum.Name = "dgvAlbum";
            dgvAlbum.RowTemplate.Height = 25;
            dgvAlbum.Size = new Size(874, 167);
            dgvAlbum.TabIndex = 1;
            dgvAlbum.CellContentClick += dgvAlbum_CellContentClick;
            dgvAlbum.CellDoubleClick += dgvAlbum_CellDoubleClick;
            // 
            // txtAlbumName
            // 
            txtAlbumName.Location = new Point(169, 295);
            txtAlbumName.Name = "txtAlbumName";
            txtAlbumName.Size = new Size(233, 23);
            txtAlbumName.TabIndex = 2;
            // 
            // AlbumName
            // 
            AlbumName.AutoSize = true;
            AlbumName.Location = new Point(50, 298);
            AlbumName.Name = "AlbumName";
            AlbumName.Size = new Size(78, 15);
            AlbumName.TabIndex = 3;
            AlbumName.Text = "Album Name";
            // 
            // ReleaseYear
            // 
            ReleaseYear.AutoSize = true;
            ReleaseYear.Location = new Point(50, 337);
            ReleaseYear.Name = "ReleaseYear";
            ReleaseYear.Size = new Size(71, 15);
            ReleaseYear.TabIndex = 4;
            ReleaseYear.Text = "Release Year";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(169, 334);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(233, 23);
            txtReleaseYear.TabIndex = 5;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(169, 378);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(233, 23);
            txtAuthor.TabIndex = 6;
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Location = new Point(50, 381);
            Author.Name = "Author";
            Author.Size = new Size(44, 15);
            Author.TabIndex = 7;
            Author.Text = "Author";
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(480, 256);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(224, 23);
            txtGenre.TabIndex = 8;
            // 
            // Genre
            // 
            Genre.AutoSize = true;
            Genre.Location = new Point(436, 259);
            Genre.Name = "Genre";
            Genre.Size = new Size(38, 15);
            Genre.TabIndex = 9;
            Genre.Text = "Genre";
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Location = new Point(421, 298);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(53, 15);
            Quantity.TabIndex = 10;
            Quantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(480, 295);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(224, 23);
            txtQuantity.TabIndex = 11;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(50, 417);
            Description.Name = "Description";
            Description.Size = new Size(67, 15);
            Description.TabIndex = 13;
            Description.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(50, 435);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(380, 101);
            txtDescription.TabIndex = 14;
            txtDescription.Text = "";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(480, 334);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(224, 23);
            txtPrice.TabIndex = 15;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(441, 337);
            Price.Name = "Price";
            Price.Size = new Size(33, 15);
            Price.TabIndex = 16;
            Price.Text = "Price";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(480, 394);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 47);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(641, 394);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 47);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(480, 464);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(128, 47);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(641, 464);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 47);
            btnCancel.TabIndex = 20;
            btnCancel.TabStop = false;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AlbumID
            // 
            AlbumID.AutoSize = true;
            AlbumID.Location = new Point(50, 264);
            AlbumID.Name = "AlbumID";
            AlbumID.Size = new Size(57, 15);
            AlbumID.TabIndex = 21;
            AlbumID.Text = "Album ID";
            // 
            // txtAlbumId
            // 
            txtAlbumId.Location = new Point(169, 256);
            txtAlbumId.Name = "txtAlbumId";
            txtAlbumId.ReadOnly = true;
            txtAlbumId.Size = new Size(233, 23);
            txtAlbumId.TabIndex = 22;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Location = new Point(749, 295);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(166, 23);
            txtSearchBox.TabIndex = 24;
            txtSearchBox.TextChanged += txtSearchBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(749, 249);
            label1.Name = "label1";
            label1.Size = new Size(166, 30);
            label1.TabIndex = 25;
            label1.Text = "Search \r\n(Album Name, Author, Genre)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(837, 36);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(78, 28);
            btnBack.TabIndex = 26;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AlbumManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 565);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(txtSearchBox);
            Controls.Add(txtAlbumId);
            Controls.Add(AlbumID);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(Price);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(Description);
            Controls.Add(txtQuantity);
            Controls.Add(Quantity);
            Controls.Add(Genre);
            Controls.Add(txtGenre);
            Controls.Add(Author);
            Controls.Add(txtAuthor);
            Controls.Add(txtReleaseYear);
            Controls.Add(ReleaseYear);
            Controls.Add(AlbumName);
            Controls.Add(txtAlbumName);
            Controls.Add(dgvAlbum);
            Controls.Add(TitleAlbum);
            Name = "AlbumManagement";
            Text = "AlbumManagement";
            ((System.ComponentModel.ISupportInitialize)dgvAlbum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleAlbum;
        private DataGridView dgvAlbum;
        private TextBox txtAlbumName;
        private Label AlbumName;
        private Label ReleaseYear;
        private TextBox txtReleaseYear;
        private TextBox txtAuthor;
        private Label Author;
        private TextBox txtGenre;
        private Label Genre;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label Description;
        private RichTextBox txtDescription;
        private TextBox txtPrice;
        private Label Price;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCancel;
        private Label Quantity;
        private TextBox txtQuantity;
        private Label AlbumID;
        private TextBox txtAlbumId;
        private TextBox txtSearchBox;
        private Label label1;
        private Button btnBack;
    }
}