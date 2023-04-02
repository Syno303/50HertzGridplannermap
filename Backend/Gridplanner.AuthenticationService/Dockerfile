FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Gridplanner.AuthenticationService/Gridplanner.AuthenticationService.csproj", "Gridplanner.AuthenticationService/"]
RUN dotnet restore "Gridplanner.AuthenticationService/Gridplanner.AuthenticationService.csproj"
COPY . .
WORKDIR "/src/Gridplanner.AuthenticationService"
RUN dotnet build "Gridplanner.AuthenticationService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Gridplanner.AuthenticationService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Gridplanner.AuthenticationService.dll"]
