FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS build
WORKDIR /src
COPY ["Trains.csproj","."]
RUN dotnet restore "./Trains.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Trains.csproj" -c Release -o /app/build
WORKDIR /app/build
ENTRYPOINT [ "dotnet","Trains.dll" ]
