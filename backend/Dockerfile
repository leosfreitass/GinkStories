# Stage 1: Build
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#WORKDIR /app

# Copy solution and restore dependencies
#COPY *.sln ./
#COPY src/ ./src/
#COPY test/ ./test/
#RUN dotnet restore

# Build the application
#RUN dotnet build src/GinkStories.Api/GinkStories.Api.csproj -c Release -o /app/build

# Publish the application
#RUN dotnet publish src/GinkStories.Api/GinkStories.Api.csproj -c Release -o /app/publish /p:UseAppHost=false

# Stage 2: Runtime
#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
#WORKDIR /app
#COPY --from=build /app/publish .

# Expose port if needed
#EXPOSE 8080

# Set the entry point
#ENTRYPOINT ["dotnet", "GinkStories.Api.dll"]

FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /app

# Copy solution and props first
COPY *.sln .
COPY Directory.Build.props .


COPY src/ ./src/
COPY test/ ./test/

# Restore dependencies
RUN dotnet restore

COPY src/ ./src/
COPY test/ ./test/

# Build to artifacts (not to project folders)
RUN dotnet build -c Debug -o /artifacts

# Set working directory to API project
ENTRYPOINT [ "dotnet", "watch", "run", "--project", "src/GinkStories.Api/GinkStories.Api.csproj", "--urls", "http://*:8080"]