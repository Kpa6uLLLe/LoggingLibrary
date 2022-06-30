using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingLibrary.LoggingInterfaces;
namespace LoggingLibrary.LogTypes
{
    public class Info : ILogType
    {
        public string FormatMessage(string message)
        {
            return "[!Info!] " + message + "\n";
        }
    }
}
