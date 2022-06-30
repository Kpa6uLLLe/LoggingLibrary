using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingLibrary.LoggingInterfaces;
namespace LoggingLibrary.LoggerOutputs
{
    public class ConsoleOutput : LoggingLibrary.LoggingInterfaces.ILoggerType
    {
        public void Log(string message, ILogType logType)
        {
            Console.WriteLine(logType.FormatMessage(message));
        }
    }
}
