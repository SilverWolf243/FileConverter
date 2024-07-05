using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConverter.TaskFile
{
    internal class JfifFile : TaskFile
    {
        public JfifFile(string outputFilePath, FileItem fileItem) : base(outputFilePath, fileItem)
        {
        }

        public override bool ConverterPng()
        {
            bool ret = true;
            try
            {
                using (Image image = Image.FromFile(fileItem.FilePath))
                {
                    image.Save($"{outputFilePath}\\{fileItem.FileName}.png", ImageFormat.Png);
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
