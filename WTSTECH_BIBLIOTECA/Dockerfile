FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["WTSTECH_BIBLIOTECA/WTSTECH_BIBLIOTECA.csproj", "WTSTECH_BIBLIOTECA/"]
RUN dotnet restore "WTSTECH_BIBLIOTECA/WTSTECH_BIBLIOTECA.csproj"
COPY . .
WORKDIR "/src/WTSTECH_BIBLIOTECA"
RUN dotnet build "WTSTECH_BIBLIOTECA.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WTSTECH_BIBLIOTECA.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WTSTECH_BIBLIOTECA.dll"]