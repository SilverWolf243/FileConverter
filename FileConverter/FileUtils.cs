using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConverter
{
    internal class FileUtils
    {
        public enum FileExp 
        {
            NONE,
            PNG,
            JPEG,
            JPG,
            GIF,
            WEBP,
            JFIF,
        }

        public static FileUtils.FileExp GetFileExp(string filePath) 
        {
            int index = filePath.LastIndexOf(".");
            string exp = filePath.Substring(index + 1).ToUpper();

            if (Enum.TryParse<FileExp>(exp, out FileExp enumValue))
            {
                return enumValue;
            }
            else
            {
                return FileExp.NONE;
            }
        } 

        public static string GetOriginalFileName(string filePath)
        {
            int expIndex = filePath.LastIndexOf(".");
            int filePathIndex = filePath.LastIndexOf("\\") + 1;
            string originalFileName = filePath.Substring(filePathIndex);
            string ret = originalFileName.Substring(0,originalFileName.LastIndexOf("."));
            return ret;
        }
    }
}
