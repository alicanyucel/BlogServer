# Use the official .NET 9 SDK image for build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./Presentation/BlogServer.WebApi/*.csproj ./Presentation/BlogServer.WebApi/
RUN dotnet restore ./Presentation/BlogServer.WebApi/BlogServer.WebApi.csproj

# Copy everything else and build
COPY . .
RUN dotnet publish ./Presentation/BlogServer.WebApi/BlogServer.WebApi.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "BlogServer.WebApi.dll"]
