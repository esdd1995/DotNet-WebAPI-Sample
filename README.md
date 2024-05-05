# Project Description

This repository provides a well-structured ASP.NET Core Web API (.NET 7) project demonstrating best practices for building modern APIs.

## Key Features & Technologies

Robust Framework: Leverages ASP.NET Core Web API for efficient and scalable API development.
Data Persistence: Utilizes Entity Framework Core for smooth interaction with a PostgreSQL database.
Clean Architecture: Follows the Clean Architecture principle, separating concerns for maintainability and testability.
Design Patterns: Implements the Unit of Work and Repository Service patterns for data access management.
Test-Driven Development (TDD): Encourages code quality through comprehensive unit testing.
Containerization: Integrates Docker for easy deployment and environment consistency.
Getting Started

## Clone the Repository:

**Bash**
`git clone https://github.com/SaraRasoulian/DotNet-WebAPI-Sample.git`
Use code with caution.
content_copy
Set Up with Docker Compose:

Ensure you have Docker installed (https://www.docker.com/).

Navigate to the project directory and run:

Bash
`docker-compose up -d`

This starts three services:

**Web API:** Accessible at http://localhost:5000
PostgreSQL Database: Available at http://localhost:5433 (use PgAdmin4 for management)
PgAdmin4 Web Interface: Accessible at http://localhost:8080
For code changes to take effect, rebuild the image with:

Bash
`docker-compose up -d --build`

## To stop and remove containers:

Bash
`docker-compose down`


## Run Database Migrations:

Open Sample.sln in Visual Studio. In the Package Manager Console, execute:


`update-database`

This creates the database schema within the PostgreSQL container.

## Contributing

We welcome your contributions! If you have improvements in mind, feel free to create an issue or submit a pull request.

## Additional Notes

Consider including a LICENSE file to clarify usage rights.
You might add a section on API endpoints and usage examples.
Include instructions for running the API without Docker (if applicable).
This enhanced README provides a clearer understanding of your project's purpose, features, and setup process, making it more user-friendly for developers.
