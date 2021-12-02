FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
RUN apt-get update \
        && apt-get -y upgrade \
        && apt-get -y dist-upgrade \
        && apt-get install -y gnupg \
        && apt-get install -y sudo \
        && curl -sL deb.nodesource.com/setup_14.x | sudo -E bash - \
        && apt-get install -y nodejs

WORKDIR /app
EXPOSE 80
EXPOSE 443


FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
RUN apt-get update \
    && apt-get -y upgrade \
    && apt-get -y dist-upgrade \
    && apt-get install -y gnupg \
    && apt-get install -y sudo \
    && curl -sL https://deb.nodesource.com/setup_12.x | sudo -E bash - \
    && apt-get install -y nodejs
    
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
