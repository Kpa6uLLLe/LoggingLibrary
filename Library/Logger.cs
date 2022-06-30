using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingLibrary.LoggingInterfaces;

namespace LoggingLibrary
{
    public class Logger : ILogger
    {
        private ILoggerType _type;
        public Logger(ILoggerType type)
        {
            _type = type;
        }
        public void Log(string message, ILogType logType)
        {
            _type.Log(message, logType);
        }
    }
}
