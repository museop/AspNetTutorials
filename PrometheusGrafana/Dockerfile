FROM mcr.microsoft.com/dotnet/sdk:7.0 as build
RUN mkdir /app
WORKDIR /app
COPY ./dotnet-prometheus-grafana.csproj /app/dotnet-prometheus-grafana.csproj
RUN dotnet restore

COPY . /app
RUN mkdir /out
WORKDIR /app
RUN dotnet publish --output /out --configuration Release

FROM mcr.microsoft.com/dotnet/aspnet:7.0 as prod
RUN mkdir /app
WORKDIR /app
COPY --from=build /out /app
RUN chmod +x /app
ENTRYPOINT ["dotnet", "dotnet-prometheus-grafana.dll"]