using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingLibrary.LoggingInterfaces;
namespace LoggingLibrary.LoggerOutputs
{
    public class DBOutput : LoggingLibrary.LoggingInterfaces.ILoggerType
    {
        public void Log(string message, ILogType logType)
        {
            Console.WriteLine("\nHey, that is not my place, I'm actually a DataBase resident...\nAnyway, :\n" + logType.FormatMessage(message));
        }
    }
}
