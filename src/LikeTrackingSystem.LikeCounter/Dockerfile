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
COPY ["src/LikeTrackingSystem.LikeCounter/LikeTrackingSystem.LikeCounter.csproj", "LikeTrackingSystem.LikeCounter/"]

# NuGet restore
RUN dotnet restore "LikeTrackingSystem.LikeCounter/LikeTrackingSystem.LikeCounter.csproj"
COPY ["src/LikeTrackingSystem.LikeCounter/", "LikeTrackingSystem.LikeCounter/"]

# Build the API
WORKDIR "/LikeTrackingSystem.LikeCounter"
RUN dotnet build "LikeTrackingSystem.LikeCounter.csproj" -c Release -o /app/build

# Publish it
FROM build AS publish
RUN dotnet publish "LikeTrackingSystem.LikeCounter.csproj" -c Release -o /app/publish

# Make the final image for publishing
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LikeTrackingSystem.LikeCounter.dll"]
