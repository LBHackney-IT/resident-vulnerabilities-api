FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./ResidentVulnerabilitiesApi.sln ./
COPY ./ResidentVulnerabilitiesApi/ResidentVulnerabilitiesApi.csproj ./ResidentVulnerabilitiesApi/
COPY ./ResidentVulnerabilitiesApi.Tests/ResidentVulnerabilitiesApi.Tests.csproj ./ResidentVulnerabilitiesApi.Tests/

RUN dotnet restore ./ResidentVulnerabilitiesApi/ResidentVulnerabilitiesApi.csproj
RUN dotnet restore ./ResidentVulnerabilitiesApi.Tests/ResidentVulnerabilitiesApi.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out ResidentVulnerabilitiesApi.Tests/ResidentVulnerabilitiesApi.Tests.csproj

CMD dotnet test
