using LoggingLibrary.LoggingInterfaces;
namespace LoggingLibrary
{
    public class Provider
    {
        //returns logger with certain type of output
        public static ILogger GetLogger(ILoggerType type)
        {
            return new Logger(type);
        }
    }
}