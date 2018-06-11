FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 53286
EXPOSE 44377

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Mpc.MyRace.Api/Mpc.MyRace.Api.csproj Mpc.MyRace.Api/
RUN dotnet restore Mpc.MyRace.Api/Mpc.MyRace.Api.csproj
COPY . .
WORKDIR /src/Mpc.MyRace.Api
RUN dotnet build Mpc.MyRace.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Mpc.MyRace.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Mpc.MyRace.Api.dll"]
