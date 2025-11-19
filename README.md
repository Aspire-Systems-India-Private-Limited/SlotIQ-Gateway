# SlotApp-Gateway

## Overview
SlotApp-Gateway is an API Gateway built with Ocelot for managing and routing requests to various microservices in the SlotIQ platform. It provides unified access, security, and routing for member management, operations, administration, and more.

## Features
- Centralized API gateway for SlotIQ microservices
- Route management via Ocelot configuration
- Supports multiple downstream services (Members, Operations, Administration, etc.)
- OpenAPI contract integration for documentation and UI design
- Environment-based configuration

## Project Structure
```
SlotApp-Gateway.sln
ApiGateway/
  ApiGateway.csproj
  ocelot.json
  appsettings.json
  appsettings.Development.json
  Contract/
    AdministrationAggregateContracts.openapi.yml
    MemberAggregateContracts.openapi.yml
    OperationsAggregateContracts.openapi.yml
  ...
```

## Key Files
- `ocelot.json`: Main routing configuration for the gateway
- `appsettings.json`: Application settings
- `Contract/`: OpenAPI contracts for each aggregate/domain
- `UI_Design_FR_for_Contracts.md`: Functional requirements for Figma UI design

## Getting Started
1. **Clone the repository**
2. **Restore dependencies**
   ```
   dotnet restore
   ```
3. **Run the API Gateway**
   ```
   dotnet run --project ApiGateway/ApiGateway.csproj
   ```
4. **Access the Gateway**
   - Default: http://localhost:9100
   - Use configured routes as per `ocelot.json`

## Contracts & Documentation
- OpenAPI YAML files are in the `Contract/` folder
- Use the provided UI design requirements to build a Figma prototype for contract visualization

## Contributing
- Please follow standard .NET and REST API best practices
- Keep the `ocelot.json` routes up to date with downstream services
- Update documentation as needed

## License
This project is proprietary to SoundaryaShanmugam-12931.

---

For any questions or support, contact the repository owner.
