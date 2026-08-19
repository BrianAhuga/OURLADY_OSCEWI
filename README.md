# Our Lady & OSCEWI Web Platform

A multi-application web platform developed for **Our Lady Parents' School** and **OSCEWI**, featuring dedicated public-facing websites, a centralized administration system, and a shared backend services layer.

The solution is built with **ASP.NET Core and .NET 8**, with Entity Framework Core and SQL Server powering the application's data layer. The architecture separates public websites, administration, API services, and shared components into dedicated projects for better maintainability and scalability.

## Overview

The **Our Lady & OSCEWI Web Platform** brings together two institutional websites and a centralized administration system within a single .NET solution.

The platform is structured around four main application areas:

* **Our Lady Website** — Public-facing website for Our Lady Parents' School
* **OSCEWI Website** — Public-facing website for OSCEWI
* **Admin Portal** — Centralized administration interface for managing platform data
* **API Services** — Shared application services and database access layer

The repository also contains a **Shared** project used across the different applications.

## Key Features

* Dedicated websites for Our Lady Parents' School and OSCEWI
* Centralized administration portal
* Shared backend services
* SQL Server database integration
* Entity Framework Core
* Database migrations
* Job application processing
* Pupil enrollment processing
* Email services
* Messaging services
* Shared application models and components
* Separation of public-facing and administrative applications
* Modular multi-project architecture

The API services project includes dedicated services for **job applications, mail, messaging, and pupil enrollment**, together with Entity Framework Core migrations and an application database context.

## Architecture

The solution follows a modular architecture:

```text
OurLady_Oscewi
│
├── APIServices
│   ├── Migrations
│   ├── ApplicationDbContext.cs
│   ├── JobApplicationService.cs
│   ├── MailService.cs
│   ├── MessageService.cs
│   └── PupilEnrollmentService.cs
│
├── Admin.Project
│   ├── Controllers
│   ├── Models
│   ├── Views
│   └── wwwroot
│
├── Oscewi.Web
│   ├── Pages
│   └── wwwroot
│
├── OurLady.Web
│   ├── Pages
│   └── wwwroot
│
├── Shared
│
└── OurLady_Oscewi.sln
```

This structure keeps the public websites, administration functionality, and backend services separated while allowing them to share common functionality.

## Technology Stack

| Technology                      | Purpose                      |
| ------------------------------- | ---------------------------- |
| **C#**                          | Primary programming language |
| **.NET 8**                      | Application framework        |
| **ASP.NET Core**                | Web application development  |
| **Entity Framework Core 8**     | Data access and ORM          |
| **SQL Server**                  | Relational database          |
| **Razor Pages**                 | Public website development   |
| **ASP.NET Core MVC**            | Administration portal        |
| **HTML / CSS / JavaScript**     | Frontend development         |
| **Entity Framework Migrations** | Database schema management   |

The API, administration portal, and OSCEWI web application target `.NET 8.0` and use Entity Framework Core 8 with SQL Server.

## Application Components

### Our Lady Website

The `OurLady.Web` project provides the public-facing website for **Our Lady Parents' School**.

It is structured using Razor Pages and has its own static assets and application configuration.

### OSCEWI Website

The `Oscewi.Web` project provides the public-facing website for **OSCEWI**.

The application uses Razor Pages and references the shared API services and shared project, allowing it to consume centralized application functionality.

### Administration Portal

The `Admin.Project` application provides a centralized administrative interface.

It follows an ASP.NET Core MVC structure with dedicated:

* Controllers
* Models
* Views
* Static assets

The project also references the shared components and Entity Framework Core infrastructure.

### API Services

The `APIServices` project provides the application's shared backend functionality.

It contains:

* `ApplicationDbContext`
* Entity Framework Core migrations
* Job application services
* Mail services
* Messaging services
* Pupil enrollment services

This allows multiple applications within the solution to rely on common backend functionality rather than duplicating business logic.

## Database

The application uses **Microsoft SQL Server** with **Entity Framework Core 8**.

Database schema changes are managed through Entity Framework Core migrations located within the `APIServices` project.

Before running the application, configure the appropriate SQL Server connection string in the relevant application configuration files.

> **Security note:** Never commit production database credentials, passwords, API keys, SMTP credentials, or other secrets to source control.

## Getting Started

### Prerequisites

Make sure you have the following installed:

* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* Microsoft SQL Server
* Visual Studio 2022 or Visual Studio Code
* Git

### Clone the Repository

```bash
git clone https://github.com/BrianAhuga/OURLADY_OSCEWI.git
```

Navigate to the project:

```bash
cd OURLADY_OSCEWI
```

### Restore Dependencies

```bash
dotnet restore
```

### Configure the Database

Update the connection string in the appropriate `appsettings.json` files with your SQL Server configuration.

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=OurLadyOscewi;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

### Apply Database Migrations

From the project containing the Entity Framework Core context, run:

```bash
dotnet ef database update
```

If Entity Framework CLI is not installed:

```bash
dotnet tool install --global dotnet-ef
```

### Build the Solution

```bash
dotnet build
```

### Run the Applications

Each web application can be launched independently through Visual Studio or with the .NET CLI.

For example:

```bash
dotnet run --project OurLady.Web
```

```bash
dotnet run --project Oscewi.Web
```

```bash
dotnet run --project Admin.Project
```

## Project Goals

The platform was designed to provide a maintainable digital foundation for the institutions while centralizing administrative operations and reusable backend functionality.

The multi-project structure makes it possible to evolve the public websites and administrative systems independently while maintaining a common service and data layer.

## Architecture Benefits

### Separation of Concerns

Public websites, administration, backend services, and shared components are organized into separate projects.

### Reusability

Common services and functionality can be shared between multiple applications.

### Maintainability

Changes to backend services can be made centrally without duplicating implementation across the public websites.

### Scalability

The modular architecture provides a foundation for introducing additional institutional websites, services, integrations, and administrative features in the future.

## Future Improvements

Potential enhancements include:

* JWT authentication and authorization
* Role-based access control
* Centralized notification management
* Advanced admin dashboards
* Audit logging
* Global exception handling
* API documentation
* Automated testing
* Structured application logging
* File and document management
* Cloud deployment
* CI/CD automation
* Containerization with Docker

## Author

**Brian Ahuga**

Software Engineer specializing in scalable web applications, backend systems, and modern software architecture.

GitHub: [BrianAhuga](https://github.com/BrianAhuga)

## License

This project is intended for demonstration and portfolio purposes.
