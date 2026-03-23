FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["Payments.Api/Payments.Api.csproj", "Payments.Api/"]
COPY ["Payments.Application/Payments.Application.csproj", "Payments.Application/"]
COPY ["Payments.Domain/Payments.Domain.csproj", "Payments.Domain/"]
COPY ["Payments.Infrastructure/Payments.Infrastructure.csproj", "Payments.Infrastructure/"]
RUN dotnet restore "Payments.Api/Payments.Api.csproj"
COPY . .
WORKDIR /src/Payments.Api
RUN dotnet publish "Payments.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
EXPOSE 8080
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Payments.Api.dll"]
