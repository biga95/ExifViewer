
namespace ExifViewer
{
    partial class ExifViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExifViewer));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRotate90Back = new System.Windows.Forms.Button();
            this.buttonRotation90Right = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonShowImage = new System.Windows.Forms.Button();
            this.buttonExif = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(7, 13);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(118, 46);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add Image";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRotate90Back
            // 
            this.buttonRotate90Back.Image = ((System.Drawing.Image)(resources.GetObject("buttonRotate90Back.Image")));
            this.buttonRotate90Back.Location = new System.Drawing.Point(144, 13);
            this.buttonRotate90Back.Name = "buttonRotate90Back";
            this.buttonRotate90Back.Size = new System.Drawing.Size(47, 46);
            this.buttonRotate90Back.TabIndex = 7;
            this.buttonRotate90Back.UseVisualStyleBackColor = true;
            this.buttonRotate90Back.Click += new System.EventHandler(this.buttonRotate90Back_Click);
            // 
            // buttonRotation90Right
            // 
            this.buttonRotation90Right.Image = ((System.Drawing.Image)(resources.GetObject("buttonRotation90Right.Image")));
            this.buttonRotation90Right.Location = new System.Drawing.Point(197, 13);
            this.buttonRotation90Right.Name = "buttonRotation90Right";
            this.buttonRotation90Right.Size = new System.Drawing.Size(47, 46);
            this.buttonRotation90Right.TabIndex = 8;
            this.buttonRotation90Right.UseVisualStyleBackColor = true;
            this.buttonRotation90Right.Click += new System.EventHandler(this.buttonRotation90Right_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 9;
            // 
            // buttonShowImage
            // 
            this.buttonShowImage.Location = new System.Drawing.Point(250, 22);
            this.buttonShowImage.Name = "buttonShowImage";
            this.buttonShowImage.Size = new System.Drawing.Size(142, 37);
            this.buttonShowImage.TabIndex = 11;
            this.buttonShowImage.Text = "Show Image";
            this.buttonShowImage.UseVisualStyleBackColor = true;
            this.buttonShowImage.Click += new System.EventHandler(this.buttonShowImage_Click);
            // 
            // buttonExif
            // 
            this.buttonExif.Location = new System.Drawing.Point(398, 22);
            this.buttonExif.Name = "buttonExif";
            this.buttonExif.Size = new System.Drawing.Size(142, 37);
            this.buttonExif.TabIndex = 12;
            this.buttonExif.Text = "EXIF DATA";
            this.buttonExif.UseVisualStyleBackColor = true;
            this.buttonExif.Click += new System.EventHandler(this.buttonExif_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImage.Location = new System.Drawing.Point(28, 76);
            this.pictureBoxImage.MaximumSize = new System.Drawing.Size(512, 512);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(512, 449);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 2;
            this.pictureBoxImage.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(81, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(444, 449);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            // 
            // ExifViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(626, 571);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonExif);
            this.Controls.Add(this.buttonShowImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRotation90Right);
            this.Controls.Add(this.buttonRotate90Back);
            this.Controls.Add(this.buttonAdd);
            this.MaximumSize = new System.Drawing.Size(800, 700);
            this.MinimumSize = new System.Drawing.Size(550, 100);
            this.Name = "ExifViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExifViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRotate90Back;
        private System.Windows.Forms.Button buttonRotation90Right;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonShowImage;
        private System.Windows.Forms.Button buttonExif;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.TextBox textBox1;
    }
}

