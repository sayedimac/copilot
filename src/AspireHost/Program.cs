using System.Reflection;
using Microsoft.Extensions.Logging;

var builder = DistributedApplication.CreateBuilder(args);

// Add frontend web project
var frontend = builder.AddProject<Projects.frontend>("frontend");

// Add backend C# Azure Functions project
var backend = builder.AddProject<Projects.backend_csharp>("backend")
    .WithHttpEndpoint(hostPort: 7071, targetPort: 7071, name: "backend-api");

// Connect the frontend to the backend
frontend.WithReference(backend);

builder.Build().Run();
