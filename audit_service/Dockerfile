#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["audit_service/audit_service.csproj", "audit_service/"]
RUN dotnet restore "audit_service/audit_service.csproj"
COPY . .
WORKDIR "/src/audit_service"
RUN dotnet build "audit_service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "audit_service.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "audit_service.dll"]