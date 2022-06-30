using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibrary.LoggingInterfaces
{
    public interface ILogType
    {
        public string FormatMessage(string message);
    }
}
