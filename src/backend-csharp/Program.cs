using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices(services => {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
    });

// Add Aspire service defaults if available
try
{
    builder.AddServiceDefaults();
}
catch
{
    // Ignore if Aspire service defaults are not available
}

var host = builder.Build();
host.Run();