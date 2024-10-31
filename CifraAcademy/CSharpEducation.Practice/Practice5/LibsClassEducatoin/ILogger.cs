namespace LibsClassEducatoin
{
    public interface ILogger
    {
        void Trace(string message);
        void Info(string message);
        void Debug(string massage);
        void Warning(string message);
        void Error(string message);
        void Fatal(string message);
        void Log(string message);



    }
}
