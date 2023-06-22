using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GdPicture14;
using GdPicture;


namespace ExifViewer
{
    public partial class ExifViewer : Form
    {
        Image image;
        int height;
        int width;
        int countBack90 = 0;
        int countForward90 = 0;
        public ExifViewer()
        {
            InitializeComponent();
            textBox1.Visible = false;
            GdPicture14.LicenseManager oLicenseManager = new GdPicture14.LicenseManager();
            oLicenseManager.RegisterKEY("0471518396633296756441224");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxImage.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            countBack90 = 0;
            countForward90 = 0;
          
          
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //loading image
                image = new Bitmap(open.FileName);
                height = (int)(image.Height * 0.16);
                width = (int)(image.Width * 0.16);
                pictureBoxImage.Size = new System.Drawing.Size(width, height);
                pictureBoxImage.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBoxImage.BorderStyle = BorderStyle.Fixed3D;
                pictureBoxImage.Image = image;                
                pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxImage.Visible = true;

                // Extracting EXIF Data.
                GdPictureImaging oGdPictureImaging = new GdPictureImaging();
                int ImageID = oGdPictureImaging.CreateGdPictureImageFromFile(open.FileName);
                if (oGdPictureImaging.GetStat() == GdPictureStatus.OK)
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.AppendLine("FILE PATH: "+open.FileName);
                    int exifTagsCount = oGdPictureImaging.TagCount(ImageID);
                    if (exifTagsCount != 0)
                    {
                        //EXIF tags.
                            sb.AppendLine("EXIF DATA:\n-----------\n");
                            for (int i = 1; i <= exifTagsCount - 1; i++)
                            {
                                string tagName = oGdPictureImaging.TagGetName(ImageID, i);
                                string tagFormattedValue = oGdPictureImaging.TagGetValueString(ImageID, i);
                                sb.AppendLine(tagName + ":      " + tagFormattedValue + "\n");
                            }
                                oGdPictureImaging.ReleaseGdPictureImage(ImageID);
                                textBox1.Text = sb.ToString();                   
                    
                    }
                    else
                    {
                        sb.AppendLine("NO EXIF DATA");
                    }
                }
                else
                {
                    MessageBox.Show("The image can't be loaded. Status: " + oGdPictureImaging.GetStat().ToString(), "Metadata Example", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Show Pixel of image resized
                labelPixel.Text = "Pixel Resize: " + pictureBoxImage.Height + " x " + pictureBoxImage.Width;
                labelPixel.Visible = true;
            }
            buttonRotation90Right.Visible = true;
            buttonRotate90Back.Visible = true;
            buttonShowImage.Visible = true;
            buttonExif.Visible = true;
            buttonAdd.Text = "Add New Image";
        }

        private void buttonRotate90Back_Click(object sender, EventArgs e)
        {


            countBack90++;
            image.RotateFlip(RotateFlipType.Rotate270FlipNone);


            //for rotation inverted height and width.
            if (countBack90%2==1 && countForward90%2==0)
                pictureBoxImage.Size = new System.Drawing.Size(height,width);
            else if(countBack90 % 2 == 1 && countForward90 % 2 == 1)
                pictureBoxImage.Size = new System.Drawing.Size(width,height);
            else if (countBack90 % 2 == 0 && countForward90 % 2 == 0)
                pictureBoxImage.Size = new System.Drawing.Size(width, height);
            else if (countBack90 % 2 == 0 && countForward90 % 2 == 1)
                pictureBoxImage.Size = new System.Drawing.Size(height, width);


            pictureBoxImage.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxImage.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxImage.Image = image;
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.Image = image;
        }

        private void buttonRotation90Right_Click(object sender, EventArgs e)
        {
          
            countForward90++; 

            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            if (countBack90 % 2 == 0 && countForward90 % 2 == 1)
                pictureBoxImage.Size = new System.Drawing.Size(height, width);
            else if (countBack90 % 2 == 0 && countForward90 % 2 == 0)
                pictureBoxImage.Size = new System.Drawing.Size(width, height);
            else if (countBack90 % 2 == 1 && countForward90 % 2 == 1)
                pictureBoxImage.Size = new System.Drawing.Size(width, height);
            else if (countBack90 % 2 == 1 && countForward90 % 2 == 0)
                pictureBoxImage.Size = new System.Drawing.Size(height, width);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxImage.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxImage.Image = image;
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.Image = image;

        }


        private void buttonShowImage_Click(object sender, EventArgs e)
        {

            pictureBoxImage.Visible = true;
            textBox1.Visible = false;
            labelPixel.Text = "Pixel Resize: " + pictureBoxImage.Height + " x " + pictureBoxImage.Width;
            labelPixel.Visible = true;
        }

        private void buttonExif_Click(object sender, EventArgs e)
        {
            pictureBoxImage.Visible = false;
            textBox1.Visible = true;
            labelPixel.Visible = false;
        }


        /*show the pixels of the image that at each reduction do not exceed 512 pixels.
        although the original ones are bigger.*/
        private void pictureBoxImage_Resize(object sender, EventArgs e)
        {
            if (pictureBoxImage.Visible)
            {
                labelPixel.Text = "Pixel Resize: " + pictureBoxImage.Height + " x " + pictureBoxImage.Width;
                labelPixel.Visible = true;
            }
            
        }
    }
}
