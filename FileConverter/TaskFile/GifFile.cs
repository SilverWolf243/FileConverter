using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConverter.TaskFile
{
    internal class GifFile : TaskFile
    {
        public GifFile(string outputFilePath, FileItem fileItem) : base(outputFilePath, fileItem)
        {
        }

        public override bool ConverterPng()
        {
            bool ret = true;
            try
            {
                using (Image gifImage = Image.FromFile(fileItem.FilePath))
                {
                    FrameDimension dimension = new FrameDimension(gifImage.FrameDimensionsList[0]);
                    gifImage.SelectActiveFrame(dimension, 0);

                    gifImage.Save($"{outputFilePath}\\{fileItem.FileName}.png", ImageFormat.Png);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                ret = false;
            }
            return ret;
        }
    }
}
