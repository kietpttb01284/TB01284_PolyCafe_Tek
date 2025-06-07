using System.Drawing;
using System.IO;

namespace TB01284_PolyCafe
{
    public static class ImageIndexConverter
    {
        /// <summary>  
        /// Saves the provided image to the specified directory and returns the file path.  
        /// </summary>  
        /// <param name="image">The image to save.</param>  
        /// <param name="directory">The directory where the image will be saved.</param>  
        /// <returns>The file path of the saved image.</returns>  
        public static string SaveImage(Image image, string directory)
        {
            if (image == null)
            {
                return string.Empty;
            }

            // Ensure the directory exists  
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Generate a unique file name  
            string fileName = Path.Combine(directory, $"{Path.GetRandomFileName()}.png");

            // Save the image as a PNG file  
            image.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);

            return fileName;
        }
    }
}
