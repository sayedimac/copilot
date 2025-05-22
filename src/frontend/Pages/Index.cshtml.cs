using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace frontend.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly HttpClient _httpClient;

    public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _httpClient = httpClientFactory.CreateClient("backend");
    }

    public IEnumerable<Item>? Items { get; set; }
    public string? Timestamp { get; set; }
    public int Count { get; set; }
    public string? ErrorMessage { get; set; }

    public async Task OnGetAsync()
    {
        try
        {
            // Call the backend API
            var response = await _httpClient.GetAsync("api/GetData");
            response.EnsureSuccessStatusCode();
            
            // Parse the JSON response
            var content = await response.Content.ReadAsStringAsync();
            var data = JsonSerializer.Deserialize<ApiResponse>(content);
            
            // Set the properties
            Items = data?.Items;
            Timestamp = data?.Timestamp;
            Count = data?.Count ?? 0;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error calling backend API");
            ErrorMessage = $"Error calling backend API: {ex.Message}";
        }
    }

    public class ApiResponse
    {
        public List<Item>? Items { get; set; }
        public string? Timestamp { get; set; }
        public int Count { get; set; }
    }

    public class Item
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Value { get; set; }
    }
}
