FROM mcr.microsoft.com/dotnet/sdk:7.0
WORKDIR /app
COPY *.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=builder /app/out .
EXPOSE 3006
ENTRYPOINT ["dotnet","WeatherApi.dll"]