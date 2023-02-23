using System.Text;

namespace FacialEmotionDetectionWebApp.ImageHelper
{
    public static class ImageFilter
    {
        public enum ImageFormat
        {
            bmp,
            jpeg,
            gif,
            tiff,
            png,
            unknown
        }

        public static ImageFormat GetImageFormat(byte[] bytes)
        {
            // Image file headers
            byte[] bmp = Encoding.ASCII.GetBytes("BM");
            byte[] gif = Encoding.ASCII.GetBytes("GIF");
            byte[] png = new byte[] { 137, 80, 78, 71 };
            byte[] tiff1 = new byte[] { 73, 73, 42 };
            byte[] tiff2 = new byte[] { 77, 77, 42 };
            byte[] jpeg1 = new byte[] { 255, 216, 255, 224 };
            byte[] jpeg2 = new byte[] { 255, 216, 255, 225 };

            if (bmp.SequenceEqual(bytes.Take(bmp.Length))) return ImageFormat.bmp;
            if (gif.SequenceEqual(bytes.Take(gif.Length))) return ImageFormat.gif;
            if (png.SequenceEqual(bytes.Take(png.Length))) return ImageFormat.png;
            if (tiff1.SequenceEqual(bytes.Take(tiff1.Length))) return ImageFormat.tiff;
            if (tiff2.SequenceEqual(bytes.Take(tiff2.Length))) return ImageFormat.tiff;
            if (jpeg1.SequenceEqual(bytes.Take(jpeg1.Length))) return ImageFormat.jpeg;
            if (jpeg2.SequenceEqual(bytes.Take(jpeg2.Length))) return ImageFormat.jpeg;

            return ImageFormat.unknown;
        }

        public static bool IsValidImage(this byte[] image)
        {
            ImageFormat imageFormat = GetImageFormat(image);
            return imageFormat == ImageFormat.png || imageFormat == ImageFormat.jpeg;
        }
    }
}
