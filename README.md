# JobTracker API

A RESTful Web API built with ASP.NET Core for tracking job applications — company, title, status, and date applied — backed by a SQLite database via Entity Framework Core.

## Features

- Full CRUD operations for job applications (Create, Read, Update, Delete)
- SQLite database with Entity Framework Core (code-first, migrations-based)
- Interactive API documentation and testing via Swagger/OpenAPI
- CORS enabled for easy integration with a frontend client

## Tech Stack

- **Language:** C#
- **Framework:** ASP.NET Core (.NET 9)
- **ORM:** Entity Framework Core
- **Database:** SQLite
- **API Docs:** Swagger / OpenAPI (Swashbuckle)

## Data Model

Each job application record includes:

| Field         | Type     | Description                          |
|---------------|----------|---------------------------------------|
| `Id`          | int      | Auto-generated primary key            |
| `Company`     | string   | Name of the company                   |
| `Title`       | string   | Job title
