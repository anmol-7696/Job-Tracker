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
| `Title`       | string   | Job title applied for                 |
| `Status`      | string   | e.g. Applied, Interviewing, Offer, Rejected |
| `DateApplied` | DateTime | Date the application was submitted    |

## API Endpoints

| Method | Route                        | Description                  |
|--------|------------------------------|-------------------------------|
| GET    | `/api/JobApplications`       | Get all job applications      |
| GET    | `/api/JobApplications/{id}`  | Get a single job application  |
| POST   | `/api/JobApplications`       | Create a new job application  |
| PUT    | `/api/JobApplications/{id}`  | Update an existing application|
| DELETE | `/api/JobApplications/{id}`  | Delete a job application      |

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [dotnet-ef CLI tool](https://learn.microsoft.com/en-us/ef/core/cli/dotnet):
  \`\`\`bash
  dotnet tool install --global dotnet-ef
  \`\`\`

### Setup

1. Clone the repository:
   \`\`\`bash
   git clone https://github.com/<your-username>/JobTracker.git
   cd JobTracker/JobTracker.Api
   \`\`\`

2. Restore dependencies:
   \`\`\`bash
   dotnet restore
   \`\`\`

3. Apply database migrations (creates \`jobtracker.db\`):
   \`\`\`bash
   dotnet ef database update
   \`\`\`

4. Run the app:
   \`\`\`bash
   dotnet run --launch-profile https
   \`\`\`

5. Open Swagger UI in your browser:
   \`\`\`
   https://localhost:7259/swagger
   \`\`\`

## Example Request

**POST** `/api/JobApplications`

\`\`\`json
{
  "company": "Google",
  "title": "Software Engineer",
  "status": "Applied",
  "dateApplied": "2026-07-06T00:00:00Z"
}
\`\`\`

## Project Structure

\`\`\`
JobTracker.Api/
├── Controllers/
│   └── JobApplicationsController.cs
├── Data/
│   └── JobTrackerContext.cs
├── Models/
│   └── JobApplication.cs
├── Migrations/
├── Properties/
│   └── launchSettings.json
├── appsettings.json
└── Program.cs
\`\`\`

## Future Improvements

- Frontend client (React) for a full end-to-end job tracking experience
- Filtering and sorting endpoints (by status, date range, company)
- Authentication and per-user job tracking
- Docker containerization for deployment

## License

This project is open source and available under the [MIT License](LICENSE).
