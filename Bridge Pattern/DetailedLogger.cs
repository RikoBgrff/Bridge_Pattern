using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    class DetailedLogger : ILogging
    {
        public IWriter Writer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string LogError(string data)
        {
            throw new NotImplementedException();
        }

        public string LogInfo(string data)
        {
            throw new NotImplementedException();
        }

        public string LogWarning(string data)
        {
            throw new NotImplementedException();
        }
    }
}
