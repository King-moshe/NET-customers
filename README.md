# Client Database API

This repository contains a simple API for managing client data using ASP.NET Core and Entity Framework Core. The API allows users to perform basic CRUD (Create, Read, Update, Delete) operations on client entities. The project is designed to use MySQL as the underlying database.

## Prerequisites

Before running the application, make sure you have the following installed:

- .NET SDK
- MySQL Server

## Setup

1. Clone this repository to your local machine.

2. Install the required NuGet packages by running the following command in the root directory of the project:

   ```
   dotnet restore
   ```

3. Update the `appsettings.json` file with your MySQL connection string under the key `DefaultConnection`.

4. Create the database using Entity Framework Core migrations by running the following command:

   ```
   dotnet ef database update
   ```

## API Endpoints

### `GET /api/Clients`

Retrieves a list of all clients in the database.

### `POST /api/Clients`

Adds a new client to the database. Requires a JSON payload with the following properties:

- `Name` (string): The name of the client (required).
- `Ip` (string): The IP address of the client (required).
- `Phone` (string): The phone number of the client (required).

### `DELETE /api/Clients/{id}`

Deletes the client with the specified `id` from the database.

### Additional Actions

Additional actions for filtering clients or performing more complex queries can be added to the `ClientsController` class.

## DbContext Configuration

The database context, `YourDbContext`, is responsible for handling the interaction with the database. It is derived from `Microsoft.EntityFrameworkCore.DbContext` and provides a `DbSet` property to access the `Client` entities.

## Models

The `Client` model represents the client entity with the following properties:

- `ID` (int): The primary key for the client (auto-generated).
- `Name` (string): The name of the client.
- `Ip` (string): The IP address of the client.
- `Phone` (string): The phone number of the client.

## Swagger Documentation

The API is documented using Swagger, which provides a web-based UI for exploring the available endpoints and their documentation. When the application is running in the development environment, you can access the Swagger UI at `/swagger` to interact with the API.

## How to Run

To run the application, use the following command:

```
dotnet run
```

The application will start, and you can access the API at `https://localhost:5001/api/Clients` by default. If you want to change the port or other configurations, you can modify the `appsettings.json` file accordingly.

Feel free to explore the code and modify it according to your specific use case. Happy coding!
