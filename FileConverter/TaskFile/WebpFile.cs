using ImageMagick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConverter.TaskFile
{
    internal class WebpFile : TaskFile
    {
        public WebpFile(string outputFilePath, FileItem fileItem) : base(outputFilePath, fileItem)
        {
        }

        public override bool ConverterPng()
        {
            bool ret = true;
            try
            {
                using (MagickImage image = new MagickImage(fileItem.FilePath))
                {
                    image.Write($"{outputFilePath}\\{fileItem.FileName}.png", MagickFormat.Png);
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
