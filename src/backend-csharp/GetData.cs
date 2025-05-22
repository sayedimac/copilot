using System.Net;
using System.Text.Json;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace backend_csharp;

public class GetData
{
    private readonly ILogger _logger;

    public GetData(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<GetData>();
    }

    [Function("GetData")]
    public HttpResponseData Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequestData req)
    {
        _logger.LogInformation($"C# HTTP trigger function processed a request: {req.Url}");

        // Create the response
        var response = req.CreateResponse(HttpStatusCode.OK);
        response.Headers.Add("Content-Type", "application/json");

        // Create the same data structure as the Node.js function
        var data = new
        {
            items = new[]
            {
                new { id = 1, name = "Item 1", description = "This is item 1", value = 10.99 },
                new { id = 2, name = "Item 2", description = "This is item 2", value = 20.49 },
                new { id = 3, name = "Item 3", description = "This is item 3", value = 15.75 },
                new { id = 4, name = "Item 4", description = "This is item 4", value = 8.25 },
                new { id = 5, name = "Item 5", description = "This is item 5", value = 30.00 }
            },
            timestamp = DateTime.UtcNow.ToString("o"),
            count = 5
        };

        // Write the response
        response.WriteString(JsonSerializer.Serialize(data));

        return response;
    }
}