namespace CleaningRobotsDatabase
{
    partial class FormMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainWindow));
            this.dataGridViewRobots = new System.Windows.Forms.DataGridView();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelWebPage = new System.Windows.Forms.Label();
            this.textBoxWebPage = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPhotoLocation = new System.Windows.Forms.TextBox();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonClearPrice = new System.Windows.Forms.Button();
            this.buttonClearModel = new System.Windows.Forms.Button();
            this.buttonClearManufacturer = new System.Windows.Forms.Button();
            this.buttonClearWebPage = new System.Windows.Forms.Button();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxRobotImage = new System.Windows.Forms.PictureBox();
            this.buttonReadFromFile = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonOpenWebside = new System.Windows.Forms.Button();
            this.buttonClearPhotoPath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRobots)).BeginInit();
            this.groupBoxButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRobotImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRobots
            // 
            this.dataGridViewRobots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRobots.Location = new System.Drawing.Point(12, 212);
            this.dataGridViewRobots.Name = "dataGridViewRobots";
            this.dataGridViewRobots.Size = new System.Drawing.Size(719, 448);
            this.dataGridViewRobots.TabIndex = 0;
            this.dataGridViewRobots.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewRobots_MouseClick);
            this.dataGridViewRobots.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewRobots_MouseClick);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(84, 87);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(229, 20);
            this.textBoxPrice.TabIndex = 4;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(84, 31);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(229, 20);
            this.textBoxModel.TabIndex = 4;
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Location = new System.Drawing.Point(84, 60);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(229, 20);
            this.textBoxManufacturer.TabIndex = 4;
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Location = new System.Drawing.Point(13, 64);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(59, 13);
            this.labelManufacturer.TabIndex = 3;
            this.labelManufacturer.Text = "Producent:";
            // 
            // labelWebPage
            // 
            this.labelWebPage.AutoSize = true;
            this.labelWebPage.Location = new System.Drawing.Point(8, 117);
            this.labelWebPage.Name = "labelWebPage";
            this.labelWebPage.Size = new System.Drawing.Size(68, 13);
            this.labelWebPage.TabIndex = 3;
            this.labelWebPage.Text = "Strona www:";
            // 
            // textBoxWebPage
            // 
            this.textBoxWebPage.Location = new System.Drawing.Point(84, 114);
            this.textBoxWebPage.Name = "textBoxWebPage";
            this.textBoxWebPage.Size = new System.Drawing.Size(229, 20);
            this.textBoxWebPage.TabIndex = 4;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(23, 34);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(39, 13);
            this.labelModel.TabIndex = 3;
            this.labelModel.Text = "Model:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(25, 90);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 13);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Cena:";
            // 
            // textBoxPhotoLocation
            // 
            this.textBoxPhotoLocation.Location = new System.Drawing.Point(446, 114);
            this.textBoxPhotoLocation.Name = "textBoxPhotoLocation";
            this.textBoxPhotoLocation.Size = new System.Drawing.Size(224, 20);
            this.textBoxPhotoLocation.TabIndex = 6;
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.buttonClearPhotoPath);
            this.groupBoxButtons.Controls.Add(this.labelPath);
            this.groupBoxButtons.Controls.Add(this.buttonClearPrice);
            this.groupBoxButtons.Controls.Add(this.buttonClearModel);
            this.groupBoxButtons.Controls.Add(this.buttonReadFromFile);
            this.groupBoxButtons.Controls.Add(this.textBoxPhotoLocation);
            this.groupBoxButtons.Controls.Add(this.buttonSaveToFile);
            this.groupBoxButtons.Controls.Add(this.buttonClearManufacturer);
            this.groupBoxButtons.Controls.Add(this.buttonOpenWebside);
            this.groupBoxButtons.Controls.Add(this.buttonClearWebPage);
            this.groupBoxButtons.Controls.Add(this.labelModel);
            this.groupBoxButtons.Controls.Add(this.buttonDelete);
            this.groupBoxButtons.Controls.Add(this.buttonAddPhoto);
            this.groupBoxButtons.Controls.Add(this.textBoxWebPage);
            this.groupBoxButtons.Controls.Add(this.buttonEdit);
            this.groupBoxButtons.Controls.Add(this.buttonAdd);
            this.groupBoxButtons.Controls.Add(this.labelManufacturer);
            this.groupBoxButtons.Controls.Add(this.textBoxManufacturer);
            this.groupBoxButtons.Controls.Add(this.labelWebPage);
            this.groupBoxButtons.Controls.Add(this.textBoxModel);
            this.groupBoxButtons.Controls.Add(this.labelPrice);
            this.groupBoxButtons.Controls.Add(this.textBoxPrice);
            this.groupBoxButtons.Location = new System.Drawing.Point(12, 55);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(864, 151);
            this.groupBoxButtons.TabIndex = 8;
            this.groupBoxButtons.TabStop = false;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(503, 98);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(99, 13);
            this.labelPath.TabIndex = 7;
            this.labelPath.Text = "Ścieżka do zdjęcia:";
            // 
            // buttonClearPrice
            // 
            this.buttonClearPrice.Image = global::CleaningRobotsDatabase.Properties.Resources.delete;
            this.buttonClearPrice.Location = new System.Drawing.Point(319, 87);
            this.buttonClearPrice.Name = "buttonClearPrice";
            this.buttonClearPrice.Size = new System.Drawing.Size(21, 20);
            this.buttonClearPrice.TabIndex = 6;
            this.buttonClearPrice.UseVisualStyleBackColor = true;
            this.buttonClearPrice.Click += new System.EventHandler(this.buttonClearPrice_Click);
            // 
            // buttonClearModel
            // 
            this.buttonClearModel.Image = global::CleaningRobotsDatabase.Properties.Resources.delete;
            this.buttonClearModel.Location = new System.Drawing.Point(319, 31);
            this.buttonClearModel.Name = "buttonClearModel";
            this.buttonClearModel.Size = new System.Drawing.Size(21, 20);
            this.buttonClearModel.TabIndex = 6;
            this.buttonClearModel.UseVisualStyleBackColor = true;
            this.buttonClearModel.Click += new System.EventHandler(this.buttonClearModel_Click);
            // 
            // buttonClearManufacturer
            // 
            this.buttonClearManufacturer.Image = global::CleaningRobotsDatabase.Properties.Resources.delete;
            this.buttonClearManufacturer.Location = new System.Drawing.Point(319, 60);
            this.buttonClearManufacturer.Name = "buttonClearManufacturer";
            this.buttonClearManufacturer.Size = new System.Drawing.Size(21, 20);
            this.buttonClearManufacturer.TabIndex = 6;
            this.buttonClearManufacturer.UseVisualStyleBackColor = true;
            this.buttonClearManufacturer.Click += new System.EventHandler(this.buttonClearManufacturer_Click);
            // 
            // buttonClearWebPage
            // 
            this.buttonClearWebPage.Image = global::CleaningRobotsDatabase.Properties.Resources.delete;
            this.buttonClearWebPage.Location = new System.Drawing.Point(319, 114);
            this.buttonClearWebPage.Name = "buttonClearWebPage";
            this.buttonClearWebPage.Size = new System.Drawing.Size(21, 20);
            this.buttonClearWebPage.TabIndex = 6;
            this.buttonClearWebPage.UseVisualStyleBackColor = true;
            this.buttonClearWebPage.Click += new System.EventHandler(this.buttonClearWebPage_Click);
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.Image = global::CleaningRobotsDatabase.Properties.Resources.monitor;
            this.buttonAddPhoto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAddPhoto.Location = new System.Drawing.Point(473, 34);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(176, 53);
            this.buttonAddPhoto.TabIndex = 5;
            this.buttonAddPhoto.Text = "Dodaj zdjęcie z dysku  ";
            this.buttonAddPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddPhoto.UseVisualStyleBackColor = true;
            this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddPhoto_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = global::CleaningRobotsDatabase.Properties.Resources.delete;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonDelete.Location = new System.Drawing.Point(357, 102);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Usuń   ";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Image = global::CleaningRobotsDatabase.Properties.Resources.edit;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonEdit.Location = new System.Drawing.Point(357, 71);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edytuj   ";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::CleaningRobotsDatabase.Properties.Resources.add;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAdd.Location = new System.Drawing.Point(357, 42);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Dodaj   ";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(415, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(461, 43);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "Baza Robotów Sprzątających!";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(903, 27);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(316, 179);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 11;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxRobotImage
            // 
            this.pictureBoxRobotImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRobotImage.Location = new System.Drawing.Point(737, 212);
            this.pictureBoxRobotImage.Name = "pictureBoxRobotImage";
            this.pictureBoxRobotImage.Size = new System.Drawing.Size(525, 448);
            this.pictureBoxRobotImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRobotImage.TabIndex = 2;
            this.pictureBoxRobotImage.TabStop = false;
            // 
            // buttonReadFromFile
            // 
            this.buttonReadFromFile.Image = global::CleaningRobotsDatabase.Properties.Resources.open;
            this.buttonReadFromFile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonReadFromFile.Location = new System.Drawing.Point(734, 122);
            this.buttonReadFromFile.Name = "buttonReadFromFile";
            this.buttonReadFromFile.Size = new System.Drawing.Size(84, 23);
            this.buttonReadFromFile.TabIndex = 1;
            this.buttonReadFromFile.Text = "Wczytaj   ";
            this.buttonReadFromFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReadFromFile.UseVisualStyleBackColor = true;
            this.buttonReadFromFile.Click += new System.EventHandler(this.buttonReadFromFile_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Image = global::CleaningRobotsDatabase.Properties.Resources.save;
            this.buttonSaveToFile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSaveToFile.Location = new System.Drawing.Point(734, 98);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(84, 23);
            this.buttonSaveToFile.TabIndex = 1;
            this.buttonSaveToFile.Text = "Zapisz   ";
            this.buttonSaveToFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // buttonOpenWebside
            // 
            this.buttonOpenWebside.Image = global::CleaningRobotsDatabase.Properties.Resources.browserbig;
            this.buttonOpenWebside.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenWebside.Location = new System.Drawing.Point(684, 34);
            this.buttonOpenWebside.Name = "buttonOpenWebside";
            this.buttonOpenWebside.Size = new System.Drawing.Size(174, 53);
            this.buttonOpenWebside.TabIndex = 1;
            this.buttonOpenWebside.Text = "    Strona www  ";
            this.buttonOpenWebside.UseVisualStyleBackColor = true;
            this.buttonOpenWebside.Click += new System.EventHandler(this.buttonOpenWebside_Click);
            // 
            // buttonClearPhotoPath
            // 
            this.buttonClearPhotoPath.Image = global::CleaningRobotsDatabase.Properties.Resources.delete;
            this.buttonClearPhotoPath.Location = new System.Drawing.Point(676, 114);
            this.buttonClearPhotoPath.Name = "buttonClearPhotoPath";
            this.buttonClearPhotoPath.Size = new System.Drawing.Size(21, 20);
            this.buttonClearPhotoPath.TabIndex = 8;
            this.buttonClearPhotoPath.UseVisualStyleBackColor = true;
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 672);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.pictureBoxRobotImage);
            this.Controls.Add(this.dataGridViewRobots);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainWindow";
            this.Text = "Baza Robotów Sprzątających ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRobots)).EndInit();
            this.groupBoxButtons.ResumeLayout(false);
            this.groupBoxButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRobotImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRobots;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonOpenWebside;
        private System.Windows.Forms.PictureBox pictureBoxRobotImage;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonReadFromFile;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelWebPage;
        private System.Windows.Forms.TextBox textBoxWebPage;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonAddPhoto;
        private System.Windows.Forms.TextBox textBoxPhotoLocation;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonClearPrice;
        private System.Windows.Forms.Button buttonClearModel;
        private System.Windows.Forms.Button buttonClearManufacturer;
        private System.Windows.Forms.Button buttonClearWebPage;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonClearPhotoPath;
    }
}

