#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Container we use for final publish
FROM mcr.microsoft.com/dotnet/core/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Build container
FROM mcr.microsoft.com/dotnet/core/sdk:5.0-buster AS build

# Copy the code into the container
WORKDIR /src
COPY ["src/LikeTrackingSystem.LikeTracker/LikeTrackingSystem.LikeTracker.csproj", "LikeTrackingSystem.LikeTracker/"]

# NuGet restore
RUN dotnet restore "LikeTrackingSystem.LikeTracker/LikeTrackingSystem.LikeTracker.csproj"
COPY ["src/LikeTrackingSystem.LikeTracker/", "LikeTrackingSystem.LikeTracker/"]

# Build the API
WORKDIR "/LikeTrackingSystem.LikeTracker"
RUN dotnet build "LikeTrackingSystem.LikeTracker.csproj" -c Release -o /app/build

# Publish it
FROM build AS publish
RUN dotnet publish "LikeTrackingSystem.LikeTracker.csproj" -c Release -o /app/publish

# Make the final image for publishing
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LikeTrackingSystem.LikeTracker.dll"]
