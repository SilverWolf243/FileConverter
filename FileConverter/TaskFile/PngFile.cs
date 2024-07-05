using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConverter.TaskFile
{
    internal class PngFile : TaskFile
    {
        public PngFile(string outputFilePath, FileItem fileItem) : base(outputFilePath, fileItem)
        {

        }

        public override bool ConverterPng()
        {
            bool ret = true;
            try
            {
                File.Copy(fileItem.FilePath, $"{outputFilePath}\\{fileItem.FileName}.png", true);
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
