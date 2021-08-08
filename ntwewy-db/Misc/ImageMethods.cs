using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace NTwewyDb
{
    public static class ImageMethods
    {
        public static Bitmap GetImageAsIs(string SpriteFileName)
        {
            return Resources.ResourceManager.GetObject(SpriteFileName) as Bitmap;
        }

        public static Bitmap DrawImage(string SpriteFileName, int Width, int Height, float Dpi = 96)
        {
            using (Bitmap Source = Resources.ResourceManager.GetObject(SpriteFileName) as Bitmap)
            {
                float ScaleFactor = Dpi / 96;
                Bitmap Result = new Bitmap((int)(Width * ScaleFactor), (int)(Height * ScaleFactor));

                using (Graphics G = Graphics.FromImage(Result))
                {
                    G.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    G.DrawImage(Source, 0, 0, Width * ScaleFactor, Height * ScaleFactor);
                }

                return Result;
            }
        }
    }
}
