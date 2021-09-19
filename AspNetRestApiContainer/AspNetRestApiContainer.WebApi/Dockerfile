#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["AspNetRestApiContainer/AspNetRestApiContainer.WebApi/AspNetRestApiContainer.WebApi.csproj", "AspNetRestApiContainer/AspNetRestApiContainer.WebApi/"]
COPY ["AspNetRestApiContainer/AspNetRestApiContainer.Infrastructure.Shared/AspNetRestApiContainer.Infrastructure.Shared.csproj", "AspNetRestApiContainer/AspNetRestApiContainer.Infrastructure.Shared/"]
COPY ["AspNetRestApiContainer/AspNetRestApiContainer.Application/AspNetRestApiContainer.Application.csproj", "AspNetRestApiContainer/AspNetRestApiContainer.Application/"]
COPY ["AspNetRestApiContainer/AspNetRestApiContainer.Domain/AspNetRestApiContainer.Domain.csproj", "AspNetRestApiContainer/AspNetRestApiContainer.Domain/"]
COPY ["AspNetRestApiContainer/AspNetRestApiContainer.Infrastructure.Persistence/AspNetRestApiContainer.Infrastructure.Persistence.csproj", "AspNetRestApiContainer/AspNetRestApiContainer.Infrastructure.Persistence/"]
RUN dotnet restore "AspNetRestApiContainer/AspNetRestApiContainer.WebApi/AspNetRestApiContainer.WebApi.csproj"
COPY . .
WORKDIR "/src/AspNetRestApiContainer/AspNetRestApiContainer.WebApi"
RUN dotnet build "AspNetRestApiContainer.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AspNetRestApiContainer.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AspNetRestApiContainer.WebApi.dll"]