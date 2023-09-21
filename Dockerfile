# Defina a imagem base
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

# Defina a imagem para a compilação
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["/src/Github.Webhook/Github.Webhook.csproj", "Github.Webhook/"]
RUN dotnet restore "Github.Webhook/Github.Webhook.csproj"
COPY . .
WORKDIR "/src/Github.Webhook"
RUN dotnet build "/src/src/Github.Webhook/Github.Webhook.csproj" -c Release -o /app/build

# Publique o aplicativo
FROM build AS publish
RUN dotnet publish "/src/src/Github.Webhook/Github.Webhook.csproj" -c Release -o /app/publish

# Crie a imagem final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Github.Webhook.dll"]