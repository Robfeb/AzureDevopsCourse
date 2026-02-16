# AzureDevopsCourse

This repository contains demo projects for learning Azure DevOps concepts, featuring a Pizza ordering web application and a supporting library with unit tests.

## Repository Structure

The repository is organized into two main projects:

### 1. PizzAzureDevops
An ASP.NET Core MVC web application for managing pizza orders.

**Technology Stack:**
- .NET 8.0
- ASP.NET Core MVC
- Entity Framework Core 8.0 (SQL Server)
- Razor Runtime Compilation

**Features:**
- Pizza management with name, description, and pricing
- Order management with customer details and quantities
- In-memory pizza catalog service
- MVC architecture with Controllers, Models, Views, and Services

**Key Components:**
- `Controllers/`: HomeController, PizzaController, OrderController
- `Models/`: Pizza, Order entities
- `Services/`: PizzaService for managing pizza data
- `Views/`: Razor views for UI
- `wwwroot/`: Static files (CSS, JavaScript, libraries)

### 2. TestArtifacts
A .NET class library demonstrating unit testing with xUnit.

**Solution Contents:**
- `PizzaLibrary/`: A class library for pizza and topping management
- `PizzaLibrary.Tests/`: xUnit test project with test coverage

**Library Features:**
- Pizza class with name and topping management
- Topping class for pizza customization
- NuGet package generation enabled (PizzaLibrary v1.0.0)

**Test Coverage:**
- Pizza creation and naming tests
- Topping management tests
- Test tools: xUnit, coverlet for code coverage

## Getting Started

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 or Visual Studio Code (optional)
- SQL Server (for database features, currently commented out)

### Running the PizzAzureDevops Web Application

1. Navigate to the PizzAzureDevops directory:
   ```bash
   cd PizzAzureDevops
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

4. Open your browser and navigate to the URL displayed in the console (typically `https://localhost:5001` or `http://localhost:5000`)

### Building and Testing the TestArtifacts Solution

1. Navigate to the TestArtifacts directory:
   ```bash
   cd TestArtifacts
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Build the solution:
   ```bash
   dotnet build
   ```

4. Run the unit tests:
   ```bash
   dotnet test
   ```

5. To generate code coverage:
   ```bash
   dotnet test --collect:"XPlat Code Coverage"
   ```

## Build and Test

### PizzAzureDevops
```bash
cd PizzAzureDevops
dotnet build
dotnet run
```

### TestArtifacts
```bash
cd TestArtifacts
dotnet build
dotnet test
```

## Project Purpose

This repository serves as a learning resource for Azure DevOps practices, including:
- CI/CD pipeline configuration
- Automated testing and test reporting
- Build artifacts and package management
- Code quality and coverage metrics
- DevOps best practices with .NET applications

## Additional Information

- The web application uses an in-memory data store for simplicity
- Entity Framework Core database features are present but commented out
- The default route redirects to the Pizza controller
- The PizzaLibrary can be built as a NuGet package for distribution
