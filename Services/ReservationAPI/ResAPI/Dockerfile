FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Services/ReservationAPI/ResAPI/ResAPI.csproj", "Services/ReservationAPI/ResAPI/"]
RUN dotnet restore "Services/ReservationAPI/ResAPI/ResAPI.csproj"
COPY . .
WORKDIR "/src/Services/ReservationAPI/ResAPI"
RUN dotnet build "ResAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ResAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ResAPI.dll"]
