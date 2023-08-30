namespace Core.CrossCuttingConcerns.Logging;

public class LogDetail
{
    public string FullName { get; set; }
    public string MethodlName { get; set; }
    public string User { get; set; }
    public List<LogParameter> Parameters { get; set; }

    public LogDetail()
    {
        FullName = string.Empty;
        MethodlName = string.Empty;
        User = string.Empty;
        Parameters = new List<LogParameter>();
    }

    public LogDetail(string fullName, string methodlName, string user, List<LogParameter> parameters)
    {
        FullName = fullName;
        MethodlName = methodlName;
        User = user;
        Parameters = parameters;
    }
}
