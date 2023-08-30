using Core.CrossCuttingConcerns.Serilog.ConfigurationModels;
using Core.CrossCuttingConcerns.Serilog.Messages;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Sinks.MSSqlServer;

namespace Core.CrossCuttingConcerns.Serilog.Logger;

public class MsSqlLogger : LoggerServiceBase
{
    private readonly IConfiguration _configuration;

    public MsSqlLogger(IConfiguration configuration)
    {
        MsSqlConfiguration logConfig =
            configuration.GetSection("SerilogLogConfigurations:MsSqlConfiguration").Get<MsSqlConfiguration>()
            ?? throw new Exception(SerilogMessages.NullOptionsMessage);

        MSSqlServerSinkOptions sinkOptions = new()
        {
            TableName = logConfig.TableName,
            AutoCreateSqlDatabase = logConfig.AutoCreateSqlTable
        };

        ColumnOptions columnOptions = new();

        global::Serilog.Core.Logger serilogConfig = new LoggerConfiguration().WriteTo
            .MSSqlServer(logConfig.ConnectionString, sinkOptions, columnOptions: columnOptions)
            .CreateLogger();

        Logger = serilogConfig;
    }
}
