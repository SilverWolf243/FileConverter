using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConverter
{
    internal class TaskFileFactory
    {
        public static FileConverter.TaskFile.TaskFile GenerateTaskFile(string outputPath,FileItem item) 
        {
            switch (item.Exp) 
            {
                case FileUtils.FileExp.PNG:
                    return new FileConverter.TaskFile.PngFile(outputPath, item);

                case FileUtils.FileExp.JPEG:
                    return new FileConverter.TaskFile.JpegFile(outputPath, item);

                case FileUtils.FileExp.JPG:
                    return new FileConverter.TaskFile.JpgFile(outputPath, item);

                case FileUtils.FileExp.WEBP:
                    return new FileConverter.TaskFile.WebpFile(outputPath, item);

                case FileUtils.FileExp.JFIF:
                    return new FileConverter.TaskFile.JfifFile(outputPath, item);

                case FileUtils.FileExp.GIF:
                    return new FileConverter.TaskFile.GifFile(outputPath, item);
            }
            return null;
        }
    }
}
