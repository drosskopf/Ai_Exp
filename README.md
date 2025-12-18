# Ai_Exp - .NET Aspire Project

This is a .NET Aspire project with Next.js frontend and .NET 10 Web API backend.

## Project Structure

- **Ai_Exp.AppHost** - .NET Aspire orchestration project
- **Ai_Exp.ServiceDefaults** - Shared service defaults for Aspire
- **Ai_Exp.Web.Api** - .NET 10 Web API project
- **Ai_Exp.Web** - Next.js application with TypeScript
- **Ai_Exp.Web.Api.Integration.Test** - Integration tests for the Web API
- **Ai_Exp.Web.Api.Unit.Test** - Unit tests for the Web API
- **Ai_Exp.Web/tests** - Playwright tests for the Next.js application

## Prerequisites

- .NET 10 SDK
- Node.js 20+
- npm

## Getting Started

### Running the Application

1. Start the Aspire AppHost (this will start both the API and Web projects):

```bash
dotnet run --project Ai_Exp.AppHost
```

The Aspire dashboard will open in your browser, showing the status of all services.

### Running Tests

#### API Unit Tests
```bash
dotnet test Ai_Exp.Web.Api.Unit.Test
```

#### API Integration Tests
```bash
dotnet test Ai_Exp.Web.Api.Integration.Test
```

#### Playwright Tests
```bash
cd Ai_Exp.Web
npm test
```

Or with UI mode:
```bash
cd Ai_Exp.Web
npm run test:ui
```

## Development

### Web API
The Web API is located in `Ai_Exp.Web.Api` and uses minimal APIs with OpenAPI support.

### Next.js Web
The Next.js application is in `Ai_Exp.Web` and includes:
- TypeScript
- Tailwind CSS
- ESLint
- Playwright for E2E testing

### Aspire Integration
Both applications are registered in the AppHost and can be monitored through the Aspire dashboard. The Web project waits for the API to be ready before starting.
