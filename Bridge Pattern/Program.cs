using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriter consoleWriter = new ConsoleWriter();

            SimpleLogger simpleLoggerConsole = new SimpleLogger(consoleWriter);
            DetailedLogger detailedLoggerConsole = new DetailedLogger(consoleWriter);

            string message = "Wrong Credentials";

            simpleLoggerConsole.LogError(message);
            detailedLoggerConsole.LogError(message);

            FileWriter textFileWriter = new FileWriter("simpleLog2.txt");

            SimpleLogger simpleLoggerFile = new SimpleLogger(textFileWriter);
            DetailedLogger detailedLoggerFile = new DetailedLogger(textFileWriter);


            simpleLoggerFile.LogError(message);
            simpleLoggerFile.LogError(message);
            simpleLoggerFile.LogError(message);

            textFileWriter.FileName = "detailedLog2.txt";

            detailedLoggerFile.LogError(message);
            detailedLoggerFile.LogError(message);
            detailedLoggerFile.LogError(message);
            detailedLoggerFile.LogError(message);
        }
    }
}    


