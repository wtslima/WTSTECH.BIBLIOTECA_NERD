FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["BIBLIOTECANERD/BIBLIOTECANERD.csproj", "BIBLIOTECANERD/"]
RUN dotnet restore "BIBLIOTECANERD/BIBLIOTECANERD.csproj"
COPY . .
WORKDIR "/src/BIBLIOTECANERD"
RUN dotnet build "BIBLIOTECANERD.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "BIBLIOTECANERD.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BIBLIOTECANERD.dll"]