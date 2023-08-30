namespace Core.CrossCuttingConcerns.Logging;

public class LogDetailWithException : LogDetail
{
    public string ExceptionMessage { get; set; }

    public LogDetailWithException()
    {
        ExceptionMessage = string.Empty;
    }

    public LogDetailWithException(
        string fullName,
        string methodlName,
        string user,
        List<LogParameter> parameters,
        string exceptionMessage) : base(fullName, methodlName, user, parameters)
    {
        ExceptionMessage = exceptionMessage;
    }
}
