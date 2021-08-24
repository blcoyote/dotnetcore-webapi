FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app
COPY ./Testapi/HotelListing.csproj .
RUN dotnet restore HotelListing.csproj
COPY ./Testapi .
RUN dotnet build HotelListing.csproj -c Release -o /out
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app
EXPOSE 80
COPY --from=build /out ./
ENTRYPOINT ["dotnet", "HotelListing.dll"]