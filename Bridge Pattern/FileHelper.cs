using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public class FileHelper
    {
        public static bool CheckExtension(string extension, string fileName)
        {
            return fileName.EndsWith(extension);
        }

        public static string GetSafeFileName(string extension, string fileName)
        {
            if (!FileHelper.CheckExtension(".txt", fileName))
                fileName += ".txt";

            return fileName;
        }
    }
}