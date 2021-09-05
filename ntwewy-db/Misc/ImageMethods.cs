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
            if (SpriteFileName == null)
            {
                return null;
            }

            using (Bitmap Source = Resources.ResourceManager.GetObject(SpriteFileName) as Bitmap)
            {
                if (Source == null)
                {
                    return null;
                }

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

        public static Bitmap DrawImage_Percentage(string SpriteFileName, double Percentage, float Dpi = 96, short Angle = 0)
        {
            if (SpriteFileName == null)
            {
                return null;
            }

            using (Bitmap Source = Resources.ResourceManager.GetObject(SpriteFileName) as Bitmap)
            {
                if (Source == null)
                {
                    return null;
                }

                int Height = (int)Math.Round(Source.Height * Percentage);
                int Width = (int)Math.Round(Source.Width * Percentage);

                float ScaleFactor = Dpi / 96;
                Bitmap Result = new Bitmap((int)(Width * ScaleFactor), (int)(Height * ScaleFactor));

                using (Graphics G = Graphics.FromImage(Result))
                {
                    G.InterpolationMode = InterpolationMode.HighQualityBicubic;

                    if (Angle != 0)
                    {
                        G.TranslateTransform(Result.Width / 2, Result.Height / 2);
                        G.RotateTransform(Angle);
                        G.TranslateTransform(-Result.Width / 2, -Result.Height / 2);
                    }

                    G.DrawImage(Source, 0, 0, Width * ScaleFactor, Height * ScaleFactor);
                }

                return Result;
            }
        }

        public static Bitmap DrawImage(Bitmap Source, int Width, int Height, float Dpi = 96)
        {
            if (Source == null)
            {
                return null;
            }

            float ScaleFactor = Dpi / 96;
            Bitmap Result = new Bitmap((int)(Width * ScaleFactor), (int)(Height * ScaleFactor));

            using (Graphics G = Graphics.FromImage(Result))
            {
                G.InterpolationMode = InterpolationMode.HighQualityBicubic;
                G.DrawImage(Source, 0, 0, Width * ScaleFactor, Height * ScaleFactor);
            }

            return Result;
        }

        public static Bitmap DrawImageAligned(string SpriteFileName, int Width, int Height, int DestX, int DestY, int IncrementX = 0, int IncrementY = 0, float Dpi = 96)
        {
            using (Bitmap Image = DrawImage(SpriteFileName, Width, Height, Dpi))
            {
                if (Image == null)
                {
                    return null;
                }

                float ScaleFactor = Dpi / 96;
                DestX = (int)((float)DestX * ScaleFactor);
                DestY = (int)((float)DestY * ScaleFactor);
                IncrementX = (int)((float)IncrementX * ScaleFactor);
                IncrementY = (int)((float)IncrementY * ScaleFactor);

                Bitmap Result = new Bitmap(DestX, DestY);

                using (Graphics G = Graphics.FromImage(Result))
                {
                    G.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    G.DrawImage(Image, DestX - Image.Width + IncrementX, DestY - Image.Height + IncrementY, Image.Width, Image.Height);
                }

                return Result;
            }
        }
    }
}
