FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

COPY . .
WORKDIR /app/src/Presentation/CleanArchitecture.WebApi/
RUN dotnet restore *.csproj
RUN dotnet publish CleanArchitecture.WebApi.csproj --runtime linux-x64 -c Release -o /app/out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
CMD ./CleanArchitecture.WebApi