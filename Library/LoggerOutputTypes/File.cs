using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingLibrary.LoggingInterfaces;
using System.IO;
namespace LoggingLibrary.LoggerOutputs
{
    public class FileOutput : LoggingLibrary.LoggingInterfaces.ILoggerType
    {
        public string LogsPath { get; set; } = Path.Combine(Directory.GetCurrentDirectory(),"Logs","logs" + DateTime.Now.ToString("dd-MM-yyyy_hh-mm") + ".txt");
        public void Log(string message, ILogType logType)
        {
            if(!Directory.Exists(Path.GetDirectoryName(LogsPath)))
                Directory.CreateDirectory(Path.GetDirectoryName(LogsPath));
            File.AppendAllTextAsync(LogsPath, logType.FormatMessage(message)).Wait();
        }
    }
}
