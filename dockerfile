FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app    
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /ConversorDeUnidades
COPY . .

RUN dotnet restore "ConversorDeUnidades/src/src.csproj"
RUN dotnet build "ConversorDeUnidades/src/src.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ConversorDeUnidades/src/src.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "/app/src.dll"]

