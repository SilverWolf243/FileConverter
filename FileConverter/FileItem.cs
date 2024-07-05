using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConverter
{
    internal class FileItem
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public FileUtils.FileExp Exp { get; set; }
        public override string ToString()
        {
            return FilePath;
        }
        public FileItem(string fileName, string filePath, FileUtils.FileExp exp)
        {
            FileName = fileName;
            FilePath = filePath;
            Exp = exp;
        }   
    }
}
