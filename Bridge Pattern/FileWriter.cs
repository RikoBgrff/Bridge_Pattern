using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public class FileWriter : IWriter
    {
        private string _fileName;

        public string FileName
        {
            get => _fileName;
            set => _fileName = FileHelper.GetSafeFileName(".txt", value);
        }

        public FileWriter(string fileName)
        {
            FileName = fileName;
        }
        public void Write(string data)
        {
            using (FileStream fs = new FileStream(FileName, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine(data);
                    sw.WriteLine(new string('-', 40));
                }
            }
        }
    }
}