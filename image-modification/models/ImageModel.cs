﻿using System.Drawing;
using System.IO;

namespace image_modification
{
    public class ImageModel
    {
        private Bitmap image;

        public ImageModel(string source)
        {
            StreamReader streamReader = new StreamReader(source);
            image = (Bitmap)Image.FromStream(streamReader.BaseStream);
            streamReader.Close();
        }

        public ImageModel(Bitmap source)
        {
            image = source;
        }

        public Bitmap GetBitmapImage()
        {
            return image;
        }

        public void SetImage(Bitmap image)
        {
            this.image = image;
        }
    }
}
