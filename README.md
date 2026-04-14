# 🔐 WebApi JWT — E-commerce Admin Dashboard API

A secure RESTful backend API for an e-commerce admin panel, built with **ASP.NET Core** and **.NET 8**. Demonstrates JWT authentication, layered architecture, AutoMapper, and Entity Framework Core with MS SQL Server.

## 🏗️ Project Structure

```
WebApi_JWT/
├── Controllers/       # API endpoints (Products, Users, Orders, Auth)
├── Services/          # Business logic layer
├── Entities/          # Database models
├── Models/            # DTOs / request-response models
├── AutoMappers/       # AutoMapper profiles
├── Authentication/    # JWT token generation & validation
├── Helpers/           # Utility classes
├── Migrations/        # EF Core database migrations
├── Program.cs
└── Startup.cs
```

## 🚀 Tech Stack

| Layer | Technology |
|---|---|
| Runtime | .NET 8 |
| Framework | ASP.NET Core Web API |
| Auth | JWT + ASP.NET Identity |
| ORM | Entity Framework Core |
| Database | MS SQL Server |
| Mapping | AutoMapper |
| Docs | Swagger / OpenAPI |
| Language | C# |

## ✨ Features

- **JWT Authentication** — token-based auth with `[Authorize]` attribute protection on all secured endpoints
- **ASP.NET Identity** — full user management with role-based access control
- **Layered Architecture** — Controllers → Services → Repositories separation of concerns
- **AutoMapper** — clean DTO mapping between domain entities and API models
- **EF Core Migrations** — code-first database schema management
- **Swagger UI** — interactive API documentation available at `/swagger`
- **Async/Await** — all database operations are fully asynchronous

## 🔑 Authentication Flow

```
POST /api/auth/register   → Register new user
POST /api/auth/login      → Returns JWT token
GET  /api/products        → [Authorize] — requires valid token
```

## 🛠️ Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- MS SQL Server

### Setup

```bash
git clone https://github.com/andre100500/WebApi_JWT.git
cd WebApi_JWT
```

Update the connection string in `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=WebApiJwtDb;Trusted_Connection=True;"
}
```

Apply migrations and run:

```bash
dotnet ef database update
dotnet run
```

Open `https://localhost:{port}/swagger` to explore the API.

## 📚 What I learned

- Implementing JWT authentication end-to-end in ASP.NET Core
- Layered backend architecture with Dependency Injection
- AutoMapper for clean separation between domain and API models
- EF Core code-first approach with migrations
