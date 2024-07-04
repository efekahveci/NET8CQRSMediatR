# NET8CQRSMediatR

This is a sample .NET 8 project demonstrating the implementation of CQRS (Command Query Responsibility Segregation) using MediatR, Entity Framework Core, and ASP.NET Core Web API. The project includes basic CRUD operations for managing actors in an in-memory database.

## Table of Contents

- [Introduction](#introduction)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Introduction

This project showcases how to set up a simple CQRS pattern in a .NET 8 application using MediatR for handling commands and queries, Entity Framework Core for data access, and ASP.NET Core for building a RESTful API. The API provides endpoints to create and retrieve actor information.

## Technologies Used

- .NET 8
- ASP.NET Core
- Entity Framework Core (In-Memory Database)
- MediatR
- Swagger/OpenAPI

## Getting Started

To get started with this project, follow these steps:

1. **Clone the repository**:
    ```bash
    git clone https://github.com/your-username/NET8CQRSMediatR.git
    cd NET8CQRSMediatR
    ```

2. **Build the project**:
    ```bash
    dotnet build
    ```

3. **Run the project**:
    ```bash
    dotnet run
    ```

4. **Open the Swagger UI**:
    Open your web browser and navigate to `https://localhost:5001/swagger` to explore the available API endpoints.

## Usage

The project provides the following API endpoints:

- **Get Actor by ID**: `GET /Actor/{id}`
    - Retrieves actor details by ID.
- **Create Actor**: `POST /Actor`
    - Creates a new actor with the provided details.

### Example Requests

**Get Actor by ID**

```bash
curl -X GET "https://localhost:5001/Actor/{id}" -H "accept: application/json"
