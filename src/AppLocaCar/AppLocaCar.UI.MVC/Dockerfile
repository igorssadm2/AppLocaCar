#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["AppLocaCar.UI.MVC/AppLocaCar.UI.MVC.csproj", "AppLocaCar.UI.MVC/"]
RUN dotnet restore "AppLocaCar.UI.MVC/AppLocaCar.UI.MVC.csproj"
COPY . .
WORKDIR "/src/AppLocaCar.UI.MVC"
RUN dotnet build "AppLocaCar.UI.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AppLocaCar.UI.MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AppLocaCar.UI.MVC.dll"]