# Simple .NET Web Application

This is a simple web application built with ASP.NET Core 8.0, demonstrating basic web functionality including Razor Pages and REST API endpoints.

## Features

- Responsive web interface using Bootstrap
- Server-side rendering with Razor Pages
- REST API endpoints
- Current time display
- Weather forecast API

## Getting Started

### Prerequisites

- .NET 8.0 SDK or later

### Running the Application

1. Clone the repository
   ```
   git clone https://github.com/sayedimac/copilot.git
   cd copilot
   ```

2. Run the application
   ```
   cd SimpleWebApp
   dotnet run
   ```

3. Open your browser and navigate to:
   - Web Interface: `https://localhost:5001` or `http://localhost:5000`
   - API Endpoint: `https://localhost:5001/api/weather` or `http://localhost:5000/api/weather`

## Project Structure

- `/Pages` - Razor pages for the web interface
- `/Controllers` - API controllers
- `/Models` - Data models
- `/wwwroot` - Static files (CSS, JavaScript, images)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.