#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["testApi/testApi.csproj", "testApi/"]
RUN dotnet restore "testApi/testApi.csproj"
COPY . .
WORKDIR "/src/testApi"
RUN dotnet build "testApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "testApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "testApi.dll"]