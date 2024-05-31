# Use the official .NET Core SDK image as the base image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory inside the container
WORKDIR /src

# Copy the remaining source code to the container
COPY . .

# Restore the NuGet packages
RUN dotnet restore

# Build the application
RUN dotnet build -c Release --no-restore

# Publish the application
RUN dotnet publish -c Release --no-build -o /app/publish

# Use the official ASP.NET Core runtime image as the base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Set the working directory inside the container
WORKDIR /app

# Copy the published output from the build stage to the runtime stage
COPY --from=build /app/publish .

# Set the entry point for the container
ENTRYPOINT ["dotnet", "MarketPlaceListing.Api.dll"]
# Set the environment variable for the ASP.NET Core environment
ENV ASPNETCORE_ENVIRONMENT=Development

# Expose the port that the application will listen on
EXPOSE 80

# Set the command to start the application
CMD ["dotnet", "MarketPlaceListing.Api.dll"]