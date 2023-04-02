FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Gridplanner.ApiGateway/Gridplanner.ApiGateway.csproj", "Gridplanner.ApiGateway/"]
RUN dotnet restore "Gridplanner.ApiGateway/Gridplanner.ApiGateway.csproj"
COPY . .
WORKDIR "/src/Gridplanner.ApiGateway"
RUN dotnet build "Gridplanner.ApiGateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Gridplanner.ApiGateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Gridplanner.ApiGateway.dll"]
