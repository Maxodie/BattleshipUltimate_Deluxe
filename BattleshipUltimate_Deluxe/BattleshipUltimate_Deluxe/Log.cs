namespace BattleshipUltimate_Deluxe
{
    public class Log
    {
        static readonly string[] s_colors = {
            "\x1b[0m",
            "\x1b[0m",
            "\x1b[32m",
            "\x1b[1;33m",
            "\x1b[31m"
        };

        enum LogLevel
        {
            LOG_DEBUG,
            LOG_TRACE,
            LOG_SUCCESS,
            LOG_WARNING,
            LOG_ERROR,
            LOG_LEVEL_LEN
        };

        static string Prefix(LogLevel logLevel)
        {
            return s_colors[(int)logLevel];
        }

        public static void Debug(string msg)
        {
            Console.WriteLine(Prefix(LogLevel.LOG_DEBUG) + msg);
        }

        public static void Trace(string msg)
        {
            Console.WriteLine(Prefix(LogLevel.LOG_TRACE) + msg);
        }

        public static void Success(string msg)
        {
            Console.WriteLine(Prefix(LogLevel.LOG_SUCCESS) + msg);
        }

        public static void Warning(string msg)
        {
            Console.WriteLine(Prefix(LogLevel.LOG_WARNING) + msg);
        }

        public static void Error(string msg)
        {
            Console.WriteLine(Prefix(LogLevel.LOG_ERROR) + msg);
        }
    } 
}