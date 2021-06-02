using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public interface ILogging
    {
        IWriter Writer { get; set; }

        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
    }
}