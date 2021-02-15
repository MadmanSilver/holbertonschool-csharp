using System;
using System.Drawing;
using System.Threading;

class ImageProcessor {
    public static void Inverse(string[] filenames) {
        Thread th = null;

        if (filenames.Length > 1) {
            string[] tmp = new string[filenames.Length - 1];
            Array.Copy(filenames, 1, tmp, 0, tmp.Length);
            th = new Thread(() => Inverse(tmp));
            th.Start();
        }

        if (filenames.Length > 0) {
            string name = filenames[0];
            Bitmap image = new Bitmap(name);

            for (int y = 0; y < image.Height; y++) {
                for (int x = 0; x < image.Width; x++) {
                    Color pixel = image.GetPixel(x, y);
                    image.SetPixel(x, y, Color.FromArgb(pixel.A, 255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }
            }

            int lastSlash = name.LastIndexOf('/') + 1;
            int lastDot = name.LastIndexOf('.');
            image.Save(name.Substring(lastSlash, lastDot - lastSlash) + "_inverse" + name.Substring(lastDot));
        }

        if (filenames.Length > 1) {
            th.Join();
        }
    }

    public static void Grayscale(string[] filenames) {
        Thread th = null;

        if (filenames.Length > 1) {
            string[] tmp = new string[filenames.Length - 1];
            Array.Copy(filenames, 1, tmp, 0, tmp.Length);
            th = new Thread(() => Grayscale(tmp));
            th.Start();
        }

        if (filenames.Length > 0) {
            string name = filenames[0];
            Bitmap image = new Bitmap(name);

            for (int y = 0; y < image.Height; y++) {
                for (int x = 0; x < image.Width; x++) {
                    Color pixel = image.GetPixel(x, y);
                    int luminance = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                    image.SetPixel(x, y, Color.FromArgb(pixel.A, luminance, luminance, luminance));
                }
            }

            int lastSlash = name.LastIndexOf('/') + 1;
            int lastDot = name.LastIndexOf('.');
            image.Save(name.Substring(lastSlash, lastDot - lastSlash) + "_grayscale" + name.Substring(lastDot));
        }

        if (filenames.Length > 1) {
            th.Join();
        }
    }

    public static void BlackWhite(string[] filenames, double threshold) {
        Thread th = null;

        if (filenames.Length > 1) {
            string[] tmp = new string[filenames.Length - 1];
            Array.Copy(filenames, 1, tmp, 0, tmp.Length);
            th = new Thread(() => BlackWhite(tmp, threshold));
            th.Start();
        }

        if (filenames.Length > 0) {
            string name = filenames[0];
            Bitmap image = new Bitmap(name);

            for (int y = 0; y < image.Height; y++) {
                for (int x = 0; x < image.Width; x++) {
                    Color pixel = image.GetPixel(x, y);
                    int luminance = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                    if (luminance >= threshold * 255) {
                        image.SetPixel(x, y, Color.FromArgb(pixel.A, 255, 255, 255));
                    } else {
                        image.SetPixel(x, y, Color.FromArgb(pixel.A, 0, 0, 0));
                    }
                }
            }

            int lastSlash = name.LastIndexOf('/') + 1;
            int lastDot = name.LastIndexOf('.');
            image.Save(name.Substring(lastSlash, lastDot - lastSlash) + "_bw" + name.Substring(lastDot));
        }

        if (filenames.Length > 1) {
            th.Join();
        }
    }

    public static void Thumbnail(string[] filenames, int height) {
        Thread th = null;

        if (filenames.Length > 1) {
            string[] tmp = new string[filenames.Length - 1];
            Array.Copy(filenames, 1, tmp, 0, tmp.Length);
            th = new Thread(() => Thumbnail(tmp, height));
            th.Start();
        }

        if (filenames.Length > 0) {
            string name = filenames[0];
            Bitmap bmp = new Bitmap(name);

            Image image = bmp.GetThumbnailImage((int)(bmp.Width * (double)((double)height / (double)bmp.Height)), height, () => {return false;}, IntPtr.Zero);

            int lastSlash = name.LastIndexOf('/') + 1;
            int lastDot = name.LastIndexOf('.');
            image.Save(name.Substring(lastSlash, lastDot - lastSlash) + "_th" + name.Substring(lastDot));
        }

        if (filenames.Length > 1) {
            th.Join();
        }
    }
}
