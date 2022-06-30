using LoggingLibrary.LoggingInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibrary.LogTypes
{
    public class Warn : ILogType
    {
        public string FormatMessage(string message)
        {
            return "[WARNING] " + message + "\n";
        }
    }
}
