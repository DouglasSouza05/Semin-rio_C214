# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
COPY . ./
RUN dotnet restore ConversorDeUnidades/src/src.csproj

RUN dotnet publish -c Release -o out ConversorDeUnidades/src/src.csproj

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "/app/src.dll"]

EXPOSE 80
