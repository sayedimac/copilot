var builder = DistributedApplication.CreateBuilder(args);

builder.Services.AddServiceDefaults();
builder.Services.AddHttpClient("frontend", client =>
{
    client.BaseAddress = new Uri("http://localhost:5000");
});
builder.Services.AddHttpClient("backend", client =>
{
    client.BaseAddress = new Uri("http://localhost:7071");
});

builder.Build().Run();
