using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    interface ILogging
    {
        IWriter Writer { get; set; }
        string LogInfo(string data);
        string LogWarning(string data);
        string LogError(string data);
    }
}
