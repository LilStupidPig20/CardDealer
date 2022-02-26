FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CardDealer/CardDealer.csproj", "CardDealer/"]
RUN dotnet restore "CardDealer/CardDealer.csproj"
COPY . .
WORKDIR "/src/CardDealer"
RUN dotnet build "CardDealer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CardDealer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CardDealer.dll"]
