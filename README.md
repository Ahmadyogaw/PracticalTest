# done proxy
- User Feature 
    - login 
    - create User
    - update Password
    - get user
    - delete user
    - update user
# Project Overfiew
- Dotnet version 7.0
- folder structure using Clean architecture

# How to Run Project
1. dotnet run --project CleanArchitecture.WebAPI

# Project Structure
- ../CleanArchitecture
├── CleanArchitecture.Application
│   ├── CleanArchitecture.Application.csproj
│   ├── Common
│   │   ├── Behaviors
│   │   │   └── ValidatorBehavior.cs
│   │   └── Exceptions
│   │       ├── BadRequestException.cs
│   │       └── NotFoundException.cs
│   ├── Features
│   │   ├── OrganizerFeature
│   │   │   ├── CreateOrganizersEvents
│   │   │   │   ├── CreateOrganizersEventsHandler.cs
│   │   │   │   ├── CreateOrganizersEventsMapper.cs
│   │   │   │   ├── CreateOrganizersEventsRequest.cs
│   │   │   │   └── CreateOrganizersEventsResponse.cs
│   │   │   ├── DeleteOrganizerEvents
│   │   │   │   ├── DeleteOrganizerEventsHandler.cs
│   │   │   │   ├── DeleteOrganizerEventsMapper.cs
│   │   │   │   ├── DeleteOrganizerEventsRequest.cs
│   │   │   │   └── DeleteOrganizerEventsResponse.cs
│   │   │   ├── GetAllOrganizersEvents
│   │   │   │   ├── GetAllOrganizersEventsHandler.cs
│   │   │   │   ├── GetAllOrganizersEventsMapper.cs
│   │   │   │   ├── GetAllOrganizersEventsRequest.cs
│   │   │   │   └── GetAllOrganizersEventsResponse.cs
│   │   │   ├── GetOrganizerEvents
│   │   │   │   ├── GetOrganizerEventsHandler.cs
│   │   │   │   ├── GetOrganizerEventsMapper.cs
│   │   │   │   ├── GetOrganizerEventsRequest.cs
│   │   │   │   └── GetOrganizerEventsResponse.cs
│   │   │   └── UpdateOrganizersEvents
│   │   │       ├── CreateOrganizersEventsHandler.cs
│   │   │       ├── CreateOrganizersEventsMapper.cs
│   │   │       ├── CreateOrganizersEventsRequest.cs
│   │   │       └── CreateOrganizersEventsResponse.cs
│   │   ├── SportFeatures
│   │   │   ├── CreateSportEvents
│   │   │   │   ├── CreateSportEventsHandler.cs
│   │   │   │   ├── CreateSportEventsMapper.cs
│   │   │   │   ├── CreateSportEventsRequest.cs
│   │   │   │   └── CreateSportEventsResponse.cs
│   │   │   ├── DeleteSportEvents
│   │   │   │   ├── DeleteSportEventsHandler.cs
│   │   │   │   ├── DeleteSportEventsMapper.cs
│   │   │   │   ├── DeleteSportEventsRequest.cs
│   │   │   │   └── DeleteSportEventsResponse.cs
│   │   │   ├── GetAllSportEvents
│   │   │   │   ├── GetAllSportEventsHandler.cs
│   │   │   │   ├── GetAllSportEventsMapper.cs
│   │   │   │   ├── GetAllSportEventsRequest.cs
│   │   │   │   └── GetAllSportEventsResponse.cs
│   │   │   ├── GetSportEvents
│   │   │   │   ├── GetSportEventsHandler.cs
│   │   │   │   ├── GetSportEventsMapper.cs
│   │   │   │   ├── GetSportEventsRequest.cs
│   │   │   │   └── GetSportEventsResponse.cs
│   │   │   └── UpdateSportEvents
│   │   │       ├── UpdateSportEventsHandler.cs
│   │   │       ├── UpdateSportEventsMapper.cs
│   │   │       ├── UpdateSportEventsRequest.cs
│   │   │       └── UpdateSportEventsResponse.cs
│   │   └── UserFeatures
│   │       ├── CreateUser
│   │       │   ├── CreateUserHandler.cs
│   │       │   ├── CreateUserMapper.cs
│   │       │   ├── CreateUserRequest.cs
│   │       │   ├── CreateUserResponse.cs
│   │       │   └── CreateUserValidator.cs
│   │       ├── DeleteUser
│   │       │   ├── DeleteUserHandler.cs
│   │       │   ├── DeleteUserMapper.cs
│   │       │   ├── DeleteUserRequest.cs
│   │       │   └── DeleteUserResponse.cs
│   │       ├── GetUser
│   │       │   ├── GetUserHandler.cs
│   │       │   ├── GetUserMapper.cs
│   │       │   ├── GetUserRequest.cs
│   │       │   └── GetUserResponse.cs
│   │       ├── Login
│   │       │   ├── LoginHandler.cs
│   │       │   ├── LoginMapper.cs
│   │       │   ├── LoginRequest.cs
│   │       │   └── LoginResponse.cs
│   │       ├── UpdatePassword
│   │       │   ├── UpdatePasswordHandler.cs
│   │       │   ├── UpdatePasswordMapper.cs
│   │       │   ├── UpdatePasswordRequest.cs
│   │       │   └── UpdatePasswordResponse.cs
│   │       └── UpdateUser
│   │           ├── UpdateUserHandler.cs
│   │           ├── UpdateUserMapper.cs
│   │           ├── UpdateUserRequest.cs
│   │           └── UpdateUserResponse.cs
│   ├── obj
│   │   ├── CleanArchitecture.Application.csproj.nuget.dgspec.json
│   │   ├── CleanArchitecture.Application.csproj.nuget.g.props
│   │   ├── CleanArchitecture.Application.csproj.nuget.g.targets
│   │   ├── Debug
│   │   ├── project.assets.json
│   │   └── project.nuget.cache
│   ├── Repositories
│   │   ├── IBaseRepository.cs
│   │   ├── IHttpClient.cs
│   │   ├── IUnitOfWork.cs
│   │   └── IUserRepository.cs
│   └── ServiceExtensions.cs
├── CleanArchitecture.Domain
│   ├── CleanArchitecture.Domain.csproj
│   ├── Common
│   │   └── BaseEntity.cs
│   ├── Entities
│   │   ├── Logger.cs
│   │   └── User.cs
│   └── obj
│       ├── CleanArchitecture.Domain.csproj.nuget.dgspec.json
│       ├── CleanArchitecture.Domain.csproj.nuget.g.props
│       ├── CleanArchitecture.Domain.csproj.nuget.g.targets
│       ├── Debug
│       ├── project.assets.json
│       └── project.nuget.cache
├── CleanArchitecture.Persistence
│   ├── CleanArchitecture.Persistence.csproj
│   ├── Context
│   │   └── DataContext.cs
│   ├── obj
│   │   ├── CleanArchitecture.Persistence.csproj.nuget.dgspec.json
│   │   ├── CleanArchitecture.Persistence.csproj.nuget.g.props
│   │   ├── CleanArchitecture.Persistence.csproj.nuget.g.targets
│   │   ├── Debug
│   │   ├── project.assets.json
│   │   └── project.nuget.cache
│   ├── Repositories
│   │   ├── BaseRepository.cs
│   │   ├── UnitOfWork.cs
│   │   └── UserRepository.cs
│   └── ServiceExtensions.cs
├── CleanArchitecture.sln
├── CleanArchitecture.UnitTest
│   ├── bin
│   ├── CleanArchitecture.UnitTest.csproj
│   └── obj
│       ├── CleanArchitecture.UnitTest.csproj.nuget.dgspec.json
│       ├── CleanArchitecture.UnitTest.csproj.nuget.g.props
│       ├── CleanArchitecture.UnitTest.csproj.nuget.g.targets
│       ├── project.assets.json
│       └── project.nuget.cache
├── CleanArchitecture.WebAPI
│   ├── appsettings.Development.json
│   ├── appsettings.json
│   ├── CleanArchitecture.WebAPI.csproj
│   ├── Controllers
│   │   ├── OrganizerController.cs
│   │   ├── SportsController.cs
│   │   └── UserController.cs
│   ├── Dockerfile
│   ├── Extensions
│   │   ├── ApiBehaviorExtensions.cs
│   │   ├── CorsPolicyExtensions.cs
│   │   └── ErrorHandlerExtensions.cs
│   ├── obj
│   │   ├── CleanArchitecture.WebAPI.csproj.nuget.dgspec.json
│   │   ├── CleanArchitecture.WebAPI.csproj.nuget.g.props
│   │   ├── CleanArchitecture.WebAPI.csproj.nuget.g.targets
│   │   ├── project.assets.json
│   │   └── project.nuget.cache
│   ├── Program.cs
│   ├── Properties
│   │   └── launchSettings.json
│   └── users.db
└── README.md

