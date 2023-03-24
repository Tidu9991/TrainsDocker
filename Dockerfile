FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS build
COPY ./bin/Debug/net6.0/Trains.dll .
ENTRYPOINT [ "dotnet","Trains.dll" ]
EXPOSE 7246
