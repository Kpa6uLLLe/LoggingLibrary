

using LoggingLibrary;
using LoggingLibrary.LoggingInterfaces;
using LoggingLibrary.LoggerOutputs;
using LoggingLibrary.LogTypes;
ILogger[] loggers = {
Provider.GetLogger(new FileOutput()),      //
Provider.GetLogger(new ConsoleOutput()),
Provider.GetLogger(new DBOutput())
};
string msg = "A message";
foreach (var logger in loggers)
{
    
    logger.Log(msg, new Debug());
    logger.Log(msg, new Info());
    logger.Log(msg, new Warn());
    logger.Log(msg, new Error());
}

//that was a brief example of how to use this library
