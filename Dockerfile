FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["DICE_CharacterTracker.csproj", "./"]
RUN dotnet restore "DICE_CharacterTracker.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "DICE_CharacterTracker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DICE_CharacterTracker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DICE_CharacterTracker.dll"]
