var builder = WebApplication.CreateBuilder(args);

// Add service defaults (telemetry, etc.)
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddRazorPages();

// Add HTTP client for backend API
builder.Services.AddHttpClient("backend", client => {
    // In Aspire, the backend URI will be resolved through service discovery
    // For local development, you can override this in appsettings.Development.json
    client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("BackendUri") ?? "http://localhost:7071/");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

// Map Aspire health checks
app.MapDefaultEndpoints();

app.Run();
