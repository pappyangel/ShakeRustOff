# ShakeRustOff

A modern ASP.NET Core Blazor web application for file upload and management services with improved readability and maintainable code structure.

## Overview

ShakeRustOff is a web-based file management application built with ASP.NET Core and Blazor Server components. The project focuses on providing a clean, maintainable architecture with well-organized service and component layers.

## Features

- 📁 **File Upload Service**: Robust file upload functionality with service-based architecture
- 🎨 **Blazor Server Components**: Interactive server-side rendering with Razor components
- 🔒 **Security**: Built-in anti-forgery protection and HTTPS enforcement
- ⚙️ **Configuration Management**: Environment-specific configuration support
- 📦 **Static Assets**: Web root support for serving static content

## Tech Stack

- **Framework**: ASP.NET Core 8.0+
- **UI Framework**: Blazor Server
- **Language**: C#
- **Styling**: CSS
- **License**: MIT

## Project Structure

```
ShakeRustOff/
├── Components/          # Razor components for UI
├── Services/            # Business logic and service implementations
│   └── IFileUploadService
├── Properties/          # Project properties and metadata
├── wwwroot/             # Static assets (CSS, JavaScript, images)
├── Program.cs           # Application entry point and configuration
├── appsettings.json     # App configuration
├── ShakeRustOff.csproj  # Project file
└── README.md            # This file
```

## Getting Started

### Prerequisites

- .NET 8.0 SDK or later
- Visual Studio 2022 or Visual Studio Code with C# extension

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/pappyangel/ShakeRustOff.git
   cd ShakeRustOff
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Build the project:
   ```bash
   dotnet build
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

The application will start at `https://localhost:5001` (or the configured port).

## Configuration

Configuration files are located in the project root:

- **appsettings.json**: Production configuration
- **appsettings.Development.json**: Development-specific settings

## Development

### Recent Updates

- ✨ **Code Refactoring**: Improved code structure for better readability and maintainability
- 🎯 **Project Rename**: Rebranded from RustOff to ShakeRustOff for better clarity

### Architecture

The application follows a layered architecture:

- **Services Layer**: Contains business logic (e.g., `IFileUploadService`)
- **Components Layer**: Razor components for UI rendering
- **Middleware**: HTTP pipeline configuration and security features

## Contributing

Contributions are welcome! Feel free to:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

For questions or feedback, please open an issue on GitHub or contact the project maintainers.