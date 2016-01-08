namespace CleaningRobotsDatabase
{
    partial class ImageLoader
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
            this.labelFirstLine = new System.Windows.Forms.Label();
            this.textBoxLinkToImage = new System.Windows.Forms.TextBox();
            this.labelSecondLine = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonImageAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstLine
            // 
            this.labelFirstLine.AutoSize = true;
            this.labelFirstLine.Location = new System.Drawing.Point(194, 29);
            this.labelFirstLine.Name = "labelFirstLine";
            this.labelFirstLine.Size = new System.Drawing.Size(143, 13);
            this.labelFirstLine.TabIndex = 0;
            this.labelFirstLine.Text = "Wklej link do zdjęcia poniżej:";
            // 
            // textBoxLinkToImage
            // 
            this.textBoxLinkToImage.Location = new System.Drawing.Point(7, 55);
            this.textBoxLinkToImage.Name = "textBoxLinkToImage";
            this.textBoxLinkToImage.Size = new System.Drawing.Size(516, 20);
            this.textBoxLinkToImage.TabIndex = 1;
            // 
            // labelSecondLine
            // 
            this.labelSecondLine.AutoSize = true;
            this.labelSecondLine.Location = new System.Drawing.Point(197, 89);
            this.labelSecondLine.Name = "labelSecondLine";
            this.labelSecondLine.Size = new System.Drawing.Size(137, 13);
            this.labelSecondLine.TabIndex = 2;
            this.labelSecondLine.Text = "lub wybierz zdjęcie z dysku:";
            // 
            // buttonDone
            // 
            this.buttonDone.Image = global::CleaningRobotsDatabase.Properties.Resources.done;
            this.buttonDone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDone.Location = new System.Drawing.Point(161, 181);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(209, 45);
            this.buttonDone.TabIndex = 4;
            this.buttonDone.Text = "Zrobione!";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonImageAdd
            // 
            this.buttonImageAdd.Image = global::CleaningRobotsDatabase.Properties.Resources.screen;
            this.buttonImageAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImageAdd.Location = new System.Drawing.Point(195, 117);
            this.buttonImageAdd.Name = "buttonImageAdd";
            this.buttonImageAdd.Size = new System.Drawing.Size(140, 23);
            this.buttonImageAdd.TabIndex = 3;
            this.buttonImageAdd.Text = "    Wybierz zdjęcie";
            this.buttonImageAdd.UseVisualStyleBackColor = true;
            this.buttonImageAdd.Click += new System.EventHandler(this.buttonImageAdd_Click);
            // 
            // ImageLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 238);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonImageAdd);
            this.Controls.Add(this.labelSecondLine);
            this.Controls.Add(this.textBoxLinkToImage);
            this.Controls.Add(this.labelFirstLine);
            this.Name = "ImageLoader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj zdjęcie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstLine;
        private System.Windows.Forms.TextBox textBoxLinkToImage;
        private System.Windows.Forms.Label labelSecondLine;
        private System.Windows.Forms.Button buttonImageAdd;
        private System.Windows.Forms.Button buttonDone;
    }
}