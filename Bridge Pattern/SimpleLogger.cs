using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge_Pattern
{
    public class SimpleLogger : ILogging
    {
        public IWriter Writer { get; set; }

        public SimpleLogger(IWriter writer)
        {
            Writer = writer;
        }
        public void LogInfo(string message)
        {
            Writer.Write($"Info: {message}");
        }

        public void LogWarning(string message)
        {
            Writer.Write($"Warning: {message}");
        }

        public void LogError(string message)
        {
            Writer.Write($"Error: {message}");
        }
    }
}
