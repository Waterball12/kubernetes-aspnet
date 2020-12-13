FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["K8STest/K8STest.csproj", "K8STest/"]
RUN dotnet restore "K8STest/K8STest.csproj"
COPY . .
WORKDIR "/src/K8STest"
RUN dotnet build "K8STest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "K8STest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "K8STest.dll"]