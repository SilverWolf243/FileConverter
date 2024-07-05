using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConverter.TaskFile
{
    internal abstract class TaskFile
    {
        public string outputFilePath { get; set; }
        public FileItem fileItem { get; set; }
        public abstract bool ConverterPng();
        public TaskFile(string outputFilePath, FileItem fileItem)
        {
            this.outputFilePath = outputFilePath;
            this.fileItem = fileItem;
        }   
    }
}
