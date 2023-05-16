# Set the base image to the official .NET SDK image.
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# Set the working directory.
WORKDIR /app

# Copy the project files to the working directory.
COPY . .

# Install the required packages.
RUN dotnet add package Microsoft.AspNetCore.Components.WebAssembly
RUN dotnet add package Microsoft.Extensions.Configuration
RUN dotnet add package Microsoft.Extensions.DependencyInjection
RUN dotnet add package Microsoft.Extensions.Hosting
RUN dotnet add package Microsoft.AspNetCore.WebUtilities


# Build the application.
RUN dotnet build

# Run the application.
CMD ["dotnet", "run"]
